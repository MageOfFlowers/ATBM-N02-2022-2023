namespace ATBM.Admin
{
    partial class Recover
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
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.NFlashback = new System.Windows.Forms.NumericUpDown();
            this.dChonNgay = new System.Windows.Forms.DateTimePicker();
            this.btnFlashback = new System.Windows.Forms.Button();
            this.btnChonNgay = new System.Windows.Forms.Button();
            this.btnCheckpoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFlashback = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfFlashback = new System.Windows.Forms.Button();
            this.panelChonNgay = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfChonNgay = new System.Windows.Forms.Button();
            this.btnHuyChonNgay = new System.Windows.Forms.Button();
            this.btnHuyBoFlashback = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NFlashback)).BeginInit();
            this.panelFlashback.SuspendLayout();
            this.panelChonNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(190, 80);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(121, 21);
            this.cbLoai.TabIndex = 0;
            // 
            // NFlashback
            // 
            this.NFlashback.Location = new System.Drawing.Point(115, 63);
            this.NFlashback.Name = "NFlashback";
            this.NFlashback.Size = new System.Drawing.Size(111, 20);
            this.NFlashback.TabIndex = 1;
            // 
            // dChonNgay
            // 
            this.dChonNgay.Location = new System.Drawing.Point(149, 52);
            this.dChonNgay.Name = "dChonNgay";
            this.dChonNgay.Size = new System.Drawing.Size(151, 20);
            this.dChonNgay.TabIndex = 2;
            // 
            // btnFlashback
            // 
            this.btnFlashback.Location = new System.Drawing.Point(119, 205);
            this.btnFlashback.Name = "btnFlashback";
            this.btnFlashback.Size = new System.Drawing.Size(144, 23);
            this.btnFlashback.TabIndex = 3;
            this.btnFlashback.Text = "Flashback";
            this.btnFlashback.UseVisualStyleBackColor = true;
            this.btnFlashback.Click += new System.EventHandler(this.btnFlashback_Click);
            // 
            // btnChonNgay
            // 
            this.btnChonNgay.Location = new System.Drawing.Point(119, 275);
            this.btnChonNgay.Name = "btnChonNgay";
            this.btnChonNgay.Size = new System.Drawing.Size(144, 23);
            this.btnChonNgay.TabIndex = 4;
            this.btnChonNgay.Text = "Chọn ngày phục hồi";
            this.btnChonNgay.UseVisualStyleBackColor = true;
            this.btnChonNgay.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCheckpoint
            // 
            this.btnCheckpoint.Location = new System.Drawing.Point(119, 343);
            this.btnCheckpoint.Name = "btnCheckpoint";
            this.btnCheckpoint.Size = new System.Drawing.Size(144, 23);
            this.btnCheckpoint.TabIndex = 5;
            this.btnCheckpoint.Text = "Phục hồi về checkpoint";
            this.btnCheckpoint.UseVisualStyleBackColor = true;
            this.btnCheckpoint.Click += new System.EventHandler(this.btnCheckpoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phục hồi bảng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Flashback về:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phục hồi về ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tùy chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phục hồi dữ liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "phút trước";
            // 
            // panelFlashback
            // 
            this.panelFlashback.Controls.Add(this.btnHuyBoFlashback);
            this.panelFlashback.Controls.Add(this.btnConfFlashback);
            this.panelFlashback.Controls.Add(this.label7);
            this.panelFlashback.Controls.Add(this.NFlashback);
            this.panelFlashback.Controls.Add(this.label6);
            this.panelFlashback.Controls.Add(this.label2);
            this.panelFlashback.Location = new System.Drawing.Point(32, 156);
            this.panelFlashback.Name = "panelFlashback";
            this.panelFlashback.Size = new System.Drawing.Size(330, 150);
            this.panelFlashback.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Flashback";
            // 
            // btnConfFlashback
            // 
            this.btnConfFlashback.Location = new System.Drawing.Point(176, 108);
            this.btnConfFlashback.Name = "btnConfFlashback";
            this.btnConfFlashback.Size = new System.Drawing.Size(75, 23);
            this.btnConfFlashback.TabIndex = 13;
            this.btnConfFlashback.Text = "Flashback";
            this.btnConfFlashback.UseVisualStyleBackColor = true;
            this.btnConfFlashback.Click += new System.EventHandler(this.btnConfFlashback_Click);
            // 
            // panelChonNgay
            // 
            this.panelChonNgay.Controls.Add(this.btnHuyChonNgay);
            this.panelChonNgay.Controls.Add(this.btnConfChonNgay);
            this.panelChonNgay.Controls.Add(this.label8);
            this.panelChonNgay.Controls.Add(this.dChonNgay);
            this.panelChonNgay.Controls.Add(this.label3);
            this.panelChonNgay.Location = new System.Drawing.Point(32, 312);
            this.panelChonNgay.Name = "panelChonNgay";
            this.panelChonNgay.Size = new System.Drawing.Size(330, 126);
            this.panelChonNgay.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Chọn ngày phục hồi";
            // 
            // btnConfChonNgay
            // 
            this.btnConfChonNgay.Location = new System.Drawing.Point(181, 90);
            this.btnConfChonNgay.Name = "btnConfChonNgay";
            this.btnConfChonNgay.Size = new System.Drawing.Size(75, 23);
            this.btnConfChonNgay.TabIndex = 10;
            this.btnConfChonNgay.Text = "Phục hồi";
            this.btnConfChonNgay.UseVisualStyleBackColor = true;
            this.btnConfChonNgay.Click += new System.EventHandler(this.btnConfChonNgay_Click);
            // 
            // btnHuyChonNgay
            // 
            this.btnHuyChonNgay.Location = new System.Drawing.Point(70, 90);
            this.btnHuyChonNgay.Name = "btnHuyChonNgay";
            this.btnHuyChonNgay.Size = new System.Drawing.Size(75, 23);
            this.btnHuyChonNgay.TabIndex = 11;
            this.btnHuyChonNgay.Text = "Hủy bỏ";
            this.btnHuyChonNgay.UseVisualStyleBackColor = true;
            this.btnHuyChonNgay.Click += new System.EventHandler(this.btnHuyChonNgay_Click);
            // 
            // btnHuyBoFlashback
            // 
            this.btnHuyBoFlashback.Location = new System.Drawing.Point(70, 108);
            this.btnHuyBoFlashback.Name = "btnHuyBoFlashback";
            this.btnHuyBoFlashback.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBoFlashback.TabIndex = 12;
            this.btnHuyBoFlashback.Text = "Hủy bỏ";
            this.btnHuyBoFlashback.UseVisualStyleBackColor = true;
            this.btnHuyBoFlashback.Click += new System.EventHandler(this.btnHuyBoFlashback_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Phục hồi toàn bộ database";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Recover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 454);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panelChonNgay);
            this.Controls.Add(this.panelFlashback);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckpoint);
            this.Controls.Add(this.btnChonNgay);
            this.Controls.Add(this.btnFlashback);
            this.Controls.Add(this.cbLoai);
            this.Name = "Recover";
            this.Text = "Recover";
            this.Load += new System.EventHandler(this.Recover_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NFlashback)).EndInit();
            this.panelFlashback.ResumeLayout(false);
            this.panelFlashback.PerformLayout();
            this.panelChonNgay.ResumeLayout(false);
            this.panelChonNgay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.NumericUpDown NFlashback;
        private System.Windows.Forms.DateTimePicker dChonNgay;
        private System.Windows.Forms.Button btnFlashback;
        private System.Windows.Forms.Button btnChonNgay;
        private System.Windows.Forms.Button btnCheckpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFlashback;
        private System.Windows.Forms.Button btnConfFlashback;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelChonNgay;
        private System.Windows.Forms.Button btnConfChonNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHuyBoFlashback;
        private System.Windows.Forms.Button btnHuyChonNgay;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}