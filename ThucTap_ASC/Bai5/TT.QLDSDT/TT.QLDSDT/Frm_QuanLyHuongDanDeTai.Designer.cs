namespace TT.QLDSDT
{
    partial class Frm_QuanLyHuongDanDeTai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyHuongDanDeTai));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGriV_DanhSachHuongDanDeTai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SinhVien = new System.Windows.Forms.TextBox();
            this.txt_GiangVien = new System.Windows.Forms.TextBox();
            this.lb_NoiThucTap = new System.Windows.Forms.Label();
            this.lb_KinhPhi = new System.Windows.Forms.Label();
            this.txt_Detai = new System.Windows.Forms.TextBox();
            this.lb_Detai = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_dkTimKiem = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_TimKiem = new System.Windows.Forms.ToolStripButton();
            this.btn_Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Themmoi = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Nhap_KQ = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_in = new System.Windows.Forms.ToolStripButton();
            this.btn_XuatExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Dong = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriV_DanhSachHuongDanDeTai)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGriV_DanhSachHuongDanDeTai);
            this.groupBox3.Location = new System.Drawing.Point(0, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(966, 255);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // dataGriV_DanhSachHuongDanDeTai
            // 
            this.dataGriV_DanhSachHuongDanDeTai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGriV_DanhSachHuongDanDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriV_DanhSachHuongDanDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGriV_DanhSachHuongDanDeTai.Location = new System.Drawing.Point(0, 13);
            this.dataGriV_DanhSachHuongDanDeTai.Name = "dataGriV_DanhSachHuongDanDeTai";
            this.dataGriV_DanhSachHuongDanDeTai.ReadOnly = true;
            this.dataGriV_DanhSachHuongDanDeTai.RowTemplate.Height = 24;
            this.dataGriV_DanhSachHuongDanDeTai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGriV_DanhSachHuongDanDeTai.Size = new System.Drawing.Size(954, 242);
            this.dataGriV_DanhSachHuongDanDeTai.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Makhoa";
            this.Column1.HeaderText = "Mã khoa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Masv";
            this.Column2.HeaderText = "Mã SV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Hotensv";
            this.Column3.HeaderText = "Họ tên SV";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Magv";
            this.Column4.HeaderText = "Mã GV";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Hotengv";
            this.Column5.HeaderText = "Họ tên GV";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Madt";
            this.Column6.HeaderText = "Mã đề tài";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Tendt";
            this.Column7.HeaderText = "Tên đề tài";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "KetQua";
            this.Column8.HeaderText = "Kết quả";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_TrangThai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_SinhVien);
            this.groupBox2.Controls.Add(this.txt_GiangVien);
            this.groupBox2.Controls.Add(this.lb_NoiThucTap);
            this.groupBox2.Controls.Add(this.lb_KinhPhi);
            this.groupBox2.Controls.Add(this.txt_Detai);
            this.groupBox2.Controls.Add(this.lb_Detai);
            this.groupBox2.Location = new System.Drawing.Point(11, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Location = new System.Drawing.Point(590, 50);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(275, 24);
            this.cbb_TrangThai.TabIndex = 9;
            this.cbb_TrangThai.SelectedIndexChanged += new System.EventHandler(this.cbb_TrangThai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trạng thái";
            // 
            // txt_SinhVien
            // 
            this.txt_SinhVien.Location = new System.Drawing.Point(590, 16);
            this.txt_SinhVien.Name = "txt_SinhVien";
            this.txt_SinhVien.Size = new System.Drawing.Size(275, 22);
            this.txt_SinhVien.TabIndex = 7;
            this.txt_SinhVien.TextChanged += new System.EventHandler(this.txt_SinhVien_TextChanged);
            // 
            // txt_GiangVien
            // 
            this.txt_GiangVien.Location = new System.Drawing.Point(99, 48);
            this.txt_GiangVien.Name = "txt_GiangVien";
            this.txt_GiangVien.Size = new System.Drawing.Size(275, 22);
            this.txt_GiangVien.TabIndex = 6;
            this.txt_GiangVien.TextChanged += new System.EventHandler(this.txt_GiangVien_TextChanged);
            // 
            // lb_NoiThucTap
            // 
            this.lb_NoiThucTap.AutoSize = true;
            this.lb_NoiThucTap.Location = new System.Drawing.Point(13, 48);
            this.lb_NoiThucTap.Name = "lb_NoiThucTap";
            this.lb_NoiThucTap.Size = new System.Drawing.Size(76, 17);
            this.lb_NoiThucTap.TabIndex = 5;
            this.lb_NoiThucTap.Text = "Giảng viên";
            // 
            // lb_KinhPhi
            // 
            this.lb_KinhPhi.AutoSize = true;
            this.lb_KinhPhi.Location = new System.Drawing.Point(515, 22);
            this.lb_KinhPhi.Name = "lb_KinhPhi";
            this.lb_KinhPhi.Size = new System.Drawing.Size(66, 17);
            this.lb_KinhPhi.TabIndex = 2;
            this.lb_KinhPhi.Text = "Sinh viên";
            // 
            // txt_Detai
            // 
            this.txt_Detai.Location = new System.Drawing.Point(99, 17);
            this.txt_Detai.Name = "txt_Detai";
            this.txt_Detai.Size = new System.Drawing.Size(275, 22);
            this.txt_Detai.TabIndex = 1;
            this.txt_Detai.TextChanged += new System.EventHandler(this.txt_Detai_TextChanged);
            // 
            // lb_Detai
            // 
            this.lb_Detai.AutoSize = true;
            this.lb_Detai.Location = new System.Drawing.Point(13, 14);
            this.lb_Detai.Name = "lb_Detai";
            this.lb_Detai.Size = new System.Drawing.Size(45, 17);
            this.lb_Detai.TabIndex = 0;
            this.lb_Detai.Text = "Đề tài";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_dkTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(11, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 41);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lb_dkTimKiem
            // 
            this.lb_dkTimKiem.AutoSize = true;
            this.lb_dkTimKiem.Location = new System.Drawing.Point(7, 18);
            this.lb_dkTimKiem.Name = "lb_dkTimKiem";
            this.lb_dkTimKiem.Size = new System.Drawing.Size(122, 17);
            this.lb_dkTimKiem.TabIndex = 0;
            this.lb_dkTimKiem.Text = "Điều kiện tìm kiếm";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(256, 48);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(578, 44);
            this.lb_title.TabIndex = 6;
            this.lb_title.Text = "QUẢN LÝ HƯỚNG DẪN ĐỀ TÀI";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_TimKiem,
            this.btn_Clear,
            this.toolStripSeparator1,
            this.btn_Themmoi,
            this.btn_Xoa,
            this.btn_Nhap_KQ,
            this.toolStripSeparator2,
            this.btn_in,
            this.btn_XuatExcel,
            this.toolStripSeparator3,
            this.btn_Dong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(76, 24);
            this.btn_TimKiem.Text = "Tìm Kiếm";
            // 
            // btn_Clear
            // 
            this.btn_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(47, 24);
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Themmoi
            // 
            this.btn_Themmoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Themmoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Themmoi.Image")));
            this.btn_Themmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Themmoi.Name = "btn_Themmoi";
            this.btn_Themmoi.Size = new System.Drawing.Size(80, 24);
            this.btn_Themmoi.Text = "Thêm mới";
            this.btn_Themmoi.Click += new System.EventHandler(this.btn_Themmoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(39, 24);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Nhap_KQ
            // 
            this.btn_Nhap_KQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Nhap_KQ.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nhap_KQ.Image")));
            this.btn_Nhap_KQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Nhap_KQ.Name = "btn_Nhap_KQ";
            this.btn_Nhap_KQ.Size = new System.Drawing.Size(73, 24);
            this.btn_Nhap_KQ.Text = "Nhập KQ";
            this.btn_Nhap_KQ.Click += new System.EventHandler(this.btn_Nhap_KQ_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_in
            // 
            this.btn_in.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_in.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.Image")));
            this.btn_in.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(25, 24);
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_XuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatExcel.Image")));
            this.btn_XuatExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(81, 24);
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.Click += new System.EventHandler(this.btn_XuatExcel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Dong
            // 
            this.btn_Dong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Dong.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dong.Image")));
            this.btn_Dong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(50, 24);
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // Frm_QuanLyHuongDanDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_QuanLyHuongDanDeTai";
            this.Text = "QUẢN LÝ HƯỚNG DẪN ĐỀ TÀI";
            this.Load += new System.EventHandler(this.Frm_QuanLyHuongDanDeTai_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriV_DanhSachHuongDanDeTai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGriV_DanhSachHuongDanDeTai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_NoiThucTap;
        private System.Windows.Forms.Label lb_KinhPhi;
        private System.Windows.Forms.TextBox txt_Detai;
        private System.Windows.Forms.Label lb_Detai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_dkTimKiem;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_TimKiem;
        private System.Windows.Forms.ToolStripButton btn_Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Themmoi;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripButton btn_Nhap_KQ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_in;
        private System.Windows.Forms.ToolStripButton btn_XuatExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Dong;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SinhVien;
        private System.Windows.Forms.TextBox txt_GiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}