using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XuLy;

namespace QL_GiuXe
{
    public partial class frm_dangnhap : Form
    {
        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();

        XuLy_MayTinh mt = new XuLy_MayTinh();

        public frm_dangnhap()
        {
            InitializeComponent();

            dangNhap1.ChuoiKetNoi = Properties.Settings.Default.Connect;
            dangNhap1.frm_Main = new frm_Main();
            dangNhap1.frm_dangnhap = this;
            dangNhap1.frm_ketnoi = new frm_ketnoiSQL();
            this.AcceptButton = dangNhap1.btn_dangnhap;


            //string TenMay = mt.LayTen_MayTinh();
            //string Serial = mt.Lay_Serial();
            //string Ip = mt.Lay_Ip(TenMay);

            //try
            //{
            //    var kt = (from m in ql.MayTinhs
            //              where m.TenMay.Contains(TenMay) && m.Serial.Contains(Serial) && m.IP_May.Contains(Ip)
            //              select m).FirstOrDefault();

            //    if (kt == null)
            //    {
            //        XtraMessageBox.Show("Lỗi thực hiện kết nối vui lòng liên hệ nhà cung cấp", "Không tồn tại máy tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        dangNhap1.Enabled = false;
            //    }
            //}
            //catch { }

           
        }
        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
