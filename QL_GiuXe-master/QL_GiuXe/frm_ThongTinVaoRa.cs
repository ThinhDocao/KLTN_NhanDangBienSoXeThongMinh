using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace QL_GiuXe
{
    public partial class frm_ThongTinVaoRa : DevExpress.XtraEditors.XtraForm
    {

        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();
        BindingSource list = new BindingSource();
        string FolderAnh;
        public frm_ThongTinVaoRa()
        {
            InitializeComponent();
            gridControl1.DataSource = list;
        }

        private void frm_ThongTinVaoRa_Load(object sender, EventArgs e)
        {
            cob_truyvan.SelectedIndex = 0;
            cboKhach.SelectedIndex = 0;
            //FolderAnh = Properties.Settings.Default.HinhAnh;           
            Load_NhanVien();
            txtMa.Visible = false;
            txtBS.Visible = false;
            txt_MaThe.Visible = false;
            txtHinhN.Visible = false;
            txt_MayTinh.Visible = false;
        }

        private void Load_NhanVien()
        {
            var ds_nv = from nv in ql.NhanViens select new { nv.TenNV, nv.MaNV };
            cob_nv_vao.Items.Add(new { MaNV = "TatCa", TenNV = "Tất cả nhân viên" });
            foreach ( var items in ds_nv )
            {
                cob_nv_vao.Items.Add(new { MaNV = items.MaNV, TenNV = items.TenNV });
            }
            cob_nv_vao.ValueMember = "MaNV";
            cob_nv_vao.DisplayMember = "TenNV";
            cob_nv_vao.SelectedIndex = 0;
        }


        private void Load_Xe_vao(DateTime ngayDB, DateTime ngayKT, string nhanvien_vao)
        {
            //var load = from l in ql.Xe_Vaos
            //           join nv in ql.NhanViens on l.MaNV_Vao equals nv.MaNV
            //           join tt in ql.TrangThais on l.TrangThai equals tt.TrangThai1
            //           where (l.TG_Vao >= ngayDB && l.TG_Vao <= ngayKT)
            //           && l.MaRFIF.Contains(txt_soThe.Text.Trim()) && l.BienSo_Vao.Contains(txt_bienso.Text.Trim())
            //           && nv.TenNV.Contains(nhanvien_vao)
            //           let MaRFIF = l.MaRFIF
            //           let HinhBX = l.HinhBX_Vao
            //           let HinhN = l.Hinh_N_Vao
            //           let BienSo = l.BienSo_Vao
            //           let TG = l.TG_Vao
            //           let Maytinh = l.MayTinh_Vao
            //           let TrangThai = tt.Ten
            //           let Ma = l.Ma_Vao
            //           let GhiChu = l.GhiChu
            //           select new { MaRFIF, HinhBX, HinhN, BienSo, TG, TrangThai, nv.TenNV, Maytinh, Ma , GhiChu};

            

            if(cboKhach.SelectedIndex==0)
            {
                var load = from l in ql.Xe_Vaos
                              join nv in ql.NhanViens on l.MaNV_Vao equals nv.MaNV
                              join tt in ql.TrangThais on l.TrangThai equals tt.TrangThai1
                              join Kh in ql.The_RFIDs on l.MaRFIF equals Kh.MaRFIF
                              where (l.TG_Vao >= ngayDB && l.TG_Vao <= ngayKT)
                              && l.MaRFIF.Contains(txt_soThe.Text.Trim()) && l.BienSo_Vao.Contains(txt_bienso.Text.Trim())
                              && nv.TenNV.Contains(nhanvien_vao)
                              let MaRFIF = l.MaRFIF
                              let HinhBX = l.HinhBX_Vao
                              let HinhN = l.Hinh_N_Vao
                              let BienSo = l.BienSo_Vao
                              let TG = l.TG_Vao
                              let Maytinh = l.MayTinh_Vao
                              let TrangThai = tt.Ten
                              let Ma = l.Ma_Vao
                              let GhiChu = l.GhiChu
                              let LoaiKhach = Kh.TheDangKi
                              select new { MaRFIF, HinhBX, HinhN, BienSo, TG, TrangThai, nv.TenNV, Maytinh, Ma, GhiChu,LoaiKhach };
                list.DataSource = load;
            }
            else
            {
                bool theDK = true;
                if (cboKhach.SelectedIndex == 1)
                    theDK = false;
                if (cboKhach.SelectedIndex == 2)
                    theDK = true;


                var load = from l in ql.Xe_Vaos
                           join nv in ql.NhanViens on l.MaNV_Vao equals nv.MaNV
                           join tt in ql.TrangThais on l.TrangThai equals tt.TrangThai1
                           join Kh in ql.The_RFIDs on l.MaRFIF equals Kh.MaRFIF
                           where (l.TG_Vao >= ngayDB && l.TG_Vao <= ngayKT)
                           && l.MaRFIF.Contains(txt_soThe.Text.Trim()) && l.BienSo_Vao.Contains(txt_bienso.Text.Trim())
                           && nv.TenNV.Contains(nhanvien_vao)
                           && Kh.TheDangKi == theDK
                           let MaRFIF = l.MaRFIF
                           let HinhBX = l.HinhBX_Vao
                           let HinhN = l.Hinh_N_Vao
                           let BienSo = l.BienSo_Vao
                           let TG = l.TG_Vao
                           let Maytinh = l.MayTinh_Vao
                           let TrangThai = tt.Ten
                           let Ma = l.Ma_Vao
                           let GhiChu = l.GhiChu
                           let LoaiKhach = Kh.TheDangKi
                           select new { MaRFIF, HinhBX, HinhN, BienSo, TG, TrangThai, nv.TenNV, Maytinh, Ma, GhiChu,LoaiKhach };
                list.DataSource = load;
            }


            //dgv_vao_ra.DataSource = load;
            

        }

        private void Load_Xe_ra(DateTime ngayDB, DateTime ngayKT, string nhanvien_vao)
        {
            var load = from l in ql.Xe_Ras
                       join nv in ql.NhanViens on l.MaNV_Ra equals nv.MaNV
                       join xv in ql.Xe_Vaos on l.Ma_Vao equals xv.Ma_Vao
                       where l.TG_Ra >= ngayDB && l.TG_Ra <= ngayKT
                       && xv.MaRFIF.Contains(txt_soThe.Text.Trim()) && l.BienSo_Ra.Contains(txt_bienso.Text.Trim())
                       && nv.TenNV.Contains(nhanvien_vao)
                       let MaRFIF = xv.MaRFIF
                       let HinhBX = l.HinhBX_Ra
                       let HinhN = l.Hinh_Ng_Ra
                       let BienSo = l.BienSo_Ra
                       let Maytinh = l.MayTinh_Ra
                       let TG = l.TG_Ra
                       let Ma = l.Ma_Vao
                       let GhiChu = l.GhiChu                     
                       select new { MaRFIF, HinhBX, HinhN, BienSo, TG, nv.TenNV, Maytinh, Ma , GhiChu};

            //dgv_vao_ra.DataSource = load;
            gridControl1.DataSource = load;
        }
        

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (cob_truyvan.SelectedIndex == 0)
            {
                try
                {
                    gridView1.Columns["TrangThai"].Visible = true;
                }
                catch { }
            }
            else
            {
                try
                {
                    gridView1.Columns["TrangThai"].Visible = false;
                }
                catch { }  
            }
            DateTime ngayKT,ngayDB;
            string nhanvien_vao;
            if (cob_nv_vao.SelectedIndex == 0)
            {
                nhanvien_vao = string.Empty;
            }
            else
            {
                nhanvien_vao = cob_nv_vao.Text;            
            }
            try
            {
                ngayKT = DateTime.Parse(txt_nagyKT.Text);
            }
            catch
            {
                ngayKT = DateTime.Now;
            }

            //try
            //{
            //    ngayDB = DateTime.Parse(txt_ngayBD.Text);
            //}
            //catch
            //{
            //    ngayDB = DateTime.Now.AddDays(-30);
            //}
            if(cob_truyvan.SelectedIndex == 0)
            {
                Load_Xe_vao(txt_ngayBD.Value, txt_nagyKT.Value, nhanvien_vao);
            }
            else
            {
                Load_Xe_ra(txt_ngayBD.Value, txt_nagyKT.Value, nhanvien_vao);   
            }



            txtBS.DataBindings.Clear();
            txtHinhN.DataBindings.Clear();
            txt_vi_pham.DataBindings.Clear();
            txtMa.DataBindings.Clear();
            txt_MaThe.DataBindings.Clear();
            txt_MayTinh.DataBindings.Clear();
            txtBS.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "HinhBX"));
            txtHinhN.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "HinhN"));
            txt_vi_pham.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "GhiChu"));
            txtMa.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "Ma"));
            txt_MaThe.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "MaRFIF"));
            txt_MayTinh.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "MayTinh"));



            int tongKHThang = 0;
            int tongKHVangLai = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                
                if (gridView1.GetRowCellDisplayText(i,"LoaiKhach") == "Checked")
                    tongKHThang++;
                else
                    tongKHVangLai++;
            }
            gridView1.Columns["LoaiKhach"].Summary.Clear();
            gridView1.Columns["Maytinh"].Summary.Clear();
            gridView1.Columns["LoaiKhach"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "XeVao", "Tổng Khách tháng = "+tongKHThang);
            gridView1.Columns["Maytinh"].Summary.Add(DevExpress.Data.SummaryItemType.Custom, "XeVao", "Tổng Khách Vãng lai = "+tongKHVangLai);


        }
        int vtri = 0;

        //private void dgv_vao_ra_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        vtri = e.RowIndex;
        //        DataGridViewRow row = dgv_vao_ra.Rows[e.RowIndex];
        //        try
        //        {
        //            string AnhXe = row.Cells["HinhBX"].Value.ToString();
        //            string DuongDan = @"\\" + row.Cells["Maytinh"].Value.ToString() + @"\" + row.Cells["Maytinh"].Value.ToString();
        //            pictureBox1.Image = Image.FromFile(DuongDan + "\\" + AnhXe);
        //        }
        //        catch { }
        //        try
        //        {
        //            string AnhNguoi = row.Cells["HinhN"].Value.ToString();
        //            string DuongDan = @"\\" + row.Cells["Maytinh"].Value.ToString() + @"\" + row.Cells["Maytinh"].Value.ToString();
        //            pictureBox2.Image = Image.FromFile(DuongDan + "\\" + AnhNguoi);
        //        }
        //        catch { }

        //        try
        //        {
        //            txt_vi_pham.Text = row.Cells["GhiChu"].Value.ToString();
        //        }
        //        catch { txt_vi_pham.Text = ""; }
        //    }
        //    catch { }
        //}

        private void cob_truyvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_QL_The the = new frm_QL_The();
            the.ShowDialog();
        }

        private void ck_vipham_CheckedChanged(object sender, EventArgs e)
        {
            if(ck_vipham.Checked == true)
            {
                txt_vi_pham.Enabled = true;
            }
            else
            {
                txt_vi_pham.Enabled = false;
            }
        }
        string MaCapNhat = "";
        private void txt_capnhat_Click(object sender, EventArgs e)
        {
            ////DataGridViewRow row = dgv_vao_ra.Rows[vtri];
            //DataGridViewRow row = dgv_vao_ra.Rows[vtri];
            //MaCapNhat = row.Cells["Ma"].Value.ToString();
            ////MessageBox.Show(MaCapNhat);
            ///

            

            if (txtMa.Text == "")
                return;
            
            if (cob_truyvan.SelectedIndex == 0)
            {
                var vipham = (from vp in ql.Xe_Vaos
                              where vp.Ma_Vao == txtMa.Text
                              select vp).FirstOrDefault();

                if (vipham != null)
                {
                    vipham.GhiChu = txt_vi_pham.Text;
                    ql.SubmitChanges();
                }
            }
            if (cob_truyvan.SelectedIndex == 1)
            {
                var vipham = (from vp in ql.Xe_Ras
                              where vp.Ma_Vao == txtMa.Text
                              select vp).FirstOrDefault();

                if (vipham != null)
                {
                    vipham.GhiChu = txt_vi_pham.Text;
                    ql.SubmitChanges();
                }
            }
            Luu_ViPham(txt_MaThe.Text,txt_vi_pham.Text);
            ck_vipham.Checked = false;
        }

        private void Luu_ViPham(string MaRFID,string ChuoiVP)
        {

            var xe = (from vt in ql.VeThangs
                      where vt.MaRFID.ToUpper() == MaRFID.ToUpper()
                      orderby vt.NgayKT descending
                      select new { vt.MaXe }).FirstOrDefault();
            if (xe == null)
                return;

            DateTime dateTime = DateTime.Now;
            string thang = dateTime.Month.ToString();
            string nam = dateTime.Year.ToString();

            string ThoiGian = thang + @"/" + nam;

            ViPham vipham = (from vp in ql.ViPhams
                             where vp.MaXe.ToUpper() == xe.MaXe && vp.ThoiGian.Contains(ThoiGian)
                             select vp).FirstOrDefault();
            if (vipham != null)
            {
                //update
                string vp_dau = vipham.ViPham1 + ", " + ChuoiVP;
                vipham.ViPham1 = vp_dau;
                ql.SubmitChanges();
            }
            else
            {
                //insert
                vipham = new ViPham();
                vipham.MaXe = xe.MaXe;
                vipham.ViPham1 = ChuoiVP;
                vipham.ThoiGian = ThoiGian;
                ql.ViPhams.InsertOnSubmit(vipham);
                ql.SubmitChanges();
            }
        }
        private void txtHinhN_TextChanged(object sender, EventArgs e)
        {             
                try
                {
                    string AnhNguoi = txtHinhN.Text;
                    string DuongDan = @"\\" + txt_MayTinh.Text + @"\" + txt_MayTinh.Text;
                    pictureBox2.Image = Image.FromFile(DuongDan + "\\" + AnhNguoi);
                }
                catch { }
        }

        private void txtBS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string BienSo = txtBS.Text;
                string DuongDan = @"\\" + txt_MayTinh.Text + @"\" + txt_MayTinh.Text;
                pictureBox1.Image = Image.FromFile(DuongDan + "\\" + BienSo);
            }
            catch { }
        }

        private void btn_xuatExcel_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount < 1)
                return;
            string filePath;
            var saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FileName = "NhanVien.xlsx";
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveDialog.ShowDialog();
            filePath = saveDialog.FileName;

            if (filePath != "")
            {
                gridControl1.ExportToXlsx(filePath);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount < 1)
                return;
            gridControl1.ShowPrintPreview();
        }
    }
}