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
using TT.QLDSDT.Data;

namespace TT.QLDSDT
{
    public partial class Frm_QuanLyDanhSachDeTai_ThemMoi_Sua : Form
    {
        public Frm_QuanLyDanhSachDeTai_ThemMoi_Sua()
        {
            InitializeComponent();
        }
        ThucTapDataContext db = new ThucTapDataContext();
        Data_QuanLyDanhSachDeTai dt = new Data_QuanLyDanhSachDeTai();
        private void btn_dong_Click(object sender, EventArgs e)
        {
            Frm_QuanLyDanhSachDeTai fm = new Frm_QuanLyDanhSachDeTai();
            txt_Madt.Clear();
            txt_Tendetai.Clear();
            txt_kinhphi.Clear();
            txt_Noithuctap.Clear();
            this.Hide();
            fm.Show();
        }

        private void Frm_QuanLyDanhSachDeTai_ThemMoi_Sua_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txt_Madt_TextChanged(object sender, EventArgs e)
        {
            if(CacheSuaDanhSachDeTai.MadtSua.Equals(""))//Thêm
            {
                if (dt.KTraTrungMaDT(txt_Madt.Text))
                {
                    lb_trungtendetai.Visible = true;
                    txt_Madt.ForeColor = Color.Red;
                }
                else
                {
                    lb_trungtendetai.Visible = false;
                    txt_Madt.ForeColor = Color.Black;
                }
            }
            else//Sửa
            {
                lb_trungtendetai.Visible = false;
                txt_Madt.ForeColor = Color.Black;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frm_QuanLyDanhSachDeTai_ThemMoi_Sua_Load(object sender, EventArgs e)
        {

            lb_trungtendetai.Visible = false;
            txt_Madt.Text = CacheSuaDanhSachDeTai.MadtSua;
            if (CacheSuaDanhSachDeTai.MadtSua.Equals(""))//Thêm
            {
                txt_Madt.Enabled = true;
            }
            else//Sửa
            {
                txt_Madt.Enabled = false;
                var detai= dt.GetDeTaiSua(CacheSuaDanhSachDeTai.MadtSua);
                txt_Tendetai.Text = detai.Tendt.Trim();
                txt_kinhphi.Text = detai.Kinhphi.ToString();
                txt_Noithuctap.Text = detai.Noithuctap.Trim();
            }
        }

        private void txt_kinhphi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_kinhphi_TextChanged(object sender, EventArgs e)
        {
         


        }

        private void txt_Noithuctap_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (CacheSuaDanhSachDeTai.MadtSua.Equals(""))//Thêm
            {
                if (dt.KTraTrungMaDT(txt_Madt.Text))//trùng
                {
                    MessageBox.Show("Trùng mã đề tài", "Thông báo");
                    txt_Madt.Focus();
                    return;
                }
                else
                {
                    if (dt.Them(txt_Madt.Text, txt_Tendetai.Text, int.Parse(txt_kinhphi.Text), txt_Noithuctap.Text))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        txt_Madt.Clear();
                        txt_Tendetai.Clear();
                        txt_kinhphi.Clear();
                        txt_Noithuctap.Clear();
                        txt_Madt.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất Bại", "Thông báo");
                        return;
                    }
                }
            }
            else//Sửa
            {
                if (dt.Sua(txt_Madt.Text, txt_Tendetai.Text, int.Parse(txt_kinhphi.Text), txt_Noithuctap.Text))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thất Bại", "Thông báo");
                    return;
                }
            }
           
        }
    }
}
