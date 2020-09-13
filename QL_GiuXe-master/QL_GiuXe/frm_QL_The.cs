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

namespace QL_GiuXe
{
    public partial class frm_QL_The : DevExpress.XtraEditors.XtraForm
    {
        public string Truyen_MaRFID = "";
        QL_BaiXeDataContext ql = new QL_BaiXeDataContext();

        string InputData = String.Empty;
        delegate void SetTextCallback(string text);
        string ma = null;
        int index_list = 0;
        bool check_them = false;

        RFID rfid;

        public frm_QL_The()
        {
            InitializeComponent();
        }

        public frm_QL_The(int gt)
        {
            InitializeComponent();
            btn_chon.Visible = true;
            btn_lammoi.Visible = true;
            btn_them.Visible = false;
            btn_xoa.Visible = false;
            btn_khoiphuc.Visible = false;          
            list_danhsach.Enabled = false;
        }

        private void frm_QL_The_Load(object sender, EventArgs e)
        {

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            Load_Cong_Com();

            Load_grid_danhsachthe();
            Load_list_danhsach();

           txt_mathe.DataBindings.Clear();
           txt_mathe.DataBindings.Add(new Binding("Text", grid_danhsachthe.DataSource, "MaRFIF"));
           list_danhsach.SelectedIndex = 1;
        }

        private void Load_grid_danhsachthe()
        {
            var ds = (from the in ql.The_RFIDs
                      join ve in ql.LoaiVes on the.MaLoaiVe equals ve.MaLoaiVe
                     select new { the.MaRFIF, the.NgayTao, ve.TenLoaiVe ,the.NgayCapNhatCuoi, the.TrangThai });

            grid_danhsachthe.DataSource = ds;
        }

        private void Load_list_danhsach()
        {
            try
            {
                list_danhsach.Items.RemoveAt(2);
                list_danhsach.Items.RemoveAt(1);
                list_danhsach.Items.RemoveAt(0);
            }
            catch { }
            int tatca = ql.The_RFIDs.Count();

            int daxoa = (from the in ql.The_RFIDs
                         where the.TrangThai == false
                         select new { the.MaRFIF }).Count();
            int chung = tatca - daxoa;


            list_danhsach.Items.Add("Tất cả" + " ("+tatca+")");
            list_danhsach.Items.Add("Chung" + " (" + chung + ")");
            list_danhsach.Items.Add("Đã xóa" + " (" + daxoa + ")");

        }

        private void list_danhsach_Click(object sender, EventArgs e)
        {
            click_ds_list();
            if(index_list == 0)
            {
                btn_xoa.Enabled = false;
                btn_khoiphuc.Enabled = false;
                btn_them.Enabled = true;
            }
            if(index_list == 1)
            {
                btn_xoa.Enabled = true;
                btn_khoiphuc.Enabled = false;
                btn_them.Enabled = true;
            }
            if(index_list == 2)
            {
                btn_xoa.Enabled = false;
                btn_khoiphuc.Enabled = true;
                btn_them.Enabled = false;
            }

        }


        private void click_ds_list()
        {

            if(list_danhsach.SelectedIndex >= 0)
                index_list = list_danhsach.SelectedIndex;

            if (index_list == 0)
            {
                Load_grid_danhsachthe();
            }
            if (index_list == 1)
            {
                var ds = (from the in ql.The_RFIDs
                          join ve in ql.LoaiVes on the.MaLoaiVe equals ve.MaLoaiVe
                          where the.TrangThai == true
                          select new { the.MaRFIF, the.NgayTao, ve.TenLoaiVe, the.NgayCapNhatCuoi, the.TrangThai });
                grid_danhsachthe.DataSource = ds;
            }

            if (index_list == 2)
            {
                var ds = (from the in ql.The_RFIDs
                          join ve in ql.LoaiVes on the.MaLoaiVe equals ve.MaLoaiVe
                          where the.TrangThai == false
                          select new { the.MaRFIF, the.NgayTao, ve.TenLoaiVe, the.NgayCapNhatCuoi, the.TrangThai });
                grid_danhsachthe.DataSource = ds;
            }
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            //var kt = (from t in ql.CauHinh_Cameras
            //          where t.Hang_Camera.ToUpper() == cauhinh.Hang_Camera.ToUpper()
            //          select t).FirstOrDefault();
            if(btn_them.Text == "Thêm thẻ")
            {
                check_them = true;
                btn_them.Text = "Hủy thêm";
            }
            else
            {
                check_them = false;
                btn_them.Text = "Thêm thẻ";
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int row = gridView1.FocusedRowHandle;
            if(row >= 0)
            {               
                string gr = gridView1.GetRowCellValue(row, MaRFIF).ToString();

                The_RFID the = (from t in ql.The_RFIDs
                                where t.MaRFIF.ToUpper() == gr.ToUpper()
                                select t).FirstOrDefault();
                the.TrangThai = false;
                the.NgayCapNhatCuoi = DateTime.Parse(dateTime.ToString());

                try
                {
                    ql.SubmitChanges();

                }
                catch
                {
                    return;
                }
                click_ds_list();

                Load_list_danhsach();
            }
        }

        private void btn_khoiphuc_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int row = gridView1.FocusedRowHandle;
            if (row >= 0)
            {
                string gr = gridView1.GetRowCellValue(row, MaRFIF).ToString();

                The_RFID the = (from t in ql.The_RFIDs
                                where t.MaRFIF.ToUpper() == gr.ToUpper()
                                select t).FirstOrDefault();
                the.TrangThai = true;
                the.NgayCapNhatCuoi = DateTime.Parse(dateTime.ToString());
                try
                {
                    ql.SubmitChanges();
                }
                catch { }
                Load_list_danhsach();

                click_ds_list();
            }
        }

        private void Load_Cong_Com()
        {
            cob_com.DataSource = SerialPort.GetPortNames();
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

                //MessageBox.Show(rfid.GetMa());

                if (ma.Contains("$"))
                {
                    if (check_them == true)
                        Them_The(rfid.GetMa());

                    txt_mathe.Text = string.Empty;
                    txt_mathe.Text = rfid.GetMa();
                }
            }
        }

        private void Them_The(string Ma)
        {
            DateTime dateTime = DateTime.Now;

            The_RFID the = new The_RFID();

            the.MaRFIF = Ma;

            the.MaLoaiVe = "VETHANG";

            the.NgayTao = DateTime.Parse(dateTime.ToString());

            the.NgayCapNhatCuoi = DateTime.Parse(dateTime.ToString());

            the.TrangThai = true;

            int kt = Luu_The(the);
            if(kt == 2)
            {
                XtraMessageBox.Show("Thẻ đã tồn tại trong hệ thống", "Tồn tại thẻ", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }


        private int Luu_The(The_RFID the)
        {
            var kt = (from t in ql.The_RFIDs
                      where t.MaRFIF.ToLower() == the.MaRFIF.ToLower()
                      select t).FirstOrDefault();
            if (kt != null)
                return 2;
            else
            {
                ql.The_RFIDs.InsertOnSubmit(the);
                ql.SubmitChanges();
                return 1;
            }           
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            Load_Cong_Com();

            Load_grid_danhsachthe();
            Load_list_danhsach();
            txt_mathe.Text = string.Empty;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_mathe.Text == string.Empty)
            {
                XtraMessageBox.Show("Không tồn tại thẻ này trong hệ thống", "Không có thẻ");
                return;
            }
            var ds = (from the in ql.The_RFIDs
                      join ve in ql.LoaiVes on the.MaLoaiVe equals ve.MaLoaiVe
                      where the.MaRFIF.ToUpper() == txt_mathe.Text.ToLower()
                      select new { the.MaRFIF, the.NgayTao, ve.TenLoaiVe, the.NgayCapNhatCuoi, the.TrangThai }).DefaultIfEmpty();
            if(ds == null)
                XtraMessageBox.Show("Không tồn tại thẻ này trong hệ thống", "Không có thẻ");
            else
                grid_danhsachthe.DataSource = ds;
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            if (txt_mathe.Text == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng chọn thẻ", "Chưa chọn thẻ");
                return;
            }
            else
            {
                Truyen_MaRFID = txt_mathe.Text;
                this.Close();
            }

        }
    }
}