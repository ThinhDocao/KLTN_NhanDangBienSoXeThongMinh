namespace QL_GiuXe
{
    partial class frm_ThongTinVaoRa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongTinVaoRa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cob_truyvan = new System.Windows.Forms.ComboBox();
            this.cob_nv_vao = new System.Windows.Forms.ComboBox();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ck_vipham = new System.Windows.Forms.CheckBox();
            this.txt_vi_pham = new System.Windows.Forms.TextBox();
            this.txt_capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ngayBD = new System.Windows.Forms.DateTimePicker();
            this.txt_nagyKT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_soThe = new System.Windows.Forms.TextBox();
            this.txt_bienso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaRFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BienSoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NVVVV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtHinhN = new System.Windows.Forms.TextBox();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txt_MaThe = new System.Windows.Forms.TextBox();
            this.btn_xuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MayTinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Truy vấn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "đến ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nhân viên:";
            // 
            // cob_truyvan
            // 
            this.cob_truyvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_truyvan.FormattingEnabled = true;
            this.cob_truyvan.Items.AddRange(new object[] {
            "Thông tin xe vào",
            "Thông tin xe ra"});
            this.cob_truyvan.Location = new System.Drawing.Point(144, 32);
            this.cob_truyvan.Name = "cob_truyvan";
            this.cob_truyvan.Size = new System.Drawing.Size(163, 21);
            this.cob_truyvan.TabIndex = 8;
            this.cob_truyvan.SelectedIndexChanged += new System.EventHandler(this.cob_truyvan_SelectedIndexChanged);
            // 
            // cob_nv_vao
            // 
            this.cob_nv_vao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_nv_vao.FormattingEnabled = true;
            this.cob_nv_vao.Location = new System.Drawing.Point(144, 151);
            this.cob_nv_vao.Name = "cob_nv_vao";
            this.cob_nv_vao.Size = new System.Drawing.Size(163, 21);
            this.cob_nv_vao.TabIndex = 9;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.find_16x16;
            this.btn_timkiem.Location = new System.Drawing.Point(369, 30);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(82, 24);
            this.btn_timkiem.TabIndex = 15;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(457, 31);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Quản lý thẻ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(823, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(552, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // ck_vipham
            // 
            this.ck_vipham.AutoSize = true;
            this.ck_vipham.Location = new System.Drawing.Point(1075, 30);
            this.ck_vipham.Name = "ck_vipham";
            this.ck_vipham.Size = new System.Drawing.Size(63, 17);
            this.ck_vipham.TabIndex = 20;
            this.ck_vipham.Text = "Vi phạm";
            this.ck_vipham.UseVisualStyleBackColor = true;
            this.ck_vipham.CheckedChanged += new System.EventHandler(this.ck_vipham_CheckedChanged);
            // 
            // txt_vi_pham
            // 
            this.txt_vi_pham.Enabled = false;
            this.txt_vi_pham.Location = new System.Drawing.Point(1075, 94);
            this.txt_vi_pham.MaxLength = 500;
            this.txt_vi_pham.Multiline = true;
            this.txt_vi_pham.Name = "txt_vi_pham";
            this.txt_vi_pham.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_vi_pham.Size = new System.Drawing.Size(234, 78);
            this.txt_vi_pham.TabIndex = 21;
            // 
            // txt_capnhat
            // 
            this.txt_capnhat.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.updatetable_32x32;
            this.txt_capnhat.Location = new System.Drawing.Point(1075, 53);
            this.txt_capnhat.Name = "txt_capnhat";
            this.txt_capnhat.Size = new System.Drawing.Size(133, 35);
            this.txt_capnhat.TabIndex = 22;
            this.txt_capnhat.Text = "Cập nhật vi phạm";
            this.txt_capnhat.Click += new System.EventHandler(this.txt_capnhat_Click);
            // 
            // txt_ngayBD
            // 
            this.txt_ngayBD.CustomFormat = "dd/MM/yyyy 00:00";
            this.txt_ngayBD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_ngayBD.Location = new System.Drawing.Point(141, 69);
            this.txt_ngayBD.Name = "txt_ngayBD";
            this.txt_ngayBD.Size = new System.Drawing.Size(166, 23);
            this.txt_ngayBD.TabIndex = 25;
            // 
            // txt_nagyKT
            // 
            this.txt_nagyKT.CustomFormat = "dd/MM/yyyy 23:59";
            this.txt_nagyKT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nagyKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_nagyKT.Location = new System.Drawing.Point(366, 70);
            this.txt_nagyKT.Name = "txt_nagyKT";
            this.txt_nagyKT.Size = new System.Drawing.Size(166, 23);
            this.txt_nagyKT.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số thẻ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Biển số:";
            // 
            // txt_soThe
            // 
            this.txt_soThe.Location = new System.Drawing.Point(144, 110);
            this.txt_soThe.Name = "txt_soThe";
            this.txt_soThe.Size = new System.Drawing.Size(163, 21);
            this.txt_soThe.TabIndex = 13;
            // 
            // txt_bienso
            // 
            this.txt_bienso.Location = new System.Drawing.Point(369, 110);
            this.txt_bienso.Name = "txt_bienso";
            this.txt_bienso.Size = new System.Drawing.Size(163, 21);
            this.txt_bienso.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Khách:";
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Items.AddRange(new object[] {
            "All",
            "Vãng lai",
            "Tháng"});
            this.cboKhach.Location = new System.Drawing.Point(369, 151);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(163, 21);
            this.cboKhach.TabIndex = 29;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 246);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1376, 510);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaRFID,
            this.BienSoo,
            this.NVVVV,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.LoaiKhach,
            this.GhiChu,
            this.MaVao});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // MaRFID
            // 
            this.MaRFID.Caption = "Mã thẻ";
            this.MaRFID.FieldName = "MaRFIF";
            this.MaRFID.Name = "MaRFID";
            this.MaRFID.Visible = true;
            this.MaRFID.VisibleIndex = 0;
            // 
            // BienSoo
            // 
            this.BienSoo.Caption = "Biển số";
            this.BienSoo.FieldName = "BienSo";
            this.BienSoo.Name = "BienSoo";
            this.BienSoo.Visible = true;
            this.BienSoo.VisibleIndex = 1;
            // 
            // NVVVV
            // 
            this.NVVVV.Caption = "Tên NV";
            this.NVVVV.FieldName = "TenNV";
            this.NVVVV.Name = "NVVVV";
            this.NVVVV.Visible = true;
            this.NVVVV.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thời gian";
            this.gridColumn1.FieldName = "TG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Hình biển số";
            this.gridColumn2.FieldName = "HinhBX";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hình người";
            this.gridColumn3.FieldName = "HinhN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Trạng thái";
            this.gridColumn4.FieldName = "TrangThai";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TrangThai", "Tổng số xe = {0}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Máy tính";
            this.gridColumn5.FieldName = "Maytinh";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            // 
            // LoaiKhach
            // 
            this.LoaiKhach.Caption = "Khách Theo tháng";
            this.LoaiKhach.FieldName = "LoaiKhach";
            this.LoaiKhach.Name = "LoaiKhach";
            this.LoaiKhach.Visible = true;
            this.LoaiKhach.VisibleIndex = 8;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            // 
            // MaVao
            // 
            this.MaVao.Caption = "Mã vào";
            this.MaVao.FieldName = "Ma";
            this.MaVao.Name = "MaVao";
            // 
            // txtHinhN
            // 
            this.txtHinhN.Location = new System.Drawing.Point(777, 151);
            this.txtHinhN.Name = "txtHinhN";
            this.txtHinhN.Size = new System.Drawing.Size(10, 21);
            this.txtHinhN.TabIndex = 31;
            this.txtHinhN.TextChanged += new System.EventHandler(this.txtHinhN_TextChanged);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(823, 151);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(10, 21);
            this.txtBS.TabIndex = 32;
            this.txtBS.TextChanged += new System.EventHandler(this.txtBS_TextChanged);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(1075, 146);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(10, 21);
            this.txtMa.TabIndex = 33;
            // 
            // txt_MaThe
            // 
            this.txt_MaThe.Location = new System.Drawing.Point(552, 151);
            this.txt_MaThe.Name = "txt_MaThe";
            this.txt_MaThe.Size = new System.Drawing.Size(10, 21);
            this.txt_MaThe.TabIndex = 34;
            // 
            // btn_xuatExcel
            // 
            this.btn_xuatExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xuatExcel.ImageOptions.Image")));
            this.btn_xuatExcel.Location = new System.Drawing.Point(1205, 178);
            this.btn_xuatExcel.Name = "btn_xuatExcel";
            this.btn_xuatExcel.Size = new System.Drawing.Size(104, 23);
            this.btn_xuatExcel.TabIndex = 35;
            this.btn_xuatExcel.Text = "Xuất Excel";
            this.btn_xuatExcel.Click += new System.EventHandler(this.btn_xuatExcel_Click);
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.print_16x16;
            this.btnIn.Location = new System.Drawing.Point(1075, 178);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(104, 23);
            this.btnIn.TabIndex = 36;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txt_MayTinh
            // 
            this.txt_MayTinh.Location = new System.Drawing.Point(1048, 151);
            this.txt_MayTinh.Name = "txt_MayTinh";
            this.txt_MayTinh.Size = new System.Drawing.Size(10, 21);
            this.txt_MayTinh.TabIndex = 37;
            // 
            // frm_ThongTinVaoRa
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 756);
            this.Controls.Add(this.txt_MayTinh);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btn_xuatExcel);
            this.Controls.Add(this.txt_MaThe);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.txtHinhN);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.cboKhach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nagyKT);
            this.Controls.Add(this.txt_ngayBD);
            this.Controls.Add(this.txt_capnhat);
            this.Controls.Add(this.txt_vi_pham);
            this.Controls.Add(this.ck_vipham);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_bienso);
            this.Controls.Add(this.txt_soThe);
            this.Controls.Add(this.cob_nv_vao);
            this.Controls.Add(this.cob_truyvan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ThongTinVaoRa";
            this.Text = "Thông tin xe ra vào";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongTinVaoRa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.DataGridViewTextBoxColumn MaRFIF;
        //private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        //private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        //private System.Windows.Forms.DataGridViewTextBoxColumn HinhBX;
        //private System.Windows.Forms.DataGridViewTextBoxColumn HinhN;
        //private System.Windows.Forms.DataGridViewTextBoxColumn TG;
        //private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cob_truyvan;
        private System.Windows.Forms.ComboBox cob_nv_vao;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox ck_vipham;
        private System.Windows.Forms.TextBox txt_vi_pham;
        private DevExpress.XtraEditors.SimpleButton txt_capnhat;
        private System.Windows.Forms.DateTimePicker txt_ngayBD;
        private System.Windows.Forms.DateTimePicker txt_nagyKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soThe;
        private System.Windows.Forms.TextBox txt_bienso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboKhach;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaRFID;
        private DevExpress.XtraGrid.Columns.GridColumn BienSoo;
        private DevExpress.XtraGrid.Columns.GridColumn NVVVV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiKhach;
        private System.Windows.Forms.TextBox txtHinhN;
        private System.Windows.Forms.TextBox txtBS;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private System.Windows.Forms.TextBox txtMa;
        private DevExpress.XtraGrid.Columns.GridColumn MaVao;
        private System.Windows.Forms.TextBox txt_MaThe;
        private DevExpress.XtraEditors.SimpleButton btn_xuatExcel;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Windows.Forms.TextBox txt_MayTinh;
    }
}