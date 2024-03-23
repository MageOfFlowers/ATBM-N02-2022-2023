namespace ATBM
{
    partial class Privilege
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
            this.Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.privCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WithGrant = new System.Windows.Forms.CheckBox();
            this.TablesCB = new System.Windows.Forms.ComboBox();
            this.CollumnCL = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User/Role";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(187, 48);
            this.Username.Margin = new System.Windows.Forms.Padding(2);
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Size = new System.Drawing.Size(125, 20);
            this.Username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Privilege";
            // 
            // privCB
            // 
            this.privCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privCB.FormattingEnabled = true;
            this.privCB.Location = new System.Drawing.Point(187, 102);
            this.privCB.Margin = new System.Windows.Forms.Padding(2);
            this.privCB.Name = "privCB";
            this.privCB.Size = new System.Drawing.Size(125, 21);
            this.privCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Collumn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WithGrant
            // 
            this.WithGrant.AutoSize = true;
            this.WithGrant.Location = new System.Drawing.Point(354, 104);
            this.WithGrant.Margin = new System.Windows.Forms.Padding(2);
            this.WithGrant.Name = "WithGrant";
            this.WithGrant.Size = new System.Drawing.Size(107, 17);
            this.WithGrant.TabIndex = 10;
            this.WithGrant.Text = "With grant option";
            this.WithGrant.UseVisualStyleBackColor = true;
            // 
            // TablesCB
            // 
            this.TablesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablesCB.FormattingEnabled = true;
            this.TablesCB.Location = new System.Drawing.Point(187, 163);
            this.TablesCB.Margin = new System.Windows.Forms.Padding(2);
            this.TablesCB.Name = "TablesCB";
            this.TablesCB.Size = new System.Drawing.Size(125, 21);
            this.TablesCB.TabIndex = 5;
            this.TablesCB.SelectedIndexChanged += new System.EventHandler(this.TablesCB_SelectedIndexChanged);
            // 
            // CollumnCL
            // 
            this.CollumnCL.CheckOnClick = true;
            this.CollumnCL.FormattingEnabled = true;
            this.CollumnCL.Location = new System.Drawing.Point(187, 224);
            this.CollumnCL.Margin = new System.Windows.Forms.Padding(2);
            this.CollumnCL.Name = "CollumnCL";
            this.CollumnCL.Size = new System.Drawing.Size(125, 109);
            this.CollumnCL.TabIndex = 11;
            // 
            // Privilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 465);
            this.Controls.Add(this.CollumnCL);
            this.Controls.Add(this.WithGrant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TablesCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.privCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Privilege";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Privilege_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox privCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox WithGrant;
        private System.Windows.Forms.ComboBox TablesCB;
        private System.Windows.Forms.CheckedListBox CollumnCL;
    }
}