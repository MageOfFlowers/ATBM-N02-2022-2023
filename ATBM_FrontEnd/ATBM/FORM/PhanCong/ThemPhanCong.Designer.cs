namespace ATBM.FORM.PhanCong
{
    partial class ThemPhanCong
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
            this.GiangVienCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lop_dgv = new System.Windows.Forms.DataGridView();
            this.ThemPC_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lop_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GiangVienCB
            // 
            this.GiangVienCB.FormattingEnabled = true;
            this.GiangVienCB.Location = new System.Drawing.Point(474, 65);
            this.GiangVienCB.Name = "GiangVienCB";
            this.GiangVienCB.Size = new System.Drawing.Size(314, 24);
            this.GiangVienCB.TabIndex = 20;
            this.GiangVienCB.SelectedIndexChanged += new System.EventHandler(this.GiangVienCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giảng viên phụ trách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thêm phân công";
            // 
            // Lop_dgv
            // 
            this.Lop_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lop_dgv.Location = new System.Drawing.Point(13, 112);
            this.Lop_dgv.Name = "Lop_dgv";
            this.Lop_dgv.RowHeadersWidth = 51;
            this.Lop_dgv.RowTemplate.Height = 24;
            this.Lop_dgv.Size = new System.Drawing.Size(775, 272);
            this.Lop_dgv.TabIndex = 23;
            // 
            // ThemPC_btn
            // 
            this.ThemPC_btn.Location = new System.Drawing.Point(350, 404);
            this.ThemPC_btn.Name = "ThemPC_btn";
            this.ThemPC_btn.Size = new System.Drawing.Size(75, 23);
            this.ThemPC_btn.TabIndex = 24;
            this.ThemPC_btn.Text = "Thêm";
            this.ThemPC_btn.UseVisualStyleBackColor = true;
            this.ThemPC_btn.Click += new System.EventHandler(this.ThemPC_btn_Click);
            // 
            // ThemPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThemPC_btn);
            this.Controls.Add(this.Lop_dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GiangVienCB);
            this.Controls.Add(this.label2);
            this.Name = "ThemPhanCong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ThemPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lop_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox GiangVienCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Lop_dgv;
        private System.Windows.Forms.Button ThemPC_btn;
    }
}