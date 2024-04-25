
namespace ATBM.FORM.Hocphan
{
    partial class DangkyHocphan
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
            this.MaHPLB = new System.Windows.Forms.Label();
            this.DSHocphanDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.HocPhanCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DSHocphanDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MaHPLB
            // 
            this.MaHPLB.AutoSize = true;
            this.MaHPLB.Location = new System.Drawing.Point(175, 95);
            this.MaHPLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaHPLB.Name = "MaHPLB";
            this.MaHPLB.Size = new System.Drawing.Size(84, 16);
            this.MaHPLB.TabIndex = 7;
            this.MaHPLB.Text = "Mã học phần";
            // 
            // DSHocphanDGV
            // 
            this.DSHocphanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSHocphanDGV.Location = new System.Drawing.Point(79, 155);
            this.DSHocphanDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DSHocphanDGV.Name = "DSHocphanDGV";
            this.DSHocphanDGV.RowHeadersWidth = 51;
            this.DSHocphanDGV.Size = new System.Drawing.Size(909, 375);
            this.DSHocphanDGV.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách học phần";
            // 
            // HocPhanCB
            // 
            this.HocPhanCB.FormattingEnabled = true;
            this.HocPhanCB.Location = new System.Drawing.Point(303, 92);
            this.HocPhanCB.Name = "HocPhanCB";
            this.HocPhanCB.Size = new System.Drawing.Size(135, 24);
            this.HocPhanCB.TabIndex = 13;
            this.HocPhanCB.SelectedIndexChanged += new System.EventHandler(this.HocPhanCB_SelectedIndexChanged);
            // 
            // DangkyHocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.HocPhanCB);
            this.Controls.Add(this.MaHPLB);
            this.Controls.Add(this.DSHocphanDGV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DangkyHocphan";
            this.Text = "DangkyHocphan";
            this.Load += new System.EventHandler(this.DangkyHocphan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSHocphanDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MaHPLB;
        private System.Windows.Forms.DataGridView DSHocphanDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HocPhanCB;
    }
}