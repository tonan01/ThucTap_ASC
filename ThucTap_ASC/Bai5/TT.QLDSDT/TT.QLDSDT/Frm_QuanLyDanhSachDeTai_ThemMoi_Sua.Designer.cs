namespace TT.QLDSDT
{
    partial class Frm_QuanLyDanhSachDeTai_ThemMoi_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyDanhSachDeTai_ThemMoi_Sua));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_dong = new System.Windows.Forms.ToolStripButton();
            this.lb_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Madt = new System.Windows.Forms.TextBox();
            this.txt_Tendetai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kinhphi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Noithuctap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_trungtendetai = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(561, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(119, 39);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(354, 44);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "THÊM MỚI ĐỀ TÀI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã đề tài";
            // 
            // txt_Madt
            // 
            this.txt_Madt.Location = new System.Drawing.Point(111, 115);
            this.txt_Madt.Name = "txt_Madt";
            this.txt_Madt.Size = new System.Drawing.Size(428, 22);
            this.txt_Madt.TabIndex = 4;
            this.txt_Madt.TextChanged += new System.EventHandler(this.txt_Madt_TextChanged);
            // 
            // txt_Tendetai
            // 
            this.txt_Tendetai.Location = new System.Drawing.Point(111, 157);
            this.txt_Tendetai.Name = "txt_Tendetai";
            this.txt_Tendetai.Size = new System.Drawing.Size(428, 22);
            this.txt_Tendetai.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên đề tài";
            // 
            // txt_kinhphi
            // 
            this.txt_kinhphi.Location = new System.Drawing.Point(111, 201);
            this.txt_kinhphi.Name = "txt_kinhphi";
            this.txt_kinhphi.Size = new System.Drawing.Size(237, 22);
            this.txt_kinhphi.TabIndex = 8;
            this.txt_kinhphi.TextChanged += new System.EventHandler(this.txt_kinhphi_TextChanged);
            this.txt_kinhphi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kinhphi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kinh phi";
            // 
            // txt_Noithuctap
            // 
            this.txt_Noithuctap.Location = new System.Drawing.Point(111, 248);
            this.txt_Noithuctap.Name = "txt_Noithuctap";
            this.txt_Noithuctap.Size = new System.Drawing.Size(428, 22);
            this.txt_Noithuctap.TabIndex = 10;
            this.txt_Noithuctap.TextChanged += new System.EventHandler(this.txt_Noithuctap_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nơi thực tập";
            // 
            // lb_trungtendetai
            // 
            this.lb_trungtendetai.AutoSize = true;
            this.lb_trungtendetai.ForeColor = System.Drawing.Color.Red;
            this.lb_trungtendetai.Location = new System.Drawing.Point(108, 137);
            this.lb_trungtendetai.Name = "lb_trungtendetai";
            this.lb_trungtendetai.Size = new System.Drawing.Size(182, 17);
            this.lb_trungtendetai.TabIndex = 11;
            this.lb_trungtendetai.Text = "Tên đề tài đã được sử dụng";
            // 
            // Frm_QuanLyDanhSachDeTai_ThemMoi_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 305);
            this.Controls.Add(this.lb_trungtendetai);
            this.Controls.Add(this.txt_Noithuctap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kinhphi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tendetai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Madt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_QuanLyDanhSachDeTai_ThemMoi_Sua";
            this.Text = "Thêm mới/Sửa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QuanLyDanhSachDeTai_ThemMoi_Sua_FormClosing);
            this.Load += new System.EventHandler(this.Frm_QuanLyDanhSachDeTai_ThemMoi_Sua_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_dong;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Madt;
        private System.Windows.Forms.TextBox txt_Tendetai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kinhphi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Noithuctap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_trungtendetai;
    }
}