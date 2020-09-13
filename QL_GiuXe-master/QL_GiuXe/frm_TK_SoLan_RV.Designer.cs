namespace QL_GiuXe
{
    partial class frm_TK_SoLan_RV
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ngayBD = new DevExpress.XtraEditors.DateEdit();
            this.txt_nagyKT = new DevExpress.XtraEditors.DateEdit();
            this.btn_thongke = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.cob_nv_vao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nagyKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nagyKT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Từ ngày:";
            // 
            // txt_ngayBD
            // 
            this.txt_ngayBD.EditValue = null;
            this.txt_ngayBD.Location = new System.Drawing.Point(110, 19);
            this.txt_ngayBD.Name = "txt_ngayBD";
            this.txt_ngayBD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngayBD.Properties.Appearance.Options.UseFont = true;
            this.txt_ngayBD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_ngayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_ngayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_ngayBD.Properties.DisplayFormat.FormatString = "";
            this.txt_ngayBD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_ngayBD.Properties.EditFormat.FormatString = "";
            this.txt_ngayBD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_ngayBD.Properties.Mask.EditMask = "";
            this.txt_ngayBD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_ngayBD.Size = new System.Drawing.Size(163, 24);
            this.txt_ngayBD.TabIndex = 15;
            // 
            // txt_nagyKT
            // 
            this.txt_nagyKT.EditValue = null;
            this.txt_nagyKT.Location = new System.Drawing.Point(341, 19);
            this.txt_nagyKT.Name = "txt_nagyKT";
            this.txt_nagyKT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nagyKT.Properties.Appearance.Options.UseFont = true;
            this.txt_nagyKT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_nagyKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_nagyKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_nagyKT.Properties.DisplayFormat.FormatString = "";
            this.txt_nagyKT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_nagyKT.Properties.EditFormat.FormatString = "";
            this.txt_nagyKT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_nagyKT.Properties.Mask.EditMask = "";
            this.txt_nagyKT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_nagyKT.Size = new System.Drawing.Size(163, 24);
            this.txt_nagyKT.TabIndex = 16;
            // 
            // btn_thongke
            // 
            this.btn_thongke.Location = new System.Drawing.Point(341, 52);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(75, 23);
            this.btn_thongke.TabIndex = 17;
            this.btn_thongke.Text = "Thống kê";
            // 
            // btn_xuatExcel
            // 
            this.btn_xuatExcel.Location = new System.Drawing.Point(429, 52);
            this.btn_xuatExcel.Name = "btn_xuatExcel";
            this.btn_xuatExcel.Size = new System.Drawing.Size(75, 23);
            this.btn_xuatExcel.TabIndex = 18;
            this.btn_xuatExcel.Text = "Xuất Excel";
            // 
            // cob_nv_vao
            // 
            this.cob_nv_vao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_nv_vao.FormattingEnabled = true;
            this.cob_nv_vao.Location = new System.Drawing.Point(110, 49);
            this.cob_nv_vao.Name = "cob_nv_vao";
            this.cob_nv_vao.Size = new System.Drawing.Size(163, 21);
            this.cob_nv_vao.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhân viên:";
            // 
            // frm_TK_SoLan_RV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 380);
            this.Controls.Add(this.cob_nv_vao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_xuatExcel);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ngayBD);
            this.Controls.Add(this.txt_nagyKT);
            this.Name = "frm_TK_SoLan_RV";
            this.Text = "frm_TK_SoLan_RV";
            this.Load += new System.EventHandler(this.frm_TK_SoLan_RV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nagyKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nagyKT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit txt_ngayBD;
        private DevExpress.XtraEditors.DateEdit txt_nagyKT;
        private DevExpress.XtraEditors.SimpleButton btn_thongke;
        private DevExpress.XtraEditors.SimpleButton btn_xuatExcel;
        private System.Windows.Forms.ComboBox cob_nv_vao;
        private System.Windows.Forms.Label label6;
    }
}