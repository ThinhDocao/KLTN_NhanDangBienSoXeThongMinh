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
    public partial class frm_DanhMuc_MayTinh : DevExpress.XtraEditors.XtraForm
    {
        public frm_DanhMuc_MayTinh()
        {
            InitializeComponent();
        }

        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();
        XuLy_MayTinh mt = new XuLy_MayTinh();

        private void frm_DanhMuc_MayTinh_Load(object sender, EventArgs e)
        {
            txt_maMay.Text = mt.LayTen_MayTinh();
            txt_tenMay.Text = mt.LayTen_MayTinh();
            txt_Serial.Text = mt.Lay_Serial();
            txt_Ip.Text = mt.Lay_Ip(txt_tenMay.Text);
            Load_MatTinh();

            //if (dgv_ds.RowCount > 0)
            //{
            //    DataGridViewRow row = dgv_ds.Rows[0];
            //    txt_tenMay.Text = row.Cells[1].Value.ToString();
            //    txt_maMay.Text = row.Cells[0].Value.ToString();
            //    txt_Ip.Text = row.Cells[2].Value.ToString();
            //    txt_Serial.Text = row.Cells[3].Value.ToString();
            //    string kichhoat = row.Cells["TinhTrang"].Value.ToString();
            //    if (kichhoat == "True")
            //    {
            //        btn_huy.Text = "Hủy kích hoạt";
            //        chk_tinhtrang.Checked = true;
            //    }
            //    else
            //    {
            //        btn_huy.Text = "Kích hoạt";
            //        chk_tinhtrang.Checked = false;
            //    }
            //}

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            var Mt = (from m in ql.MayTinhs
                      where m.Ma_may == txt_maMay.Text.ToUpper()
                      select m).FirstOrDefault();
            if (Mt != null)
            {
                XtraMessageBox.Show("Đã có máy tính này trong hệ thống", "Đã có máy tính");
                return;
            }

            MayTinh mt = new MayTinh();
            mt.Ma_may = txt_tenMay.Text;
            mt.IP_May = txt_Ip.Text;
            mt.TenMay = txt_tenMay.Text;
            mt.Serial = txt_Serial.Text;
            if (chk_tinhtrang.Checked == true)
                mt.TinhTrang = true;
            else
                mt.TinhTrang = false;
            ql.MayTinhs.InsertOnSubmit(mt);
            ql.SubmitChanges();

            Load_MatTinh();
        }

        private void Load_MatTinh()
        {
            var Mt = from mt in ql.MayTinhs
                     select mt;
            dgv_ds.DataSource = Mt;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắt muốn xóa máy tính " + txt_maMay.Text, "Xóa máy tính", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var Mt = (from mt in ql.MayTinhs
                          where mt.Ma_may == txt_maMay.Text.ToUpper()
                          select mt).FirstOrDefault();
                if (Mt == null)
                {
                    XtraMessageBox.Show("Không có máy tính này trong hệ thống", "Không có máy tính");
                    return;
                }
                else
                {
                    ql.MayTinhs.DeleteOnSubmit(Mt);
                    ql.SubmitChanges();
                    Load_MatTinh();
                }
            }
        }

        private void dgv_ds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_ds.Rows[e.RowIndex];
                txt_tenMay.Text = row.Cells[1].Value.ToString();
                txt_maMay.Text = row.Cells[0].Value.ToString();
                txt_Ip.Text = row.Cells[2].Value.ToString();
                txt_Serial.Text = row.Cells[3].Value.ToString();
                string kichhoat = row.Cells["TinhTrang"].Value.ToString();
                if (kichhoat == "True")
                {
                    btn_huy.Text = "Hủy kích hoạt";
                    chk_tinhtrang.Checked = true;
                }
                else
                {
                    btn_huy.Text = "Kích hoạt";
                    chk_tinhtrang.Checked = false;
                }
            }
            catch { }
        } 

        private void btn_huy_Click(object sender, EventArgs e)
        {
            var huy = (from h in ql.MayTinhs
                       where h.Ma_may.ToUpper() == txt_maMay.Text.ToUpper()
                       select h).FirstOrDefault();
            if(huy != null)
            {
                if(huy.TinhTrang == true)
                {
                    huy.TinhTrang = false;
                }
                else
                    huy.TinhTrang = true;
            }
            ql.SubmitChanges();
            Load_MatTinh();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_maMay.Text = mt.LayTen_MayTinh();
            txt_tenMay.Text = mt.LayTen_MayTinh();
            txt_Serial.Text = mt.Lay_Serial();
            txt_Ip.Text = mt.Lay_Ip(txt_tenMay.Text);
            Load_MatTinh();
        }
    }
}