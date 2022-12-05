namespace TT.QLDSDT
{
    partial class Home
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
            this.btn_quanlydetai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_quanlyhuongdandetai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quanlydetai
            // 
            this.btn_quanlydetai.Location = new System.Drawing.Point(142, 201);
            this.btn_quanlydetai.Name = "btn_quanlydetai";
            this.btn_quanlydetai.Size = new System.Drawing.Size(195, 23);
            this.btn_quanlydetai.TabIndex = 0;
            this.btn_quanlydetai.Text = "Quản lý đề tài";
            this.btn_quanlydetai.UseVisualStyleBackColor = true;
            this.btn_quanlydetai.Click += new System.EventHandler(this.btn_quanlydetai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bài 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bài 2";
            // 
            // btn_quanlyhuongdandetai
            // 
            this.btn_quanlyhuongdandetai.Location = new System.Drawing.Point(411, 201);
            this.btn_quanlyhuongdandetai.Name = "btn_quanlyhuongdandetai";
            this.btn_quanlyhuongdandetai.Size = new System.Drawing.Size(195, 23);
            this.btn_quanlyhuongdandetai.TabIndex = 2;
            this.btn_quanlyhuongdandetai.Text = "Quản lý hướng dẫn đề tài";
            this.btn_quanlyhuongdandetai.UseVisualStyleBackColor = true;
            this.btn_quanlyhuongdandetai.Click += new System.EventHandler(this.btn_quanlyhuongdandetai_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_quanlyhuongdandetai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quanlydetai);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quanlydetai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_quanlyhuongdandetai;
    }
}