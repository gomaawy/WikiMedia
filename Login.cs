using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace DBPhase2
{ 
    public partial class Login : Form
    {
        public static string CurrentEmail;
        public static int userid;
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Log_button_Click(object sender, EventArgs e)
        {
            //Check if this user exists
            OracleCommand C = new OracleCommand();
            C.Connection = con;
            C.CommandText = "select EMAIL, Password, User_ID from users where EMAIL=:mail and Password=:pass";
            C.CommandType = CommandType.Text;
            C.Parameters.Add("mail", EMail_Txt.Text.ToString());
            C.Parameters.Add("pass", Password_Txt.Text.ToString());
            OracleDataReader r = C.ExecuteReader();
            if (r.Read())
            {
                CurrentEmail = EMail_Txt.Text.ToString();
                userid = Convert.ToInt32(r[2]);
                Home H = new Home();
                H.Show();
            }
            else MessageBox.Show("E-Mail or Password is incorrect");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration Reg = new Registration();
            Reg.Show();
        }
    }
}
