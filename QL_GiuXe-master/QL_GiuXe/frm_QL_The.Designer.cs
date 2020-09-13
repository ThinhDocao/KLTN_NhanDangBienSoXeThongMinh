namespace QL_GiuXe
{
    partial class frm_QL_The
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QL_The));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grid_danhsachthe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaRFIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiVe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCapNhatCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ketnoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_khoiphuc = new DevExpress.XtraEditors.SimpleButton();
            this.cob_com = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_chon = new DevExpress.XtraEditors.SimpleButton();
            this.txt_mathe = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_lammoi = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.list_danhsach = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_danhsachthe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.grid_danhsachthe, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1213, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grid_danhsachthe
            // 
            this.grid_danhsachthe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_danhsachthe.Location = new System.Drawing.Point(377, 102);
            this.grid_danhsachthe.MainView = this.gridView1;
            this.grid_danhsachthe.Name = "grid_danhsachthe";
            this.tableLayoutPanel1.SetRowSpan(this.grid_danhsachthe, 2);
            this.grid_danhsachthe.Size = new System.Drawing.Size(822, 444);
            this.grid_danhsachthe.TabIndex = 0;
            this.grid_danhsachthe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaRFIF,
            this.NgayTao,
            this.LoaiVe,
            this.NgayCapNhatCuoi,
            this.TrangThai});
            this.gridView1.GridControl = this.grid_danhsachthe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // MaRFIF
            // 
            this.MaRFIF.Caption = "Mã thẻ";
            this.MaRFIF.FieldName = "MaRFIF";
            this.MaRFIF.Name = "MaRFIF";
            this.MaRFIF.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaRFIF", "Tổng thẻ = {0}")});
            this.MaRFIF.Visible = true;
            this.MaRFIF.VisibleIndex = 0;
            // 
            // NgayTao
            // 
            this.NgayTao.Caption = "Ngày tạo";
            this.NgayTao.FieldName = "NgayTao";
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.Visible = true;
            this.NgayTao.VisibleIndex = 1;
            // 
            // LoaiVe
            // 
            this.LoaiVe.Caption = "Loại vé";
            this.LoaiVe.FieldName = "TenLoaiVe";
            this.LoaiVe.Name = "LoaiVe";
            this.LoaiVe.Visible = true;
            this.LoaiVe.VisibleIndex = 2;
            // 
            // NgayCapNhatCuoi
            // 
            this.NgayCapNhatCuoi.Caption = "Cập nhật cuối";
            this.NgayCapNhatCuoi.FieldName = "NgayCapNhatCuoi";
            this.NgayCapNhatCuoi.Name = "NgayCapNhatCuoi";
            this.NgayCapNhatCuoi.Visible = true;
            this.NgayCapNhatCuoi.VisibleIndex = 3;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1186, 73);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_ketnoi);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_khoiphuc);
            this.panel2.Controls.Add(this.cob_com);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_chon);
            this.panel2.Controls.Add(this.txt_mathe);
            this.panel2.Controls.Add(this.btn_timkiem);
            this.panel2.Controls.Add(this.btn_lammoi);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 67);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(736, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đầu đọc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã thẻ:";
            // 
            // btn_ketnoi
            // 
            this.btn_ketnoi.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.usb_32x32;
            this.btn_ketnoi.Location = new System.Drawing.Point(972, 13);
            this.btn_ketnoi.Name = "btn_ketnoi";
            this.btn_ketnoi.Size = new System.Drawing.Size(194, 35);
            this.btn_ketnoi.TabIndex = 2;
            this.btn_ketnoi.Text = "KẾT NỐI VỚI ĐẦU ĐỌC THẺ";
            this.btn_ketnoi.Click += new System.EventHandler(this.btn_ketnoi_Click);
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.insert_32x32;
            this.btn_them.Location = new System.Drawing.Point(110, 13);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 35);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm thẻ";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_khoiphuc
            // 
            this.btn_khoiphuc.Enabled = false;
            this.btn_khoiphuc.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.redo_32x32;
            this.btn_khoiphuc.Location = new System.Drawing.Point(300, 13);
            this.btn_khoiphuc.Name = "btn_khoiphuc";
            this.btn_khoiphuc.Size = new System.Drawing.Size(111, 35);
            this.btn_khoiphuc.TabIndex = 1;
            this.btn_khoiphuc.Text = "Khôi phục thẻ";
            this.btn_khoiphuc.Click += new System.EventHandler(this.btn_khoiphuc_Click);
            // 
            // cob_com
            // 
            this.cob_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_com.FormattingEnabled = true;
            this.cob_com.Location = new System.Drawing.Point(805, 19);
            this.cob_com.Name = "cob_com";
            this.cob_com.Size = new System.Drawing.Size(143, 21);
            this.cob_com.TabIndex = 4;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Enabled = false;
            this.btn_xoa.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.hide_32x32;
            this.btn_xoa.Location = new System.Drawing.Point(208, 13);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(86, 35);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa thẻ";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_chon
            // 
            this.btn_chon.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.apply_32x323;
            this.btn_chon.Location = new System.Drawing.Point(110, 13);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(92, 35);
            this.btn_chon.TabIndex = 3;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.Visible = false;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // txt_mathe
            // 
            this.txt_mathe.Location = new System.Drawing.Point(482, 21);
            this.txt_mathe.Name = "txt_mathe";
            this.txt_mathe.Size = new System.Drawing.Size(139, 21);
            this.txt_mathe.TabIndex = 2;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.find_32x321;
            this.btn_timkiem.Location = new System.Drawing.Point(627, 13);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(88, 35);
            this.btn_timkiem.TabIndex = 1;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.ImageOptions.Image = global::QL_GiuXe.Properties.Resources.refresh_32x32;
            this.btn_lammoi.Location = new System.Drawing.Point(12, 13);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(92, 35);
            this.btn_lammoi.TabIndex = 0;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.list_danhsach, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 102);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 354F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 444);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // list_danhsach
            // 
            this.list_danhsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.list_danhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_danhsach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_danhsach.FormattingEnabled = true;
            this.list_danhsach.ItemHeight = 19;
            this.list_danhsach.Location = new System.Drawing.Point(3, 3);
            this.list_danhsach.Name = "list_danhsach";
            this.tableLayoutPanel2.SetRowSpan(this.list_danhsach, 2);
            this.list_danhsach.Size = new System.Drawing.Size(342, 438);
            this.list_danhsach.TabIndex = 0;
            this.list_danhsach.Click += new System.EventHandler(this.list_danhsach_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1205, 181);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(5, 365);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // frm_QL_The
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_QL_The";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thẻ";
            this.Load += new System.EventHandler(this.frm_QL_The_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_danhsachthe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btn_khoiphuc;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_ketnoi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox list_danhsach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraGrid.GridControl grid_danhsachthe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaRFIF;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCapNhatCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private System.Windows.Forms.ComboBox cob_com;
        private System.IO.Ports.SerialPort serialPort1;
        private DevExpress.XtraEditors.SimpleButton btn_lammoi;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiVe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_mathe;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private DevExpress.XtraEditors.SimpleButton btn_chon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}