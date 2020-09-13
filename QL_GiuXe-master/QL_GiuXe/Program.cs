using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using WindowsFormsApp1;

namespace QL_GiuXe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            //Application.Run(new CauHinh_HeThong());
            //Application.Run(new frm_ThongTinVaoRa());
            //Application.Run(new frm_DanhMuc_MayTinh());
            //Application.Run(new frm_BackUp());
            Application.Run(new frm_Main());
            //Application.Run(new frm_ThongKeViPham());
        }
    }
}
