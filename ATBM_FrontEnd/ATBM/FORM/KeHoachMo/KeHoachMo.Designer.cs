namespace ATBM.FORM.KeHoachMo
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
            this.KHM_dvg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPlan_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KHM_dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // KHM_dvg
            // 
            this.KHM_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KHM_dvg.Location = new System.Drawing.Point(31, 101);
            this.KHM_dvg.Name = "KHM_dvg";
            this.KHM_dvg.RowHeadersWidth = 51;
            this.KHM_dvg.RowTemplate.Height = 24;
            this.KHM_dvg.Size = new System.Drawing.Size(733, 323);
            this.KHM_dvg.TabIndex = 0;
            this.KHM_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHM_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kế hoạch mở môn học";
            // 
            // AddPlan_btn
            // 
            this.AddPlan_btn.Location = new System.Drawing.Point(610, 61);
            this.AddPlan_btn.Name = "AddPlan_btn";
            this.AddPlan_btn.Size = new System.Drawing.Size(130, 23);
            this.AddPlan_btn.TabIndex = 2;
            this.AddPlan_btn.Text = "Thêm kế hoạch";
            this.AddPlan_btn.UseVisualStyleBackColor = true;
            this.AddPlan_btn.Click += new System.EventHandler(this.AddPlan_btn_Click);
            // 
            // KeHoachMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPlan_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KHM_dvg);
            this.Name = "KeHoachMo";
            this.Text = "Kế Hoạch mở môn học";
            this.Load += new System.EventHandler(this.KeHoachMo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KHM_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KHM_dvg;
        private System.Windows.Forms.Button AddPlan_btn;
    }
}