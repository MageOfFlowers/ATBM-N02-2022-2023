
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
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.NSoTC = new System.Windows.Forms.NumericUpDown();
            this.NSTLT = new System.Windows.Forms.NumericUpDown();
            this.NSTTH = new System.Windows.Forms.NumericUpDown();
            this.NSoSVTD = new System.Windows.Forms.NumericUpDown();
            this.cbMaDV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NSoTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSTLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSTTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSoSVTD)).BeginInit();
            this.SuspendLayout();
            // 
            // HuyboCTHP_BTN
            // 
            this.HuyboCTHP_BTN.Location = new System.Drawing.Point(217, 480);
            this.HuyboCTHP_BTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HuyboCTHP_BTN.Name = "HuyboCTHP_BTN";
            this.HuyboCTHP_BTN.Size = new System.Drawing.Size(100, 28);
            this.HuyboCTHP_BTN.TabIndex = 0;
            this.HuyboCTHP_BTN.Text = "Hủy bỏ";
            this.HuyboCTHP_BTN.UseVisualStyleBackColor = true;
            this.HuyboCTHP_BTN.Click += new System.EventHandler(this.HuyboCTHP_BTN_Click);
            // 
            // CapnhatCTHP_BTN
            // 
            this.CapnhatCTHP_BTN.Location = new System.Drawing.Point(403, 480);
            this.CapnhatCTHP_BTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CapnhatCTHP_BTN.Name = "CapnhatCTHP_BTN";
            this.CapnhatCTHP_BTN.Size = new System.Drawing.Size(100, 28);
            this.CapnhatCTHP_BTN.TabIndex = 1;
            this.CapnhatCTHP_BTN.Text = "Cập nhật";
            this.CapnhatCTHP_BTN.UseVisualStyleBackColor = true;
            this.CapnhatCTHP_BTN.Click += new System.EventHandler(this.CapnhatCTHP_BTN_Click);
            // 
            // MaHP_LB
            // 
            this.MaHP_LB.AutoSize = true;
            this.MaHP_LB.Location = new System.Drawing.Point(160, 110);
            this.MaHP_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaHP_LB.Name = "MaHP_LB";
            this.MaHP_LB.Size = new System.Drawing.Size(84, 16);
            this.MaHP_LB.TabIndex = 2;
            this.MaHP_LB.Text = "Mã học phần";
            // 
            // TenHP_LB
            // 
            this.TenHP_LB.AutoSize = true;
            this.TenHP_LB.Location = new System.Drawing.Point(160, 153);
            this.TenHP_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TenHP_LB.Name = "TenHP_LB";
            this.TenHP_LB.Size = new System.Drawing.Size(89, 16);
            this.TenHP_LB.TabIndex = 3;
            this.TenHP_LB.Text = "Tên học phần";
            // 
            // SoTC_LB
            // 
            this.SoTC_LB.AutoSize = true;
            this.SoTC_LB.Location = new System.Drawing.Point(160, 198);
            this.SoTC_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoTC_LB.Name = "SoTC_LB";
            this.SoTC_LB.Size = new System.Drawing.Size(60, 16);
            this.SoTC_LB.TabIndex = 4;
            this.SoTC_LB.Text = "Số tín chỉ";
            // 
            // STLT_LB
            // 
            this.STLT_LB.AutoSize = true;
            this.STLT_LB.Location = new System.Drawing.Point(160, 250);
            this.STLT_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STLT_LB.Name = "STLT_LB";
            this.STLT_LB.Size = new System.Drawing.Size(91, 16);
            this.STLT_LB.TabIndex = 5;
            this.STLT_LB.Text = "Số tiết lí thuyết";
            // 
            // STTH_LB
            // 
            this.STTH_LB.AutoSize = true;
            this.STTH_LB.Location = new System.Drawing.Point(160, 300);
            this.STTH_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STTH_LB.Name = "STTH_LB";
            this.STTH_LB.Size = new System.Drawing.Size(103, 16);
            this.STTH_LB.TabIndex = 6;
            this.STTH_LB.Text = "Số tiết thực hành";
            // 
            // SOSVTD_LB
            // 
            this.SOSVTD_LB.AutoSize = true;
            this.SOSVTD_LB.Location = new System.Drawing.Point(161, 353);
            this.SOSVTD_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SOSVTD_LB.Name = "SOSVTD_LB";
            this.SOSVTD_LB.Size = new System.Drawing.Size(115, 16);
            this.SOSVTD_LB.TabIndex = 7;
            this.SOSVTD_LB.Text = "Số sinh viên tối đa";
            // 
            // MaDV_LB
            // 
            this.MaDV_LB.AutoSize = true;
            this.MaDV_LB.Location = new System.Drawing.Point(160, 400);
            this.MaDV_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaDV_LB.Name = "MaDV_LB";
            this.MaDV_LB.Size = new System.Drawing.Size(65, 16);
            this.MaDV_LB.TabIndex = 8;
            this.MaDV_LB.Text = "Mã đơn vị";
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(373, 153);
            this.txtTenHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(159, 22);
            this.txtTenHP.TabIndex = 10;
            // 
            // NSoTC
            // 
            this.NSoTC.Location = new System.Drawing.Point(373, 198);
            this.NSoTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NSoTC.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NSoTC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NSoTC.Name = "NSoTC";
            this.NSoTC.Size = new System.Drawing.Size(160, 22);
            this.NSoTC.TabIndex = 11;
            this.NSoTC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NSTLT
            // 
            this.NSTLT.Location = new System.Drawing.Point(373, 250);
            this.NSTLT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NSTLT.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NSTLT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NSTLT.Name = "NSTLT";
            this.NSTLT.Size = new System.Drawing.Size(160, 22);
            this.NSTLT.TabIndex = 12;
            this.NSTLT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NSTTH
            // 
            this.NSTTH.Location = new System.Drawing.Point(373, 300);
            this.NSTTH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NSTTH.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NSTTH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NSTTH.Name = "NSTTH";
            this.NSTTH.Size = new System.Drawing.Size(160, 22);
            this.NSTTH.TabIndex = 13;
            this.NSTTH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NSoSVTD
            // 
            this.NSoSVTD.Location = new System.Drawing.Point(375, 353);
            this.NSoSVTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NSoSVTD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NSoSVTD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NSoSVTD.Name = "NSoSVTD";
            this.NSoSVTD.Size = new System.Drawing.Size(160, 22);
            this.NSoSVTD.TabIndex = 14;
            this.NSoSVTD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbMaDV
            // 
            this.cbMaDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDV.FormattingEnabled = true;
            this.cbMaDV.Location = new System.Drawing.Point(373, 400);
            this.cbMaDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaDV.Name = "cbMaDV";
            this.cbMaDV.Size = new System.Drawing.Size(160, 24);
            this.cbMaDV.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cập nhật học phần";
            // 
            // lblMaHP
            // 
            this.lblMaHP.Location = new System.Drawing.Point(373, 110);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(160, 22);
            this.lblMaHP.TabIndex = 17;
            // 
            // ChitietHocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 554);
            this.Controls.Add(this.lblMaHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaDV);
            this.Controls.Add(this.NSoSVTD);
            this.Controls.Add(this.NSTTH);
            this.Controls.Add(this.NSTLT);
            this.Controls.Add(this.NSoTC);
            this.Controls.Add(this.txtTenHP);
            this.Controls.Add(this.MaDV_LB);
            this.Controls.Add(this.SOSVTD_LB);
            this.Controls.Add(this.STTH_LB);
            this.Controls.Add(this.STLT_LB);
            this.Controls.Add(this.SoTC_LB);
            this.Controls.Add(this.TenHP_LB);
            this.Controls.Add(this.MaHP_LB);
            this.Controls.Add(this.CapnhatCTHP_BTN);
            this.Controls.Add(this.HuyboCTHP_BTN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChitietHocphan";
            this.Text = "ChitietHocphan";
            this.Load += new System.EventHandler(this.ChitietHocphan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NSoTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSTLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSTTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSoSVTD)).EndInit();
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
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.NumericUpDown NSoTC;
        private System.Windows.Forms.NumericUpDown NSTLT;
        private System.Windows.Forms.NumericUpDown NSTTH;
        private System.Windows.Forms.NumericUpDown NSoSVTD;
        private System.Windows.Forms.ComboBox cbMaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblMaHP;
    }
}