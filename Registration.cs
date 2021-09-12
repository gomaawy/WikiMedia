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
    public partial class Registration : Form
    {
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        public Registration()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add new user
            OracleCommand C = new OracleCommand();
            C.Connection = con;
            C.CommandText = "insert into users values(userseq.nextval,:Mail, :Pass,:FName, :LName, To_Date(:Birth,'yyyy/mm/dd') , :Gen, :Mob)";
            C.CommandType = CommandType.Text;        
            try
            {
                C.Parameters.Add("Mail", Email_txt.Text);
                C.Parameters.Add("Pass", Password_txt.Text);
                C.Parameters.Add("FName", FirstName_txt.Text);
                C.Parameters.Add("LName", LastName_txt.Text);
                C.Parameters.Add("Birth", Date_Txt.Text);
                C.Parameters.Add("Gen", Gender_CB.SelectedItem.ToString());
                C.Parameters.Add("Mob", PhoneNo_Txt.Text);
                C.ExecuteNonQuery();
                MessageBox.Show("Registeration successful");       
            }
            catch
            {
                MessageBox.Show("Wrong information");
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }
    }
}
