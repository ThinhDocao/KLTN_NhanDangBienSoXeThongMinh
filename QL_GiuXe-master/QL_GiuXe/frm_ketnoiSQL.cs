using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QL_GiuXe
{
    public partial class frm_ketnoiSQL : Form
    {
        string c_conn = null;
        SqlConnection conn;

        public SqlConnection Conn { get => conn; set => conn = value; }

        int quyen = 0;

        public frm_ketnoiSQL()
        {
            InitializeComponent();
            cob_qtrycap.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }


        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cob_database_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cob_server_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cob_server_DropDown(object sender, EventArgs e)
        {
            DataTable dt = GetServerName();
            cob_server.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cob_server.Items.Add(row[col]);
                }
            }
        }

        

        private void btn_capnhat_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(Properties.Settings.Default.Connect.ToString());

            string Windows = @"Data Source=" + cob_server.Text + ";Initial Catalog="+cob_database.Text+";Integrated Security=True";//0
            string SA = @"Data Source=" + cob_server.Text + ";Initial Catalog=" + cob_database.Text + "; User ID =" + txt_username.Text + "; Password = " + txt_password.Text + "";//1

            if(quyen  == 0)
            {
                c_conn = Windows;
            }
            else
            {
                c_conn = SA;
            }
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                    
                }
                else
                {
                    Properties.Settings.Default.Connect = c_conn;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Cấu hình thành công, vui lòng khởi động lại hệ thống");
                    Application.Restart();
                }
                
            }
            catch
            {
                MessageBox.Show("Cấu hình sai vui lòng cấu hình lại !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            

        }

        

        private void cob_database_DropDown(object sender, EventArgs e)
        {
            string Windows = @"Data Source=" + cob_server.Text + ";Initial Catalog=master;Integrated Security=True";
            string SA = @"Data Source=" + cob_server.Text + ";Initial Catalog=master; User ID =" + txt_username.Text + "; Password = " + txt_password.Text + "";

            if (cob_qtrycap.SelectedIndex == 0)
            {
                Conn = new SqlConnection(Windows);
                try
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                        c_conn = Windows;
                        quyen = 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Cấu hình không đúng");
                    return;
                }
            }
            else
            {
                Conn = new SqlConnection(SA);
                try
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                        c_conn = SA;
                        quyen = 1;
                    }
                }
                catch
                {
                    MessageBox.Show("Cấu hình không đúng");
                    return;
                }
            }
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT NAME FROM SYS.databases", Conn);
                da.Fill(dt);
                cob_database.DisplayMember = "name";
                cob_database.DataSource = dt;
            }
            catch
            { return; }


        }
        private void cob_qtrycap_SelectedIndexChanged(object sender, EventArgs e)
        {         
                TT_User_Pass((byte)cob_qtrycap.SelectedIndex); 
        }

        private void TT_User_Pass(byte n)
        {
            txt_password.Clear();
            txt_username.Clear();
            if(n == 0)
            {
                txt_password.Enabled = false;
                txt_username.Enabled = false;
            }
            else
            {
                txt_password.Enabled = true;
                txt_username.Enabled = true;
            }
           
        }

        
    }
}
