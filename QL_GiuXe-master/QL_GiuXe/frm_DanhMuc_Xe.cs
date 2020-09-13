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
using XuLy;

namespace QL_GiuXe
{
    public partial class frm_DanhMuc_Xe : DevExpress.XtraEditors.XtraForm
    {
        string Nhan_MaKH = "";
        public string Truyen_MaXe = "";
        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();
        byte[] Anh = null;
        XuLyAnh anh;
        public frm_DanhMuc_Xe()
        {
            InitializeComponent();
        }

        public frm_DanhMuc_Xe(int gt)
        {
            InitializeComponent();
            btn_chon.Visible = true;
            btn_khachHang.Visible = false;
            btn_them.Visible = false;
            btn_xoa.Visible = false;
            btn_sua.Visible = false;
            btn_luu.Visible = false;
            btn_sua_anh.Visible = false;
        }

        private void frm_DanhMuc_Xe_Load(object sender, EventArgs e)
        {
            anh = new XuLyAnh();
            Load_dgv();
        }

        private void Load_dgv()
        {
            var load = from kq in ql.Xes
                       select new { kq.MaXe, kq.HinhAnhXe, kq.BienXo_Xe, kq.MauSacXe, kq.MaKH };

            dgv_xe.DataSource = load;
        }

        private void btn_sua_anh_Click(object sender, EventArgs e)
        {
            try
            {
                string duongdan = anh.ChonAnh();
                Anh = anh.C_Anh_Byte(duongdan);
                pic_Xe.Image = anh.C_Byte_Anh(Convert.ToBase64String(Anh));
            }
            catch { }

        }

        private int Sua_Xe(Xe xe)
        {
            var kq = (from x in ql.Xes
                      where x.MaXe.ToUpper() == xe.MaXe.ToUpper()
                      select x).FirstOrDefault();

            if (kq == null)
            {
                return 2;
            }
            else
            {
                if(Anh != null)
                {
                    kq.HinhAnhXe = xe.HinhAnhXe;
                }
                kq.MaKH = xe.MaKH;
                kq.MauSacXe = xe.MauSacXe;
                ql.SubmitChanges();
                return 1;
            }
        }


        private int Luu_Xe(Xe xe)
        {
            var kq = (from x in ql.Xes
                      where x.MaXe.ToUpper() == xe.MaXe.ToUpper()
                      select x).FirstOrDefault();

            if(kq != null)
            {
                return 2;
            }
            else
            {
                ql.Xes.InsertOnSubmit(xe);
                ql.SubmitChanges();
                return 1;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Mo(true);
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
            dgv_xe.Enabled = false;
            Anh = null;
        }

        private void Mo(bool kq)
        {
            if (kq == true)
            {
                txt_BienSo.Enabled = true;
                txt_MauSac.Enabled = true;
                btn_sua_anh.Enabled = true;
                pic_Xe.Enabled = true;
                txt_BienSo.Text = string.Empty;
                txt_maXe.Text = string.Empty;
                txt_MauSac.Text = string.Empty;
                txt_KhachHang.Text = string.Empty;
                btn_khachHang.Enabled = true;
            }
            else
            {
                txt_BienSo.Enabled = false;
                txt_MauSac.Enabled = false;
                btn_sua_anh.Enabled = false;
                pic_Xe.Enabled = false;
                btn_khachHang.Enabled = false;
            }

        }


        private void dgv_xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {       
            DataGridViewRow row = dgv_xe.Rows[e.RowIndex];

            try
            {
                txt_BienSo.Text = row.Cells["BienXo_Xe"].Value.ToString();
                txt_maXe.Text = row.Cells["MaXe"].Value.ToString();                
                txt_KhachHang.Text = row.Cells["MaKH"].Value.ToString();
                txt_MauSac.Text = row.Cells["MauSacXe"].Value.ToString();
            }
            catch
            {

            }
            try
            {
                pic_Xe.Image = anh.C_Byte_Anh(row.Cells["HinhAnhXe"].Value.ToString().Replace("\"", ""));
            }
            catch { }
        }

        private void txt_BienSo_TextChanged(object sender, EventArgs e)
        {
            txt_maXe.Text = txt_BienSo.Text.Trim().ToUpper();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_BienSo.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Chưa nhập biển số xe", "Nhập biển số xe");
                txt_BienSo.Focus();
                return;
            }
            if (txt_KhachHang.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng chọn khách hàng", "Chưa chọn khách hàng");
                btn_khachHang.Focus();
                return;
            }
            Xe xe = new Xe();
            xe.MaXe = txt_maXe.Text;
            xe.BienXo_Xe = txt_BienSo.Text;
            xe.MaKH = txt_KhachHang.Text;
            xe.MauSacXe = txt_MauSac.Text;
            if (Anh != null)
            {
                xe.HinhAnhXe = Anh;
            }
            

            //if(btn)

            if (dgv_xe.Enabled == false)
            {
                int kq = Luu_Xe(xe);
                if (kq == 1)
                {
                    XtraMessageBox.Show("Thêm xe thành công", "Thành công");
                }
                else
                {
                    XtraMessageBox.Show("Đã tồn tại xe này trong hệ thống", "Tồn tại xe");
                }
            }
            else
            {
                int kq = Sua_Xe(xe);
                if (kq == 1)
                {
                    XtraMessageBox.Show("Cập nhật xe thành công", "Thành công");
                }
                else
                {
                    XtraMessageBox.Show("Không tồn tại xe này trong hệ thống", "Không tồn tại xe");
                }
            }
            Load_dgv();
            Mo(false);
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            dgv_xe.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Mo(true);
            txt_BienSo.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_luu.Enabled = true;
            Anh = null;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Mo(true);
            Mo(false);
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            dgv_xe.Enabled = true;
            Load_dgv();
            Anh = null;
        }

        private int Xoa_Xe(Xe xe)
        {
            var kq = (from x in ql.Xes
                      where x.MaXe.ToUpper() == xe.MaXe.ToUpper()
                      select x).FirstOrDefault();

            if (kq == null)
            {
                return 2;
            }
            else
            {
                ql.Xes.DeleteOnSubmit(kq);              
                ql.SubmitChanges();
                return 1;
            }
        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Xe xe = new Xe();
            xe.MaXe = txt_maXe.Text;
            xe.BienXo_Xe = txt_BienSo.Text;
            int kq = Xoa_Xe(xe);
            if(kq == 2)
            {
                XtraMessageBox.Show("Xe không tồn tại trong hệ thống", "Không tìm thấy xe");
            }
            else
            {
                Load_dgv();
                XtraMessageBox.Show("Xóa xe thành công", "Thành công");
            }
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            if (txt_maXe.Text == string.Empty)
                XtraMessageBox.Show("Vui lòng chọn xe", "Chưa chọn xe");
            else
                Truyen_MaXe = txt_maXe.Text;

            this.Close();
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm = new frm_KhachHang(1);
            frm.ShowDialog();
            Nhan_MaKH = frm.Truyen_MaKH;
            txt_KhachHang.Text = frm.Truyen_MaKH;
        }
    }
}