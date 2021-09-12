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
    public partial class AddArtist : Form
    {
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet set;
        public AddArtist()
        {
            InitializeComponent();
        }

        private void AddArtist_Load(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id = HR; Password = HR;";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Type_CB.SelectedItem.ToString() == "Actor")
            {
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "AddActor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Name", Name_Txt.Text);
                cmd.Parameters.Add("Birthdate",BirthDate_Txt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actor added successfully");
            }
            else if (Type_CB.SelectedItem.ToString() == "Director")
            {
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "AddDirector";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Name", Name_Txt.Text);
                cmd.Parameters.Add("Birthdate", BirthDate_Txt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Director added successfully");
            }
            else
            {
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand c = new OracleCommand();
                c.Connection = con;
                c.CommandText = "AddSinger";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("Name", Name_Txt.Text);
                c.Parameters.Add("Birthdate", BirthDate_Txt.Text);
                c.ExecuteNonQuery();
                MessageBox.Show("Singer added successfully");
            } 
        }
    }
}
