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
    public partial class ManageAlbums : Form
    {
        OracleDataAdapter adapterr;
        OracleCommandBuilder builderr;
        DataSet sett;
        public ManageAlbums()
        {
            InitializeComponent();
        }

        private void AddAlbum_Load(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id = HR; Password = HR;";
            string cmdstr = "select * from album where User_ID=:userr ";         
            adapterr = new OracleDataAdapter(cmdstr, constr);
            adapterr.SelectCommand.Parameters.Add("userr", Login.userid);
            sett = new DataSet();
            adapterr.Fill(sett);
            AlbumsDGV.DataSource = sett.Tables[0];
           // AlbumsDGV.ReadOnly = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
          
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            builderr = new OracleCommandBuilder(adapterr);
            adapterr.Update(sett.Tables[0]);
            MessageBox.Show("Data saved succesfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDGV.Rows.RemoveAt(AlbumsDGV.SelectedRows[0].Index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleDataAdapter adapter;
            DataSet set;
            string constt = "Data Source = orcl; User Id = HR; Password = HR;";
            string cmdst = "select albumseq.nextval from dual ";
            adapter = new OracleDataAdapter(cmdst, constt);
            set = new DataSet();
            adapter.Fill(set);
            DataRow row;
            row = sett.Tables[0].NewRow();
            row["Album_ID"] =Convert.ToInt32(set.Tables[0].Rows[0][0]);
            row["User_ID"] = Login.userid;
            sett.Tables[0].Rows.Add(row);
            AlbumsDGV.DataSource = sett.Tables[0];
            AlbumsDGV.ReadOnly = false;
        }
    }
}
