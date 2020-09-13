namespace QL_GiuXe
{
    partial class frm_BackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BackUp));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Full_15 = new System.Windows.Forms.RadioButton();
            this.rad_Full_1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.rad_diff_CN = new System.Windows.Forms.RadioButton();
            this.rad_diff_5 = new System.Windows.Forms.RadioButton();
            this.rad_diff_2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_chonNoi = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(150, 51);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(107, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Tạo bảng full";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Full_15);
            this.groupBox1.Controls.Add(this.rad_Full_1);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 106);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Full";
            // 
            // rad_Full_15
            // 
            this.rad_Full_15.AutoSize = true;
            this.rad_Full_15.Location = new System.Drawing.Point(17, 54);
            this.rad_Full_15.Name = "rad_Full_15";
            this.rad_Full_15.Size = new System.Drawing.Size(115, 17);
            this.rad_Full_15.TabIndex = 14;
            this.rad_Full_15.Text = "Ngày 15 mỗi tháng";
            this.rad_Full_15.UseVisualStyleBackColor = true;
            // 
            // rad_Full_1
            // 
            this.rad_Full_1.AutoSize = true;
            this.rad_Full_1.Checked = true;
            this.rad_Full_1.Location = new System.Drawing.Point(17, 20);
            this.rad_Full_1.Name = "rad_Full_1";
            this.rad_Full_1.Size = new System.Drawing.Size(109, 17);
            this.rad_Full_1.TabIndex = 13;
            this.rad_Full_1.TabStop = true;
            this.rad_Full_1.Text = "Ngày 1 mỗi tháng";
            this.rad_Full_1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.rad_diff_CN);
            this.groupBox2.Controls.Add(this.rad_diff_5);
            this.groupBox2.Controls.Add(this.rad_diff_2);
            this.groupBox2.Location = new System.Drawing.Point(14, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 106);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup differential";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(150, 59);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(107, 23);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "Tạo bảng diff";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // rad_diff_CN
            // 
            this.rad_diff_CN.AutoSize = true;
            this.rad_diff_CN.Location = new System.Drawing.Point(6, 62);
            this.rad_diff_CN.Name = "rad_diff_CN";
            this.rad_diff_CN.Size = new System.Drawing.Size(83, 17);
            this.rad_diff_CN.TabIndex = 2;
            this.rad_diff_CN.Text = "CN mỗi tuần";
            this.rad_diff_CN.UseVisualStyleBackColor = true;
            // 
            // rad_diff_5
            // 
            this.rad_diff_5.AutoSize = true;
            this.rad_diff_5.Location = new System.Drawing.Point(150, 20);
            this.rad_diff_5.Name = "rad_diff_5";
            this.rad_diff_5.Size = new System.Drawing.Size(97, 17);
            this.rad_diff_5.TabIndex = 1;
            this.rad_diff_5.Text = "Thứ 5 mỗi tuần";
            this.rad_diff_5.UseVisualStyleBackColor = true;
            // 
            // rad_diff_2
            // 
            this.rad_diff_2.AutoSize = true;
            this.rad_diff_2.Checked = true;
            this.rad_diff_2.Location = new System.Drawing.Point(6, 20);
            this.rad_diff_2.Name = "rad_diff_2";
            this.rad_diff_2.Size = new System.Drawing.Size(97, 17);
            this.rad_diff_2.TabIndex = 0;
            this.rad_diff_2.TabStop = true;
            this.rad_diff_2.Text = "Thứ 2 mỗi tuần";
            this.rad_diff_2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(14, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 48);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Backup log";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(61, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(77, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Hằng ngày";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(208, 290);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "Lưu";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_chonNoi
            // 
            this.btn_chonNoi.Location = new System.Drawing.Point(127, 290);
            this.btn_chonNoi.Name = "btn_chonNoi";
            this.btn_chonNoi.Size = new System.Drawing.Size(75, 23);
            this.btn_chonNoi.TabIndex = 17;
            this.btn_chonNoi.Text = "Chọn nơi lưu";
            this.btn_chonNoi.Click += new System.EventHandler(this.btn_chonNoi_Click);
            // 
            // frm_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 320);
            this.Controls.Add(this.btn_chonNoi);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BackUp";
            this.Text = "Backup database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_Full_15;
        private System.Windows.Forms.RadioButton rad_Full_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.RadioButton rad_diff_CN;
        private System.Windows.Forms.RadioButton rad_diff_5;
        private System.Windows.Forms.RadioButton rad_diff_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_chonNoi;
    }
}