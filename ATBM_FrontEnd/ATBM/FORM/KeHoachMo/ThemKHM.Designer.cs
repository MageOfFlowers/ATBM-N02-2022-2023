namespace ATBM.FORM.KeHoachMo
{
    partial class ThemKHM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HocPhan_cb = new System.Windows.Forms.ComboBox();
            this.HocKy_cb = new System.Windows.Forms.ComboBox();
            this.ChuongTrinh_cb = new System.Windows.Forms.ComboBox();
            this.Them_btn = new System.Windows.Forms.Button();
            this.NamHoc_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chương trình";
            // 
            // HocPhan_cb
            // 
            this.HocPhan_cb.FormattingEnabled = true;
            this.HocPhan_cb.Location = new System.Drawing.Point(249, 50);
            this.HocPhan_cb.Name = "HocPhan_cb";
            this.HocPhan_cb.Size = new System.Drawing.Size(223, 24);
            this.HocPhan_cb.TabIndex = 4;
            // 
            // HocKy_cb
            // 
            this.HocKy_cb.FormattingEnabled = true;
            this.HocKy_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.HocKy_cb.Location = new System.Drawing.Point(249, 122);
            this.HocKy_cb.Name = "HocKy_cb";
            this.HocKy_cb.Size = new System.Drawing.Size(121, 24);
            this.HocKy_cb.TabIndex = 5;
            // 
            // ChuongTrinh_cb
            // 
            this.ChuongTrinh_cb.FormattingEnabled = true;
            this.ChuongTrinh_cb.Items.AddRange(new object[] {
            "CQ",
            "CTTT",
            "CLC",
            "VP"});
            this.ChuongTrinh_cb.Location = new System.Drawing.Point(249, 269);
            this.ChuongTrinh_cb.Name = "ChuongTrinh_cb";
            this.ChuongTrinh_cb.Size = new System.Drawing.Size(121, 24);
            this.ChuongTrinh_cb.TabIndex = 7;
            // 
            // Them_btn
            // 
            this.Them_btn.Location = new System.Drawing.Point(249, 355);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(121, 23);
            this.Them_btn.TabIndex = 8;
            this.Them_btn.Text = "Thêm";
            this.Them_btn.UseVisualStyleBackColor = true;
            this.Them_btn.Click += new System.EventHandler(this.Them_btn_Click);
            // 
            // NamHoc_txt
            // 
            this.NamHoc_txt.Location = new System.Drawing.Point(249, 196);
            this.NamHoc_txt.Name = "NamHoc_txt";
            this.NamHoc_txt.Size = new System.Drawing.Size(100, 22);
            this.NamHoc_txt.TabIndex = 9;
            this.NamHoc_txt.TextChanged += new System.EventHandler(this.NamHoc_txt_TextChanged);
            // 
            // ThemKHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NamHoc_txt);
            this.Controls.Add(this.Them_btn);
            this.Controls.Add(this.ChuongTrinh_cb);
            this.Controls.Add(this.HocKy_cb);
            this.Controls.Add(this.HocPhan_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemKHM";
            this.Text = "Thêm kế hoạch mở môn học";
            this.Load += new System.EventHandler(this.ThemKHM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HocPhan_cb;
        private System.Windows.Forms.ComboBox HocKy_cb;
        private System.Windows.Forms.ComboBox ChuongTrinh_cb;
        private System.Windows.Forms.Button Them_btn;
        private System.Windows.Forms.TextBox NamHoc_txt;
    }
}