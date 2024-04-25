namespace ATBM.Admin
{
    partial class GanNhan
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
            this.GroupCLB = new System.Windows.Forms.CheckedListBox();
            this.CompartmentCLB = new System.Windows.Forms.CheckedListBox();
            this.Tao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NguoiDungCB = new System.Windows.Forms.ComboBox();
            this.LevelCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GroupCLB
            // 
            this.GroupCLB.FormattingEnabled = true;
            this.GroupCLB.Location = new System.Drawing.Point(609, 93);
            this.GroupCLB.Name = "GroupCLB";
            this.GroupCLB.Size = new System.Drawing.Size(142, 106);
            this.GroupCLB.TabIndex = 22;
            // 
            // CompartmentCLB
            // 
            this.CompartmentCLB.FormattingEnabled = true;
            this.CompartmentCLB.Location = new System.Drawing.Point(379, 93);
            this.CompartmentCLB.Name = "CompartmentCLB";
            this.CompartmentCLB.Size = new System.Drawing.Size(142, 106);
            this.CompartmentCLB.TabIndex = 21;
            // 
            // Tao
            // 
            this.Tao.Location = new System.Drawing.Point(597, 393);
            this.Tao.Name = "Tao";
            this.Tao.Size = new System.Drawing.Size(143, 27);
            this.Tao.TabIndex = 19;
            this.Tao.Text = "Gắn nhãn";
            this.Tao.UseVisualStyleBackColor = true;
            this.Tao.Click += new System.EventHandler(this.Tao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Compartment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(245, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gắn nhãn người dùng";
            // 
            // NguoiDungCB
            // 
            this.NguoiDungCB.FormattingEnabled = true;
            this.NguoiDungCB.Location = new System.Drawing.Point(153, 249);
            this.NguoiDungCB.Name = "NguoiDungCB";
            this.NguoiDungCB.Size = new System.Drawing.Size(367, 24);
            this.NguoiDungCB.TabIndex = 23;
            this.NguoiDungCB.SelectedIndexChanged += new System.EventHandler(this.NguoiDungCB_SelectedIndexChanged);
            // 
            // LevelCB
            // 
            this.LevelCB.FormattingEnabled = true;
            this.LevelCB.Location = new System.Drawing.Point(106, 90);
            this.LevelCB.Name = "LevelCB";
            this.LevelCB.Size = new System.Drawing.Size(153, 24);
            this.LevelCB.TabIndex = 25;
            // 
            // GanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LevelCB);
            this.Controls.Add(this.NguoiDungCB);
            this.Controls.Add(this.GroupCLB);
            this.Controls.Add(this.CompartmentCLB);
            this.Controls.Add(this.Tao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GanNhan";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.GanNhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox GroupCLB;
        private System.Windows.Forms.CheckedListBox CompartmentCLB;
        private System.Windows.Forms.Button Tao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NguoiDungCB;
        private System.Windows.Forms.ComboBox LevelCB;
    }
}