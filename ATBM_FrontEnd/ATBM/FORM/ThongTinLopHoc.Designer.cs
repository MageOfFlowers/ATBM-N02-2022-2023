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
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaLopCB = new System.Windows.Forms.ComboBox();
            this.HocKiCB = new System.Windows.Forms.ComboBox();
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
            this.ThongTinLopDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThongTinLopDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSV,
            this.HoTen,
            this.Phai,
            this.DiemTH,
            this.DiemQT,
            this.DiemCK,
            this.DiemTK});
            this.ThongTinLopDGV.Location = new System.Drawing.Point(60, 143);
            this.ThongTinLopDGV.Name = "ThongTinLopDGV";
            this.ThongTinLopDGV.RowHeadersWidth = 51;
            this.ThongTinLopDGV.RowTemplate.Height = 24;
            this.ThongTinLopDGV.Size = new System.Drawing.Size(705, 265);
            this.ThongTinLopDGV.TabIndex = 2;
            this.ThongTinLopDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "MaSV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 125;
            // 
            // Phai
            // 
            this.Phai.HeaderText = "Phái";
            this.Phai.MinimumWidth = 6;
            this.Phai.Name = "Phai";
            this.Phai.ReadOnly = true;
            this.Phai.Width = 50;
            // 
            // DiemTH
            // 
            this.DiemTH.HeaderText = "T.Hành";
            this.DiemTH.MinimumWidth = 6;
            this.DiemTH.Name = "DiemTH";
            this.DiemTH.Width = 75;
            // 
            // DiemQT
            // 
            this.DiemQT.HeaderText = "Q.Trình";
            this.DiemQT.MinimumWidth = 6;
            this.DiemQT.Name = "DiemQT";
            this.DiemQT.Width = 75;
            // 
            // DiemCK
            // 
            this.DiemCK.HeaderText = "C.Kì";
            this.DiemCK.MinimumWidth = 6;
            this.DiemCK.Name = "DiemCK";
            this.DiemCK.Width = 75;
            // 
            // DiemTK
            // 
            this.DiemTK.HeaderText = "T.Kết";
            this.DiemTK.MinimumWidth = 6;
            this.DiemTK.Name = "DiemTK";
            this.DiemTK.Width = 75;
            // 
            // TenLop
            // 
            this.TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.TenLop.Location = new System.Drawing.Point(388, 57);
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Size = new System.Drawing.Size(377, 28);
            this.TenLop.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Học kì/Năm";
            // 
            // MaLopCB
            // 
            this.MaLopCB.FormattingEnabled = true;
            this.MaLopCB.Location = new System.Drawing.Point(127, 61);
            this.MaLopCB.Name = "MaLopCB";
            this.MaLopCB.Size = new System.Drawing.Size(151, 24);
            this.MaLopCB.TabIndex = 10;
            // 
            // HocKiCB
            // 
            this.HocKiCB.FormattingEnabled = true;
            this.HocKiCB.Location = new System.Drawing.Point(646, 15);
            this.HocKiCB.Name = "HocKiCB";
            this.HocKiCB.Size = new System.Drawing.Size(119, 24);
            this.HocKiCB.TabIndex = 11;
            // 
            // ThongTinLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HocKiCB);
            this.Controls.Add(this.MaLopCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenLop);
            this.Controls.Add(this.ThongTinLopDGV);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinLopHoc";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinLopDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ThongTinLopDGV;
        private System.Windows.Forms.TextBox TenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MaLopCB;
        private System.Windows.Forms.ComboBox HocKiCB;
    }
}