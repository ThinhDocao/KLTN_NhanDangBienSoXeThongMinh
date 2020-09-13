namespace QL_GiuXe
{
    partial class frm_DanhMuc_Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DanhMuc_Camera));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hang = new System.Windows.Forms.TextBox();
            this.txt_chuoi = new System.Windows.Forms.TextBox();
            this.btn_luuthem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luuthoat = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hang_Camera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuoiCauHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hãng camera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi kết nối:";
            // 
            // txt_hang
            // 
            this.txt_hang.Location = new System.Drawing.Point(123, 226);
            this.txt_hang.Name = "txt_hang";
            this.txt_hang.Size = new System.Drawing.Size(303, 21);
            this.txt_hang.TabIndex = 2;
            // 
            // txt_chuoi
            // 
            this.txt_chuoi.Location = new System.Drawing.Point(123, 253);
            this.txt_chuoi.Name = "txt_chuoi";
            this.txt_chuoi.Size = new System.Drawing.Size(303, 21);
            this.txt_chuoi.TabIndex = 3;
            // 
            // btn_luuthem
            // 
            this.btn_luuthem.Location = new System.Drawing.Point(272, 280);
            this.btn_luuthem.Name = "btn_luuthem";
            this.btn_luuthem.Size = new System.Drawing.Size(75, 23);
            this.btn_luuthem.TabIndex = 4;
            this.btn_luuthem.Text = "Lưu và thêm";
            this.btn_luuthem.Click += new System.EventHandler(this.btn_luuthem_Click);
            // 
            // btn_luuthoat
            // 
            this.btn_luuthoat.Location = new System.Drawing.Point(353, 280);
            this.btn_luuthoat.Name = "btn_luuthoat";
            this.btn_luuthoat.Size = new System.Drawing.Size(75, 23);
            this.btn_luuthoat.TabIndex = 5;
            this.btn_luuthoat.Text = "Lưu và thoát";
            this.btn_luuthoat.Click += new System.EventHandler(this.btn_luuthoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hang_Camera,
            this.ChuoiCauHinh});
            this.dataGridView1.Location = new System.Drawing.Point(29, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(397, 165);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Hang_Camera
            // 
            this.Hang_Camera.DataPropertyName = "Hang_Camera";
            this.Hang_Camera.FillWeight = 101.5228F;
            this.Hang_Camera.HeaderText = "Hãng camera";
            this.Hang_Camera.Name = "Hang_Camera";
            this.Hang_Camera.ReadOnly = true;
            // 
            // ChuoiCauHinh
            // 
            this.ChuoiCauHinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChuoiCauHinh.DataPropertyName = "ChuoiCauHinh";
            this.ChuoiCauHinh.FillWeight = 98.47716F;
            this.ChuoiCauHinh.HeaderText = "Chuỗi kết nối";
            this.ChuoiCauHinh.Name = "ChuoiCauHinh";
            this.ChuoiCauHinh.ReadOnly = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(110, 280);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(191, 280);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chuỗi kết nối:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mật khẩu: @MATKHAU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "IP: @IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cổng: @CONG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tài Khoản: @TAIKHOAN ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vi dụ: rtsp://admin:mk12345@192.168.0.10:cong/onvif1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(399, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "=> rtsp://@TAIKHOAN:@MATKHAU@@IP:@CONG/onvif1";
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.add_16x16;
            this.btn_them.Location = new System.Drawing.Point(29, 280);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(412, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(40, 40);
            this.btn_thoat.TabIndex = 17;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_DanhMuc_Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 423);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_luuthoat);
            this.Controls.Add(this.btn_luuthem);
            this.Controls.Add(this.txt_chuoi);
            this.Controls.Add(this.txt_hang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DanhMuc_Camera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Camera";
            this.Load += new System.EventHandler(this.frm_DanhMuc_Camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hang;
        private System.Windows.Forms.TextBox txt_chuoi;
        private DevExpress.XtraEditors.SimpleButton btn_luuthem;
        private DevExpress.XtraEditors.SimpleButton btn_luuthoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hang_Camera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuoiCauHinh;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
    }
}