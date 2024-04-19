
namespace ATBM.FORM
{
    partial class DSSinhvien
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
            this.MaSVLB = new System.Windows.Forms.Label();
            this.DSSinhvienDGV = new System.Windows.Forms.DataGridView();
            this.TimBTN = new System.Windows.Forms.Button();
            this.MaSVB = new System.Windows.Forms.TextBox();
            this.DSSinhvienLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSSinhvienDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MaSVLB
            // 
            this.MaSVLB.AutoSize = true;
            this.MaSVLB.Location = new System.Drawing.Point(85, 75);
            this.MaSVLB.Name = "MaSVLB";
            this.MaSVLB.Size = new System.Drawing.Size(67, 13);
            this.MaSVLB.TabIndex = 0;
            this.MaSVLB.Text = "Mã sinh viên";
            this.MaSVLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // DSSinhvienDGV
            // 
            this.DSSinhvienDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSSinhvienDGV.Location = new System.Drawing.Point(28, 122);
            this.DSSinhvienDGV.Name = "DSSinhvienDGV";
            this.DSSinhvienDGV.Size = new System.Drawing.Size(741, 298);
            this.DSSinhvienDGV.TabIndex = 2;
            // 
            // TimBTN
            // 
            this.TimBTN.Location = new System.Drawing.Point(694, 75);
            this.TimBTN.Name = "TimBTN";
            this.TimBTN.Size = new System.Drawing.Size(75, 23);
            this.TimBTN.TabIndex = 4;
            this.TimBTN.Text = "Tìm";
            this.TimBTN.UseVisualStyleBackColor = true;
            this.TimBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaSVB
            // 
            this.MaSVB.Location = new System.Drawing.Point(169, 72);
            this.MaSVB.Name = "MaSVB";
            this.MaSVB.Size = new System.Drawing.Size(100, 20);
            this.MaSVB.TabIndex = 5;
            // 
            // DSSinhvienLB
            // 
            this.DSSinhvienLB.AutoSize = true;
            this.DSSinhvienLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSSinhvienLB.Location = new System.Drawing.Point(282, 9);
            this.DSSinhvienLB.Name = "DSSinhvienLB";
            this.DSSinhvienLB.Size = new System.Drawing.Size(226, 25);
            this.DSSinhvienLB.TabIndex = 6;
            this.DSSinhvienLB.Text = "Danh sách sinh viên";
            // 
            // DSSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DSSinhvienLB);
            this.Controls.Add(this.MaSVB);
            this.Controls.Add(this.TimBTN);
            this.Controls.Add(this.DSSinhvienDGV);
            this.Controls.Add(this.MaSVLB);
            this.Name = "DSSinhvien";
            this.Text = "DSSinhvien";
            this.Load += new System.EventHandler(this.DSSinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSSinhvienDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaSVLB;
        private System.Windows.Forms.DataGridView DSSinhvienDGV;
        private System.Windows.Forms.Button TimBTN;
        private System.Windows.Forms.TextBox MaSVB;
        private System.Windows.Forms.Label DSSinhvienLB;
    }
}