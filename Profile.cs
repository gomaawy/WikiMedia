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
    public partial class Profile : Form
    {
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        public Profile()
        {
            InitializeComponent();
        }
        
        private void Profile_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where User_ID=:userr";
            cmd.Parameters.Add("userr", Login.userid);
            OracleDataReader r = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("User_ID");
            table.Columns.Add("EMAIL");
            table.Columns.Add("Password");
            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");
            table.Columns.Add("BirthDate");
            table.Columns.Add("Gender");
            table.Columns.Add("MobileNumber");
            while(r.Read())
            {
                table.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
            }
            UserInfoDGV.DataSource = table;
            UserInfoDGV.Columns["USER_ID"].Visible = false;
            UserInfoDGV.Columns["EMAIL"].ReadOnly = true;
            UserInfoDGV.Columns["Gender"].ReadOnly = true;
            UserInfoDGV.Columns["BirthDate"].ReadOnly = true;
            con.Close();
            r.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update users set EMAIL=:em,password=:pass,FirstName=:fn,LastName=:ln,Gender=:gn,MobileNumber=:mn where User_ID=:userid";
            cmd.Parameters.Add("em",UserInfoDGV.Rows[0].Cells["EMAIL"].Value);
            cmd.Parameters.Add("pass", UserInfoDGV.Rows[0].Cells["Password"].Value);
            cmd.Parameters.Add("fn", UserInfoDGV.Rows[0].Cells["FirstName"].Value);
            cmd.Parameters.Add("ln", UserInfoDGV.Rows[0].Cells["LastName"].Value);
            cmd.Parameters.Add("gn", UserInfoDGV.Rows[0].Cells["Gender"].Value);
            cmd.Parameters.Add("mn", UserInfoDGV.Rows[0].Cells["MobileNumber"].Value);
            cmd.Parameters.Add("userid", UserInfoDGV.Rows[0].Cells["User_ID"].Value);
            cmd.ExecuteNonQuery();          
            MessageBox.Show("Updated successfully");
            con.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            DialogResult A = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (A == DialogResult.Yes)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from users where EMail=:e";
                cmd.Parameters.Add("e", Login.CurrentEmail);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account deleted successfully");
                UserInfoDGV.Columns.Clear();
            }
            con.Close();
        }
    }
}
