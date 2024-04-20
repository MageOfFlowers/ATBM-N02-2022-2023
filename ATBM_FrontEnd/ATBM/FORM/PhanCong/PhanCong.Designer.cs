namespace ATBM.FORM.PhanCong
{
    partial class PhanCong
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
            this.Label = new System.Windows.Forms.Label();
            this.PhanCong_dvg = new System.Windows.Forms.DataGridView();
            this.ThemPC_btn = new System.Windows.Forms.Button();
            this.DoiGV = new System.Windows.Forms.Panel();
            this.Huy_btn = new System.Windows.Forms.Button();
            this.DoiGV_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GiangVienCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhanCong_dvg)).BeginInit();
            this.DoiGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Label.Location = new System.Drawing.Point(207, 33);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(347, 31);
            this.Label.TabIndex = 3;
            this.Label.Text = "DANH SÁCH PHÂN CÔNG";
            // 
            // PhanCong_dvg
            // 
            this.PhanCong_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhanCong_dvg.Location = new System.Drawing.Point(24, 114);
            this.PhanCong_dvg.Name = "PhanCong_dvg";
            this.PhanCong_dvg.RowHeadersWidth = 51;
            this.PhanCong_dvg.RowTemplate.Height = 24;
            this.PhanCong_dvg.Size = new System.Drawing.Size(748, 324);
            this.PhanCong_dvg.TabIndex = 4;
            // 
            // ThemPC_btn
            // 
            this.ThemPC_btn.Location = new System.Drawing.Point(576, 77);
            this.ThemPC_btn.Name = "ThemPC_btn";
            this.ThemPC_btn.Size = new System.Drawing.Size(143, 23);
            this.ThemPC_btn.TabIndex = 5;
            this.ThemPC_btn.Text = "Thêm phân công";
            this.ThemPC_btn.UseVisualStyleBackColor = true;
            this.ThemPC_btn.Visible = false;
            this.ThemPC_btn.Click += new System.EventHandler(this.ThemPC_btn_Click);
            // 
            // DoiGV
            // 
            this.DoiGV.Controls.Add(this.Huy_btn);
            this.DoiGV.Controls.Add(this.DoiGV_btn);
            this.DoiGV.Controls.Add(this.label1);
            this.DoiGV.Controls.Add(this.GiangVienCB);
            this.DoiGV.Location = new System.Drawing.Point(238, 135);
            this.DoiGV.Name = "DoiGV";
            this.DoiGV.Size = new System.Drawing.Size(302, 153);
            this.DoiGV.TabIndex = 6;
            this.DoiGV.Visible = false;
            // 
            // Huy_btn
            // 
            this.Huy_btn.Location = new System.Drawing.Point(161, 106);
            this.Huy_btn.Name = "Huy_btn";
            this.Huy_btn.Size = new System.Drawing.Size(104, 23);
            this.Huy_btn.TabIndex = 9;
            this.Huy_btn.Text = "Hủy bỏ";
            this.Huy_btn.UseVisualStyleBackColor = true;
            this.Huy_btn.Click += new System.EventHandler(this.Huy_btn_Click);
            // 
            // DoiGV_btn
            // 
            this.DoiGV_btn.Location = new System.Drawing.Point(43, 106);
            this.DoiGV_btn.Name = "DoiGV_btn";
            this.DoiGV_btn.Size = new System.Drawing.Size(104, 23);
            this.DoiGV_btn.TabIndex = 8;
            this.DoiGV_btn.Text = "Xác nhận";
            this.DoiGV_btn.UseVisualStyleBackColor = true;
            this.DoiGV_btn.Click += new System.EventHandler(this.DoiGV_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thay đổi giảng viên phụ trách";
            // 
            // GiangVienCB
            // 
            this.GiangVienCB.FormattingEnabled = true;
            this.GiangVienCB.Location = new System.Drawing.Point(43, 52);
            this.GiangVienCB.Name = "GiangVienCB";
            this.GiangVienCB.Size = new System.Drawing.Size(222, 24);
            this.GiangVienCB.TabIndex = 0;
            // 
            // PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DoiGV);
            this.Controls.Add(this.ThemPC_btn);
            this.Controls.Add(this.PhanCong_dvg);
            this.Controls.Add(this.Label);
            this.Name = "PhanCong";
            this.Text = "Phân Công";
            this.Load += new System.EventHandler(this.PhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhanCong_dvg)).EndInit();
            this.DoiGV.ResumeLayout(false);
            this.DoiGV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DataGridView PhanCong_dvg;
        private System.Windows.Forms.Button ThemPC_btn;
        private System.Windows.Forms.Panel DoiGV;
        private System.Windows.Forms.ComboBox GiangVienCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DoiGV_btn;
        private System.Windows.Forms.Button Huy_btn;
    }
}