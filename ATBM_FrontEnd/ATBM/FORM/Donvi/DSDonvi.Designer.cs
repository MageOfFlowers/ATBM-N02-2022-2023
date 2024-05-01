
namespace ATBM.FORM
{
    partial class DSDonvi
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
            this.DanhsachdonviLB = new System.Windows.Forms.Label();
            this.DonVi_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DonVi_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhsachdonviLB
            // 
            this.DanhsachdonviLB.AutoSize = true;
            this.DanhsachdonviLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachdonviLB.Location = new System.Drawing.Point(409, 11);
            this.DanhsachdonviLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DanhsachdonviLB.Name = "DanhsachdonviLB";
            this.DanhsachdonviLB.Size = new System.Drawing.Size(239, 31);
            this.DanhsachdonviLB.TabIndex = 0;
            this.DanhsachdonviLB.Text = "Danh sách đơn vị";
            // 
            // DonVi_dgv
            // 
            this.DonVi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonVi_dgv.Location = new System.Drawing.Point(72, 156);
            this.DonVi_dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DonVi_dgv.Name = "DonVi_dgv";
            this.DonVi_dgv.RowHeadersWidth = 51;
            this.DonVi_dgv.Size = new System.Drawing.Size(924, 358);
            this.DonVi_dgv.TabIndex = 4;
            // 
            // DSDonvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DonVi_dgv);
            this.Controls.Add(this.DanhsachdonviLB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DSDonvi";
            this.Text = "DSDonvi";
            this.Load += new System.EventHandler(this.DSDonvi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonVi_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DanhsachdonviLB;
        private System.Windows.Forms.DataGridView DonVi_dgv;
    }
}