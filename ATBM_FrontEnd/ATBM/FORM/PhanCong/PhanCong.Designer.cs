namespace ATBM.FORM.PhanCong
{
    partial class PhanCong
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
            this.Label = new System.Windows.Forms.Label();
            this.PhanCong_dvg = new System.Windows.Forms.DataGridView();
            this.ThemPC_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhanCong_dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Label.Location = new System.Drawing.Point(207, 33);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(347, 31);
            this.Label.TabIndex = 3;
            this.Label.Text = "DANH SÁCH PHÂN CÔNG";
            // 
            // PhanCong_dvg
            // 
            this.PhanCong_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhanCong_dvg.Location = new System.Drawing.Point(24, 114);
            this.PhanCong_dvg.Name = "PhanCong_dvg";
            this.PhanCong_dvg.RowHeadersWidth = 51;
            this.PhanCong_dvg.RowTemplate.Height = 24;
            this.PhanCong_dvg.Size = new System.Drawing.Size(748, 324);
            this.PhanCong_dvg.TabIndex = 4;
            // 
            // ThemPC_btn
            // 
            this.ThemPC_btn.Location = new System.Drawing.Point(576, 77);
            this.ThemPC_btn.Name = "ThemPC_btn";
            this.ThemPC_btn.Size = new System.Drawing.Size(143, 23);
            this.ThemPC_btn.TabIndex = 5;
            this.ThemPC_btn.Text = "Thêm phân công";
            this.ThemPC_btn.UseVisualStyleBackColor = true;
            this.ThemPC_btn.Click += new System.EventHandler(this.ThemPC_btn_Click);
            // 
            // PhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThemPC_btn);
            this.Controls.Add(this.PhanCong_dvg);
            this.Controls.Add(this.Label);
            this.Name = "PhanCong";
            this.Text = "Phân Công";
            this.Load += new System.EventHandler(this.PhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhanCong_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DataGridView PhanCong_dvg;
        private System.Windows.Forms.Button ThemPC_btn;
    }
}