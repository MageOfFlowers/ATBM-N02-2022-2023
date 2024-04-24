namespace ATBM.FORM.SinhVien
{
    partial class KQ_Dang_Ky_HP
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
            this.HocPhan_dvg = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HocKyCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NamCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HocPhan_dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // HocPhan_dvg
            // 
            this.HocPhan_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HocPhan_dvg.Location = new System.Drawing.Point(28, 119);
            this.HocPhan_dvg.Name = "HocPhan_dvg";
            this.HocPhan_dvg.RowHeadersWidth = 51;
            this.HocPhan_dvg.RowTemplate.Height = 24;
            this.HocPhan_dvg.Size = new System.Drawing.Size(742, 319);
            this.HocPhan_dvg.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Label.Location = new System.Drawing.Point(236, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(327, 31);
            this.Label.TabIndex = 3;
            this.Label.Text = "Kết quả đăng ký học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Học kỳ";
            // 
            // HocKyCB
            // 
            this.HocKyCB.FormattingEnabled = true;
            this.HocKyCB.Location = new System.Drawing.Point(142, 69);
            this.HocKyCB.Name = "HocKyCB";
            this.HocKyCB.Size = new System.Drawing.Size(121, 24);
            this.HocKyCB.TabIndex = 5;
            this.HocKyCB.SelectedIndexChanged += new System.EventHandler(this.HocKyCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm học";
            // 
            // NamCB
            // 
            this.NamCB.FormattingEnabled = true;
            this.NamCB.Location = new System.Drawing.Point(426, 69);
            this.NamCB.Name = "NamCB";
            this.NamCB.Size = new System.Drawing.Size(121, 24);
            this.NamCB.TabIndex = 7;
            this.NamCB.SelectedIndexChanged += new System.EventHandler(this.NamCB_SelectedIndexChanged);
            // 
            // KQ_Dang_Ky_HP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NamCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HocKyCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.HocPhan_dvg);
            this.Name = "KQ_Dang_Ky_HP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KQ_Dang_Ky_HP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HocPhan_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HocPhan_dvg;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HocKyCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NamCB;
    }
}