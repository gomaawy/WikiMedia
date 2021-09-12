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
    public partial class AddMedia : Form
    {
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        public int directorid;
        public int mediaid;
        List<int> actorsid;
        List<int> categoriesid;
        public AddMedia()
        {
            InitializeComponent();
        }

        private void AddMedia_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from actor";
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Actor_CB.Items.Add(r[0]);
            }
            r.Close();
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandType = CommandType.Text;
            c.CommandText = "select name from category";
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                Category_CB.Items.Add(dr[0]);
            }
            dr.Close();
            OracleCommand cm = new OracleCommand();
            cm.Connection = con;
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select name from director";
            OracleDataReader dd = cm.ExecuteReader();
            while (dd.Read())
            {
                comboBox1.Items.Add(dd[0]);
            }
            dd.Close();
            con.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actorsid = new List<int>();
            categoriesid = new List<int>();
            con = new OracleConnection(ordb);
            con.Open();
           
            for (int i = 0; i < Actor_CB.CheckedItems.Count; i++)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Actor_ID from actor where Name=:nam";
                cmd.Parameters.Add("nam", Actor_CB.CheckedItems[i].ToString());
                OracleDataReader d = cmd.ExecuteReader();
                if (d.Read())
                    actorsid.Add(Convert.ToInt32(d[0]));
                d.Close();
            }

            for (int i = 0; i < Category_CB.CheckedItems.Count; i++)
            {
                OracleCommand cm = new OracleCommand();
                cm.Connection = con;
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select Category_ID from category where Name=:namee";
                cm.Parameters.Add("namee", Category_CB.CheckedItems[i].ToString());
                OracleDataReader dr = cm.ExecuteReader();
                if (dr.Read())
                    categoriesid.Add(Convert.ToInt32(dr[0]));
                dr.Close();
            }
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandType = CommandType.Text;
            c.CommandText = "insert into Media Values(MediaSeq.nextval,:dire,:userr,:Namee,:Typee,:Descriptionn,To_Date(:ReleaseDatee,'yyyy/MM/dd'),:Ratee,NULL)";
            c.Parameters.Add("dire", directorid);
            c.Parameters.Add("userr", Login.userid);
            c.Parameters.Add("Namee", Name_Txt.Text);
            c.Parameters.Add("Typee", Type_txt.SelectedItem.ToString());
            c.Parameters.Add("Descriptionn", Description_Txt.Text);
            c.Parameters.Add("ReleaseDatee", ReleaseDate_Txt.Text);
            c.Parameters.Add("Ratee", Convert.ToInt32(Rate_Txt.Text));
            c.ExecuteNonQuery();
            MessageBox.Show("Media Added Successfully");
            OracleCommand mi = new OracleCommand();
            mi.Connection = con;
            mi.CommandType = CommandType.Text;
            mi.CommandText = "select Media_ID from Media where name=:namee";
            mi.Parameters.Add("namee", Name_Txt.Text);
            OracleDataReader dd = mi.ExecuteReader();
            if (dd.Read())
                mediaid = Convert.ToInt32(dd[0]);
            for (int i = 0; i < Actor_CB.CheckedItems.Count; i++)
            {
                OracleCommand am = new OracleCommand();
                am.Connection = con;
                am.CommandType = CommandType.Text;
                am.CommandText = "insert into Actor_Media values(:actorid,:mediaid)";
                am.Parameters.Add("actorid", actorsid[i]);
                am.Parameters.Add("mediaid", mediaid);
                am.ExecuteNonQuery();                
            }
            for (int i = 0; i < Category_CB.CheckedItems.Count; i++)
            {
                OracleCommand a = new OracleCommand();
                a.Connection = con;
                a.CommandType = CommandType.Text;
                a.CommandText = "insert into Media_Category values(:mediaid,:categoryid)";
                a.Parameters.Add("mediaid", mediaid);
                a.Parameters.Add("categoryid", categoriesid[i]);
                a.ExecuteNonQuery();
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cb = new OracleCommand();
            cb.Connection = con;
            cb.CommandType = CommandType.Text;
            cb.CommandText = "select Director_ID from director where name=:namee";
            cb.Parameters.Add("namee", comboBox1.SelectedItem.ToString());
            OracleDataReader d = cb.ExecuteReader();
            if (d.Read())
                directorid = Convert.ToInt32(d[0]);              
            d.Close();
        }
    }
}
