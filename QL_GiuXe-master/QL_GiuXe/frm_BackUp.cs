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
using SaoLuu_HT;

namespace QL_GiuXe
{
    public partial class frm_BackUp : DevExpress.XtraEditors.XtraForm
    {
        public frm_BackUp()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FolderBackUp == string.Empty)
            {
                XtraMessageBox.Show("Chọn nơi lưu file trước", "Chọn nơi lưu");
            }
            else
            {
                SaoLuu saoLuu = new SaoLuu();
                saoLuu.BackUp_FileFull(Properties.Settings.Default.FolderBackUp, "Full_QL_Xe", "Bai_Xe_TM", Properties.Settings.Default.Connect);
                XtraMessageBox.Show("BackUp thành công");
            }
        }

        private void btn_chonNoi_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.FolderBackUp = dialog.SelectedPath.ToString();
                Properties.Settings.Default.Save();                
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FolderBackUp == string.Empty)
            {
                XtraMessageBox.Show("Chọn nơi lưu file trước", "Chọn nơi lưu");
            }
            else
            {
                SaoLuu saoLuu = new SaoLuu();
                saoLuu.BackUp_FileDiff(Properties.Settings.Default.FolderBackUp, "Diff_QL_Xe", "Bai_Xe_TM", Properties.Settings.Default.Connect);
                XtraMessageBox.Show("BackUp thành công");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (rad_Full_1.Checked == true)
                Properties.Settings.Default.Full = "1";
            else
                Properties.Settings.Default.Full = "15";

            if (rad_diff_2.Checked == true)
                Properties.Settings.Default.Diff = "Monday";
            else
                if(rad_diff_5.Checked == true)
                    Properties.Settings.Default.Diff = "Thursday";
                else
                    Properties.Settings.Default.Diff = "Sunday";

            Properties.Settings.Default.Log = "1";

            Properties.Settings.Default.Save();

            XtraMessageBox.Show("Lưu thành công", "Thành công");
        }
    }
}