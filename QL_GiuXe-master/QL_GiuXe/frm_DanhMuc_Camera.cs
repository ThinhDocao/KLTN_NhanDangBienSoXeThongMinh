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
    public partial class frm_DanhMuc_Camera : DevExpress.XtraEditors.XtraForm
    {
        public frm_DanhMuc_Camera()
        {
            InitializeComponent();
        }


        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();
        public void DanhMuc_Camera()
        {           
            var load = from l in ql.CauHinh_Cameras
                       select l;

            dataGridView1.DataSource = load;
            
            if(dataGridView1.RowCount > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[0];
                txt_hang.Text = row.Cells[0].Value.ToString();
                txt_chuoi.Text = row.Cells[1].Value.ToString();
            }

        }

        private void frm_DanhMuc_Camera_Load(object sender, EventArgs e)
        {
            DanhMuc_Camera();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_hang.Text = row.Cells[0].Value.ToString();
            txt_chuoi.Text = row.Cells[1].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_chuoi.Enabled = true;
            txt_hang.Enabled = true;

            txt_chuoi.Text = string.Empty;
            txt_hang.Text = string.Empty;          
        }

        private void btn_luuthem_Click(object sender, EventArgs e)
        {
            CauHinh_Camera ch = new CauHinh_Camera();
            ch.Hang_Camera = txt_hang.Text;
            ch.ChuoiCauHinh = txt_chuoi.Text;

            int kq = Them_Hang_Camera(ch);
            
            if(kq == 1)
            {
                XtraMessageBox.Show("Thành công", "Thêm dữ liệu");
            }
            else
                if (kq == 2)
            {
                XtraMessageBox.Show("Thất bại đã tại mã này trong hệ thống", "Thêm dữ liệu");
            }
            else
            {
                XtraMessageBox.Show("Thất bại", "Thêm dữ liệu");
            }
            DanhMuc_Camera();
            txt_chuoi.Text = string.Empty;
            txt_hang.Text = string.Empty;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("Bạn có muốn sửa chuỗi kết nối camera này", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                CauHinh_Camera ch = new CauHinh_Camera();
                ch.Hang_Camera = txt_hang.Text;

                int kq = Sua_Hang_Camera(ch, txt_chuoi.Text);

                if (kq == 1)
                {
                    XtraMessageBox.Show("Thành công", "Sửa dữ liệu");
                }
                else
                   if (kq == 2)
                {
                    XtraMessageBox.Show("Thất bại không tồn tại mã này trong hệ thống", "Sửa dữ liệu");
                }
                else
                {
                    XtraMessageBox.Show("Thất bại xảy ra lỗi trong quá trình xử lý", "Sửa dữ liệu");
                }

                DanhMuc_Camera();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if(XtraMessageBox.Show("Bạn có muốn xóa chuỗi kết nối camera này","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CauHinh_Camera ch = new CauHinh_Camera();
                ch.Hang_Camera = txt_hang.Text;

                int kq = Xoa_Hang_Camera(ch);

                if (kq == 1)
                {
                    XtraMessageBox.Show("Thành công", "Xóa dữ liệu");
                }
                else
                    if (kq == 2)
                {
                    XtraMessageBox.Show("Thất bại không tồn tại mã này trong hệ thống", "Xóa dữ liệu");
                }
                else
                {
                    XtraMessageBox.Show("Thất bại xảy ra lỗi trong quá trình xử lý", "Xóa dữ liệu");
                }

                DanhMuc_Camera();
            }
        }


        public int Them_Hang_Camera(CauHinh_Camera cauhinh)
        {
            var kt = (from t in ql.CauHinh_Cameras
                      where t.Hang_Camera.ToUpper() == cauhinh.Hang_Camera.ToUpper()
                      select t).FirstOrDefault();

            if (kt != null)
                return 2;
            else
            {
                ql.CauHinh_Cameras.InsertOnSubmit(cauhinh);
                ql.SubmitChanges();
            }
            return 1;
        }

        public int Xoa_Hang_Camera(CauHinh_Camera cauhinh)
        {
            var kt = (from t in ql.CauHinh_Cameras
                      where t.Hang_Camera.ToUpper() == cauhinh.Hang_Camera.ToUpper()
                      select t).FirstOrDefault();

            if (kt == null)
                return 2;
            else
            {
                ql.CauHinh_Cameras.DeleteOnSubmit(kt);
                ql.SubmitChanges();
            }
            return 1;
        }


        public int Sua_Hang_Camera(CauHinh_Camera cauhinh,string Chuoi)
        {
            var kt = (from t in ql.CauHinh_Cameras
                      where t.Hang_Camera.ToUpper() == cauhinh.Hang_Camera.ToUpper()
                      select t).FirstOrDefault();
            if (kt == null)
                return 2;
            else
            {
                kt.ChuoiCauHinh = Chuoi;
                ql.SubmitChanges();
            }
            return 1;

        }

        private void btn_luuthoat_Click(object sender, EventArgs e)
        {
            CauHinh_Camera ch = new CauHinh_Camera();
            ch.Hang_Camera = txt_hang.Text;
            ch.ChuoiCauHinh = txt_chuoi.Text;

            int kq = Them_Hang_Camera(ch);

            if (kq == 1)
            {
                XtraMessageBox.Show("Thành công", "Thêm dữ liệu");
            }
            else
                if (kq == 2)
            {
                XtraMessageBox.Show("Thất bại đã tại mã này trong hệ thống", "Thêm dữ liệu");
            }
            else
            {
                XtraMessageBox.Show("Thất bại", "Thêm dữ liệu");
            }

            this.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}