using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT.QLDSDT.Cache;
namespace TT.QLDSDT
{
    public partial class Frm_QuanLyHuongDanDeTai_NhapKetQua : Form
    {
        public Frm_QuanLyHuongDanDeTai_NhapKetQua()
        {
            InitializeComponent();
        }
        Data_QuanLyDanhSachHuongDanDeTai dt = new Data_QuanLyDanhSachHuongDanDeTai();
        private void Frm_QuanLyHuongDanDeTai_NhapKetQua_Load(object sender, EventArgs e)
        {
            txt_Giangvien.Enabled = txt_madetai.Enabled = txt_Sinhvien.Enabled = false;
            //hiển thị thông tin hướng dẫn cần nhập điểm
            txt_madetai.Text = Cache_NhapKQ.MaDT + " - " + Cache_NhapKQ.TenDT;
            txt_Sinhvien.Text = Cache_NhapKQ.SinhVien + " - " + Cache_NhapKQ.HoTenSV;
            txt_Giangvien.Text = Cache_NhapKQ.GiangVien + " - " + Cache_NhapKQ.HoTenGV;
            txt_Ketqua.Text = Cache_NhapKQ.Diem;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(txt_Ketqua.Text.Length==0)
            {
                MessageBox.Show("Chưa nhập số điểm", "Thông báo");
                return;
            }
            else
            {

                if (dt.NhapKQ(int.Parse(Cache_NhapKQ.SinhVien), txt_Ketqua.Text))
                {
                    MessageBox.Show("Nhập điểm thành công", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Nhập điểm thất bại", "Thông báo");
                    return;
                }
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            Frm_QuanLyHuongDanDeTai fm = new Frm_QuanLyHuongDanDeTai();
            this.Hide();
            fm.Show();
        }
    }
}
