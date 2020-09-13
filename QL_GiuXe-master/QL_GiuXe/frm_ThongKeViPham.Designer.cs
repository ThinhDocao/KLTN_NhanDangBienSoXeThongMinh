namespace QL_GiuXe
{
    partial class frm_ThongKeViPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongKeViPham));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BienXo_Xe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ViPham1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.glueNV = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNVV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNVV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glueKH = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhongg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 152);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(907, 362);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaXe,
            this.BienXo_Xe,
            this.MaKH,
            this.TenKH,
            this.SoPhong,
            this.MaNV,
            this.TenNV,
            this.ThoiGian,
            this.ViPham1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // MaXe
            // 
            this.MaXe.Caption = "Mã xe";
            this.MaXe.FieldName = "MaXe";
            this.MaXe.Name = "MaXe";
            // 
            // BienXo_Xe
            // 
            this.BienXo_Xe.Caption = "Biển số xe";
            this.BienXo_Xe.FieldName = "BienXo_Xe";
            this.BienXo_Xe.Name = "BienXo_Xe";
            this.BienXo_Xe.Visible = true;
            this.BienXo_Xe.VisibleIndex = 0;
            this.BienXo_Xe.Width = 115;
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Mã KH";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Tên KH";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            this.TenKH.Width = 161;
            // 
            // SoPhong
            // 
            this.SoPhong.Caption = "Số phòng";
            this.SoPhong.FieldName = "SoPhong";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Visible = true;
            this.SoPhong.VisibleIndex = 2;
            this.SoPhong.Width = 103;
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã NV";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.Caption = "Tên NV";
            this.TenNV.FieldName = "TenNV";
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 3;
            this.TenNV.Width = 158;
            // 
            // ThoiGian
            // 
            this.ThoiGian.Caption = "Thời gian";
            this.ThoiGian.FieldName = "ThoiGian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Visible = true;
            this.ThoiGian.VisibleIndex = 4;
            this.ThoiGian.Width = 76;
            // 
            // ViPham1
            // 
            this.ViPham1.Caption = "Vi phạm";
            this.ViPham1.FieldName = "ViPham1";
            this.ViPham1.Name = "ViPham1";
            this.ViPham1.Visible = true;
            this.ViPham1.VisibleIndex = 5;
            this.ViPham1.Width = 79;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(125, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 15);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 15);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Khách hàng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 15);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Từ ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 21);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(104, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 21);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(33, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 15);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Đến ngày";
            // 
            // glueNV
            // 
            this.glueNV.EditValue = "Chọn NV";
            this.glueNV.Location = new System.Drawing.Point(17, 23);
            this.glueNV.Name = "glueNV";
            this.glueNV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glueNV.Properties.Appearance.Options.UseFont = true;
            this.glueNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueNV.Properties.NullText = "Chọn NV";
            this.glueNV.Properties.PopupView = this.gridView3;
            this.glueNV.Size = new System.Drawing.Size(136, 22);
            this.glueNV.TabIndex = 10;
            this.glueNV.EditValueChanged += new System.EventHandler(this.glueNV_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNVV,
            this.TenNVV,
            this.GioiTinh});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // MaNVV
            // 
            this.MaNVV.Caption = "Mã NV";
            this.MaNVV.FieldName = "MaNV";
            this.MaNVV.Name = "MaNVV";
            // 
            // TenNVV
            // 
            this.TenNVV.Caption = "Tên NV";
            this.TenNVV.FieldName = "TenNV";
            this.TenNVV.Name = "TenNVV";
            this.TenNVV.Visible = true;
            this.TenNVV.VisibleIndex = 0;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 1;
            // 
            // glueKH
            // 
            this.glueKH.EditValue = "Chọn KH";
            this.glueKH.Location = new System.Drawing.Point(104, 28);
            this.glueKH.Name = "glueKH";
            this.glueKH.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glueKH.Properties.Appearance.Options.UseFont = true;
            this.glueKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueKH.Properties.NullText = "Chọn KH";
            this.glueKH.Properties.PopupView = this.gridLookUpEdit1View;
            this.glueKH.Size = new System.Drawing.Size(136, 22);
            this.glueKH.TabIndex = 11;
            this.glueKH.EditValueChanged += new System.EventHandler(this.glueKH_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKHH,
            this.TenKHH,
            this.SoPhongg});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MaKHH
            // 
            this.MaKHH.Caption = "Mã KH";
            this.MaKHH.FieldName = "MaKH";
            this.MaKHH.Name = "MaKHH";
            // 
            // TenKHH
            // 
            this.TenKHH.Caption = "Tên KH";
            this.TenKHH.FieldName = "TenKH";
            this.TenKHH.Name = "TenKHH";
            this.TenKHH.Visible = true;
            this.TenKHH.VisibleIndex = 0;
            // 
            // SoPhongg
            // 
            this.SoPhongg.Caption = "Số phòng";
            this.SoPhongg.FieldName = "SoPhong";
            this.SoPhongg.Name = "SoPhongg";
            this.SoPhongg.Visible = true;
            this.SoPhongg.VisibleIndex = 1;
            // 
            // txtVP
            // 
            this.txtVP.Enabled = false;
            this.txtVP.Location = new System.Drawing.Point(458, 12);
            this.txtVP.Multiline = true;
            this.txtVP.Name = "txtVP";
            this.txtVP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVP.Size = new System.Drawing.Size(287, 118);
            this.txtVP.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateTimePicker1);
            this.groupControl1.Location = new System.Drawing.Point(18, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(162, 56);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Tìm theo khách hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.glueNV);
            this.groupControl2.Location = new System.Drawing.Point(18, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(162, 56);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Tìm theo Nhân viên";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.glueKH);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.dateTimePicker2);
            this.groupControl3.Location = new System.Drawing.Point(186, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(252, 118);
            this.groupControl3.TabIndex = 15;
            this.groupControl3.Text = "Tìm theo thời gian";
            // 
            // frm_ThongKeViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 596);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ThongKeViPham";
            this.Text = "Thống kê vi phạm";
            this.Load += new System.EventHandler(this.frm_ThongKeViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glueKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaXe;
        private DevExpress.XtraGrid.Columns.GridColumn BienXo_Xe;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhong;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GridLookUpEdit glueNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn MaNVV;
        private DevExpress.XtraGrid.Columns.GridColumn TenNVV;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraEditors.GridLookUpEdit glueKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MaKHH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKHH;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhongg;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn ViPham1;
        private System.Windows.Forms.TextBox txtVP;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}