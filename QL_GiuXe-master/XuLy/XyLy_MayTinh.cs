using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XuLy
{
    public class XuLy_MayTinh
    {
        public string LayTen_MayTinh()
        {
            return System.Environment.MachineName.ToString();
        }
        public string Lay_Serial()
        {
            Process cmdProcess;
            cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.Arguments = "/c " + "wmic diskdrive get serialnumber";
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.Start();
            string serial = cmdProcess.StandardOutput.ReadToEnd();
            cmdProcess.WaitForExit();
            if (string.IsNullOrEmpty(serial))
                return null;
            return serial.Replace("SerialNumber", "").Replace(" ", "");
        }

        public string Lay_Ip(string TenMay)
        {
            string Ip = null;
            IPHostEntry iphostentry = Dns.GetHostByName(TenMay);
            // Enumerate IP addresses
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Ip += ipaddress.ToString();
            }
            return Ip;
        }
    }
}
