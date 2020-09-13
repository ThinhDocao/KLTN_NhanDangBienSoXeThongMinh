namespace QL_GiuXe
{
    partial class frm_dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangnhap));
            this.dangNhap1 = new DangNhap.DangNhap();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // dangNhap1
            // 
            this.dangNhap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangNhap1.Location = new System.Drawing.Point(13, 13);
            this.dangNhap1.Margin = new System.Windows.Forms.Padding(4);
            this.dangNhap1.Name = "dangNhap1";
            this.dangNhap1.Size = new System.Drawing.Size(442, 179);
            this.dangNhap1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(426, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_thoat.Size = new System.Drawing.Size(38, 36);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 203);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dangNhap1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dangnhap";
            this.Load += new System.EventHandler(this.frm_dangnhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DangNhap.DangNhap dangNhap1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
    }
}