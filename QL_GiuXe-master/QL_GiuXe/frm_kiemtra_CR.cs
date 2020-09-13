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
using Accord.Video.FFMPEG;
using System.Threading;

namespace QL_GiuXe
{
    public partial class frm_kiemtra_CR : DevExpress.XtraEditors.XtraForm
    {
        private VideoFileReader ip = new VideoFileReader();

        public frm_kiemtra_CR()
        {
            InitializeComponent();
        }

        private void frm_kiemtra_CR_Load(object sender, EventArgs e)
        {
            
        }


        Thread IP = null;
        string KetNoi = null;

        public frm_kiemtra_CR(string KetNoi_CR)
        {
            InitializeComponent();
           

                KetNoi = KetNoi_CR;

                IP = new Thread(load_IP);
                IP.Start();
           
        }
        int i = 0;
        private void Dem()
        {

            timer = new System.Windows.Forms.Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 1000;
        }

        private void load_IP()
        {
            try
            {
                ip.Open(KetNoi);
            }
            catch
            {
                XtraMessageBox.Show("Vui lòng kiểm tra các thông số camera", "Kết nối thất bại", MessageBoxButtons.OK);
            }
            do
            {
                try
                {
                    Bitmap frame1 = ip.ReadVideoFrame();
                    pictureBox1.Image = frame1;
                }
                catch { }
            }
            while (ip.IsOpen);

        }

        private void frm_kiemtra_CR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frm_kiemtra_CR_FormClosing(object sender, FormClosingEventArgs e)
        {
            ip.Close();
            IP.Abort();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 7)
            {
                if (pictureBox1.Image == null)
                {
                    IP.Abort();
                    this.Close();
                    XtraMessageBox.Show("Vui lòng kiểm tra các thông số camera", "Kết nối thất bại", MessageBoxButtons.OK);
                }
            }

        }
    }
}