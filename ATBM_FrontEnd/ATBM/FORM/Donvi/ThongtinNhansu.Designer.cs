
namespace ATBM.FORM.Donvi
{
    partial class ThongtinNhansu
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
            this.MaNV_LB = new System.Windows.Forms.Label();
            this.TTNhansu_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNV_B = new System.Windows.Forms.TextBox();
            this.TTNhansu_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TTNhansu_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MaNV_LB
            // 
            this.MaNV_LB.AutoSize = true;
            this.MaNV_LB.Location = new System.Drawing.Point(96, 69);
            this.MaNV_LB.Name = "MaNV_LB";
            this.MaNV_LB.Size = new System.Drawing.Size(72, 13);
            this.MaNV_LB.TabIndex = 0;
            this.MaNV_LB.Text = "Mã nhân viên";
            // 
            // TTNhansu_BTN
            // 
            this.TTNhansu_BTN.Location = new System.Drawing.Point(666, 64);
            this.TTNhansu_BTN.Name = "TTNhansu_BTN";
            this.TTNhansu_BTN.Size = new System.Drawing.Size(75, 23);
            this.TTNhansu_BTN.TabIndex = 8;
            this.TTNhansu_BTN.Text = "Tìm";
            this.TTNhansu_BTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin nhân sự";
            // 
            // MaNV_B
            // 
            this.MaNV_B.Location = new System.Drawing.Point(187, 66);
            this.MaNV_B.Name = "MaNV_B";
            this.MaNV_B.Size = new System.Drawing.Size(100, 20);
            this.MaNV_B.TabIndex = 10;
            // 
            // TTNhansu_DGV
            // 
            this.TTNhansu_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TTNhansu_DGV.Location = new System.Drawing.Point(56, 112);
            this.TTNhansu_DGV.Name = "TTNhansu_DGV";
            this.TTNhansu_DGV.Size = new System.Drawing.Size(685, 308);
            this.TTNhansu_DGV.TabIndex = 11;
            // 
            // ThongtinNhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TTNhansu_DGV);
            this.Controls.Add(this.MaNV_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TTNhansu_BTN);
            this.Controls.Add(this.MaNV_LB);
            this.Name = "ThongtinNhansu";
            this.Text = "ThongtinNhansu";
            ((System.ComponentModel.ISupportInitialize)(this.TTNhansu_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaNV_LB;
        private System.Windows.Forms.Button TTNhansu_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaNV_B;
        private System.Windows.Forms.DataGridView TTNhansu_DGV;
    }
}