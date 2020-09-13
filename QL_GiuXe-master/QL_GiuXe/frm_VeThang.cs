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
using System.IO.Ports;
using System.Threading;

namespace QL_GiuXe
{
    public partial class frm_VeThang : DevExpress.XtraEditors.XtraForm
    {
        string Nhan_MaRFID = "";
        string Nhan_MaXe = "";
        static string TenMayTinh = null;
        static string MaNhanVien = "NV002";
        string InputData = String.Empty;
        delegate void SetTextCallback(string text);
        string ma = null;
        RFID rfid;

        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();

        public frm_VeThang()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_VeThang_Load(object sender, EventArgs e)
        {


            Load_dgv();
            DateTime now = DateTime.Now;
            txt_NgayTao.Text = now.ToShortDateString();
            txt_NgayBD.Text = now.ToShortDateString();
            TenMayTinh = System.Environment.MachineName.ToString();
            txt_MayTinh.Text = TenMayTinh;
            txt_NhanVien.Text = MaNhanVien;

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            cob_com.DataSource = SerialPort.GetPortNames();

        }

        private void Load_dgv()
        {
            var load_dgv = from vt in ql.VeThangs
                           select new { vt.MaVeThang, vt.MaRFID, vt.MaXe, vt.NgayBD, vt.NgayKT, vt.NgayTaoVe, vt.NhanVien, vt.MayTinh };

            dgv_VeThang.DataSource = load_dgv;
        }

        private void txt_NgayBD_EditValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            txt_NgayKT.Text = now.AddDays(30).ToShortDateString();
        }

        private void txt_NgayBD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = txt_NgayBD.DateTime;
                txt_NgayKT.Text = dateTime.AddDays(30).ToShortDateString();
            }
            catch { }
        }

        private void txt_MaVeThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_ketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cob_com.Text;
                    serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.BaudRate);
                    try
                    {
                        serialPort1.Open();

                        if (btn_ketnoi.Text.Contains("KẾT NỐI VỚI ĐẦU ĐỌC"))
                            serialPort1.Write("R@");

                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort1.PortName, "Cổng " + serialPort1.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort1.PortName, "Cổng " + serialPort1.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            try
            {
                InputData = serialPort1.ReadTo("\r\n");
                if (InputData != String.Empty)
                {
                    SetText(InputData);
                }
            }
            catch { }
        }

        private void SetText(string text)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                ma = text;
                rfid = new RFID();
                rfid.XyLy_Data(ma);

                if (ma.Contains("#R#"))
                    btn_ketnoi.Text = "ĐÃ KẾT NỐI " + serialPort1.PortName;

                txt_MaRFID.Text = rfid.GetMa();
            }
        }

        private void txt_MaRFID_TextChanged(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string tt = time.ToString("-ddmmyyyy-hhmmss");
            txt_MaVeThang.Text = txt_MaRFID.Text.ToUpper() + tt;

            if(txt_MaRFID.Text.Trim() != string.Empty && txt_MaXe.Text.Trim() != string.Empty)
            {
                KT_The_Xe(txt_MaRFID.Text.Trim(), txt_MaXe.Text.Trim());
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (txt_MaRFID.Text == string.Empty)
            {
                XtraMessageBox.Show("Chưa chọn mã thẻ", "Chọn thẻ");
                return;
            }
            if (txt_MaXe.Text == string.Empty)
            {
                XtraMessageBox.Show("Chưa chọn xe", "Chọn xe");
                return;
            }

            DateTime NgayBD = DateTime.Parse(txt_NgayBD.Text.ToString());
            DateTime NgayKT = DateTime.Parse((txt_NgayKT.Text.ToString()));

            if (NgayBD > NgayKT)
            {
                XtraMessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Chọn ngày sai");
                return;
            }


            VeThang veThang = new VeThang();

            veThang.MaVeThang = txt_MaVeThang.Text;
            veThang.MaRFID = txt_MaRFID.Text;
            veThang.MaXe = txt_MaXe.Text;
            veThang.NgayBD = DateTime.Parse(txt_NgayBD.Text.ToString());
            veThang.NgayKT = DateTime.Parse((txt_NgayKT.Text.ToString()));
            veThang.NgayTaoVe = DateTime.Parse(txt_NgayTao.Text);
            veThang.NhanVien = txt_NhanVien.Text;
            veThang.MayTinh = txt_MayTinh.Text;

            int kq = Luu_VeThang(veThang);
            if (kq == 1)
            {
                progressBar1.Value = 50;
                progressBar1.Value = 100;
                progress = new Thread(progressBar_0);
                progress.Start();
                Load_dgv();
                XtraMessageBox.Show("Tạo mới vé tháng thành công", "Hoàn thành", MessageBoxButtons.OK);
            }
            else
            if(kq == 2)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu hoặc đã có vé này trong hệ thống", "Chưa lưu được", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu vui lòng kiểm tra lại mã thẻ và mã xe", "Chưa lưu được", MessageBoxButtons.OK);
            }

        }

        
        private void KT_The_Xe(string MaThe, string MaXe)
        {
           

            var kq = (from kt in ql.VeThangs
                     where (kt.MaRFID.ToUpper() == MaThe.ToUpper() || kt.MaXe.ToUpper() == MaXe.ToUpper())
                            && kt.NgayKT >= DateTime.Now
                     select new { kt.MaVeThang }).FirstOrDefault();

            if (kq != null)
                XtraMessageBox.Show("Thẻ đang được kích hoạt bởi xe khác hoặc xe này đã được kích hoạt bởi thẻ khác");
        }

        private int Luu_VeThang(VeThang veThang)
        {

            try
            {
                var ve = (from vt in ql.VeThangs
                          where vt.MaVeThang.ToUpper() == veThang.MaVeThang.ToUpper()
                          select vt).FirstOrDefault();

                if (ve != null)
                {
                    return 2;
                }
                else
                {
                    ql.VeThangs.InsertOnSubmit(veThang);
                    ql.SubmitChanges();
                    return 1;
                }
            }catch
            {
                return 3;
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string NgayTao = "", NgayBD = "", NgayKT = "";
            try
            {
                NgayTao = (DateTime.Parse(txt_NgayTao.Text)).ToShortDateString();
            }
            catch { }
            try
            {
                NgayBD = (DateTime.Parse(txt_NgayBD.Text)).ToShortDateString();
            }
            catch { }
            try
            {
                NgayKT = (DateTime.Parse(txt_NgayKT.Text)).ToShortDateString();
            }
            catch { }

            //MessageBox.Show(NgayBD);

            var tk = from vt in ql.VeThangs
                     where vt.MaXe.Contains(txt_MaXe.Text.Trim()) && vt.MaRFID.Contains(txt_MaRFID.Text.Trim())
                     //&& vt.MaVeThang.Contains(txt_MaVeThang.Text.Trim()) && vt.NgayBD.ToString().Contains(NgayBD) && vt.NgayKT.ToString().Contains(NgayKT)
                     //&& vt.NgayTaoVe.ToString().Contains(NgayTao) && vt.NhanVien.Contains(txt_NhanVien.Text.Trim()) && vt.MayTinh.Contains(txt_MayTinh.Text.Trim())
                     select vt;
            dgv_VeThang.DataSource = tk;
        }
        int rowindex = 0;
        private void btn_giahan_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_VeThang.Rows[rowindex];

                VeThang ve = (from vt in ql.VeThangs
                              where vt.MaVeThang.ToUpper() == row.Cells[0].Value.ToString().ToUpper()
                              select vt).FirstOrDefault();

                DateTime ngayKT_HT = DateTime.Parse(ve.NgayKT.ToString());

                //MessageBox.Show(ngayKT_HT.AddMonths(1).ToString());

                ve.NgayKT = ngayKT_HT.AddMonths(1);

                ql.SubmitChanges();

            }
            catch { }
            //DateTime now = DateTime.Now;
            //txt_NgayKT.Text = now.AddDays(30).ToShortDateString();
            //ve.NgayKT.


        }

        private void dgv_VeThang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Load_dgv();
        }

        private void btn_MaXe_Click(object sender, EventArgs e)
        {
            frm_DanhMuc_Xe frm = new frm_DanhMuc_Xe(1);
            frm.ShowDialog();
            Nhan_MaXe = frm.Truyen_MaXe;
            txt_MaXe.Text = Nhan_MaXe;
        }

        private void btn_MaRFID_Click(object sender, EventArgs e)
        {
            frm_QL_The frm = new frm_QL_The(1);
            frm.ShowDialog();
            Nhan_MaRFID = frm.Truyen_MaRFID;
            txt_MaRFID.Text = frm.Truyen_MaRFID;
        }

        private void cob_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                btn_ketnoi.Text = "KẾT NỐI VỚI ĐẦU ĐỌC";
            }
        }

        Thread progress = null;

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_VeThang.Rows[rowindex];

                VeThang ve = (from vt in ql.VeThangs
                              where vt.MaVeThang.ToUpper() == row.Cells["MaVeThang"].Value.ToString().ToUpper()
                              select vt).FirstOrDefault();
                if(XtraMessageBox.Show("Thao tác này sẽ không thể khôi phục lại dữ liệu", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    ql.VeThangs.DeleteOnSubmit(ve);
                    progressBar1.Value = 50;
                    ql.SubmitChanges();
                    dgv_VeThang.Rows.RemoveAt(rowindex);
                    progressBar1.Value = 100;
                    progress = new Thread(progressBar_0);
                    progress.Start();

                    

                } 
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Xảy ra lỗi trong thao tác này: " + ex, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void progressBar_0()
        {
            Thread.Sleep(700);
            if (progressBar1.InvokeRequired)
                progressBar1.Invoke(new Action(progressBar_0));
            progressBar1.Value = 0;
        } 
    }

}