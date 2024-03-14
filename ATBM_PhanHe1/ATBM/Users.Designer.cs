namespace ATBM
{
    partial class Users
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
            this.UserList = new System.Windows.Forms.DataGridView();
            this.AddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserList.Location = new System.Drawing.Point(37, 79);
            this.UserList.Name = "UserList";
            this.UserList.RowHeadersWidth = 51;
            this.UserList.RowTemplate.Height = 24;
            this.UserList.Size = new System.Drawing.Size(725, 359);
            this.UserList.TabIndex = 0;
            this.UserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserList_CellContentClick);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(629, 32);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(115, 23);
            this.AddUser.TabIndex = 1;
            this.AddUser.Text = "Create user";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.UserList);
            this.Name = "Users";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserList;
        private System.Windows.Forms.Button AddUser;
    }
}