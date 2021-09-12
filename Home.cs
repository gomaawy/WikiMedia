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
    public partial class Home : Form
    {
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Email_Label.Text = Login.CurrentEmail;
            con = new OracleConnection(ordb);
            con.Open();

            //DGV category
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Name from Category";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            while (dr.Read())
            {
                table.Rows.Add(dr[0]);
            }
            Categories_DGV.DataSource = table;
            dr.Close();

            //DGV happened this day
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select Name from Media where Release_Date=To_Date(:datee,'dd-MM-yyyy')";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("datee", DateTime.Now.ToString("dd/MM/yyyy"));
            OracleDataReader d = c.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Columns.Add("Name");
            while (d.Read())
            {
                table1.Rows.Add(d[0]);
            }
            ReleasedDGV.DataSource = table1;
            d.Close();
            con.Close();
        }

        private void Search_BT_Click(object sender, EventArgs e)
        {
            //Opens search form
            Search searchh = new Search();
            searchh.Show();
        }

        private void Profile_BT_Click(object sender, EventArgs e)
        {
            //Opens profile form 
            Profile P = new Profile();
            P.Show();
        }

        private void Post_BT_Click(object sender, EventArgs e)
        {
            //Add new media
            AddMedia A = new AddMedia();
            A.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add new artist
            AddArtist AR = new AddArtist();
            AR.Show();
        }

        private void AddAlbum_Button_Click(object sender, EventArgs e)
        {
            //Manages album
            ManageAlbums AA = new ManageAlbums();
            AA.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Edit media
            EditMedia EM = new EditMedia();
            EM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Opens crystal report form
            CrystalReport cr = new CrystalReport();
            cr.Show();
        }
    }
}
