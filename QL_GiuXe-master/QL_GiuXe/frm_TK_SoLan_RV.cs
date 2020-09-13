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

namespace QL_GiuXe
{
    public partial class frm_TK_SoLan_RV : DevExpress.XtraEditors.XtraForm
    {
        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();
        public frm_TK_SoLan_RV()
        {
            InitializeComponent();
        }

        private void frm_TK_SoLan_RV_Load(object sender, EventArgs e)
        {
            Load_NhanVien();
        }

        private void Load_NhanVien()
        {
            var ds_nv = from nv in ql.NhanViens select new { nv.TenNV, nv.MaNV };
            cob_nv_vao.Items.Add(new { MaNV = "TatCa", TenNV = "Tất cả nhân viên" });
            foreach (var items in ds_nv)
            {
                cob_nv_vao.Items.Add(new { MaNV = items.MaNV, TenNV = items.TenNV });
            }
            cob_nv_vao.ValueMember = "MaNV";
            cob_nv_vao.DisplayMember = "TenNV";
            cob_nv_vao.SelectedIndex = 0;
        }
    }
}