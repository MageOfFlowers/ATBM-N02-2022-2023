
namespace ATBM.FORM
{
    partial class ChitietHocphan
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
            this.HuyboCTHP_BTN = new System.Windows.Forms.Button();
            this.CapnhatCTHP_BTN = new System.Windows.Forms.Button();
            this.MaHP_LB = new System.Windows.Forms.Label();
            this.TenHP_LB = new System.Windows.Forms.Label();
            this.SoTC_LB = new System.Windows.Forms.Label();
            this.STLT_LB = new System.Windows.Forms.Label();
            this.STTH_LB = new System.Windows.Forms.Label();
            this.SOSVTD_LB = new System.Windows.Forms.Label();
            this.MaDV_LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HuyboCTHP_BTN
            // 
            this.HuyboCTHP_BTN.Location = new System.Drawing.Point(267, 392);
            this.HuyboCTHP_BTN.Name = "HuyboCTHP_BTN";
            this.HuyboCTHP_BTN.Size = new System.Drawing.Size(75, 23);
            this.HuyboCTHP_BTN.TabIndex = 0;
            this.HuyboCTHP_BTN.Text = "Hủy bỏ";
            this.HuyboCTHP_BTN.UseVisualStyleBackColor = true;
            // 
            // CapnhatCTHP_BTN
            // 
            this.CapnhatCTHP_BTN.Location = new System.Drawing.Point(406, 392);
            this.CapnhatCTHP_BTN.Name = "CapnhatCTHP_BTN";
            this.CapnhatCTHP_BTN.Size = new System.Drawing.Size(75, 23);
            this.CapnhatCTHP_BTN.TabIndex = 1;
            this.CapnhatCTHP_BTN.Text = "Cập nhật";
            this.CapnhatCTHP_BTN.UseVisualStyleBackColor = true;
            // 
            // MaHP_LB
            // 
            this.MaHP_LB.AutoSize = true;
            this.MaHP_LB.Location = new System.Drawing.Point(91, 62);
            this.MaHP_LB.Name = "MaHP_LB";
            this.MaHP_LB.Size = new System.Drawing.Size(70, 13);
            this.MaHP_LB.TabIndex = 2;
            this.MaHP_LB.Text = "Mã học phần";
            // 
            // TenHP_LB
            // 
            this.TenHP_LB.AutoSize = true;
            this.TenHP_LB.Location = new System.Drawing.Point(91, 107);
            this.TenHP_LB.Name = "TenHP_LB";
            this.TenHP_LB.Size = new System.Drawing.Size(74, 13);
            this.TenHP_LB.TabIndex = 3;
            this.TenHP_LB.Text = "Tên học phần";
            // 
            // SoTC_LB
            // 
            this.SoTC_LB.AutoSize = true;
            this.SoTC_LB.Location = new System.Drawing.Point(91, 144);
            this.SoTC_LB.Name = "SoTC_LB";
            this.SoTC_LB.Size = new System.Drawing.Size(53, 13);
            this.SoTC_LB.TabIndex = 4;
            this.SoTC_LB.Text = "Số tín chỉ";
            // 
            // STLT_LB
            // 
            this.STLT_LB.AutoSize = true;
            this.STLT_LB.Location = new System.Drawing.Point(91, 179);
            this.STLT_LB.Name = "STLT_LB";
            this.STLT_LB.Size = new System.Drawing.Size(78, 13);
            this.STLT_LB.TabIndex = 5;
            this.STLT_LB.Text = "Số tiết lí thuyết";
            // 
            // STTH_LB
            // 
            this.STTH_LB.AutoSize = true;
            this.STTH_LB.Location = new System.Drawing.Point(91, 218);
            this.STTH_LB.Name = "STTH_LB";
            this.STTH_LB.Size = new System.Drawing.Size(88, 13);
            this.STTH_LB.TabIndex = 6;
            this.STTH_LB.Text = "Số tiết thực hành";
            // 
            // SOSVTD_LB
            // 
            this.SOSVTD_LB.AutoSize = true;
            this.SOSVTD_LB.Location = new System.Drawing.Point(91, 262);
            this.SOSVTD_LB.Name = "SOSVTD_LB";
            this.SOSVTD_LB.Size = new System.Drawing.Size(95, 13);
            this.SOSVTD_LB.TabIndex = 7;
            this.SOSVTD_LB.Text = "Số sinh viên tối đa";
            // 
            // MaDV_LB
            // 
            this.MaDV_LB.AutoSize = true;
            this.MaDV_LB.Location = new System.Drawing.Point(91, 308);
            this.MaDV_LB.Name = "MaDV_LB";
            this.MaDV_LB.Size = new System.Drawing.Size(55, 13);
            this.MaDV_LB.TabIndex = 8;
            this.MaDV_LB.Text = "Mã đơn vị";
            // 
            // ChitietHocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaDV_LB);
            this.Controls.Add(this.SOSVTD_LB);
            this.Controls.Add(this.STTH_LB);
            this.Controls.Add(this.STLT_LB);
            this.Controls.Add(this.SoTC_LB);
            this.Controls.Add(this.TenHP_LB);
            this.Controls.Add(this.MaHP_LB);
            this.Controls.Add(this.CapnhatCTHP_BTN);
            this.Controls.Add(this.HuyboCTHP_BTN);
            this.Name = "ChitietHocphan";
            this.Text = "ChitietHocphan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HuyboCTHP_BTN;
        private System.Windows.Forms.Button CapnhatCTHP_BTN;
        private System.Windows.Forms.Label MaHP_LB;
        private System.Windows.Forms.Label TenHP_LB;
        private System.Windows.Forms.Label SoTC_LB;
        private System.Windows.Forms.Label STLT_LB;
        private System.Windows.Forms.Label STTH_LB;
        private System.Windows.Forms.Label SOSVTD_LB;
        private System.Windows.Forms.Label MaDV_LB;
    }
}