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
    public partial class EditMedia : Form
    {
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        public EditMedia()
        {
            InitializeComponent();
        }

        private void EditMedia_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from media where User_ID=:userid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("userid", Login.userid);
            OracleDataReader r = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Media_ID");
            table.Columns.Add("Director_ID");
            table.Columns.Add("User_ID");
            table.Columns.Add("Name");
            table.Columns.Add("Type");
            table.Columns.Add("Description");
            table.Columns.Add("Release_Date");
            table.Columns.Add("Rate");
            table.Columns.Add("Poster");
            while (r.Read())
            {
                table.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7],r[8]);
            }
            MediainfoDGV.DataSource = table;
            MediainfoDGV.Columns["Media_ID"].Visible = false;
            MediainfoDGV.Columns["Director_ID"].Visible = false;
            MediainfoDGV.Columns["User_ID"].Visible = false;
            MediainfoDGV.Columns["Release_Date"].ReadOnly = true;
            con.Close();
            r.Close();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            con.Open();
            for (int i = 0; i < MediainfoDGV.Rows.Count - 1; i++)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "EditMedia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("medid", MediainfoDGV.Rows[i].Cells["Media_ID"].Value);
                cmd.Parameters.Add("nam", MediainfoDGV.Rows[i].Cells["Name"].Value);
                cmd.Parameters.Add("typ", MediainfoDGV.Rows[i].Cells["Type"].Value);
                cmd.Parameters.Add("descr", MediainfoDGV.Rows[i].Cells["Description"].Value);
                cmd.Parameters.Add("Ratee", MediainfoDGV.Rows[i].Cells["Rate"].Value);
                cmd.ExecuteNonQuery();              
            }
            MessageBox.Show("Updated successfully");
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "DeleteMedia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Mediaid", MediainfoDGV.Rows[MediainfoDGV.CurrentCell.RowIndex].Cells["Media_ID"].Value);
            cmd.ExecuteNonQuery();
            MediainfoDGV.Rows.RemoveAt(MediainfoDGV.CurrentCell.RowIndex);
            MessageBox.Show("Media deleted successfully");
            con.Close();
        }
    }
}
