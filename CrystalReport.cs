using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPhase2
{
    public partial class CrystalReport : Form
    {
        Media cr1;
        Album a1;
        public CrystalReport()
        {
            InitializeComponent();
        }

        private void crystalReport11_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CrystalReport_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr1 = new Media();
            crystalReportViewer1.ReportSource = cr1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1 = new Album();
            crystalReportViewer1.ReportSource = a1;
        }
    }
}
