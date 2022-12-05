using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT.QLDSDT.Cache;

using OfficeOpenXml;

namespace TT.QLDSDT
{
    public partial class Frm_QuanLyDanhSachDeTai : FormBase
    {
        public Frm_QuanLyDanhSachDeTai()
        {
            InitializeComponent();
        }
        Data_QuanLyDanhSachDeTai dt = new Data_QuanLyDanhSachDeTai();
        private void Frm_QuanLyDanhSachDeTai_Load(object sender, EventArgs e)
        {
            //danh sách đề tài
            dataGriV_DanhSachDeTai.DataSource = dt.getDanhSachDeTai();
            CacheSuaDanhSachDeTai.MadtSua = "";
          
        }
        //Tim kiem
        public void SearchDeTai()
        {

                dataGriV_DanhSachDeTai.DataSource = dt.TimKiemDeTai(txt_Detai.Text,
                txt_Kinhphi_start.Text, txt_Kinhphi_End.Text, txt_Noithuctap.Text);
          
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txt_Detai_TextChanged(object sender, EventArgs e)
        {
            SearchDeTai();
        }

        private void txt_Noithuctap_TextChanged(object sender, EventArgs e)
        {
            SearchDeTai();
        }

        private void txt_Kinhphi_start_TextChanged(object sender, EventArgs e)
        {
            SearchDeTai();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Kinhphi_End_TextChanged(object sender, EventArgs e)
        {
            SearchDeTai();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Detai.Clear();
            txt_Noithuctap.Clear();
            txt_Kinhphi_start.Clear();
            txt_Kinhphi_End.Clear();
            txt_Detai.Focus();
        }
        private void btn_Themmoi_Click(object sender, EventArgs e)
        {
            Frm_QuanLyDanhSachDeTai_ThemMoi_Sua frts = new Frm_QuanLyDanhSachDeTai_ThemMoi_Sua();
            CacheSuaDanhSachDeTai.MadtSua="";
            this.Hide();
            frts.Show();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGriV_DanhSachDeTai_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            CacheSuaDanhSachDeTai.MadtSua = dataGriV_DanhSachDeTai.CurrentRow.Cells[0].Value.ToString();
            if (CacheSuaDanhSachDeTai.MadtSua.Equals(""))
            {
                MessageBox.Show("Chưa chọn đề tài để sửa", "Thông Báo");
                return;
            }
            else
            {
                Frm_QuanLyDanhSachDeTai_ThemMoi_Sua frts = new Frm_QuanLyDanhSachDeTai_ThemMoi_Sua();
                this.Hide();
                frts.Show();
            }
           
        }

        private void dataGriV_DanhSachDeTai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_QuanLyDanhSachDeTai_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string MadtCanXoa = dataGriV_DanhSachDeTai.CurrentRow.Cells[0].Value.ToString();
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa đề tài: " + MadtCanXoa, "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (dt.KTraTrungMaDTHuongDan(MadtCanXoa))
                {
                    MessageBox.Show("Mã đề tài đang được sử dụng ở table hướng dẫn", "Thông báo");
                    return;
                }
                else
                {
                    if (dt.Xoa(MadtCanXoa))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGriV_DanhSachDeTai.DataSource = dt.getDanhSachDeTai();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                        return;
                    }
                }
            }
           
        }
        private void btn_in_Click(object sender, EventArgs e)
        {
            //tạo ở form base
            _PrintDataGrivew(dataGriV_DanhSachDeTai);
        }
      
        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            _Xuat_Execl(dataGriV_DanhSachDeTai);
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}
