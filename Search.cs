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
    public partial class Search : Form
    {
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void Search_Txt_TextChanged(object sender, EventArgs e)
        {
            Search_LB.Items.Clear();
            if (string.IsNullOrEmpty(Search_Txt.Text))
                Search_LB.Items.Clear();
            else
            {
                con = new OracleConnection(ordb);
                con.Open();
                if (Type_CB.SelectedItem.ToString() == "Media")
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    string txt = Search_Txt.Text;
                    cmd.CommandText = "select Name from Media where Name like '%'||:Namee||'%'";
                    cmd.Parameters.Add("Namee", txt);
                    OracleDataReader Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        Search_LB.Items.Add(Dr[0]);
                    }
                    Dr.Close();
                }
                else
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    string txt = Search_Txt.Text;
                    cmd.CommandText = "select Name from Album where Name like '%'||:Namee||'%'";
                    cmd.Parameters.Add("Namee", txt);
                    OracleDataReader Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        Search_LB.Items.Add(Dr[0]);
                    }
                    Dr.Close();
                }
                con.Close();
            }
        }

        private void Search_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            if (Type_CB.SelectedItem.ToString() == "Media")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Name,Type,Description,Release_Date,Rate from Media where Name=:Namee";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("Namee", Search_LB.SelectedItem.ToString());
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Name");
                table.Columns.Add("Type");
                table.Columns.Add("Description");
                table.Columns.Add("Release_Date");
                table.Columns.Add("Rate");
                while (dr.Read())
                {
                    table.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
                }
                Information_DGV.DataSource = table;
            }
            else
            {
                OracleCommand c = new OracleCommand();
                c.Connection = con;
                c.CommandText = "LoadData";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("Namee", Search_LB.SelectedItem.ToString());
                c.Parameters.Add("NumberOfSongs",OracleDbType.Int32, ParameterDirection.Output);
                c.Parameters.Add("ReleaseDate", OracleDbType.Date,ParameterDirection.Output);
                c.ExecuteNonQuery();
                DataTable table = new DataTable();
                table.Columns.Add("Name");
                table.Columns.Add("NumberOfSongs");
                table.Columns.Add("ReleaseDate");
                table.Rows.Add(c.Parameters["Namee"].Value.ToString(), c.Parameters["NumberOfSongs"].Value.ToString(), c.Parameters["ReleaseDate"].Value.ToString());
                Information_DGV.DataSource = table;
            }
        }
    }
}
