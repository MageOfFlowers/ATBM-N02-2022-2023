namespace ATBM
{
    partial class MainMenu
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
            this.BtnTTCaNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Label.Location = new System.Drawing.Point(212, 18);
            this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(138, 26);
            this.Label.TabIndex = 2;
            this.Label.Text = "MAIN MENU";
            // 
            // BtnTTCaNhan
            // 
            this.BtnTTCaNhan.Location = new System.Drawing.Point(41, 69);
            this.BtnTTCaNhan.Name = "BtnTTCaNhan";
            this.BtnTTCaNhan.Size = new System.Drawing.Size(110, 23);
            this.BtnTTCaNhan.TabIndex = 3;
            this.BtnTTCaNhan.Text = "Thông tin cá nhân";
            this.BtnTTCaNhan.UseVisualStyleBackColor = true;
            this.BtnTTCaNhan.Click += new System.EventHandler(this.BtnTTCaNhan_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnTTCaNhan);
            this.Controls.Add(this.Label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button BtnTTCaNhan;
    }
}