
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
            this.DSHocphanBTN = new System.Windows.Forms.Button();
            this.MaHPB = new System.Windows.Forms.TextBox();
            this.MaHPLB = new System.Windows.Forms.Label();
            this.DSHocphanDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Thaydoi_BTN = new System.Windows.Forms.Button();
            this.TTDangky_CBB = new System.Windows.Forms.ComboBox();
            this.TTDangky_LB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSHocphanDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DSHocphanBTN
            // 
            this.DSHocphanBTN.Location = new System.Drawing.Point(666, 55);
            this.DSHocphanBTN.Name = "DSHocphanBTN";
            this.DSHocphanBTN.Size = new System.Drawing.Size(75, 23);
            this.DSHocphanBTN.TabIndex = 9;
            this.DSHocphanBTN.Text = "Tìm";
            this.DSHocphanBTN.UseVisualStyleBackColor = true;
            // 
            // MaHPB
            // 
            this.MaHPB.Location = new System.Drawing.Point(175, 74);
            this.MaHPB.Name = "MaHPB";
            this.MaHPB.Size = new System.Drawing.Size(100, 20);
            this.MaHPB.TabIndex = 8;
            // 
            // MaHPLB
            // 
            this.MaHPLB.AutoSize = true;
            this.MaHPLB.Location = new System.Drawing.Point(90, 77);
            this.MaHPLB.Name = "MaHPLB";
            this.MaHPLB.Size = new System.Drawing.Size(70, 13);
            this.MaHPLB.TabIndex = 7;
            this.MaHPLB.Text = "Mã học phần";
            // 
            // DSHocphanDGV
            // 
            this.DSHocphanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSHocphanDGV.Location = new System.Drawing.Point(59, 126);
            this.DSHocphanDGV.Name = "DSHocphanDGV";
            this.DSHocphanDGV.Size = new System.Drawing.Size(682, 305);
            this.DSHocphanDGV.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách học phần";
            // 
            // Thaydoi_BTN
            // 
            this.Thaydoi_BTN.Location = new System.Drawing.Point(666, 84);
            this.Thaydoi_BTN.Name = "Thaydoi_BTN";
            this.Thaydoi_BTN.Size = new System.Drawing.Size(75, 23);
            this.Thaydoi_BTN.TabIndex = 10;
            this.Thaydoi_BTN.Text = "Thay đổi";
            this.Thaydoi_BTN.UseVisualStyleBackColor = true;
            // 
            // TTDangky_CBB
            // 
            this.TTDangky_CBB.FormattingEnabled = true;
            this.TTDangky_CBB.Items.AddRange(new object[] {
            "Đăng ký",
            "Hủy đăng ký"});
            this.TTDangky_CBB.Location = new System.Drawing.Point(468, 74);
            this.TTDangky_CBB.Name = "TTDangky_CBB";
            this.TTDangky_CBB.Size = new System.Drawing.Size(121, 21);
            this.TTDangky_CBB.TabIndex = 11;
            this.TTDangky_CBB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TTDangky_LB
            // 
            this.TTDangky_LB.AutoSize = true;
            this.TTDangky_LB.Location = new System.Drawing.Point(394, 77);
            this.TTDangky_LB.Name = "TTDangky_LB";
            this.TTDangky_LB.Size = new System.Drawing.Size(55, 13);
            this.TTDangky_LB.TabIndex = 12;
            this.TTDangky_LB.Text = "Trạng thái";
            // 
            // DangkyHocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TTDangky_LB);
            this.Controls.Add(this.TTDangky_CBB);
            this.Controls.Add(this.Thaydoi_BTN);
            this.Controls.Add(this.DSHocphanBTN);
            this.Controls.Add(this.MaHPB);
            this.Controls.Add(this.MaHPLB);
            this.Controls.Add(this.DSHocphanDGV);
            this.Controls.Add(this.label1);
            this.Name = "DangkyHocphan";
            this.Text = "DangkyHocphan";
            this.Load += new System.EventHandler(this.DangkyHocphan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSHocphanDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DSHocphanBTN;
        private System.Windows.Forms.TextBox MaHPB;
        private System.Windows.Forms.Label MaHPLB;
        private System.Windows.Forms.DataGridView DSHocphanDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Thaydoi_BTN;
        private System.Windows.Forms.ComboBox TTDangky_CBB;
        private System.Windows.Forms.Label TTDangky_LB;
    }
}