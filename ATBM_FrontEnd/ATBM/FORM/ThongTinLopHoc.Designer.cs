namespace ATBM
{
    partial class ThongTinLopHoc
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
            this.ThongTinLopDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MaLopCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HocKiCB = new System.Windows.Forms.ComboBox();
            this.NamCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChuongTrinhCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChonLai = new System.Windows.Forms.Button();
            this.CapNhatDiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinLopDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin lớp học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ThongTinLopDGV
            // 
            this.ThongTinLopDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ThongTinLopDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThongTinLopDGV.Location = new System.Drawing.Point(60, 143);
            this.ThongTinLopDGV.Name = "ThongTinLopDGV";
            this.ThongTinLopDGV.RowHeadersWidth = 51;
            this.ThongTinLopDGV.RowTemplate.Height = 24;
            this.ThongTinLopDGV.Size = new System.Drawing.Size(705, 265);
            this.ThongTinLopDGV.TabIndex = 2;
            this.ThongTinLopDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã lớp";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // MaLopCB
            // 
            this.MaLopCB.FormattingEnabled = true;
            this.MaLopCB.Location = new System.Drawing.Point(127, 61);
            this.MaLopCB.Name = "MaLopCB";
            this.MaLopCB.Size = new System.Drawing.Size(299, 24);
            this.MaLopCB.TabIndex = 10;
            this.MaLopCB.SelectedIndexChanged += new System.EventHandler(this.MaLopCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Học Kì";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // HocKiCB
            // 
            this.HocKiCB.FormattingEnabled = true;
            this.HocKiCB.Location = new System.Drawing.Point(127, 91);
            this.HocKiCB.Name = "HocKiCB";
            this.HocKiCB.Size = new System.Drawing.Size(93, 24);
            this.HocKiCB.TabIndex = 12;
            this.HocKiCB.SelectedIndexChanged += new System.EventHandler(this.HocKiCB_SelectedIndexChanged);
            // 
            // NamCB
            // 
            this.NamCB.FormattingEnabled = true;
            this.NamCB.Location = new System.Drawing.Point(333, 91);
            this.NamCB.Name = "NamCB";
            this.NamCB.Size = new System.Drawing.Size(93, 24);
            this.NamCB.TabIndex = 14;
            this.NamCB.SelectedIndexChanged += new System.EventHandler(this.NamCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Năm";
            // 
            // ChuongTrinhCB
            // 
            this.ChuongTrinhCB.FormattingEnabled = true;
            this.ChuongTrinhCB.Location = new System.Drawing.Point(586, 63);
            this.ChuongTrinhCB.Name = "ChuongTrinhCB";
            this.ChuongTrinhCB.Size = new System.Drawing.Size(93, 24);
            this.ChuongTrinhCB.TabIndex = 16;
            this.ChuongTrinhCB.SelectedIndexChanged += new System.EventHandler(this.ChuongTrinhCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chương trình";
            // 
            // ChonLai
            // 
            this.ChonLai.Location = new System.Drawing.Point(673, 16);
            this.ChonLai.Name = "ChonLai";
            this.ChonLai.Size = new System.Drawing.Size(75, 23);
            this.ChonLai.TabIndex = 17;
            this.ChonLai.Text = "Chọn lại";
            this.ChonLai.UseVisualStyleBackColor = true;
            this.ChonLai.Click += new System.EventHandler(this.ChonLai_Click);
            // 
            // CapNhatDiem
            // 
            this.CapNhatDiem.Location = new System.Drawing.Point(633, 105);
            this.CapNhatDiem.Name = "CapNhatDiem";
            this.CapNhatDiem.Size = new System.Drawing.Size(132, 23);
            this.CapNhatDiem.TabIndex = 18;
            this.CapNhatDiem.Text = "Cập nhật điểm";
            this.CapNhatDiem.UseVisualStyleBackColor = true;
            this.CapNhatDiem.Visible = false;
            this.CapNhatDiem.Click += new System.EventHandler(this.CapNhatDiem_Click);
            // 
            // ThongTinLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CapNhatDiem);
            this.Controls.Add(this.ChonLai);
            this.Controls.Add(this.ChuongTrinhCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NamCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HocKiCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaLopCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThongTinLopDGV);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinLopHoc";
            this.Text = "Thông tin lớp học";
            this.Load += new System.EventHandler(this.ThongTinLopHoc_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinLopDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ThongTinLopDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MaLopCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox HocKiCB;
        private System.Windows.Forms.ComboBox NamCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ChuongTrinhCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ChonLai;
        private System.Windows.Forms.Button CapNhatDiem;
    }
}