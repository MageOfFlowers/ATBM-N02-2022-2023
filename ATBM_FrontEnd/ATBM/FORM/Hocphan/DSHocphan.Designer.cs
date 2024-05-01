
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
            this.Them_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSHocphanDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách học phần";
            // 
            // DSHocphanDGV
            // 
            this.DSHocphanDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DSHocphanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSHocphanDGV.Location = new System.Drawing.Point(56, 142);
            this.DSHocphanDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DSHocphanDGV.Name = "DSHocphanDGV";
            this.DSHocphanDGV.ReadOnly = true;
            this.DSHocphanDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DSHocphanDGV.Size = new System.Drawing.Size(1352, 523);
            this.DSHocphanDGV.TabIndex = 1;
            this.DSHocphanDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DSHocphanDGV_CellContentClick);
            // 
            // MaHPLB
            // 
            this.MaHPLB.AutoSize = true;
            this.MaHPLB.Location = new System.Drawing.Point(150, 84);
            this.MaHPLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaHPLB.Name = "MaHPLB";
            this.MaHPLB.Size = new System.Drawing.Size(84, 16);
            this.MaHPLB.TabIndex = 2;
            this.MaHPLB.Text = "Mã học phần";
            // 
            // MaHPB
            // 
            this.MaHPB.Location = new System.Drawing.Point(263, 80);
            this.MaHPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaHPB.Name = "MaHPB";
            this.MaHPB.Size = new System.Drawing.Size(132, 22);
            this.MaHPB.TabIndex = 3;
            // 
            // DSHocphanBTN
            // 
            this.DSHocphanBTN.Location = new System.Drawing.Point(435, 80);
            this.DSHocphanBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DSHocphanBTN.Name = "DSHocphanBTN";
            this.DSHocphanBTN.Size = new System.Drawing.Size(115, 25);
            this.DSHocphanBTN.TabIndex = 4;
            this.DSHocphanBTN.Text = "Tìm";
            this.DSHocphanBTN.UseVisualStyleBackColor = true;
            this.DSHocphanBTN.Click += new System.EventHandler(this.DSHocphanBTN_Click);
            // 
            // Them_btn
            // 
            this.Them_btn.Location = new System.Drawing.Point(1259, 84);
            this.Them_btn.Name = "Them_btn";
            this.Them_btn.Size = new System.Drawing.Size(75, 23);
            this.Them_btn.TabIndex = 5;
            this.Them_btn.Text = "Thêm";
            this.Them_btn.UseVisualStyleBackColor = true;
            this.Them_btn.Click += new System.EventHandler(this.Them_btn_Click);
            // 
            // DSHocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 702);
            this.Controls.Add(this.Them_btn);
            this.Controls.Add(this.DSHocphanBTN);
            this.Controls.Add(this.MaHPB);
            this.Controls.Add(this.MaHPLB);
            this.Controls.Add(this.DSHocphanDGV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DSHocphan";
            this.Text = "DSHocphan";
            this.Load += new System.EventHandler(this.DSHocphan_Load);
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
        private System.Windows.Forms.Button Them_btn;
    }
}