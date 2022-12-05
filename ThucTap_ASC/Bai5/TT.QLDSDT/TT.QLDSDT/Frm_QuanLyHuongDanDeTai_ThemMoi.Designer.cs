namespace TT.QLDSDT
{
    partial class Frm_QuanLyHuongDanDeTai_ThemMoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyHuongDanDeTai_ThemMoi));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_dong = new System.Windows.Forms.ToolStripButton();
            this.cbb_Madetai = new System.Windows.Forms.ComboBox();
            this.cbb_sinhvien = new System.Windows.Forms.ComboBox();
            this.cbb_Giangvien = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giảng viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã đề tài";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(17, 45);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(604, 44);
            this.lb_title.TabIndex = 13;
            this.lb_title.Text = "THÊM MỚI HƯỚNG DẪN ĐỀ TÀI";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_luu,
            this.toolStripSeparator1,
            this.btn_dong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_luu
            // 
            this.btn_luu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(37, 24);
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_dong
            // 
            this.btn_dong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_dong.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.Image")));
            this.btn_dong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(50, 24);
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // cbb_Madetai
            // 
            this.cbb_Madetai.FormattingEnabled = true;
            this.cbb_Madetai.Location = new System.Drawing.Point(137, 116);
            this.cbb_Madetai.Name = "cbb_Madetai";
            this.cbb_Madetai.Size = new System.Drawing.Size(450, 24);
            this.cbb_Madetai.TabIndex = 19;
            // 
            // cbb_sinhvien
            // 
            this.cbb_sinhvien.FormattingEnabled = true;
            this.cbb_sinhvien.Location = new System.Drawing.Point(137, 158);
            this.cbb_sinhvien.Name = "cbb_sinhvien";
            this.cbb_sinhvien.Size = new System.Drawing.Size(450, 24);
            this.cbb_sinhvien.TabIndex = 20;
            // 
            // cbb_Giangvien
            // 
            this.cbb_Giangvien.FormattingEnabled = true;
            this.cbb_Giangvien.Location = new System.Drawing.Point(137, 202);
            this.cbb_Giangvien.Name = "cbb_Giangvien";
            this.cbb_Giangvien.Size = new System.Drawing.Size(450, 24);
            this.cbb_Giangvien.TabIndex = 21;
            // 
            // Frm_QuanLyHuongDanDeTai_ThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 262);
            this.Controls.Add(this.cbb_Giangvien);
            this.Controls.Add(this.cbb_sinhvien);
            this.Controls.Add(this.cbb_Madetai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_QuanLyHuongDanDeTai_ThemMoi";
            this.Text = "Thêm mới";
            this.Load += new System.EventHandler(this.Frm_QuanLyHuongDanDeTai_ThemMoi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_dong;
        private System.Windows.Forms.ComboBox cbb_Madetai;
        private System.Windows.Forms.ComboBox cbb_sinhvien;
        private System.Windows.Forms.ComboBox cbb_Giangvien;
    }
}