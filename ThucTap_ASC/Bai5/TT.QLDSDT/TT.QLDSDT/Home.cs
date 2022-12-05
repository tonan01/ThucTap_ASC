using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.QLDSDT
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_quanlydetai_Click(object sender, EventArgs e)
        {
            Frm_QuanLyDanhSachDeTai quanLyDanhSachDeTai = new Frm_QuanLyDanhSachDeTai();
            this.Hide();
            quanLyDanhSachDeTai.Show();
        }

        private void btn_quanlyhuongdandetai_Click(object sender, EventArgs e)
        {
            Frm_QuanLyHuongDanDeTai quanLyHuongDanDeTai = new Frm_QuanLyHuongDanDeTai();
            this.Hide();
            quanLyHuongDanDeTai.Show();
        }
    }
}
