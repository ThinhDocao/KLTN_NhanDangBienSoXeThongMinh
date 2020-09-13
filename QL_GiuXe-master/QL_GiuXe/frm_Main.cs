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
using System.Threading;
using Accord.Video.FFMPEG;
using System.IO.Ports;
using DevExpress.XtraWaitForm;
using ClassLibrary;
using System.Diagnostics;
using System.Globalization;
using SaoLuu_HT;

namespace QL_GiuXe
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        static string Full = "";
        static string Diff = "";
        static string Log = "";
        static string GiaVe1 = "5.000 đ";
        static string GiaVe2 = "10.000 đ";

        string InputData = String.Empty;
        delegate void SetTextCallback(string text);

        static string Ma_NhanVien = "NV002";
        static string Ma_MayTinh = "ADMIN";
        static string ten_CapMa = "CMM";
        string ma = null;
        static string DuoiAnh = ".jpg";
        string taoma = null;

        string string_RFID = null;
        string string_Data_RFID = null;
        string Tao_Ma_anh = null;

        string string_RFID_Ra = null;
        string string_Data_RFID_Ra = null;
        string Tao_Ma_anh_Ra = null;

        string FolderAnh = "";

        int Timer_HinhAnh_T = 0, Timer_HinhAnh_P = 0;

        XyLy xyLy = new XyLy();

        int VR_seri_1 = 0; // 0 : Vào 
        int VR_seri_2 = 1; // 1 : Ra

        RFID rfid = new RFID();

        Thread IP1 = null;
        Thread IP2 = null;
        Thread IP3 = null;
        Thread IP4 = null;
        Thread DocBienSo_T = null;
        Thread DocBienSo_P = null;
        Thread NgatLuong_BS_T = null;
        Thread NgatLuong_BS_P = null;


        string BienSo_T = "";
        string BienSo_P = "";


        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();
        QL_BaiXeDataContext ql1 = new QL_BaiXeDataContext();

        private VideoFileReader ip1 = new VideoFileReader();
        private VideoFileReader ip2 = new VideoFileReader();
        private VideoFileReader ip3 = new VideoFileReader();
        private VideoFileReader ip4 = new VideoFileReader();
        int check = 0;

        public frm_Main()
        {
            InitializeComponent();
            this.Enabled = false;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

            Ma_NhanVien = DangNhap.DangNhap.TenTK;
            MessageBox.Show(Ma_NhanVien);
            xyLy.Load_Cascade();
            Load_camera();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            serialPort2.DataReceived += new SerialDataReceivedEventHandler(DataReceive2);
            KetNoi_RFID();
            Load_Lan(0, 'C');

            try
            {

                if (serialPort1.IsOpen)
                    serialPort1.WriteLine("V@");
                else
                {
                    lb_lan_1.Text = "Mất kết nối " + serialPort1.PortName;                  
                }

            }
            catch { }



            for (int i = 0; i <= 3; i++)
            {
                if (serialPort2.IsOpen)
                    serialPort2.WriteLine("R@");
                else
                {
                    lb_lan_2.Text = "Mất kết nối " + serialPort2.PortName;
                    break;
                }
                Thread.Sleep(500);
            }
            KT_FolderAnh();
            for (int i = 0; i <= 5; i++)
            {
                Thread.Sleep(500);
            }
            this.Enabled = true;
            Load_BackUp();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void Load_BackUp()
        {
            try
            {
                Full = Properties.Settings.Default.Full;
                Diff = Properties.Settings.Default.Diff;
                Log = Properties.Settings.Default.Log;
            }
            catch { }
        }

        private void KT_FolderAnh()
        {
            bool save = false;

            while (save == false)
            {
                save = Save_FolderAnh();
                if (save == false)
                {
                    if (XtraMessageBox.Show("Vui lòng chọn nơi lưu trữ hình ảnh", "Chưa cấu hình lưu ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        this.Enabled = false;
                        CauHinh_HeThong ch = new CauHinh_HeThong();
                        ch.ShowDialog();
                    }
                }
                else
                {
                    this.Enabled = true;
                    return;
                }
            }
        }


        private bool Save_FolderAnh()
        {
            try
            {
                FolderAnh = Properties.Settings.Default.HinhAnh;
                if (FolderAnh == null)
                    return false;

                saveFileDialog1.FileName = FolderAnh + "\\logo.jpg";
                Camera_trai_1.Image.Save(saveFileDialog1.FileName);
                return true;

            }
            catch { return false; }
        }

        private void Load_camera()
        {
            {

                IP1 = new Thread(load_IP1);
                IP1.Start();

                IP2 = new Thread(load_IP2);
                IP2.Start();

                IP3 = new Thread(load_IP3);
                IP3.Start();

                IP4 = new Thread(load_IP4);
                IP4.Start();

            }           
        }
        private void load_IP1()
        {
            string KetNoi_CR_Trai_1 = Properties.Settings.Default.Camera_Chuoi_Trai_1;
            try
            {
                ip1.Open(KetNoi_CR_Trai_1);
            }
            catch { }
            while (ip1.IsOpen)
            {
                try
                {
                    Bitmap frame1 = NewMethod2();
                    Camera_trai_1.Image = frame1;
                }
                catch { }
            }
        }

        private Bitmap NewMethod2()
        {
            try
            {
                return ip1.ReadVideoFrame();
            }
            catch
            {
                return null;
            }
        }

        private void load_IP2()
        {

            string KetNoi_CR_Trai_2 = Properties.Settings.Default.Camera_Chuoi_Trai_2;
            try
            {
                ip2.Open(KetNoi_CR_Trai_2);
            }
            catch { }

            while (ip2.IsOpen)
            {
                try
                {
                    Bitmap frame2 = NewMethod1();
                    Camera_trai_2.Image = frame2;
                }
                catch { }
            }
        }

        private Bitmap NewMethod1()
        {
            try
            {
                return ip2.ReadVideoFrame();
            }
            catch
            {
                return null;
            }
        }

        private void load_IP3()
        {

            string KetNoi_CR_Phai_1 = Properties.Settings.Default.Camera_Chuoi_Phai_1;
            try
            {
                ip3.Open(KetNoi_CR_Phai_1);
            }
            catch { }

            while (ip3.IsOpen)
            {
                try
                {
                    Bitmap frame3 = NewMethod();
                    Camera_phai_1.Image = frame3;
                }
                catch { }
        }
        }

        private Bitmap NewMethod()
        {
            try
            {
                return ip3.ReadVideoFrame();
            }
            catch
            {
                return null;
            }
        }

        private void load_IP4()
        {
            string KetNoi_CR_Phai_2 = Properties.Settings.Default.Camera_Chuoi_Phai_2;
            try
            {
                ip4.Open(KetNoi_CR_Phai_2);
            }
            catch { }
            while (ip4.IsOpen)
            {
                try
                {
                    Bitmap frame4 = GetFrame4();
                    Camera_phai_2.Image = frame4;
                }
                catch { }
            }
        }

        private Bitmap GetFrame4()
        {
            try
            {
                return ip4.ReadVideoFrame();
            }
            catch
            {
                return null;
            }
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check == 0)
            {
                if (XtraMessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //try
                    //{
                        //ip1.Close();
                        //ip2.Close();
                        //ip3.Close();
                        //ip4.Close();
                        IP1.Abort();
                        IP2.Abort();
                        IP3.Abort();
                        IP4.Abort();
                    System.Environment.Exit(0);
                    //}
                    //catch { }
                    //Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void frm_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_thoat.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                btn_lammoi.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btn_capnhat.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                btn_danhmuc_camera.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                btn_ql_the.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                btn_F5.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                btn_F6.PerformClick();
            }
            if (e.KeyCode == Keys.F7)
            {
                btn_an.PerformClick();
            }
            if(e.KeyCode == Keys.F11)
            {
                if (lb_lan_1.Text.Contains("Xe vào"))
                {
                    serialPort1.WriteLine("R@");
                    //string_RFID_Ra = null;
                    //string_Data_RFID_Ra = null;
                    //Tao_Ma_anh_Ra = null;
                }
                if (lb_lan_1.Text.Contains("Xe ra"))
                {
                    serialPort1.WriteLine("V@");
                }
            }
            if (e.KeyCode == Keys.F12)
            {
                if (lb_lan_2.Text.Contains("Xe vào"))
                    serialPort2.WriteLine("R@");
                if (lb_lan_2.Text.Contains("Xe ra"))
                    serialPort2.WriteLine("V@");
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            IP1.Abort();
            IP2.Abort();
            IP3.Abort();
            IP4.Abort();
            try
            {
                check = 1;
                Application.Restart();
            }
            catch { }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
            }

            CauHinh_HeThong ch = new CauHinh_HeThong();
            ch.ShowDialog();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    IP1.Abort();
                    IP2.Abort();
                    IP3.Abort();
                    IP4.Abort();
                    System.Environment.Exit(0);
                }
                catch { }
            }
        }

        private void btn_danhmuc_camera_Click(object sender, EventArgs e)
        {
            frm_DanhMuc_Camera cr = new frm_DanhMuc_Camera();
            cr.ShowDialog();
        }

        //------------------  RFID -------------------------

        private void KetNoi_RFID()
        {
            if (!serialPort1.IsOpen)
            {               
                try
                {
                    serialPort1.PortName = Properties.Settings.Default.DocThe_Trai;
                    serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.BaudRate);
                    serialPort1.Open();

                }
                catch
                {
                    XtraMessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort1.PortName, "Cổng " + serialPort1.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!serialPort2.IsOpen)
            {                
                try
                {
                    serialPort2.PortName = Properties.Settings.Default.DocThe_Phai;
                    serialPort2.BaudRate = Convert.ToInt32(Properties.Settings.Default.BaudRate);
                    serialPort2.Open();
                }
                catch
                {
                    XtraMessageBox.Show("Vui lòng kiểm tra lại cổng " + serialPort2.PortName, "Cổng " + serialPort2.PortName + " không khả dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

        private void DataReceive2(object obj, SerialDataReceivedEventArgs e)
        {
            try
            {
                InputData = serialPort2.ReadTo("\r\n");
                if (InputData != String.Empty)
                {
                    SetText2(InputData);
                }
            }
            catch { }
        }

        private void DC_Label()
        {
            lb_1.Text = string.Empty;
            lb_2.Text = string.Empty;
            lb_3.Text = string.Empty;
            lb_4.Text = string.Empty;
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

                // Xe vào
                ma = text;

                //MessageBox.Show(ma);
                if (VR_seri_1 == 0)
                {
                    //XuLy_XeVao(ma, 1);
                    Thread thread = new Thread(() => XuLy_XeVao(ma, 1));
                    thread.Start();
                }
                else
                {
                    //XuLy_XeRa(ma, 1);
                    Thread thread = new Thread(() => XuLy_XeRa(ma, 1));
                    thread.Start();
                }

            }
        }


        private void SetText2(string text)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText2); 
                this.Invoke(d, new object[] { text });
            }
            else
            {              
                // Xe ra
                ma = text;

                if (VR_seri_2 == 1)
                {
                    //XuLy_XeRa(ma, 2);
                    Thread thread2 = new Thread(() => XuLy_XeRa(ma, 2));
                    thread2.Start();
                }
                else
                {
                    //XuLy_XeVao(ma, 2);
                    Thread thread2 = new Thread(() => XuLy_XeVao(ma, 2));
                    thread2.Start();
                }
            }
        }

        private void XuLy_XeRa(string ma,int serial)
        {
            rfid.XyLy_Data(ma);

            if (ma.Contains("$"))
            {
                if (TinhTrangThe(rfid.GetMa()) == true)
                {
                    List<object> tt = Get_TT_KhachHang(rfid.GetMa());

                    if (string_RFID_Ra == rfid.GetMa())
                    {

                        Xe_Vao xevao = (from x in ql.Xe_Vaos
                                        where x.MaRFIF.ToUpper() == string_RFID_Ra.ToUpper() && x.MaGui.ToUpper() == string_Data_RFID_Ra.ToUpper()
                                        select x).FirstOrDefault();

                        Xe_Ra xera = (from xr in ql.Xe_Ras
                                      where xr.Ma_Ra.ToUpper() == xevao.Ma_Vao.ToUpper()
                                      select xr).FirstOrDefault();


                        Chup_Anh(xera.HinhBX_Ra.Replace(".jpg", ""), DuoiAnh, serial);
                        //lb_3.Text = tt[0].ToString() + "-" + tt[1].ToString();
                        //lb_4.Text = tt[3].ToString();

                        xera.TG_Ra = DateTime.Now;
                        ql.SubmitChanges();

                        Timer_HinhAnh_P = 0;
                        timer_HinhAnh_P.Enabled = true;
                        Timer_HinhAnh_T = 0;
                        timer_HinhAnh_T.Enabled = true;

                        try
                        {
                            if (serial == 1)
                            {
                                lb_1.Text = tt[0].ToString() + "-" + tt[1].ToString();
                                lb_2.Text = tt[3].ToString();
                                txt_TenKH_T.Text = tt[0].ToString();
                                txt_Phong_T.Text = tt[1].ToString();

                                //saveFileDialog1.FileName = FolderAnh + "\\" + maAnh + duoiAnh;
                                Camera_phai_Ra_2.Image = Image.FromFile(FolderAnh + "\\" + xevao.Hinh_N_Vao.ToString());
                                lb_4.Text = xevao.Hinh_N_Vao.Replace(".jpg", "").ToString();
                            }
                            else
                            {
                                lb_3.Text = tt[0].ToString() + "-" + tt[1].ToString();
                                lb_4.Text = tt[3].ToString();

                                txt_TenKH_P.Text = tt[0].ToString();
                                txt_Phong_P.Text = tt[1].ToString();

                                Camera_trai_Ra_2.Image = Image.FromFile(FolderAnh + "\\" + xevao.Hinh_N_Vao.ToString());
                                lb_2.Text = xevao.Hinh_N_Vao.Replace(".jpg", "").ToString();
                            }
                        }
                        catch { }
                        try
                        {
                            if (serial == 1)
                            {
                                Camera_phai_Ra_1.Image = Image.FromFile(FolderAnh + "\\" + xevao.HinhBX_Vao.ToString());
                                lb_3.Text = xevao.HinhBX_Vao.Replace(".jpg", "").ToString();
                            }
                            else
                            {
                                Camera_trai_Ra_1.Image = Image.FromFile(FolderAnh + "\\" + xevao.HinhBX_Vao.ToString());
                                lb_1.Text = xevao.HinhBX_Vao.Replace(".jpg", "").ToString();
                            }
                        }
                        catch { }

                    }
                    else
                    {
                        Xe_Vao xe_vao = (from x in ql.Xe_Vaos
                                         where x.MaRFIF.ToUpper() == rfid.GetMa().ToUpper() && x.MaGui.ToUpper() == rfid.GetData().ToUpper()
                                         select x).FirstOrDefault();
                        if (xe_vao.TrangThai == true)
                        {
                            Show_MessageBox("Xe này đã ra khỏi hệ thống. Vui lòng liên hệ nhà cung cấp.", "Xe đã ra.");
                            string_RFID_Ra = "";
                            return;
                        }
                        if (xe_vao != null)
                        {

                            Timer_HinhAnh_P = 0;
                            timer_HinhAnh_P.Enabled = true;
                            Timer_HinhAnh_T = 0;
                            timer_HinhAnh_T.Enabled = true;

                            try
                            {
                                if (serial == 1)
                                {
                                    lb_1.Text = tt[0].ToString() + "-" + tt[1].ToString();
                                    lb_2.Text = tt[3].ToString();
                                    txt_TenKH_T.Text = tt[0].ToString();
                                    txt_Phong_T.Text = tt[1].ToString();

                                    Camera_phai_Ra_2.Image = Image.FromFile(FolderAnh + "\\" + xe_vao.Hinh_N_Vao.ToString());
                                    lb_4.Text = xe_vao.Hinh_N_Vao.Replace(".jpg", "").ToString();
                                }
                                else
                                {
                                    lb_3.Text = tt[0].ToString() + "-" + tt[1].ToString();
                                    lb_4.Text = tt[3].ToString();
                                    txt_TenKH_P.Text = tt[0].ToString();
                                    txt_Phong_P.Text = tt[1].ToString();

                                    Camera_trai_Ra_2.Image = Image.FromFile(FolderAnh + "\\" + xe_vao.Hinh_N_Vao.ToString());
                                    lb_2.Text = xe_vao.Hinh_N_Vao.Replace(".jpg", "").ToString();
                                }
                            }
                            catch { }
                            try
                            {
                                if (serial == 1)
                                {
                                    Camera_phai_Ra_1.Image = Image.FromFile(FolderAnh + "\\" + xe_vao.HinhBX_Vao.ToString());
                                    lb_3.Text = xe_vao.HinhBX_Vao.Replace(".jpg", "").ToString();
                                }
                                else
                                {
                                    //Camera_trai_Ra_1.Image = Image.FromFile(Application.StartupPath + "\\anh\\" + xe_vao.HinhBX_Vao.ToString());
                                    Camera_trai_Ra_1.Image = Image.FromFile(FolderAnh + "\\" + xe_vao.HinhBX_Vao.ToString());
                                    lb_1.Text = xe_vao.HinhBX_Vao.Replace(".jpg", "").ToString();
                                }
                            }
                            catch { }

                            //----------------------------
                            string_RFID_Ra = rfid.GetMa();
                            string_Data_RFID_Ra = rfid.GetData();
                            //----------------------------


                            Text_Ra(serial);

                            if (serial == 1)
                            {
                                //Timer_HinhAnh_T = 0;
                                //timer_HinhAnh_T.Enabled = true;
                                DateTime dateTime = DateTime.Parse(xe_vao.TG_Vao.ToString());
                                txt_ngayVao_T.Text = dateTime.ToString("dd/MM/yyyy");
                                txt_TG_Vao_T.Text = xe_vao.Gio_Vao.ToString();
                                txt_bienso_trai.Text = xe_vao.BienSo_Vao;
                                txt_Gia_T.Text = TinhTien(TimeSpan.Parse(txt_TG_Vao_T.Text), DateTime.ParseExact(txt_ngayVao_T.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), TimeSpan.Parse(txt_TG_Ra_T.Text),DateTime.ParseExact(txt_ngayRa_T.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));

                            }
                            else
                            {
                                //Timer_HinhAnh_P = 0;
                                //timer_HinhAnh_P.Enabled = true;
                                DateTime dateTime = DateTime.Parse(xe_vao.TG_Vao.ToString());
                                txt_ngayVao_P.Text = dateTime.ToString("dd/MM/yyyy");
                                txt_TG_Vao_P.Text = xe_vao.Gio_Vao.ToString();
                                txt_bienso_P.Text = xe_vao.BienSo_Vao;
                                txt_Gia_P.Text = TinhTien(TimeSpan.Parse(txt_TG_Vao_P.Text), DateTime.ParseExact(txt_ngayVao_P.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), TimeSpan.Parse(txt_TG_Ra_P.Text), DateTime.ParseExact(txt_ngayRa_P.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                            }


                            Tao_Ma_anh_Ra = Tao_Ma_Anh(rfid.GetMa());
                            Chup_Anh(Tao_Ma_anh_Ra, DuoiAnh, serial);

                            DocBS_XeRa(serial);

                             //lb_3.Text = tt[0].ToString() + "-" + tt[1].ToString();
                             //lb_4.Text = tt[3].ToString();

                             Xe_Ra xe_Ra = (from xr in ql.Xe_Ras
                                           where xr.Ma_Ra.ToUpper() == xe_vao.Ma_Vao.ToUpper()
                                           select xr).FirstOrDefault();
                            if (xe_Ra == null)
                            {
                                Xe_Ra xe_ = new Xe_Ra();

                                xe_.MayTinh_Ra = Ma_MayTinh;
                                xe_.Ma_Ra = xe_vao.Ma_Vao;
                                xe_.Ma_Vao = xe_vao.Ma_Vao;
                                xe_.HinhBX_Ra = Tao_Ma_anh_Ra + DuoiAnh;
                                xe_.Hinh_Ng_Ra = Tao_Ma_anh_Ra + "x" + DuoiAnh;
                                if(serial == 1)
                                {
                                    if (BienSo_T.Trim() == string.Empty)
                                        xe_.BienSo_Ra = "NULL";
                                    else
                                        xe_.BienSo_Ra = BienSo_T;
                                }else
                                {
                                    if (BienSo_P.Trim() == string.Empty)
                                        xe_.BienSo_Ra = "NULL";
                                    else
                                        xe_.BienSo_Ra = BienSo_P;
                                }
                                xe_.TG_Ra = DateTime.Now;
                                xe_.MaNV_Ra = Ma_NhanVien;
                                xe_vao.TrangThai = true;
                                ql.Xe_Ras.InsertOnSubmit(xe_);
                                ql.SubmitChanges();
                            }
                            else
                            {
                                //Update ảnh chụp biển số                           
                                xe_Ra.TG_Ra = DateTime.Now;
                                ql.SubmitChanges();
                            }
                        }
                        else
                        {
                            Show_MessageBox("Xe không tồn tại trong hệ thống.", "Không có xe trong hệ thống");
                            string_RFID_Ra = "";
                        }
                    }
                }
            }
            else if (ma.Contains("#"))
            {
                if (serial == 1)
                {
                    if (ma.Contains("#V#"))
                        Load_Lan(11, 'V');
                    if (ma.Contains("#R#"))
                        Load_Lan(11, 'R');
                }
                if (serial == 2)
                {
                    if (ma.Contains("#V#"))
                        Load_Lan(12, 'V');
                    if (ma.Contains("#R#"))
                        Load_Lan(12, 'R');
                }
            }
            //else
            //{
            //    NhanMa_RFID(ma);
            //}
        }

        Thread LayBienSo_Loi = null;
        string Bs_Loi = "";
        private void XuLy_XeVao(string ma, int serial)
        {
            rfid.XyLy_Data(ma);

            if (ma.Contains("$"))
            {
                DC_Label();
                if (TinhTrangThe(rfid.GetMa()) == true)
                {
                    
                    int kt_the = Get_Loai_The(rfid.GetMa());
                    if (kt_the == 0)
                    {
                        Show_MessageBox("Thẻ đã hết hạn đăng kí vui lòng liên hệ nhà cung cấp để gia hạn.", "Thẻ hết hạn.");
                        return;
                    }

                    // lỗi không quẹt thẻ được 3 lần


                    //try
                    //{
                    //    LayBienSo_Loi = new Thread(() => Bs_Loi = LayBS_Loi(rfid.GetMa()));
                    //    LayBienSo_Loi.Start();
                    //}catch
                    //{
                    //    Bs_Loi = null;
                    //}

                    //Bs_Loi = LayBS_Loi(rfid.GetMa());

                    if (string_RFID == rfid.GetMa())
                    {
                        Xe_Vao xe_vao = (from x in ql.Xe_Vaos
                                         where x.MaRFIF.ToUpper() == string_RFID.ToUpper() && x.MaGui.ToUpper() == string_Data_RFID.ToUpper()
                                         select x).FirstOrDefault();
                        if (xe_vao != null)
                        {                           
                            xe_vao.TG_Vao = DateTime.Now;
                            xe_vao.MaGui = rfid.GetData();
                            ql.SubmitChanges();

                            Chup_Anh(Tao_Ma_anh, DuoiAnh, serial);

                            string_RFID = rfid.GetMa();
                            string_Data_RFID = rfid.GetData();
                        }

                    }
                    else
                    {
                        Xe_Vao xe_vao = (from x in ql.Xe_Vaos
                                         where x.MaRFIF.ToUpper() == rfid.GetMa().ToUpper() && x.TrangThai == false
                                         select x).FirstOrDefault();

                        // Lưu lại mã vào data để kiểm tra
                        string_RFID = rfid.GetMa();
                        string_Data_RFID = rfid.GetData();

                        if (xe_vao != null)
                        {
                            Show_MessageBox("Xe chưa ra trong hệ thống. Vui lòng liên hệ nhà cung cấp.", "Xe chưa ra.");
                            xe_vao.MaGui = rfid.GetData();
                            ql.SubmitChanges();
                            string_RFID = "";
                            return;
                        }
                        else
                        {

                            Text_Vao(serial);


                            Tao_Ma_anh = Tao_Ma_Anh(rfid.GetMa());

                            //Chụp ảnh
                            Chup_Anh(Tao_Ma_anh, DuoiAnh, serial);


                            DocBS_XeVao(serial);

                            // Lưu vào CSDL
                            Xe_Vao xe_Vao = new Xe_Vao();
                            xe_Vao.Ma_Vao = Tao_Ma_anh;
                            xe_Vao.MaRFIF = rfid.GetMa();
                            xe_Vao.MaGui = rfid.GetData();
                            xe_Vao.MayTinh_Vao = Ma_MayTinh; 
                            xe_Vao.DC = 62;
                            xe_Vao.HinhBX_Vao = Tao_Ma_anh + DuoiAnh;
                            xe_Vao.Hinh_N_Vao = Tao_Ma_anh + "x" + DuoiAnh;
                            xe_Vao.MaNV_Vao = Ma_NhanVien;
                            if (serial == 1)
                            {
                                Timer_HinhAnh_T = 0;
                                timer_HinhAnh_T.Enabled = true;
                                DateTime dateTime = DateTime.ParseExact(txt_ngayVao_T.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                xe_Vao.TG_Vao = dateTime;
                                TimeSpan GioVao = TimeSpan.Parse(txt_TG_Vao_T.Text);
                                xe_Vao.Gio_Vao = GioVao;

                                // lấy biển số khi đã đăng ký với hệ thống
                                //if (BienSo_T.Trim() == string.Empty)
                                //{
                                //    txt_bienso_trai.Text = Bs_Loi;
                                //    xe_Vao.BienSo_Vao = Bs_Loi;
                                //}
                                //else
                                //    xe_Vao.BienSo_Vao = BienSo_T;
                            }
                            else
                            {
                                Timer_HinhAnh_P = 0;
                                timer_HinhAnh_P.Enabled = true;
                                DateTime dateTime = DateTime.ParseExact(txt_ngayVao_P.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                xe_Vao.TG_Vao = dateTime;
                                TimeSpan GioVao = TimeSpan.Parse(txt_TG_Vao_P.Text);
                                xe_Vao.Gio_Vao = GioVao;
                                if (BienSo_P.Trim() == string.Empty)
                                {
                                    txt_bienso_P.Text = Bs_Loi;
                                    xe_Vao.BienSo_Vao = Bs_Loi;
                                }
                                else
                                    xe_Vao.BienSo_Vao = BienSo_P;
                            }
                            xe_Vao.TrangThai = false;
                            ql.Xe_Vaos.InsertOnSubmit(xe_Vao);
                            ql.SubmitChanges();
                        }
                    }
                }
                //BienSo = null;
                Bs_Loi = "";
            }
            else if (ma.Contains("#"))
            {
                if (serial == 1)
                {
                    if (ma.Contains("#V#"))
                        Load_Lan(11, 'V');
                    if (ma.Contains("#R#"))
                        Load_Lan(11, 'R');
                }
                if (serial == 2)
                {
                    if (ma.Contains("#V#"))
                        Load_Lan(12, 'V');
                    if (ma.Contains("#R#"))
                        Load_Lan(12, 'R');
                }
            }
            else
            {
                if(serial == 1)
                    NhanMa_RFID(ma,1);
                else
                    NhanMa_RFID(ma, 2);
            }
        }

        private void DocBS_XeRa(int serial)
        {
            if (serial == 1)
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Camera_trai_Ra_2.Image;
                    NgatLuong_BS_T = new Thread(NgatLuong_T);
                    NgatLuong_BS_T.Start();
                    DocBienSo_T = new Thread(() => BienSo_T = DocDuLieu_Vao_T(bitmap));
                    DocBienSo_T.Start();
                    DocBienSo_T.Join();
                    txt_BienSo_Ra_T.Text = BienSo_T;
                }
                catch
                {
                    try
                    {
                        NgatLuong_BS_T.Abort();
                        DocBienSo_T.Abort();
                        txt_BienSo_Ra_T.Text = string.Empty;
                    }
                    catch { }
                }
            }
            else
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Camera_phai_Ra_2.Image;
                    NgatLuong_BS_P = new Thread(NgatLuong_P);
                    NgatLuong_BS_P.Start();
                    DocBienSo_P = new Thread(() => BienSo_P = DocDuLieu_Vao_P(bitmap));
                    DocBienSo_P.Start();
                    DocBienSo_P.Join();
                    txt_BienSo_Ra_P.Text = BienSo_P;
                }
                catch
                {
                    try
                    {
                        NgatLuong_BS_P.Abort();
                        DocBienSo_P.Abort();
                        txt_BienSo_Ra_P.Text = string.Empty;
                    }
                    catch { }
                }
            }
        }
        private void DocBS_XeVao(int serial)
        {
            if (serial == 1)
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Camera_trai_Ra_1.Image;
                    //timer_NgatLuong.Enabled = true;
                    NgatLuong_BS_T = new Thread(NgatLuong_T);
                    NgatLuong_BS_T.Start();
                    DocBienSo_T = new Thread(() => BienSo_T = DocDuLieu_Vao_T(bitmap));
                    DocBienSo_T.Start();
                    DocBienSo_T.Join();
                    txt_bienso_trai.Text = BienSo_T;
                }
                catch
                {
                    try
                    {
                        NgatLuong_BS_T.Abort();
                        DocBienSo_T.Abort();
                        txt_bienso_trai.Text = string.Empty;
                    }
                    catch { }
                }
            }
            else
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Camera_phai_Ra_1.Image;
                    NgatLuong_BS_P = new Thread(NgatLuong_P);
                    NgatLuong_BS_P.Start();
                    DocBienSo_P = new Thread(() => BienSo_P = DocDuLieu_Vao_P(bitmap));
                    DocBienSo_P.Start();
                    DocBienSo_P.Join();
                    txt_bienso_P.Text = BienSo_P;
                }
                catch
                {
                    try
                    {
                        NgatLuong_BS_P.Abort();
                        DocBienSo_P.Abort();
                        txt_bienso_P.Text = string.Empty;
                    }
                    catch { }
                }
            }
        }


        private void Show_MessageBox(string NoiDung, string TieuDe)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = 5000;
            args.DefaultButtonIndex = 0;
            args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
            args.Caption = TieuDe;
            args.Text = NoiDung;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }

        private string Tao_Ma_Anh(string maRFID)
        {
            DateTime time = DateTime.Now;
            string tt = time.ToString("-ddmmyyyy-hhmmss");
            string maAnh = maRFID.Replace(" ", "") + tt;
            return maAnh;
        }


        private bool TinhTrangThe(string Ma)
        {
            var the = (from t in ql.The_RFIDs
                       where t.MaRFIF.ToLower() == Ma.ToLower()
                       select new { t.TrangThai }).FirstOrDefault();


            if (the == null)
                return false;
            if(the.TrangThai == false)
                return false;

            return true;
        }


        public void NhanMa_RFID(string Data_Input,int serial)
        {
            // CMM : Cap ma moi danh cho lay ma tu dong
            // #R# : Mo cong ra
            // #V# : Mo cong vao           
            if (Data_Input.Equals(ten_CapMa))
            {
                taoma = TaoMa();

                if (serial == 1)
                    serialPort1.WriteLine(taoma);
                else
                    serialPort2.WriteLine(taoma);
            }


            //Set_ChuyenLang(Data_Input);

        }

        

        public string TaoMa()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks) + "@";
        }

        private void Chup_Anh(string maAnh ,string duoiAnh, int serial)// đuôi của anh vd : jpg,png,gif,...
        {
            //saveFileDialog1.FileName = Application.StartupPath + "\\anh\\" + maAnh + duoiAnh;

            saveFileDialog1.FileName = FolderAnh + "\\" + maAnh + duoiAnh;
            saveFileDialog2.FileName = FolderAnh + "\\" + maAnh + "x" + duoiAnh;

            if (serial == 1)
            {
                try
                {
                    Camera_trai_1.Image.Save(saveFileDialog1.FileName);
                    Camera_trai_Ra_1.Image = Camera_trai_1.Image;
                }
                catch { }
                try
                {
                    Camera_trai_2.Image.Save(saveFileDialog2.FileName);
                    Camera_trai_Ra_2.Image = Camera_trai_2.Image;
                }
                catch { }
            }
            if(serial == 2)
            {
                try
                {
                    Camera_phai_1.Image.Save(saveFileDialog1.FileName);
                    Camera_phai_Ra_1.Image = Camera_phai_1.Image;
                }
                catch { }
                try
                {
                    Camera_phai_2.Image.Save(saveFileDialog2.FileName);
                    Camera_phai_Ra_2.Image = Camera_phai_2.Image;
                }
                catch { }
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            //if (btn_vao_ra.Text.Equals("Xe vào"))
            //{
            //serialPort1.Write("V@");
            //taoma = TaoMa();
            //serialPort1.WriteLine(taoma);
            //serialPort2.Write("V@");
            //}
            //else
            //if (btn_vao_ra.Text.Equals("Xe ra"))
            //{
            //serialPort1.Write("R@");
            //serialPort2.Write("R@");
            //}

            //button1.TransparencyKey = Color.Wheat;

        }



        private void Load_Lan(int kx,char Vao_Ra)//Load làn xe
        {
            if (kx == 0)
            {
                lb_lan_1.Text = "Xe vào (Đảo làn F11)";
                lb_lan_1.BackColor = Color.Green;
                lb_lan_2.Text = "Xe ra (Đảo làn F12)";
                lb_lan_2.BackColor = Color.Red;
            }
            if(kx == 11)
            {
                if (Vao_Ra == 'R')
                {
                    lb_lan_1.Text = "Xe ra (Đảo làn F11)";
                    lb_lan_1.BackColor = Color.Red;
                    VR_seri_1 = 1;
                }
                if(Vao_Ra == 'V')
                {
                    lb_lan_1.Text = "Xe vào (Đảo làn F11)";
                    lb_lan_1.BackColor = Color.Green;
                    VR_seri_1 = 0;
                }
            }
            if (kx == 12)
            {
                if (Vao_Ra == 'R')
                {
                    lb_lan_2.Text = "Xe ra (Đảo làn F12)";
                    lb_lan_2.BackColor = Color.Red;
                    VR_seri_2 = 1;
                }
                if (Vao_Ra == 'V')
                {
                  
                    lb_lan_2.Text = "Xe vào (Đảo làn F12)";
                    lb_lan_2.BackColor = Color.Green;
                    VR_seri_2 = 0;
                }
            }
        }


        private void btn_ql_the_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            if(serialPort2.IsOpen)
            {
                serialPort2.Close();
            }
            frm_QL_The frm_QL_The = new frm_QL_The();
            frm_QL_The.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frm_ThongTinVaoRa frm = new frm_ThongTinVaoRa();
            frm.ShowDialog();
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Minimized;
        }

        private List<object> Get_TT_KhachHang(string maRFID)
        {
            var tt = (from vt in ql.VeThangs
                    join x in ql.Xes on vt.MaXe equals x.MaXe
                    join kh in ql.KhachHangs on x.MaKH equals kh.MaKH
                    where vt.NgayKT >= DateTime.Now && vt.MaRFID.ToUpper() == maRFID.ToUpper()
                    select new { kh.TenKH, kh.SoPhong, vt.NgayBD ,vt.NgayKT }).FirstOrDefault();
            List<object> list;
            if (tt != null)
            {
                string[] NgayKT = tt.NgayKT.ToString().Split(' ');

                string[] NgayBD = tt.NgayBD.ToString().Split(' ');

                list = new List<object>() { tt.TenKH, tt.SoPhong, NgayBD[0], NgayKT[0] };
            }
            else
            {
                list = new List<object>() { "", "", "", "" };
            }
            return list;
        }

        private int Get_Loai_The(string MaRFID)
        {
            var the =(from t in ql.The_RFIDs
                      where t.MaRFIF.ToUpper() == MaRFID.ToUpper()
                      select new { t.TheDangKi}).FirstOrDefault();

            if(the.TheDangKi == true)
            {
                //Kiểm tra hạn sử dụng
                var dk = (from d in ql.VeThangs
                          where d.NgayKT >= DateTime.Now && d.MaRFID.ToUpper() == MaRFID.ToUpper() 
                          select new { d.NgayKT }).FirstOrDefault();

                if(dk != null)
                {
                    return 1;
                }
                else
                {                   
                    return 0;                  
                }
            }
            else
            {
                return 1;
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        bool save_btn_biensophai = false;
        private void btn_bienso_phai_Click(object sender, EventArgs e)
        {
            try
            {
                if (save_btn_biensophai == false)
                {
                    btn_bienso_phai.Text = "Lưu tùy chỉnh phải (F9)";
                    save_btn_biensophai = true;

                    if (VR_seri_2 == 0)
                    {
                        txt_bienso_P.Text = string.Empty;
                        txt_bienso_P.ReadOnly = false;
                        txt_bienso_P.Focus();
                    }
                    else
                    {
                        txt_BienSo_Ra_P.Text = string.Empty;
                        txt_BienSo_Ra_P.ReadOnly = false;
                        txt_BienSo_Ra_P.Focus();
                    }

                }
                else
                {
                    if (VR_seri_2 == 0)
                    {
                        if (txt_bienso_P.Text.Trim() == string.Empty)
                        {
                            btn_bienso_phai.Text = "Tùy chỉnh phải (F9)";
                            save_btn_biensophai = false;
                            return;
                        }
                        if (txt_bienso_P.Text.Trim() == string.Empty || txt_bienso_P.Text.Trim().Length < 8 || txt_bienso_P.Text.Trim().Length > 12)
                        {
                            Show_MessageBox("Vui lòng nhập biển số xe.", "Lỗi kí tự biển số xe không đúng định dạng");
                            return;
                        }
                        btn_bienso_phai.Text = "Tùy chỉnh phải (F9)";
                        save_btn_biensophai = false;

                        Xe_Vao xe_vao = (from x in ql.Xe_Vaos
                                         where x.MaRFIF.ToUpper() == string_RFID.ToUpper() && x.MaGui.ToUpper() == string_Data_RFID.ToUpper()
                                         select x).FirstOrDefault();
                        xe_vao.BienSo_Vao = txt_bienso_P.Text.Trim();
                        ql.SubmitChanges();
                        txt_bienso_P.ReadOnly = true;
                    }
                    else
                    {
                        if (txt_BienSo_Ra_P.Text.Trim() == string.Empty)
                        {
                            btn_bienso_phai.Text = "Tùy chỉnh phải (F9)";
                            save_btn_biensophai = false;
                            return;
                        }
                        if (txt_BienSo_Ra_P.Text.Trim() == string.Empty || txt_BienSo_Ra_P.Text.Trim().Length < 8 || txt_BienSo_Ra_P.Text.Trim().Length > 12)
                        {
                            Show_MessageBox("Vui lòng nhập biển số xe.", "Lỗi kí tự biển số xe không đúng định dạng");
                            return;
                        }
                        btn_bienso_phai.Text = "Tùy chỉnh phải (F9)";
                        save_btn_biensophai = false;
                        Xe_Vao xevao = (from x in ql.Xe_Vaos
                                        where x.MaRFIF.ToUpper() == string_RFID_Ra.ToUpper() && x.MaGui.ToUpper() == string_Data_RFID_Ra.ToUpper()
                                        select x).FirstOrDefault();

                        Xe_Ra xera = (from xr in ql.Xe_Ras
                                      where xr.Ma_Ra.ToUpper() == xevao.Ma_Vao.ToUpper()
                                      select xr).FirstOrDefault();

                        xera.BienSo_Ra = txt_BienSo_Ra_P.Text.Trim();
                        ql.SubmitChanges();
                        txt_BienSo_Ra_P.ReadOnly = true;
                    }
                    Show_MessageBox("Lưu thành công", "Xong");
                }
            }catch
            {
                Show_MessageBox("Đã xảy ra lỗi trong quá trình thực hiện này", "Lỗi không thực hiện được");
                btn_biensotrai.Text = "Tùy chỉnh trái (F8)";
                save_btn_biensophai = false;
                txt_bienso_P.ReadOnly = true;
                txt_BienSo_Ra_P.ReadOnly = true;
            }
        }

        bool save_btn_biensotrai = false;
        private void btn_biensotrai_Click(object sender, EventArgs e)
        {
            try
            {
                if (save_btn_biensotrai == false)
                {
                    btn_biensotrai.Text = "Lưu tùy chỉnh trái (F8)";
                    save_btn_biensotrai = true;
                    if (VR_seri_1 == 0)
                    {
                        txt_bienso_trai.Text = string.Empty;
                        txt_bienso_trai.ReadOnly = false;
                        txt_bienso_trai.Focus();
                    }
                    else
                    {
                        txt_BienSo_Ra_T.Text = string.Empty;
                        txt_BienSo_Ra_T.ReadOnly = false;
                        txt_BienSo_Ra_T.Focus();
                    }


                }
                else
                {
                    if (VR_seri_1 == 0)
                    {
                        if (txt_bienso_trai.Text.Trim() == string.Empty)
                        {
                            btn_biensotrai.Text = "Tùy chỉnh trái (F8)";
                            save_btn_biensotrai = false;
                            return;
                        }
                        if ( txt_bienso_trai.Text.Trim().Length < 8 || txt_bienso_trai.Text.Trim().Length > 12)
                        {
                            Show_MessageBox("Vui lòng nhập biển số xe.", "Lỗi kí tự biển số xe không đúng định dạng");
                            return;
                        }

                        btn_biensotrai.Text = "Tùy chỉnh trái (F8)";
                        save_btn_biensotrai = false;

                        Xe_Vao xe_vao = (from x in ql.Xe_Vaos
                                         where x.MaRFIF.ToUpper() == string_RFID.ToUpper() && x.MaGui.ToUpper() == string_Data_RFID.ToUpper()
                                         select x).FirstOrDefault();
                        xe_vao.BienSo_Vao = txt_bienso_trai.Text.Trim();
                        //xe_vao.TG_Vao = DateTime.Now;
                        //xe_vao.MaGui = rfid.GetData();
                        ql.SubmitChanges();
                        txt_bienso_trai.ReadOnly = true;
                    }
                    else
                    {
                        if (txt_BienSo_Ra_T.Text.Trim() == string.Empty)
                        {
                            btn_biensotrai.Text = "Tùy chỉnh trái (F8)";
                            save_btn_biensotrai = false;
                            return;
                        }
                        if ( txt_BienSo_Ra_T.Text.Trim().Length < 8 || txt_BienSo_Ra_T.Text.Trim().Length > 12)
                        {
                            Show_MessageBox("Vui lòng nhập biển số xe.", "Lỗi kí tự biển số xe không đúng định dạng");
                            return;
                        }

                        btn_biensotrai.Text = "Tùy chỉnh trái (F8)";
                        save_btn_biensotrai = false;

                        Xe_Vao xevao = (from x in ql.Xe_Vaos
                                        where x.MaRFIF.ToUpper() == string_RFID_Ra.ToUpper() && x.MaGui.ToUpper() == string_Data_RFID_Ra.ToUpper()
                                        select x).FirstOrDefault();

                        Xe_Ra xera = (from xr in ql.Xe_Ras
                                      where xr.Ma_Ra.ToUpper() == xevao.Ma_Vao.ToUpper()
                                      select xr).FirstOrDefault();

                        xera.BienSo_Ra = txt_BienSo_Ra_T.Text.Trim();
                        ql.SubmitChanges();
                        txt_BienSo_Ra_T.ReadOnly = true;
                    }
                    Show_MessageBox("Lưu thành công", "Xong");
                }
            }
            catch
            {
                Show_MessageBox("Đã xảy ra lỗi trong quá trình thực hiện này", "Lỗi không thực hiện được");
                btn_biensotrai.Text = "Tùy chỉnh trái (F8)";
                save_btn_biensotrai = false;
                txt_bienso_trai.ReadOnly = true;
                txt_BienSo_Ra_T.ReadOnly = true;
            }
        }

        private string DocDuLieu_Vao_T(Bitmap bitmap)
        {
            //Bitmap bitmap = (Bitmap)Camera_trai_Ra_1.Image;
            string xc = xyLy.XuLyDuLieu(bitmap);
            NgatLuong_BS_T.Abort();
            return xc;
        }

        private string DocDuLieu_Vao_P(Bitmap bitmap)
        {
            //Bitmap bitmap = (Bitmap)Camera_trai_Ra_1.Image;
            string xc = xyLy.XuLyDuLieu(bitmap);
            NgatLuong_BS_P.Abort();
            return xc;
        }

        void NgatLuong()
        {
            //Stopwatch st = new Stopwatch();
            //st.Start();
            //while (true)
            //{
            //    if (st.ElapsedTicks >= 100000000)
            //    {
            //        DocBienSo.Abort();
            //        NgatLuong_BS.Abort();
            //    }
            //}


        }


   

        private void button1_Click(object sender, EventArgs e)
        {
            timer_HinhAnh_P.Enabled = true;
            timer_HinhAnh_T.Enabled = true;

            //timer.Enabled = true;


            //string Tien = TinhTien(TimeSpan.Parse("20:00:00"), DateTime.Now, TimeSpan.Parse("23:00:00"), DateTime.Now);

            //MessageBox.Show(Tien);

            //TimeSpan dateTime = TimeSpan.Parse(txt_TG_Vao_T.Text);

            //MessageBox.Show(dateTime.ToString());

            //Bitmap bitmap = (Bitmap)Camera_trai_Ra_1.Image;
            //string xc = xyLy.XuLyDuLieu(bitmap);
            //MessageBox.Show(xc);




            //string value = null;
            //DocBienSo = new Thread(() => value = MyFunction());
            //DocBienSo.Start();
            //DocBienSo.Join();

            //MessageBox.Show(value);

            //NgatLuong_BS.Join();
            //DocBienSo.Join();

            //Console.WriteLine("xong");
            //NgatLuong();



        }

        private string LayBS_Loi(string maRFID)
        {
            string bx = "";
            var tt = (from vt in ql.VeThangs
                      join x in ql.Xes on vt.MaXe equals x.MaXe
                      where vt.NgayKT >= DateTime.Now && vt.MaRFID.ToUpper() == maRFID.ToUpper()
                      select new { x.BienXo_Xe} ).FirstOrDefault();
            if (tt != null)
            {
                bx = tt.BienXo_Xe;
            }
            return bx;
        }

        private void Text_Vao(int serial)
        {
            if(serial == 1)
            {
                txt_ngayVao_T.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txt_TG_Vao_T.Text =  DateTime.Now.ToString("HH:mm:ss", CultureInfo.CurrentCulture);
            }
            else
            {
                txt_ngayVao_P.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txt_TG_Vao_P.Text = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CurrentCulture);
            }
        }

        private void Text_Ra(int serial)
        {
            if (serial == 1)
            {
                txt_ngayRa_T.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txt_TG_Ra_T.Text = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CurrentCulture);
            }
            else
            {
                txt_ngayRa_P.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txt_TG_Ra_P.Text = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CurrentCulture);
            }
        }


        private void btn_F5_Click(object sender, EventArgs e)
        {
            frm_VeThang frm = new frm_VeThang();
            frm.ShowDialog();
        }

        private string TinhTien(TimeSpan TG_V,DateTime Ngay_V, TimeSpan TG_R, DateTime Ngay_R)
        {          
            if(Ngay_V.Equals(Ngay_R))
            {
                if(TG_V >= TimeSpan.Parse("7:00:00") && TG_R <= TimeSpan.Parse("22:00:00"))
                {
                    return GiaVe1;
                }
                else
                //if (TG_V >= TimeSpan.Parse("22:00:00") && TG_R <= TimeSpan.Parse("7:00:00"))
                {
                    return GiaVe2;
                }
            }
            else
            {
                return GiaVe2;
            }
            
        }

        private void txt_bienso_trai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == '-' ||(e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || char.IsControl(e.KeyChar)   )
            {
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
                e.Handled = false;
            }
            else
            {
                    e.Handled = true;
            }
            
        }

        int i = 0;
        //private void Dem()
        //{

        //    timer = new System.Windows.Forms.Timer();
        //    timer.Tick += timer_Tick;
        //    timer.Interval = 1000;
        //}


        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == i)
                Console.WriteLine(i);
            //if (i == 7)
            //{
            //    //if (pictureBox1.Image == null)
            //    {
            //        //this.Close();
            //        //XtraMessageBox.Show("Vui lòng kiểm tra các thông số camera", "Kết nối thất bại", MessageBoxButtons.OK);
                    
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            i = 0;
        }

        private void NgatLuong_T()
        {
            for (int i = 0; i < 7; i++)
            {
                Thread.Sleep(1000);
                //Timer_NgatLuong++;
                Console.WriteLine(i);
            }
            DocBienSo_T.Abort();
        }

        private void NgatLuong_P()
        {
            for (int i = 0; i < 7; i++)
            {
                Thread.Sleep(1000);
                //Timer_NgatLuong++;
                Console.WriteLine(i);
            }
            DocBienSo_P.Abort();
        }


        //private void timer_NgatLuong_Tick(object sender, EventArgs e)
        //{
        //    Timer_NgatLuong++;
        //    if(Timer_NgatLuong == 5)
        //    {
        //        //if(DocBienSo != null)
        //        DocBienSo.Abort();
        //        //NgatLuong_BS.Abort();
        //        timer_NgatLuong.Enabled = false;
        //        Timer_NgatLuong = 0;
        //    }
        //    Console.WriteLine(Timer_NgatLuong);
        //}

        private void timer_HinhAnh_T_Tick(object sender, EventArgs e)
        {
            Timer_HinhAnh_T++;
            if(Timer_HinhAnh_T == 20)
            {
                Camera_trai_Ra_1.Image = null;
                Camera_trai_Ra_2.Image = null;
                txt_bienso_trai.Text = "";
                txt_BienSo_Ra_T.Text = "";
                txt_TenKH_T.Text = "";
                txt_Phong_T.Text = "";
                txt_Gia_T.Text = "";
                Timer_HinhAnh_T = 0;
                timer_HinhAnh_T.Enabled = false;
            }
            //Console.WriteLine( "T: "+Timer_HinhAnh_T);
        }

        private void timer_TG_HeThong_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("hh:mm:ss");
            lab_thu.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        int td_tmr = 0;

        private void lab_thu_TextChanged(object sender, EventArgs e)
        {
            if(td_tmr > 0)
            {
                string Ngay = DateTime.Now.Day.ToString();
                string Thu = DateTime.Now.DayOfWeek.ToString();

                if(Ngay == Full)
                {
                    SaoLuu saoLuu = new SaoLuu();
                    saoLuu.BackUp_FileFull(Properties.Settings.Default.FolderBackUp, "Full_QL_Xe", "Bai_Xe_TM", Properties.Settings.Default.Connect);
                }
                else
                if(Thu == Diff)
                {
                    SaoLuu saoLuu = new SaoLuu();
                    saoLuu.BackUp_FileDiff(Properties.Settings.Default.FolderBackUp, "Diff_QL_Xe", "Bai_Xe_TM", Properties.Settings.Default.Connect);
                }
                else
                //if (Thu == Log)
                {
                    SaoLuu saoLuu = new SaoLuu();
                    saoLuu.BackUp_FileLog(Properties.Settings.Default.FolderBackUp, Thu+"_QL_Xe", "Bai_Xe_TM", Properties.Settings.Default.Connect);
                }
            }
            td_tmr++;
        }

        private void timer_HinhAnh_P_Tick(object sender, EventArgs e)
        {
            Timer_HinhAnh_P++;
            if (Timer_HinhAnh_P == 20)
            {
                Camera_phai_Ra_1.Image = null;
                Camera_phai_Ra_2.Image = null;
                txt_bienso_P.Text = "";
                txt_BienSo_Ra_P.Text = "";
                txt_TenKH_P.Text = "";
                txt_Phong_P.Text = "";
                txt_Gia_P.Text = "";
                Timer_HinhAnh_P = 0;
                timer_HinhAnh_P.Enabled = false;
                
            }
            //Console.WriteLine("P: "+Timer_HinhAnh_P);
        }
    }
}

