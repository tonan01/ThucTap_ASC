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
    public partial class Frm_QuanLyHuongDanDeTai_ThemMoi : FormBase
    {
        public Frm_QuanLyHuongDanDeTai_ThemMoi()
        {
            InitializeComponent();
        }
        Data_QuanLyDanhSachHuongDanDeTai dt = new Data_QuanLyDanhSachHuongDanDeTai();
        private void Frm_QuanLyHuongDanDeTai_ThemMoi_Load(object sender, EventArgs e)
        {
            //mã đề tài
            cbb_Madetai.DataSource = dt.getCBB_MaDeTai();
            cbb_Madetai.DisplayMember = "Tendt";
            cbb_Madetai.ValueMember = "Madt";
            //Sinh viên
            cbb_sinhvien.DataSource = dt.getCBB_SinhVien();
            cbb_sinhvien.DisplayMember = "Hotensv";
            cbb_sinhvien.ValueMember = "Masv";
            //Giang viên
            cbb_Giangvien.DataSource = dt.getCBB_GiangVien();
            cbb_Giangvien.DisplayMember = "Hotengv";
            cbb_Giangvien.ValueMember = "Magv";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (dt.KTraTrungHuongDanDeTai(int.Parse(cbb_sinhvien.SelectedValue.ToString())))//trùng
            {
                MessageBox.Show("Sinh viên này đã đăng ký đề tài", "Thông báo");
                return;
            }
            else
            {
                if(dt.Them(int.Parse(cbb_sinhvien.SelectedValue.ToString()),
                cbb_Madetai.SelectedValue.ToString(),int.Parse(cbb_Giangvien.SelectedValue.ToString())))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
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
