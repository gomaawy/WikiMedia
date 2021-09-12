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
    public partial class MainForm : Form
    {
        OracleConnection con;
        string ordb = "Data Source = orcl; User Id = HR; Password = HR;";
        OracleDataAdapter adapter;
        DataSet set;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DGV category
            string constr = "Data Source = orcl; User Id = HR; Password = HR;";
            string cmdstr = "select Name from Category";
            adapter = new OracleDataAdapter(cmdstr, constr);
            set = new DataSet();
            adapter.Fill(set);
            CategoriesDGV.DataSource = set.Tables[0];

            //DGV happened this day
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "ThisDay";
            c.CommandType = CommandType.StoredProcedure;           
            c.Parameters.Add("datee", DateTime.Now.ToString("dd-MMM-yyyy"));
            c.Parameters.Add("Name", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader d = c.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Columns.Add("Name");
            while (d.Read())
            {
                table1.Rows.Add(d[0]);
            }
            HappenedDGV.DataSource = table1;
            d.Close();
            con.Close();
        }
        private void CategoriesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ThisDay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Opens login form
            Login LoginShow = new Login();
            LoginShow.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //Opens registration form
            Registration Reg = new Registration();
            Reg.Show();
        }

        private void CategoriesDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Opens search form
            Search searchh = new Search();
            searchh.Show();
        }

        private void HappenedDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opens crystal report
            CrystalReport cr = new CrystalReport();
            cr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
