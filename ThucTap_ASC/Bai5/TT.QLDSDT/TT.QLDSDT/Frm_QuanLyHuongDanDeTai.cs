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
    public partial class Frm_QuanLyHuongDanDeTai : FormBase
    {
        public Frm_QuanLyHuongDanDeTai()
        {
            InitializeComponent();
        }
        Data_QuanLyDanhSachHuongDanDeTai dt = new Data_QuanLyDanhSachHuongDanDeTai();
        private void Frm_QuanLyHuongDanDeTai_Load(object sender, EventArgs e)
        {
            dataGriV_DanhSachHuongDanDeTai.DataSource = dt.GetBLHuongDans();
            cbb_TrangThai.DataSource = dt.getCBB_TrangThai();
        }

        #region Tìm kiếm
        public void SearchDeTai()
        {

            dataGriV_DanhSachHuongDanDeTai.DataSource = dt.TimKiemHuongDanDeTai(txt_Detai.Text,
            txt_GiangVien.Text, txt_SinhVien.Text, cbb_TrangThai.SelectedValue.ToString());

        }
        
        private void txt_Detai_TextChanged(object sender, EventArgs e)
        {
            SearchDeTai();
        }

        private void txt_GiangVien_TextChanged(object sender, EventArgs e)
        {
            SearchDeTai();
        }

        private void txt_SinhVien_TextChanged(object sender, EventArgs e)
        {
            SearchDeTai();
        }

        private void cbb_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchDeTai();
        }
        #endregion
        //In
        private void btn_in_Click(object sender, EventArgs e)
        {
            _PrintDataGrivew(dataGriV_DanhSachHuongDanDeTai);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Detai.Clear();
            txt_GiangVien.Clear();
            txt_SinhVien.Clear();
            cbb_TrangThai.SelectedIndex = 0;
            txt_Detai.Focus();
            dataGriV_DanhSachHuongDanDeTai.DataSource = dt.GetBLHuongDans();
        }

        private void btn_Themmoi_Click(object sender, EventArgs e)
        {
            Frm_QuanLyHuongDanDeTai_ThemMoi frm_themmoi = new Frm_QuanLyHuongDanDeTai_ThemMoi();
            this.Hide();
            frm_themmoi.Show();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string MahdCanXoa = dataGriV_DanhSachHuongDanDeTai.CurrentRow.Cells[1].Value.ToString();
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa hướng dẫn đề tài  " + MahdCanXoa, "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (dt.Xoa(int.Parse(MahdCanXoa)))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGriV_DanhSachHuongDanDeTai.DataSource = dt.GetBLHuongDans();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }

        private void btn_Nhap_KQ_Click(object sender, EventArgs e)
        {
            //Lưu kết quả chuyển form
            //Mã đề tài
            Cache_NhapKQ.MaDT= dataGriV_DanhSachHuongDanDeTai.CurrentRow.Cells[5].Value.ToString();
            Cache_NhapKQ.TenDT = dataGriV_DanhSachHuongDanDeTai.CurrentRow.Cells[6].Value.ToString();
            //Sinh viên
            Cache_NhapKQ.SinhVien= dataGriV_DanhSachHuongDanDeTai.CurrentRow.Cells[1].Value.ToString();
            Cache_NhapKQ.HoTenSV = dataGriV_DanhSachHuongDanDeTai.CurrentRow.Cells[2].Value.ToString();
            //Giảng viên
            Cache_NhapKQ.GiangVien = dataGriV_DanhSachHuongDanDeTai.CurrentRow.Cells[3].Value.ToString();
            Cache_NhapKQ.HoTenGV = dataGriV_DanhSachHuongDanDeTai.CurrentRow.Cells[4].Value.ToString();
            //điểm
            try//Chưa nhập kiểm thì sẽ chạy xuống cacht
            {
                Cache_NhapKQ.Diem = dataGriV_DanhSachHuongDanDeTai.CurrentRow.Cells[7].Value.ToString();
            }
            catch//kết quả là null
            {
                Cache_NhapKQ.Diem = "";
            }

            Frm_QuanLyHuongDanDeTai_NhapKetQua frm = new Frm_QuanLyHuongDanDeTai_NhapKetQua();
            this.Hide();
            frm.Show();
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            _Xuat_Execl(dataGriV_DanhSachHuongDanDeTai);
           
        }
    }
}
