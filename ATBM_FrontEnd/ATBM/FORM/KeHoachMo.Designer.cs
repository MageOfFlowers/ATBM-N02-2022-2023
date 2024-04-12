namespace ATBM.FORM
{
    partial class KeHoachMo
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
            this.dgvKHM = new System.Windows.Forms.DataGridView();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKHM
            // 
            this.dgvKHM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHP,
            this.TenHP,
            this.HK,
            this.Nam,
            this.CT});
            this.dgvKHM.Location = new System.Drawing.Point(31, 56);
            this.dgvKHM.Name = "dgvKHM";
            this.dgvKHM.RowHeadersWidth = 51;
            this.dgvKHM.RowTemplate.Height = 24;
            this.dgvKHM.Size = new System.Drawing.Size(733, 368);
            this.dgvKHM.TabIndex = 0;
            this.dgvKHM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHM_CellContentClick);
            // 
            // MaHP
            // 
            this.MaHP.HeaderText = "Mã học phần";
            this.MaHP.MinimumWidth = 6;
            this.MaHP.Name = "MaHP";
            this.MaHP.ReadOnly = true;
            this.MaHP.Width = 125;
            // 
            // TenHP
            // 
            this.TenHP.HeaderText = "Tên học phần";
            this.TenHP.MinimumWidth = 6;
            this.TenHP.Name = "TenHP";
            this.TenHP.ReadOnly = true;
            this.TenHP.Width = 125;
            // 
            // HK
            // 
            this.HK.HeaderText = "Học Kỳ";
            this.HK.MinimumWidth = 6;
            this.HK.Name = "HK";
            this.HK.ReadOnly = true;
            this.HK.Width = 125;
            // 
            // Nam
            // 
            this.Nam.HeaderText = "Năm học";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            this.Nam.Width = 125;
            // 
            // CT
            // 
            this.CT.HeaderText = "Chương trình";
            this.CT.MinimumWidth = 6;
            this.CT.Name = "CT";
            this.CT.ReadOnly = true;
            this.CT.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kế hoạch mở môn học";
            // 
            // KeHoachMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKHM);
            this.Name = "KeHoachMo";
            this.Text = "Kế Hoạch mở môn học";
            this.Load += new System.EventHandler(this.KeHoachMo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKHM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT;
        private System.Windows.Forms.Label label1;
    }
}