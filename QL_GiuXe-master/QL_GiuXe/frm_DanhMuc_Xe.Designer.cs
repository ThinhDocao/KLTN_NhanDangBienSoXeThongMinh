namespace QL_GiuXe
{
    partial class frm_DanhMuc_Xe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DanhMuc_Xe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maXe = new System.Windows.Forms.TextBox();
            this.txt_KhachHang = new System.Windows.Forms.TextBox();
            this.txt_MauSac = new System.Windows.Forms.TextBox();
            this.dgv_xe = new System.Windows.Forms.DataGridView();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienXo_Xe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSacXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnhXe = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_sua_anh = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Xe = new DevExpress.XtraEditors.PictureEdit();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_BienSo = new System.Windows.Forms.TextBox();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_khachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btn_lammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_chon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Xe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình biển số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Biển số:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Màu sắc:";
            // 
            // txt_maXe
            // 
            this.txt_maXe.Enabled = false;
            this.txt_maXe.Location = new System.Drawing.Point(110, 79);
            this.txt_maXe.Name = "txt_maXe";
            this.txt_maXe.Size = new System.Drawing.Size(100, 21);
            this.txt_maXe.TabIndex = 5;
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.Enabled = false;
            this.txt_KhachHang.Location = new System.Drawing.Point(110, 164);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.Size = new System.Drawing.Size(100, 21);
            this.txt_KhachHang.TabIndex = 7;
            this.txt_KhachHang.Text = "KH001";
            // 
            // txt_MauSac
            // 
            this.txt_MauSac.Enabled = false;
            this.txt_MauSac.Location = new System.Drawing.Point(110, 135);
            this.txt_MauSac.Name = "txt_MauSac";
            this.txt_MauSac.Size = new System.Drawing.Size(100, 21);
            this.txt_MauSac.TabIndex = 8;
            // 
            // dgv_xe
            // 
            this.dgv_xe.AllowUserToAddRows = false;
            this.dgv_xe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_xe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.BienXo_Xe,
            this.MauSacXe,
            this.MaKH,
            this.HinhAnhXe});
            this.dgv_xe.Location = new System.Drawing.Point(23, 205);
            this.dgv_xe.Name = "dgv_xe";
            this.dgv_xe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_xe.Size = new System.Drawing.Size(450, 184);
            this.dgv_xe.TabIndex = 10;
            this.dgv_xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_xe_CellClick);
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            // 
            // BienXo_Xe
            // 
            this.BienXo_Xe.DataPropertyName = "BienXo_Xe";
            this.BienXo_Xe.HeaderText = "Biển số xe";
            this.BienXo_Xe.Name = "BienXo_Xe";
            // 
            // MauSacXe
            // 
            this.MauSacXe.DataPropertyName = "MauSacXe";
            this.MauSacXe.HeaderText = "Màu sắc xe";
            this.MauSacXe.Name = "MauSacXe";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách";
            this.MaKH.Name = "MaKH";
            // 
            // HinhAnhXe
            // 
            this.HinhAnhXe.DataPropertyName = "HinhAnhXe";
            this.HinhAnhXe.HeaderText = "Hình biển số";
            this.HinhAnhXe.Name = "HinhAnhXe";
            this.HinhAnhXe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnhXe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HinhAnhXe.Visible = false;
            // 
            // btn_sua_anh
            // 
            this.btn_sua_anh.Enabled = false;
            this.btn_sua_anh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua_anh.ImageOptions.Image")));
            this.btn_sua_anh.Location = new System.Drawing.Point(398, 164);
            this.btn_sua_anh.Name = "btn_sua_anh";
            this.btn_sua_anh.Size = new System.Drawing.Size(75, 23);
            this.btn_sua_anh.TabIndex = 12;
            this.btn_sua_anh.Text = "Sửa ảnh";
            this.btn_sua_anh.Click += new System.EventHandler(this.btn_sua_anh_Click);
            // 
            // pic_Xe
            // 
            this.pic_Xe.Enabled = false;
            this.pic_Xe.Location = new System.Drawing.Point(357, 79);
            this.pic_Xe.Name = "pic_Xe";
            this.pic_Xe.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_Xe.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic_Xe.Size = new System.Drawing.Size(116, 79);
            this.pic_Xe.TabIndex = 13;
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_them.ImageOptions.SvgImage")));
            this.btn_them.Location = new System.Drawing.Point(155, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 39);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_BienSo
            // 
            this.txt_BienSo.Enabled = false;
            this.txt_BienSo.Location = new System.Drawing.Point(110, 106);
            this.txt_BienSo.Name = "txt_BienSo";
            this.txt_BienSo.Size = new System.Drawing.Size(100, 21);
            this.txt_BienSo.TabIndex = 6;
            this.txt_BienSo.TextChanged += new System.EventHandler(this.txt_BienSo_TextChanged);
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(398, 12);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 39);
            this.btn_luu.TabIndex = 15;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sua.ImageOptions.SvgImage")));
            this.btn_sua.Location = new System.Drawing.Point(317, 12);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 39);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_khachHang
            // 
            this.btn_khachHang.Enabled = false;
            this.btn_khachHang.Location = new System.Drawing.Point(216, 164);
            this.btn_khachHang.Name = "btn_khachHang";
            this.btn_khachHang.Size = new System.Drawing.Size(22, 23);
            this.btn_khachHang.TabIndex = 17;
            this.btn_khachHang.Text = "...";
            this.btn_khachHang.Click += new System.EventHandler(this.btn_khachHang_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.ImageOptions.Image")));
            this.btn_lammoi.Location = new System.Drawing.Point(108, 12);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(41, 39);
            this.btn_lammoi.TabIndex = 18;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_xoa.ImageOptions.SvgImage")));
            this.btn_xoa.Location = new System.Drawing.Point(236, 12);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 39);
            this.btn_xoa.TabIndex = 19;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_chon
            // 
            this.btn_chon.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.apply_32x321;
            this.btn_chon.Location = new System.Drawing.Point(23, 12);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(79, 39);
            this.btn_chon.TabIndex = 20;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.Visible = false;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // frm_DanhMuc_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 398);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_khachHang);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.pic_Xe);
            this.Controls.Add(this.btn_sua_anh);
            this.Controls.Add(this.dgv_xe);
            this.Controls.Add(this.txt_MauSac);
            this.Controls.Add(this.txt_KhachHang);
            this.Controls.Add(this.txt_BienSo);
            this.Controls.Add(this.txt_maXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_DanhMuc_Xe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xe";
            this.Load += new System.EventHandler(this.frm_DanhMuc_Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Xe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maXe;
        private System.Windows.Forms.TextBox txt_KhachHang;
        private System.Windows.Forms.TextBox txt_MauSac;
        private System.Windows.Forms.DataGridView dgv_xe;
        private DevExpress.XtraEditors.SimpleButton btn_sua_anh;
        private DevExpress.XtraEditors.PictureEdit pic_Xe;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.TextBox txt_BienSo;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienXo_Xe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSacXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnhXe;
        private DevExpress.XtraEditors.SimpleButton btn_khachHang;
        private DevExpress.XtraEditors.SimpleButton btn_lammoi;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_chon;
    }
}