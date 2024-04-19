namespace ATBM.Admin
{
    partial class TaoThongBao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoiDung = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tao = new System.Windows.Forms.Button();
            this.LevelCLB = new System.Windows.Forms.CheckedListBox();
            this.CompartmentCLB = new System.Windows.Forms.CheckedListBox();
            this.GroupCLB = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(299, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo thông báo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Compartment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Group";
            // 
            // NoiDung
            // 
            this.NoiDung.Location = new System.Drawing.Point(56, 235);
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Size = new System.Drawing.Size(689, 117);
            this.NoiDung.TabIndex = 7;
            this.NoiDung.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Content";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tao
            // 
            this.Tao.Location = new System.Drawing.Point(591, 386);
            this.Tao.Name = "Tao";
            this.Tao.Size = new System.Drawing.Size(143, 27);
            this.Tao.TabIndex = 9;
            this.Tao.Text = "Tạo thông báo";
            this.Tao.UseVisualStyleBackColor = true;
            this.Tao.Click += new System.EventHandler(this.Tao_Click);
            // 
            // LevelCLB
            // 
            this.LevelCLB.FormattingEnabled = true;
            this.LevelCLB.Location = new System.Drawing.Point(104, 86);
            this.LevelCLB.Name = "LevelCLB";
            this.LevelCLB.Size = new System.Drawing.Size(142, 106);
            this.LevelCLB.TabIndex = 10;
            this.LevelCLB.SelectedIndexChanged += new System.EventHandler(this.LevelCLB_SelectedIndexChanged);
            // 
            // CompartmentCLB
            // 
            this.CompartmentCLB.FormattingEnabled = true;
            this.CompartmentCLB.Location = new System.Drawing.Point(373, 86);
            this.CompartmentCLB.Name = "CompartmentCLB";
            this.CompartmentCLB.Size = new System.Drawing.Size(142, 106);
            this.CompartmentCLB.TabIndex = 11;
            // 
            // GroupCLB
            // 
            this.GroupCLB.FormattingEnabled = true;
            this.GroupCLB.Location = new System.Drawing.Point(603, 86);
            this.GroupCLB.Name = "GroupCLB";
            this.GroupCLB.Size = new System.Drawing.Size(142, 106);
            this.GroupCLB.TabIndex = 12;
            // 
            // TaoThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupCLB);
            this.Controls.Add(this.CompartmentCLB);
            this.Controls.Add(this.LevelCLB);
            this.Controls.Add(this.Tao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NoiDung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaoThongBao";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.TaoThongBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox NoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Tao;
        private System.Windows.Forms.CheckedListBox LevelCLB;
        private System.Windows.Forms.CheckedListBox CompartmentCLB;
        private System.Windows.Forms.CheckedListBox GroupCLB;
    }
}