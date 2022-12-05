namespace TT.QLDSDT
{
    partial class Frm_QuanLyDanhSachDeTai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyDanhSachDeTai));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_TimKiem = new System.Windows.Forms.ToolStripButton();
            this.btn_Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Themmoi = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_in = new System.Windows.Forms.ToolStripButton();
            this.btn_XuatExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Dong = new System.Windows.Forms.ToolStripButton();
            this.lb_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_dkTimKiem = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Noithuctap = new System.Windows.Forms.TextBox();
            this.lb_NoiThucTap = new System.Windows.Forms.Label();
            this.txt_Kinhphi_End = new System.Windows.Forms.TextBox();
            this.txt_Kinhphi_start = new System.Windows.Forms.TextBox();
            this.lb_KinhPhi = new System.Windows.Forms.Label();
            this.txt_Detai = new System.Windows.Forms.TextBox();
            this.lb_Detai = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGriV_DanhSachDeTai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriV_DanhSachDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_TimKiem,
            this.btn_Clear,
            this.toolStripSeparator1,
            this.btn_Themmoi,
            this.btn_Sua,
            this.btn_Xoa,
            this.toolStripSeparator2,
            this.btn_in,
            this.btn_XuatExcel,
            this.toolStripSeparator3,
            this.btn_Dong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // btn_Sua
            // 
            this.btn_Sua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(38, 24);
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
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
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(116, 37);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(568, 44);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "QUẢN LÝ DANH SÁCH ĐỀ TÀI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_dkTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(0, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 41);
            this.groupBox1.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Noithuctap);
            this.groupBox2.Controls.Add(this.lb_NoiThucTap);
            this.groupBox2.Controls.Add(this.txt_Kinhphi_End);
            this.groupBox2.Controls.Add(this.txt_Kinhphi_start);
            this.groupBox2.Controls.Add(this.lb_KinhPhi);
            this.groupBox2.Controls.Add(this.txt_Detai);
            this.groupBox2.Controls.Add(this.lb_Detai);
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_Noithuctap
            // 
            this.txt_Noithuctap.Location = new System.Drawing.Point(103, 48);
            this.txt_Noithuctap.Name = "txt_Noithuctap";
            this.txt_Noithuctap.Size = new System.Drawing.Size(574, 22);
            this.txt_Noithuctap.TabIndex = 6;
            this.txt_Noithuctap.TextChanged += new System.EventHandler(this.txt_Noithuctap_TextChanged);
            // 
            // lb_NoiThucTap
            // 
            this.lb_NoiThucTap.AutoSize = true;
            this.lb_NoiThucTap.Location = new System.Drawing.Point(13, 48);
            this.lb_NoiThucTap.Name = "lb_NoiThucTap";
            this.lb_NoiThucTap.Size = new System.Drawing.Size(84, 17);
            this.lb_NoiThucTap.TabIndex = 5;
            this.lb_NoiThucTap.Text = "Nơi thực tập";
            // 
            // txt_Kinhphi_End
            // 
            this.txt_Kinhphi_End.Location = new System.Drawing.Point(555, 11);
            this.txt_Kinhphi_End.Name = "txt_Kinhphi_End";
            this.txt_Kinhphi_End.Size = new System.Drawing.Size(122, 22);
            this.txt_Kinhphi_End.TabIndex = 4;
            this.txt_Kinhphi_End.TextChanged += new System.EventHandler(this.txt_Kinhphi_End_TextChanged);
            // 
            // txt_Kinhphi_start
            // 
            this.txt_Kinhphi_start.Location = new System.Drawing.Point(442, 11);
            this.txt_Kinhphi_start.Name = "txt_Kinhphi_start";
            this.txt_Kinhphi_start.Size = new System.Drawing.Size(107, 22);
            this.txt_Kinhphi_start.TabIndex = 3;
            this.txt_Kinhphi_start.TextChanged += new System.EventHandler(this.txt_Kinhphi_start_TextChanged);
            // 
            // lb_KinhPhi
            // 
            this.lb_KinhPhi.AutoSize = true;
            this.lb_KinhPhi.Location = new System.Drawing.Point(361, 17);
            this.lb_KinhPhi.Name = "lb_KinhPhi";
            this.lb_KinhPhi.Size = new System.Drawing.Size(59, 17);
            this.lb_KinhPhi.TabIndex = 2;
            this.lb_KinhPhi.Text = "Kinh phí";
            // 
            // txt_Detai
            // 
            this.txt_Detai.Location = new System.Drawing.Point(65, 14);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGriV_DanhSachDeTai);
            this.groupBox3.Location = new System.Drawing.Point(0, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 255);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // dataGriV_DanhSachDeTai
            // 
            this.dataGriV_DanhSachDeTai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGriV_DanhSachDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriV_DanhSachDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGriV_DanhSachDeTai.Location = new System.Drawing.Point(0, 13);
            this.dataGriV_DanhSachDeTai.Name = "dataGriV_DanhSachDeTai";
            this.dataGriV_DanhSachDeTai.ReadOnly = true;
            this.dataGriV_DanhSachDeTai.RowTemplate.Height = 24;
            this.dataGriV_DanhSachDeTai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGriV_DanhSachDeTai.Size = new System.Drawing.Size(800, 242);
            this.dataGriV_DanhSachDeTai.TabIndex = 0;
            this.dataGriV_DanhSachDeTai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriV_DanhSachDeTai_CellContentClick);
            this.dataGriV_DanhSachDeTai.SelectionChanged += new System.EventHandler(this.dataGriV_DanhSachDeTai_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Madt";
            this.Column1.HeaderText = "Mã đề tài";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tendt";
            this.Column2.HeaderText = "Tên đề tài";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Kinhphi";
            this.Column3.HeaderText = "Kinh phí";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Noithuctap";
            this.Column4.HeaderText = "Nơi thực tập";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Frm_QuanLyDanhSachDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_QuanLyDanhSachDeTai";
            this.Text = "QUẢN LÝ DANH SÁCH ĐỀ TÀI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QuanLyDanhSachDeTai_FormClosing);
            this.Load += new System.EventHandler(this.Frm_QuanLyDanhSachDeTai_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriV_DanhSachDeTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_TimKiem;
        private System.Windows.Forms.ToolStripButton btn_Clear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Themmoi;
        private System.Windows.Forms.ToolStripButton btn_Sua;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_in;
        private System.Windows.Forms.ToolStripButton btn_XuatExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Dong;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_dkTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Noithuctap;
        private System.Windows.Forms.Label lb_NoiThucTap;
        private System.Windows.Forms.TextBox txt_Kinhphi_End;
        private System.Windows.Forms.TextBox txt_Kinhphi_start;
        private System.Windows.Forms.Label lb_KinhPhi;
        private System.Windows.Forms.TextBox txt_Detai;
        private System.Windows.Forms.Label lb_Detai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGriV_DanhSachDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}