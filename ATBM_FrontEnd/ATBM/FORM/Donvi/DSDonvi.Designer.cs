
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
            this.MaDVLB = new System.Windows.Forms.Label();
            this.MaDVB = new System.Windows.Forms.TextBox();
            this.DSDonviBTN = new System.Windows.Forms.Button();
            this.DSDonviDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DSDonviDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhsachdonviLB
            // 
            this.DanhsachdonviLB.AutoSize = true;
            this.DanhsachdonviLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhsachdonviLB.Location = new System.Drawing.Point(307, 9);
            this.DanhsachdonviLB.Name = "DanhsachdonviLB";
            this.DanhsachdonviLB.Size = new System.Drawing.Size(195, 25);
            this.DanhsachdonviLB.TabIndex = 0;
            this.DanhsachdonviLB.Text = "Danh sách đơn vị";
            // 
            // MaDVLB
            // 
            this.MaDVLB.AutoSize = true;
            this.MaDVLB.Location = new System.Drawing.Point(70, 81);
            this.MaDVLB.Name = "MaDVLB";
            this.MaDVLB.Size = new System.Drawing.Size(55, 13);
            this.MaDVLB.TabIndex = 1;
            this.MaDVLB.Text = "Mã đơn vị";
            // 
            // MaDVB
            // 
            this.MaDVB.Location = new System.Drawing.Point(132, 81);
            this.MaDVB.Name = "MaDVB";
            this.MaDVB.Size = new System.Drawing.Size(100, 20);
            this.MaDVB.TabIndex = 2;
            // 
            // DSDonviBTN
            // 
            this.DSDonviBTN.Location = new System.Drawing.Point(672, 81);
            this.DSDonviBTN.Name = "DSDonviBTN";
            this.DSDonviBTN.Size = new System.Drawing.Size(75, 23);
            this.DSDonviBTN.TabIndex = 3;
            this.DSDonviBTN.Text = "Tìm";
            this.DSDonviBTN.UseVisualStyleBackColor = true;
            // 
            // DSDonviDGV
            // 
            this.DSDonviDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSDonviDGV.Location = new System.Drawing.Point(54, 127);
            this.DSDonviDGV.Name = "DSDonviDGV";
            this.DSDonviDGV.Size = new System.Drawing.Size(693, 291);
            this.DSDonviDGV.TabIndex = 4;
            // 
            // DSDonvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DSDonviDGV);
            this.Controls.Add(this.DSDonviBTN);
            this.Controls.Add(this.MaDVB);
            this.Controls.Add(this.MaDVLB);
            this.Controls.Add(this.DanhsachdonviLB);
            this.Name = "DSDonvi";
            this.Text = "DSDonvi";
            ((System.ComponentModel.ISupportInitialize)(this.DSDonviDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DanhsachdonviLB;
        private System.Windows.Forms.Label MaDVLB;
        private System.Windows.Forms.TextBox MaDVB;
        private System.Windows.Forms.Button DSDonviBTN;
        private System.Windows.Forms.DataGridView DSDonviDGV;
    }
}