namespace QL_GiuXe
{
    partial class frm_DanhMuc_MayTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DanhMuc_MayTinh));
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huy = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Serial = new System.Windows.Forms.TextBox();
            this.txt_tenMay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ds = new System.Windows.Forms.DataGridView();
            this.Ma_may = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP_May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Cong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_tinhtrang = new System.Windows.Forms.CheckBox();
            this.txt_maMay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_lammoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(720, 7);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(40, 40);
            this.btn_thoat.TabIndex = 35;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(539, 76);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(539, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 25;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(539, 47);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 22;
            this.btn_huy.Text = "Hủy kích hoạt";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // txt_Serial
            // 
            this.txt_Serial.Enabled = false;
            this.txt_Serial.Location = new System.Drawing.Point(196, 98);
            this.txt_Serial.Name = "txt_Serial";
            this.txt_Serial.Size = new System.Drawing.Size(303, 21);
            this.txt_Serial.TabIndex = 21;
            // 
            // txt_tenMay
            // 
            this.txt_tenMay.Enabled = false;
            this.txt_tenMay.Location = new System.Drawing.Point(196, 44);
            this.txt_tenMay.Name = "txt_tenMay";
            this.txt_tenMay.Size = new System.Drawing.Size(303, 21);
            this.txt_tenMay.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Địa chỉ IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên máy tính:";
            // 
            // dgv_ds
            // 
            this.dgv_ds.AllowUserToAddRows = false;
            this.dgv_ds.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_may,
            this.TenMay,
            this.IP_May,
            this.Serial,
            this.TinhTrang,
            this.Ma_Cong,
            this.GhiChu});
            this.dgv_ds.Location = new System.Drawing.Point(12, 148);
            this.dgv_ds.Name = "dgv_ds";
            this.dgv_ds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds.Size = new System.Drawing.Size(748, 160);
            this.dgv_ds.TabIndex = 36;
            this.dgv_ds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ds_CellClick);
            // 
            // Ma_may
            // 
            this.Ma_may.DataPropertyName = "Ma_may";
            this.Ma_may.HeaderText = "Mã máy";
            this.Ma_may.Name = "Ma_may";
            // 
            // TenMay
            // 
            this.TenMay.DataPropertyName = "TenMay";
            this.TenMay.HeaderText = "Tên máy";
            this.TenMay.Name = "TenMay";
            // 
            // IP_May
            // 
            this.IP_May.DataPropertyName = "IP_May";
            this.IP_May.HeaderText = "Địa chỉ IP";
            this.IP_May.Name = "IP_May";
            // 
            // Serial
            // 
            this.Serial.DataPropertyName = "Serial";
            this.Serial.HeaderText = "Serial number";
            this.Serial.Name = "Serial";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // Ma_Cong
            // 
            this.Ma_Cong.DataPropertyName = "Ma_Cong";
            this.Ma_Cong.HeaderText = "Cổng đặt";
            this.Ma_Cong.Name = "Ma_Cong";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // txt_Ip
            // 
            this.txt_Ip.Enabled = false;
            this.txt_Ip.Location = new System.Drawing.Point(196, 71);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(302, 21);
            this.txt_Ip.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Serial number:";
            // 
            // chk_tinhtrang
            // 
            this.chk_tinhtrang.AutoSize = true;
            this.chk_tinhtrang.Enabled = false;
            this.chk_tinhtrang.Location = new System.Drawing.Point(196, 125);
            this.chk_tinhtrang.Name = "chk_tinhtrang";
            this.chk_tinhtrang.Size = new System.Drawing.Size(76, 17);
            this.chk_tinhtrang.TabIndex = 39;
            this.chk_tinhtrang.Text = "Hoạt động";
            this.chk_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // txt_maMay
            // 
            this.txt_maMay.Enabled = false;
            this.txt_maMay.Location = new System.Drawing.Point(196, 17);
            this.txt_maMay.Name = "txt_maMay";
            this.txt_maMay.Size = new System.Drawing.Size(303, 21);
            this.txt_maMay.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Mã máy tính:";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(539, 105);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.TabIndex = 42;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // frm_DanhMuc_MayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 322);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.txt_maMay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_tinhtrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Ip);
            this.Controls.Add(this.dgv_ds);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.txt_Serial);
            this.Controls.Add(this.txt_tenMay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DanhMuc_MayTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý máy tính";
            this.Load += new System.EventHandler(this.frm_DanhMuc_MayTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_huy;
        private System.Windows.Forms.TextBox txt_Serial;
        private System.Windows.Forms.TextBox txt_tenMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ds;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_may;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP_May;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Cong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.CheckBox chk_tinhtrang;
        private System.Windows.Forms.TextBox txt_maMay;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_lammoi;
    }
}