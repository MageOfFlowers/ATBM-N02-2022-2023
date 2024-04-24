namespace ATBM
{
    partial class EditRole
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QuyenView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.roleName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuyenView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(893, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Grant privileges";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Role";
            // 
            // QuyenView
            // 
            this.QuyenView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuyenView.Location = new System.Drawing.Point(420, 66);
            this.QuyenView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuyenView.Name = "QuyenView";
            this.QuyenView.ReadOnly = true;
            this.QuyenView.RowHeadersWidth = 51;
            this.QuyenView.RowTemplate.Height = 24;
            this.QuyenView.Size = new System.Drawing.Size(601, 356);
            this.QuyenView.TabIndex = 9;
            this.QuyenView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuyenView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Privileges";
            // 
            // roleName
            // 
            this.roleName.Location = new System.Drawing.Point(147, 197);
            this.roleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleName.Name = "roleName";
            this.roleName.ReadOnly = true;
            this.roleName.Size = new System.Drawing.Size(188, 22);
            this.roleName.TabIndex = 16;
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.roleName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuyenView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditRole";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EditRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuyenView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView QuyenView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roleName;
    }
}