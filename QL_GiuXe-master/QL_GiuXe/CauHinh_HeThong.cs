using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;
using static DevExpress.Utils.Diagnostics.GUIResources;

namespace QL_GiuXe
{
    public partial class CauHinh_HeThong : DevExpress.XtraEditors.XtraForm
    {
        int check = 0;
       
        bool frm_closing = false;

        public CauHinh_HeThong()
        {
            InitializeComponent();
        }

        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();
        private void Form1_Load(object sender, EventArgs e)
        {           
            Load_Hang_Camera();           
            Load_Cong_Com();

            Load_Giao_Thuc();

            check = 0;
        }


        private void btn_chon_Hinhanh_Click(object sender, EventArgs e)
        {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_hinhanh.Text = dialog.SelectedPath.ToString();
                    Properties.Settings.Default.HinhAnh = dialog.SelectedPath.ToString();
                    Properties.Settings.Default.Save();
                    string tenfile = System.IO.Path.GetFileName(dialog.SelectedPath.ToString());
                    ChiaSeThuMuc(txt_hinhanh.Text, tenfile, "Quản lý bãi xe thông minh LTH");
                }


        }

        private void btn_chon_Duphong_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txt_duphong.Text = dialog.SelectedPath.ToString();
               
            }

            


        }

        private void btn_LuuCauHinh_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Camera_IP_Trai_1 = txt_IP_trai_1.Text;
                Properties.Settings.Default.Camera_IP_Trai_Cong_1 = txt_cong_trai_1.Text;
                Properties.Settings.Default.Camera_IP_Trai_TaiKhoan_1 = txt_taikhoan_trai_1.Text;
                Properties.Settings.Default.Camera_IP_Trai_MatKhau_1 = txt_matkhau_trai_1.Text;
                Properties.Settings.Default.Camera_Hang_Trai_1 = cob_hangCR_trai_1.Text;
                string s1 = cob_hangCR_trai_1.SelectedValue.ToString();
                Properties.Settings.Default.Camera_Chuoi_Trai_1 = Rep_Chuoi_KetNoi(s1.Trim(), txt_taikhoan_trai_1.Text.Trim(), txt_matkhau_trai_1.Text.Trim(), txt_IP_trai_1.Text.Trim(), txt_cong_trai_1.Text.Trim());
            }
            catch { }

            try
            {
                Properties.Settings.Default.Camera_IP_Trai_2 = txt_IP_trai_2.Text;
                Properties.Settings.Default.Camera_IP_Trai_Cong_2 = txt_cong_trai_2.Text;
                Properties.Settings.Default.Camera_IP_Trai_TaiKhoan_2 = txt_taikhoan_trai_2.Text;
                Properties.Settings.Default.Camera_IP_Trai_MatKhau_2 = txt_matkhau_trai_2.Text;
                Properties.Settings.Default.Camera_Hang_Trai_2 = cob_hangCR_trai_2.Text;
                string s2 = cob_hangCR_trai_2.SelectedValue.ToString();
                Properties.Settings.Default.Camera_Chuoi_Trai_2 = Rep_Chuoi_KetNoi(s2.Trim(), txt_taikhoan_trai_2.Text.Trim(), txt_matkhau_trai_2.Text.Trim(), txt_IP_trai_2.Text.Trim(), txt_cong_trai_2.Text.Trim());
            }
            catch { }

            try
            {
                Properties.Settings.Default.Camera_IP_Phai_1 = txt_IP_phai_1.Text;
                Properties.Settings.Default.Camera_IP_Phai_Cong_1 = txt_cong_phai_1.Text;
                Properties.Settings.Default.Camera_IP_Phai_TaiKhoan_1 = txt_taikhoan_phai_1.Text;
                Properties.Settings.Default.Camera_IP_Phai_MatKhau_1 = txt_matkhau_phai_1.Text;
                Properties.Settings.Default.Camera_Hang_Phai_1 = cob_hangCR_phai_1.Text;
                string s3 = cob_hangCR_phai_1.SelectedValue.ToString();
                Properties.Settings.Default.Camera_Chuoi_Phai_1 = Rep_Chuoi_KetNoi(s3.Trim(), txt_taikhoan_phai_1.Text.Trim(), txt_matkhau_phai_1.Text.Trim(), txt_IP_phai_1.Text.Trim(), txt_cong_phai_1.Text.Trim());
            }
            catch { }

            try
            {
                Properties.Settings.Default.Camera_IP_Phai_2 = txt_IP_phai_2.Text;
                Properties.Settings.Default.Camera_IP_Phai_Cong_2 = txt_cong_phai_2.Text;
                Properties.Settings.Default.Camera_IP_Phai_TaiKhoan_2 = txt_taikhoan_phai_2.Text;
                Properties.Settings.Default.Camera_IP_Phai_MatKhau_2 = txt_matkhau_phai_2.Text;
                Properties.Settings.Default.Camera_Hang_Phai_2 = cob_hangCR_phai_2.Text;
                string s4 = cob_hangCR_phai_2.SelectedValue.ToString();
                Properties.Settings.Default.Camera_Chuoi_Phai_2 = Rep_Chuoi_KetNoi(s4.Trim(), txt_taikhoan_phai_2.Text.Trim(), txt_matkhau_phai_2.Text.Trim(), txt_IP_phai_2.Text.Trim(), txt_cong_phai_2.Text.Trim());
            }
            catch { }


            try
            {
                Properties.Settings.Default.DocThe_Trai = cob_dau_doc_trai.Text;
                Properties.Settings.Default.DocThe_Phai = cob_dau_doc_phai.Text;
            }
            catch
            {

            }
            try
            {
                Properties.Settings.Default.BaudRate = cob_BaudRate.Text;
                Properties.Settings.Default.Save();
            }
            catch { }
            check = 0;

            if(frm_closing == false)
                XtraMessageBox.Show("Lưu cấu hình thành công !","Lưu cấu hình",MessageBoxButtons.OK);

        }

        private void Load_Giao_Thuc()
        {
            try
            {
                txt_hinhanh.Text = Properties.Settings.Default.HinhAnh.ToString();
                txt_duphong.Text = Properties.Settings.Default.DuPhong.ToString();

                txt_IP_trai_1.Text = Properties.Settings.Default.Camera_IP_Trai_1.ToString();
                txt_cong_trai_1.Text = Properties.Settings.Default.Camera_IP_Trai_Cong_1.ToString();
                txt_taikhoan_trai_1.Text = Properties.Settings.Default.Camera_IP_Trai_TaiKhoan_1.ToString();
                txt_matkhau_trai_1.Text = Properties.Settings.Default.Camera_IP_Trai_MatKhau_1.ToString();
                cob_hangCR_trai_1.Text = Properties.Settings.Default.Camera_Hang_Trai_1;

                txt_IP_trai_2.Text = Properties.Settings.Default.Camera_IP_Trai_2.ToString();
                txt_cong_trai_2.Text = Properties.Settings.Default.Camera_IP_Trai_Cong_2.ToString();
                txt_taikhoan_trai_2.Text = Properties.Settings.Default.Camera_IP_Trai_TaiKhoan_2.ToString();
                txt_matkhau_trai_2.Text = Properties.Settings.Default.Camera_IP_Trai_MatKhau_2.ToString();
                cob_hangCR_trai_2.Text = Properties.Settings.Default.Camera_Hang_Trai_2;

                txt_IP_phai_1.Text = Properties.Settings.Default.Camera_IP_Phai_1.ToString();
                txt_cong_phai_1.Text = Properties.Settings.Default.Camera_IP_Phai_Cong_1.ToString();
                txt_taikhoan_phai_1.Text = Properties.Settings.Default.Camera_IP_Phai_TaiKhoan_1.ToString();
                txt_matkhau_phai_1.Text = Properties.Settings.Default.Camera_IP_Phai_MatKhau_1.ToString();
                cob_hangCR_phai_1.Text = Properties.Settings.Default.Camera_Hang_Phai_1;

                txt_IP_phai_2.Text = Properties.Settings.Default.Camera_IP_Phai_2.ToString();
                txt_cong_phai_2.Text = Properties.Settings.Default.Camera_IP_Phai_Cong_2.ToString();
                txt_taikhoan_phai_2.Text = Properties.Settings.Default.Camera_IP_Phai_TaiKhoan_2.ToString();
                txt_matkhau_phai_2.Text = Properties.Settings.Default.Camera_IP_Phai_MatKhau_2.ToString();
                cob_hangCR_phai_2.Text = Properties.Settings.Default.Camera_Hang_Phai_2;

                cob_dau_doc_trai.Text = Properties.Settings.Default.DocThe_Trai;
                cob_dau_doc_phai.Text = Properties.Settings.Default.DocThe_Phai;

                cob_BaudRate.Text = Properties.Settings.Default.BaudRate;
            }
            catch { }
        }

   
        private void Load_Hang_Camera()
        {
            try
            {
                cob_hangCR_trai_2.DataSource = from camera in ql.CauHinh_Cameras select camera;
                cob_hangCR_trai_2.DisplayMember = "Hang_Camera";
                cob_hangCR_trai_2.ValueMember = "ChuoiCauHinh";

                cob_hangCR_trai_1.DataSource = from camera in ql.CauHinh_Cameras select camera;
                cob_hangCR_trai_1.DisplayMember = "Hang_Camera";
                cob_hangCR_trai_1.ValueMember = "ChuoiCauHinh";


                cob_hangCR_phai_1.DataSource = from camera in ql.CauHinh_Cameras select camera;
                cob_hangCR_phai_1.DisplayMember = "Hang_Camera";
                cob_hangCR_phai_1.ValueMember = "ChuoiCauHinh";

                cob_hangCR_phai_2.DataSource = from camera in ql.CauHinh_Cameras select camera;
                cob_hangCR_phai_2.DisplayMember = "Hang_Camera";
                cob_hangCR_phai_2.ValueMember = "ChuoiCauHinh";
            }
            catch { }
        }

       

        private string Rep_Chuoi_KetNoi(string CauHinh,string taikhoan,string matkhau,string ip,string cong)
        {
            string Rep_tk = CauHinh.Replace("@TAIKHOAN", taikhoan.Trim());
            string Rep_mk = Rep_tk.Replace("@MATKHAU", matkhau.Trim());
            string Rep_ip = Rep_mk.Replace("@IP", ip.Trim());
            string Rep_cong = Rep_ip.Replace("@CONG", cong.Trim());
            return Rep_cong;
        }

        private void kiemtra_1_Click(object sender, EventArgs e)
        {
            string s = cob_hangCR_trai_1.SelectedValue.ToString();
            string ketnoi = Rep_Chuoi_KetNoi(s.Trim(), txt_taikhoan_trai_1.Text.Trim(), txt_matkhau_trai_1.Text.Trim(), txt_IP_trai_1.Text.Trim(), txt_cong_trai_1.Text.Trim());
            frm_kiemtra_CR kt = new frm_kiemtra_CR(ketnoi);
            kt.ShowDialog();
        }

        private void kiemtra_2_Click(object sender, EventArgs e)
        {
            string s = cob_hangCR_trai_2.SelectedValue.ToString();
            string ketnoi = Rep_Chuoi_KetNoi(s.Trim(), txt_taikhoan_trai_2.Text.Trim(), txt_matkhau_trai_2.Text.Trim(), txt_IP_trai_2.Text.Trim(), txt_cong_trai_2.Text.Trim());
            frm_kiemtra_CR kt = new frm_kiemtra_CR(ketnoi);
            kt.ShowDialog();
        }

        private void cob_hangCR_trai_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void kiemtra_3_Click(object sender, EventArgs e)
        {
            string s = cob_hangCR_phai_1.SelectedValue.ToString();
            string ketnoi = Rep_Chuoi_KetNoi(s.Trim(), txt_taikhoan_phai_1.Text.Trim(), txt_matkhau_phai_1.Text.Trim(), txt_IP_phai_1.Text.Trim(), txt_cong_phai_1.Text.Trim());
            frm_kiemtra_CR kt = new frm_kiemtra_CR(ketnoi);
            kt.ShowDialog();
        }

        private void kiemtra_4_Click(object sender, EventArgs e)
        {
            string s = cob_hangCR_phai_2.SelectedValue.ToString();
            string ketnoi = Rep_Chuoi_KetNoi(s.Trim(), txt_taikhoan_phai_2.Text.Trim(), txt_matkhau_phai_2.Text.Trim(), txt_IP_phai_2.Text.Trim(), txt_cong_phai_2.Text.Trim());
            frm_kiemtra_CR kt = new frm_kiemtra_CR(ketnoi);
            kt.ShowDialog();
        }

        private void CauHinh_HeThong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("czxc");
            }
        }


        //-------------------------------- COM -------------------------

        private void Load_Cong_Com()
        {
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cob_BaudRate.Items.AddRange(BaudRate);

            cob_dau_doc_trai.DataSource = SerialPort.GetPortNames();
            cob_dau_doc_phai.DataSource = SerialPort.GetPortNames();
        }

        private void btn_kiemtra_daudoc_trai_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cob_dau_doc_trai.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cob_BaudRate.Text);
                    try
                    {
                        serialPort1.Open();
                        XtraMessageBox.Show("Có kết nối", "Kết nối");
                        serialPort1.Close();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort1.PortName, "Cổng " + serialPort1.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort1.PortName, "Cổng " + serialPort1.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txt_IP_trai_1_TextChanged(object sender, EventArgs e)
        {
            check = 1;
        }

        private void CauHinh_HeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_kiemtra_daudoc_phai_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cob_dau_doc_phai.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cob_BaudRate.Text);
                    try
                    {
                        serialPort1.Open();
                        XtraMessageBox.Show("Có kết nối", "Kết nối");
                        serialPort1.Close();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort1.PortName, "Cổng " + serialPort1.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort1.PortName, "Cổng " + serialPort1.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frm_closing = true;
            if (check == 1)
            {
                if (XtraMessageBox.Show("Chưa thực hiện lưu dữ liệu. Bạn có muốn lưu dữ liệu?", "Chưa lưu dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btn_LuuCauHinh.PerformClick();
                }
            }
            this.Close();
        }

        public void ChiaSeThuMuc(string DuongDan, string TenChiaSe, string Mota)
        {
            try
            {
                ManagementClass managementClass = new ManagementClass("Win32_Share");
                ManagementBaseObject inParams = managementClass.GetMethodParameters("Create");
                ManagementBaseObject outParams;
                inParams["Description"] = Mota;
                inParams["Name"] = TenChiaSe;
                inParams["Path"] = DuongDan;
                inParams["Type"] = 0x0;
                outParams = managementClass.InvokeMethod("Create", inParams, null);
                if ((uint)(outParams.Properties["ReturnValue"].Value) != 0)
                    MessageBox.Show("Thư mục này đã được chia sẽ trước đó");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
