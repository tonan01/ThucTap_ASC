using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
namespace TT.QLDSDT
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        #region In DataGridView
        Bitmap bitmap;
        public void _PrintDataGrivew(DataGridView dataGridView)
        {
            try
            {
                int hieght = dataGridView.Height;
                dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
                dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
                printPreviewDialog1.Document = printDocument1;//lấy dữ liệu
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;

                printPreviewDialog1.ShowDialog();
                dataGridView.Height = hieght;
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo");
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        #endregion

        #region Xuất execl

        public void _Xuat_Execl(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xeclApp = new Microsoft.Office.Interop.Excel.Application();
                xeclApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i > dataGridView.Columns.Count + 1; i++)
                {
                    xeclApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i > dataGridView.Rows.Count + 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        xeclApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xeclApp.Columns.AutoFit();
                xeclApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu", "Thống báo");
                return;
            }    
        }
        #endregion
    }
}
