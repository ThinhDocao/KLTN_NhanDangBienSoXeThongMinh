namespace QL_GiuXe
{
    partial class frm_VeThang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VeThang));
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_giahan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_lammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ketnoi = new DevExpress.XtraEditors.SimpleButton();
            this.cob_com = new System.Windows.Forms.ComboBox();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaVeThang = new System.Windows.Forms.TextBox();
            this.txt_MaRFID = new System.Windows.Forms.TextBox();
            this.txt_NgayBD = new DevExpress.XtraEditors.DateEdit();
            this.txt_NgayKT = new DevExpress.XtraEditors.DateEdit();
            this.txt_MayTinh = new System.Windows.Forms.TextBox();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaXe = new System.Windows.Forms.TextBox();
            this.btn_MaXe = new DevExpress.XtraEditors.SimpleButton();
            this.btn_MaRFID = new DevExpress.XtraEditors.SimpleButton();
            this.txt_NgayTao = new DevExpress.XtraEditors.TextEdit();
            this.dgv_VeThang = new System.Windows.Forms.DataGridView();
            this.MaVeThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaRFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MayTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VeThang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.ColumnCount = 6;
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.panel.Controls.Add(this.progressBar1, 1, 4);
            this.panel.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.panel.Controls.Add(this.dgv_VeThang, 1, 2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.RowCount = 5;
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panel.Size = new System.Drawing.Size(1285, 527);
            this.panel.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.panel.SetColumnSpan(this.progressBar1, 4);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(13, 520);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1258, 4);
            this.progressBar1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 13;
            this.panel.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.190947F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.83188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.619355F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.61318F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.991676F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.37504F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.60006F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.991676F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.18157F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60461F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 11, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 11, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_MaVeThang, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_MaRFID, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_NgayBD, 8, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_NgayKT, 12, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_MayTinh, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_NhanVien, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_MaXe, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_MaXe, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_MaRFID, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_NgayTao, 12, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1258, 163);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_giahan);
            this.panel1.Controls.Add(this.btn_lammoi);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_ketnoi);
            this.panel1.Controls.Add(this.cob_com);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 55);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(642, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Đầu đọc thẻ:";
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.addfile_32x32;
            this.btn_them.Location = new System.Drawing.Point(280, 9);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(98, 41);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "Thêm vé";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_giahan
            // 
            this.btn_giahan.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.updatetable_32x321;
            this.btn_giahan.Location = new System.Drawing.Point(400, 9);
            this.btn_giahan.Name = "btn_giahan";
            this.btn_giahan.Size = new System.Drawing.Size(100, 41);
            this.btn_giahan.TabIndex = 23;
            this.btn_giahan.Text = "Gia hạn";
            this.btn_giahan.Click += new System.EventHandler(this.btn_giahan_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.refreshpivottable_32x32;
            this.btn_lammoi.Location = new System.Drawing.Point(40, 9);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(94, 41);
            this.btn_lammoi.TabIndex = 24;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.trash_32x32;
            this.btn_xoa.Location = new System.Drawing.Point(520, 9);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 41);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.Text = "Xóa vé";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_ketnoi
            // 
            this.btn_ketnoi.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.usb_32x32;
            this.btn_ketnoi.Location = new System.Drawing.Point(953, 9);
            this.btn_ketnoi.Name = "btn_ketnoi";
            this.btn_ketnoi.Size = new System.Drawing.Size(182, 41);
            this.btn_ketnoi.TabIndex = 21;
            this.btn_ketnoi.Text = "KẾT NỐI VỚI ĐẦU ĐỌC THẺ";
            this.btn_ketnoi.Click += new System.EventHandler(this.btn_ketnoi_Click);
            // 
            // cob_com
            // 
            this.cob_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_com.FormattingEnabled = true;
            this.cob_com.Location = new System.Drawing.Point(748, 20);
            this.cob_com.Name = "cob_com";
            this.cob_com.Size = new System.Drawing.Size(162, 21);
            this.cob_com.TabIndex = 20;
            this.cob_com.SelectedIndexChanged += new System.EventHandler(this.cob_com_SelectedIndexChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.findbyid_32x32;
            this.btn_timkiem.Location = new System.Drawing.Point(160, 9);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 41);
            this.btn_timkiem.TabIndex = 22;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vé tháng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã RFID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(953, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày tạo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhân viên:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Máy tính:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(625, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày bắt đầu:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(953, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày hết hạn:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_MaVeThang
            // 
            this.txt_MaVeThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MaVeThang.Location = new System.Drawing.Point(103, 64);
            this.txt_MaVeThang.Name = "txt_MaVeThang";
            this.txt_MaVeThang.ReadOnly = true;
            this.txt_MaVeThang.Size = new System.Drawing.Size(163, 21);
            this.txt_MaVeThang.TabIndex = 8;
            this.txt_MaVeThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaVeThang_KeyPress);
            // 
            // txt_MaRFID
            // 
            this.txt_MaRFID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MaRFID.Location = new System.Drawing.Point(400, 64);
            this.txt_MaRFID.Name = "txt_MaRFID";
            this.txt_MaRFID.Size = new System.Drawing.Size(185, 21);
            this.txt_MaRFID.TabIndex = 9;
            this.txt_MaRFID.TextChanged += new System.EventHandler(this.txt_MaRFID_TextChanged);
            // 
            // txt_NgayBD
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_NgayBD, 2);
            this.txt_NgayBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_NgayBD.EditValue = null;
            this.txt_NgayBD.Location = new System.Drawing.Point(752, 114);
            this.txt_NgayBD.Name = "txt_NgayBD";
            this.txt_NgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgayBD.Properties.DisplayFormat.FormatString = "";
            this.txt_NgayBD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_NgayBD.Properties.EditFormat.FormatString = "";
            this.txt_NgayBD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_NgayBD.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txt_NgayBD.Size = new System.Drawing.Size(185, 20);
            this.txt_NgayBD.TabIndex = 12;
            this.txt_NgayBD.EditValueChanged += new System.EventHandler(this.txt_NgayBD_EditValueChanged);
            this.txt_NgayBD.TextChanged += new System.EventHandler(this.txt_NgayBD_TextChanged);
            // 
            // txt_NgayKT
            // 
            this.txt_NgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_NgayKT.EditValue = null;
            this.txt_NgayKT.Location = new System.Drawing.Point(1078, 114);
            this.txt_NgayKT.Name = "txt_NgayKT";
            this.txt_NgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_NgayKT.Properties.DisplayFormat.FormatString = "";
            this.txt_NgayKT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_NgayKT.Properties.EditFormat.FormatString = "";
            this.txt_NgayKT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_NgayKT.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txt_NgayKT.Properties.ReadOnly = true;
            this.txt_NgayKT.Size = new System.Drawing.Size(177, 20);
            this.txt_NgayKT.TabIndex = 13;
            this.txt_NgayKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaVeThang_KeyPress);
            // 
            // txt_MayTinh
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_MayTinh, 2);
            this.txt_MayTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MayTinh.Location = new System.Drawing.Point(400, 114);
            this.txt_MayTinh.Name = "txt_MayTinh";
            this.txt_MayTinh.ReadOnly = true;
            this.txt_MayTinh.Size = new System.Drawing.Size(209, 21);
            this.txt_MayTinh.TabIndex = 14;
            this.txt_MayTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaVeThang_KeyPress);
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_NhanVien.Location = new System.Drawing.Point(103, 114);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.ReadOnly = true;
            this.txt_NhanVien.Size = new System.Drawing.Size(163, 21);
            this.txt_NhanVien.TabIndex = 15;
            this.txt_NhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaVeThang_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã xe:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_MaXe
            // 
            this.txt_MaXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MaXe.Location = new System.Drawing.Point(752, 64);
            this.txt_MaXe.Name = "txt_MaXe";
            this.txt_MaXe.Size = new System.Drawing.Size(161, 21);
            this.txt_MaXe.TabIndex = 16;
            this.txt_MaXe.TextChanged += new System.EventHandler(this.txt_MaRFID_TextChanged);
            this.txt_MaXe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaVeThang_KeyPress);
            // 
            // btn_MaXe
            // 
            this.btn_MaXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MaXe.Location = new System.Drawing.Point(919, 64);
            this.btn_MaXe.Name = "btn_MaXe";
            this.btn_MaXe.Size = new System.Drawing.Size(18, 19);
            this.btn_MaXe.TabIndex = 17;
            this.btn_MaXe.Text = "...";
            this.btn_MaXe.Click += new System.EventHandler(this.btn_MaXe_Click);
            // 
            // btn_MaRFID
            // 
            this.btn_MaRFID.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MaRFID.Location = new System.Drawing.Point(591, 64);
            this.btn_MaRFID.Name = "btn_MaRFID";
            this.btn_MaRFID.Size = new System.Drawing.Size(18, 19);
            this.btn_MaRFID.TabIndex = 18;
            this.btn_MaRFID.Text = "...";
            this.btn_MaRFID.Click += new System.EventHandler(this.btn_MaRFID_Click);
            // 
            // txt_NgayTao
            // 
            this.txt_NgayTao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_NgayTao.Enabled = false;
            this.txt_NgayTao.Location = new System.Drawing.Point(1078, 64);
            this.txt_NgayTao.Name = "txt_NgayTao";
            this.txt_NgayTao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_NgayTao.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_NgayTao.Properties.ReadOnly = true;
            this.txt_NgayTao.Size = new System.Drawing.Size(177, 20);
            this.txt_NgayTao.TabIndex = 11;
            this.txt_NgayTao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaVeThang_KeyPress);
            // 
            // dgv_VeThang
            // 
            this.dgv_VeThang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_VeThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VeThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVeThang,
            this.MaRFID,
            this.MaXe,
            this.NgayBD,
            this.NgayKT,
            this.NgayTaoVe,
            this.NhanVien,
            this.MayTinh});
            this.panel.SetColumnSpan(this.dgv_VeThang, 4);
            this.dgv_VeThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_VeThang.Location = new System.Drawing.Point(13, 182);
            this.dgv_VeThang.Name = "dgv_VeThang";
            this.panel.SetRowSpan(this.dgv_VeThang, 2);
            this.dgv_VeThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VeThang.Size = new System.Drawing.Size(1258, 332);
            this.dgv_VeThang.TabIndex = 1;
            this.dgv_VeThang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VeThang_CellClick);
            // 
            // MaVeThang
            // 
            this.MaVeThang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaVeThang.DataPropertyName = "MaVeThang";
            this.MaVeThang.HeaderText = "Mã vé tháng";
            this.MaVeThang.Name = "MaVeThang";
            // 
            // MaRFID
            // 
            this.MaRFID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaRFID.DataPropertyName = "MaRFID";
            this.MaRFID.HeaderText = "Mã RFID";
            this.MaRFID.Name = "MaRFID";
            // 
            // MaXe
            // 
            this.MaXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            // 
            // NgayBD
            // 
            this.NgayBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày bắt đầu";
            this.NgayBD.Name = "NgayBD";
            // 
            // NgayKT
            // 
            this.NgayKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKT.DataPropertyName = "NgayKT";
            this.NgayKT.HeaderText = "Ngày hết hạn";
            this.NgayKT.Name = "NgayKT";
            // 
            // NgayTaoVe
            // 
            this.NgayTaoVe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayTaoVe.DataPropertyName = "NgayTaoVe";
            this.NgayTaoVe.HeaderText = "Ngày tạo vé";
            this.NgayTaoVe.Name = "NgayTaoVe";
            // 
            // NhanVien
            // 
            this.NhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhanVien.DataPropertyName = "NhanVien";
            this.NhanVien.HeaderText = "Nhân viên";
            this.NhanVien.Name = "NhanVien";
            // 
            // MayTinh
            // 
            this.MayTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MayTinh.DataPropertyName = "MayTinh";
            this.MayTinh.HeaderText = "Máy tính";
            this.MayTinh.Name = "MayTinh";
            // 
            // frm_VeThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 527);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_VeThang";
            this.Text = "Quản lý vé tháng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_VeThang_Load);
            this.panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VeThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaVeThang;
        private System.Windows.Forms.TextBox txt_MaRFID;
        private DevExpress.XtraEditors.DateEdit txt_NgayBD;
        private DevExpress.XtraEditors.DateEdit txt_NgayKT;
        private System.Windows.Forms.TextBox txt_MayTinh;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.TextBox txt_MaXe;
        private DevExpress.XtraEditors.SimpleButton btn_MaXe;
        private DevExpress.XtraEditors.SimpleButton btn_MaRFID;
        private System.Windows.Forms.DataGridView dgv_VeThang;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVeThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTaoVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MayTinh;
        private DevExpress.XtraEditors.TextEdit txt_NgayTao;
        private System.Windows.Forms.ComboBox cob_com;
        private System.IO.Ports.SerialPort serialPort1;
        private DevExpress.XtraEditors.SimpleButton btn_ketnoi;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private DevExpress.XtraEditors.SimpleButton btn_giahan;
        private DevExpress.XtraEditors.SimpleButton btn_lammoi;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}