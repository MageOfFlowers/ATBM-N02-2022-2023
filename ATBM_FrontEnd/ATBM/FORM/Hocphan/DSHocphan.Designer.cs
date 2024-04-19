
namespace ATBM.FORM
{
    partial class DSHocphan
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
            this.DSHocphanDGV = new System.Windows.Forms.DataGridView();
            this.MaHPLB = new System.Windows.Forms.Label();
            this.MaHPB = new System.Windows.Forms.TextBox();
            this.DSHocphanBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSHocphanDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách học phần";
            // 
            // DSHocphanDGV
            // 
            this.DSHocphanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSHocphanDGV.Location = new System.Drawing.Point(54, 116);
            this.DSHocphanDGV.Name = "DSHocphanDGV";
            this.DSHocphanDGV.Size = new System.Drawing.Size(682, 305);
            this.DSHocphanDGV.TabIndex = 1;
            // 
            // MaHPLB
            // 
            this.MaHPLB.AutoSize = true;
            this.MaHPLB.Location = new System.Drawing.Point(85, 67);
            this.MaHPLB.Name = "MaHPLB";
            this.MaHPLB.Size = new System.Drawing.Size(70, 13);
            this.MaHPLB.TabIndex = 2;
            this.MaHPLB.Text = "Mã học phần";
            // 
            // MaHPB
            // 
            this.MaHPB.Location = new System.Drawing.Point(170, 64);
            this.MaHPB.Name = "MaHPB";
            this.MaHPB.Size = new System.Drawing.Size(100, 20);
            this.MaHPB.TabIndex = 3;
            // 
            // DSHocphanBTN
            // 
            this.DSHocphanBTN.Location = new System.Drawing.Point(661, 64);
            this.DSHocphanBTN.Name = "DSHocphanBTN";
            this.DSHocphanBTN.Size = new System.Drawing.Size(75, 23);
            this.DSHocphanBTN.TabIndex = 4;
            this.DSHocphanBTN.Text = "Tìm";
            this.DSHocphanBTN.UseVisualStyleBackColor = true;
            // 
            // DSHocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DSHocphanBTN);
            this.Controls.Add(this.MaHPB);
            this.Controls.Add(this.MaHPLB);
            this.Controls.Add(this.DSHocphanDGV);
            this.Controls.Add(this.label1);
            this.Name = "DSHocphan";
            this.Text = "DSHocphan";
            ((System.ComponentModel.ISupportInitialize)(this.DSHocphanDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DSHocphanDGV;
        private System.Windows.Forms.Label MaHPLB;
        private System.Windows.Forms.TextBox MaHPB;
        private System.Windows.Forms.Button DSHocphanBTN;
    }
}