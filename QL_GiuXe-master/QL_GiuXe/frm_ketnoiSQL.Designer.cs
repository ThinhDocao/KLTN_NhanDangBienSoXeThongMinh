namespace QL_GiuXe
{
    partial class frm_ketnoiSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ketnoiSQL));
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.cob_database = new System.Windows.Forms.ComboBox();
            this.cob_server = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cob_qtrycap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_thoat.ImageOptions.SvgImage")));
            this.btn_thoat.Location = new System.Drawing.Point(290, 246);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(107, 40);
            this.btn_thoat.TabIndex = 19;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_capnhat.ImageOptions.SvgImage")));
            this.btn_capnhat.Location = new System.Drawing.Point(175, 246);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(107, 40);
            this.btn_capnhat.TabIndex = 18;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(137, 166);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(261, 26);
            this.txt_password.TabIndex = 17;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(136, 130);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(261, 26);
            this.txt_username.TabIndex = 16;
            // 
            // cob_database
            // 
            this.cob_database.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_database.FormattingEnabled = true;
            this.cob_database.Location = new System.Drawing.Point(137, 205);
            this.cob_database.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cob_database.Name = "cob_database";
            this.cob_database.Size = new System.Drawing.Size(261, 28);
            this.cob_database.TabIndex = 15;
            this.cob_database.DropDown += new System.EventHandler(this.cob_database_DropDown);
            this.cob_database.SelectedIndexChanged += new System.EventHandler(this.cob_database_SelectedIndexChanged);
            // 
            // cob_server
            // 
            this.cob_server.FormattingEnabled = true;
            this.cob_server.Items.AddRange(new object[] {
            "DESKTOP-PO9HKN4"});
            this.cob_server.Location = new System.Drawing.Point(136, 51);
            this.cob_server.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cob_server.Name = "cob_server";
            this.cob_server.Size = new System.Drawing.Size(261, 28);
            this.cob_server.TabIndex = 14;
            this.cob_server.DropDown += new System.EventHandler(this.cob_server_DropDown);
            this.cob_server.SelectedIndexChanged += new System.EventHandler(this.cob_server_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Database";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 169);
            this.Password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 12;
            this.Password.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Server Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Authentication";
            // 
            // cob_qtrycap
            // 
            this.cob_qtrycap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_qtrycap.FormattingEnabled = true;
            this.cob_qtrycap.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cob_qtrycap.Location = new System.Drawing.Point(136, 92);
            this.cob_qtrycap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cob_qtrycap.Name = "cob_qtrycap";
            this.cob_qtrycap.Size = new System.Drawing.Size(261, 28);
            this.cob_qtrycap.TabIndex = 21;
            this.cob_qtrycap.SelectedIndexChanged += new System.EventHandler(this.cob_qtrycap_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "CẤU HÌNH HỆ THỐNG";
            // 
            // frm_ketnoiSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(411, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cob_qtrycap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.cob_database);
            this.Controls.Add(this.cob_server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_ketnoiSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_capnhat;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.ComboBox cob_database;
        private System.Windows.Forms.ComboBox cob_server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cob_qtrycap;
        private System.Windows.Forms.Label label5;
    }
}