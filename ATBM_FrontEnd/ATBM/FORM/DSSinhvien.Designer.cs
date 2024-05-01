
namespace ATBM.FORM
{
    partial class DSSinhvien
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
            this.MaSVLB = new System.Windows.Forms.Label();
            this.SinhVien_dgv = new System.Windows.Forms.DataGridView();
            this.MaSVB = new System.Windows.Forms.TextBox();
            this.DSSinhvienLB = new System.Windows.Forms.Label();
            this.TimSV_btn = new System.Windows.Forms.Button();
            this.ThemSV_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVien_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MaSVLB
            // 
            this.MaSVLB.AutoSize = true;
            this.MaSVLB.Location = new System.Drawing.Point(113, 92);
            this.MaSVLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaSVLB.Name = "MaSVLB";
            this.MaSVLB.Size = new System.Drawing.Size(81, 16);
            this.MaSVLB.TabIndex = 0;
            this.MaSVLB.Text = "Mã sinh viên";
            this.MaSVLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // SinhVien_dgv
            // 
            this.SinhVien_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SinhVien_dgv.Location = new System.Drawing.Point(37, 150);
            this.SinhVien_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.SinhVien_dgv.Name = "SinhVien_dgv";
            this.SinhVien_dgv.RowHeadersWidth = 51;
            this.SinhVien_dgv.Size = new System.Drawing.Size(988, 367);
            this.SinhVien_dgv.TabIndex = 2;
            // 
            // MaSVB
            // 
            this.MaSVB.Location = new System.Drawing.Point(211, 89);
            this.MaSVB.Margin = new System.Windows.Forms.Padding(4);
            this.MaSVB.Name = "MaSVB";
            this.MaSVB.Size = new System.Drawing.Size(132, 22);
            this.MaSVB.TabIndex = 5;
            // 
            // DSSinhvienLB
            // 
            this.DSSinhvienLB.AutoSize = true;
            this.DSSinhvienLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSSinhvienLB.Location = new System.Drawing.Point(376, 11);
            this.DSSinhvienLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DSSinhvienLB.Name = "DSSinhvienLB";
            this.DSSinhvienLB.Size = new System.Drawing.Size(277, 31);
            this.DSSinhvienLB.TabIndex = 6;
            this.DSSinhvienLB.Text = "Danh sách sinh viên";
            // 
            // TimSV_btn
            // 
            this.TimSV_btn.Location = new System.Drawing.Point(361, 86);
            this.TimSV_btn.Margin = new System.Windows.Forms.Padding(4);
            this.TimSV_btn.Name = "TimSV_btn";
            this.TimSV_btn.Size = new System.Drawing.Size(79, 28);
            this.TimSV_btn.TabIndex = 4;
            this.TimSV_btn.Text = "Tìm";
            this.TimSV_btn.UseVisualStyleBackColor = true;
            this.TimSV_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThemSV_btn
            // 
            this.ThemSV_btn.Location = new System.Drawing.Point(896, 88);
            this.ThemSV_btn.Name = "ThemSV_btn";
            this.ThemSV_btn.Size = new System.Drawing.Size(81, 23);
            this.ThemSV_btn.TabIndex = 7;
            this.ThemSV_btn.Text = "Thêm";
            this.ThemSV_btn.UseVisualStyleBackColor = true;
            this.ThemSV_btn.Visible = false;
            this.ThemSV_btn.Click += new System.EventHandler(this.ThemSV_btn_Click);
            // 
            // DSSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ThemSV_btn);
            this.Controls.Add(this.DSSinhvienLB);
            this.Controls.Add(this.MaSVB);
            this.Controls.Add(this.TimSV_btn);
            this.Controls.Add(this.SinhVien_dgv);
            this.Controls.Add(this.MaSVLB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DSSinhvien";
            this.Text = "DSSinhvien";
            this.Load += new System.EventHandler(this.DSSinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SinhVien_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaSVLB;
        private System.Windows.Forms.DataGridView SinhVien_dgv;
        private System.Windows.Forms.TextBox MaSVB;
        private System.Windows.Forms.Label DSSinhvienLB;
        private System.Windows.Forms.Button TimSV_btn;
        private System.Windows.Forms.Button ThemSV_btn;
    }
}