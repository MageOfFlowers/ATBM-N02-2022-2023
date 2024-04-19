namespace ATBM.Admin
{
    partial class NhatKyHeThong
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
            this.BatGhiNhatKy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NguoiDungCB = new System.Windows.Forms.ComboBox();
            this.TrangThaiCB = new System.Windows.Forms.ComboBox();
            this.DoiTuongCB = new System.Windows.Forms.ComboBox();
            this.NhatKyDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoaiCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DoiTuongCB2 = new System.Windows.Forms.ComboBox();
            this.NguoiDungCB2 = new System.Windows.Forms.ComboBox();
            this.Reset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TrangThaiCB2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.HanhDongCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HanhDongCB2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CachGhiCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NhatKyDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BatGhiNhatKy
            // 
            this.BatGhiNhatKy.Location = new System.Drawing.Point(50, 349);
            this.BatGhiNhatKy.Name = "BatGhiNhatKy";
            this.BatGhiNhatKy.Size = new System.Drawing.Size(231, 27);
            this.BatGhiNhatKy.TabIndex = 0;
            this.BatGhiNhatKy.Text = "Bật Ghi nhật ký";
            this.BatGhiNhatKy.UseVisualStyleBackColor = true;
            this.BatGhiNhatKy.Click += new System.EventHandler(this.BatGhiNhatKy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(530, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhật ký Hệ thống";
            // 
            // NguoiDungCB
            // 
            this.NguoiDungCB.FormattingEnabled = true;
            this.NguoiDungCB.Location = new System.Drawing.Point(172, 152);
            this.NguoiDungCB.Name = "NguoiDungCB";
            this.NguoiDungCB.Size = new System.Drawing.Size(304, 24);
            this.NguoiDungCB.TabIndex = 3;
            this.NguoiDungCB.SelectedIndexChanged += new System.EventHandler(this.NguoiDungCB_SelectedIndexChanged);
            // 
            // TrangThaiCB
            // 
            this.TrangThaiCB.FormattingEnabled = true;
            this.TrangThaiCB.Location = new System.Drawing.Point(172, 228);
            this.TrangThaiCB.Name = "TrangThaiCB";
            this.TrangThaiCB.Size = new System.Drawing.Size(304, 24);
            this.TrangThaiCB.TabIndex = 4;
            this.TrangThaiCB.SelectedIndexChanged += new System.EventHandler(this.TrangThaiCB_SelectedIndexChanged);
            // 
            // DoiTuongCB
            // 
            this.DoiTuongCB.FormattingEnabled = true;
            this.DoiTuongCB.Location = new System.Drawing.Point(172, 188);
            this.DoiTuongCB.Name = "DoiTuongCB";
            this.DoiTuongCB.Size = new System.Drawing.Size(304, 24);
            this.DoiTuongCB.TabIndex = 5;
            this.DoiTuongCB.SelectedIndexChanged += new System.EventHandler(this.DoiTuongCB_SelectedIndexChanged);
            // 
            // NhatKyDGV
            // 
            this.NhatKyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NhatKyDGV.Location = new System.Drawing.Point(504, 68);
            this.NhatKyDGV.Name = "NhatKyDGV";
            this.NhatKyDGV.RowHeadersWidth = 51;
            this.NhatKyDGV.RowTemplate.Height = 24;
            this.NhatKyDGV.Size = new System.Drawing.Size(723, 534);
            this.NhatKyDGV.TabIndex = 7;
            this.NhatKyDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đối tượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loại";
            // 
            // LoaiCB
            // 
            this.LoaiCB.FormattingEnabled = true;
            this.LoaiCB.Location = new System.Drawing.Point(172, 113);
            this.LoaiCB.Name = "LoaiCB";
            this.LoaiCB.Size = new System.Drawing.Size(304, 24);
            this.LoaiCB.TabIndex = 12;
            this.LoaiCB.SelectedIndexChanged += new System.EventHandler(this.LoaiCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đối tượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Người dùng";
            // 
            // DoiTuongCB2
            // 
            this.DoiTuongCB2.FormattingEnabled = true;
            this.DoiTuongCB2.Location = new System.Drawing.Point(172, 470);
            this.DoiTuongCB2.Name = "DoiTuongCB2";
            this.DoiTuongCB2.Size = new System.Drawing.Size(304, 24);
            this.DoiTuongCB2.TabIndex = 15;
            // 
            // NguoiDungCB2
            // 
            this.NguoiDungCB2.FormattingEnabled = true;
            this.NguoiDungCB2.Location = new System.Drawing.Point(172, 391);
            this.NguoiDungCB2.Name = "NguoiDungCB2";
            this.NguoiDungCB2.Size = new System.Drawing.Size(304, 24);
            this.NguoiDungCB2.TabIndex = 14;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(50, 68);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(231, 23);
            this.Reset.TabIndex = 18;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Trạng thái";
            // 
            // TrangThaiCB2
            // 
            this.TrangThaiCB2.FormattingEnabled = true;
            this.TrangThaiCB2.Location = new System.Drawing.Point(172, 509);
            this.TrangThaiCB2.Name = "TrangThaiCB2";
            this.TrangThaiCB2.Size = new System.Drawing.Size(304, 24);
            this.TrangThaiCB2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hành động";
            // 
            // HanhDongCB
            // 
            this.HanhDongCB.FormattingEnabled = true;
            this.HanhDongCB.Location = new System.Drawing.Point(172, 268);
            this.HanhDongCB.Name = "HanhDongCB";
            this.HanhDongCB.Size = new System.Drawing.Size(304, 24);
            this.HanhDongCB.TabIndex = 21;
            this.HanhDongCB.SelectedIndexChanged += new System.EventHandler(this.HanhDongCB_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Hành động";
            // 
            // HanhDongCB2
            // 
            this.HanhDongCB2.FormattingEnabled = true;
            this.HanhDongCB2.Location = new System.Drawing.Point(172, 430);
            this.HanhDongCB2.Name = "HanhDongCB2";
            this.HanhDongCB2.Size = new System.Drawing.Size(304, 24);
            this.HanhDongCB2.TabIndex = 23;
            this.HanhDongCB2.SelectedIndexChanged += new System.EventHandler(this.HanhDongCB2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cách ghi";
            // 
            // CachGhiCB
            // 
            this.CachGhiCB.FormattingEnabled = true;
            this.CachGhiCB.Location = new System.Drawing.Point(172, 551);
            this.CachGhiCB.Name = "CachGhiCB";
            this.CachGhiCB.Size = new System.Drawing.Size(304, 24);
            this.CachGhiCB.TabIndex = 25;
            // 
            // NhatKyHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 629);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CachGhiCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HanhDongCB2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HanhDongCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TrangThaiCB2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DoiTuongCB2);
            this.Controls.Add(this.NguoiDungCB2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoaiCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NhatKyDGV);
            this.Controls.Add(this.DoiTuongCB);
            this.Controls.Add(this.TrangThaiCB);
            this.Controls.Add(this.NguoiDungCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BatGhiNhatKy);
            this.Name = "NhatKyHeThong";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.NhatKyDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BatGhiNhatKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NguoiDungCB;
        private System.Windows.Forms.ComboBox TrangThaiCB;
        private System.Windows.Forms.ComboBox DoiTuongCB;
        private System.Windows.Forms.DataGridView NhatKyDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LoaiCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DoiTuongCB2;
        private System.Windows.Forms.ComboBox NguoiDungCB2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TrangThaiCB2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox HanhDongCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox HanhDongCB2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CachGhiCB;
    }
}