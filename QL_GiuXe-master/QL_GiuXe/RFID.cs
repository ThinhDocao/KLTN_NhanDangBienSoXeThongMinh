using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiuXe
{
    public class RFID
    {
        private string Ma;
        private string Data;

        public RFID()
        {
            Ma = null;
            Data = null;
        }

        public RFID(string ma,string data)
        {
            this.Ma = ma;
            this.Data = data;
        }

        public void XyLy_Data(string Data_Input)
        {
            if (Data_Input.Contains('$'))
            {
                //MessageBox.Show(Data_Input);
                try
                {
                    string[] CatChuoi = Data_Input.Split('$');
                    this.Ma = CatChuoi[0];
                    this.Data = CatChuoi[1].Substring(0, 15);
                }
                catch { }
            }
        }
        public string GetMa()
        {
            return this.Ma;
        }
        public string GetData()
        {
            return this.Data;
        }
        public void SetMa(string ma)
        {
            this.Ma = ma;
        }
        public void SetData(string data)
        {
            this.Data = data;
        }


    }
}
