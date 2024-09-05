using LoanCalculator.Forms;
using LoanCalculator.Properties;
using LoanCalculator.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class MainForm : Form
    {
        SqlConnection connection = Scripts.DataSettings.connection;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSimpleLoan_Click(object sender, EventArgs e)
        {
            Scripts.DataSettings.Tools = "Simple";

            SimpleForm sf = new SimpleForm();
            sf.Show();
            this.Close();
        }

        private void btnAdvanceLoan_Click(object sender, EventArgs e)
        {
            Scripts.DataSettings.Tools = "Advance";

            AdvanceForm af = new AdvanceForm();
            af.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmsLight_Click(object sender, EventArgs e)
        {
            Scripts.DataSettings.DarkMode = false;
        }

        private void cmsDark_Click(object sender, EventArgs e)
        {
            Scripts.DataSettings.DarkMode = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Scripts.DataSettings.DarkMode == true)
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void Step_Tick(object sender, EventArgs e)
        {
            if (Scripts.DataSettings.DarkMode == true)
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History his = new History();
            his.Show();
            this.Close();
        }
    }
}
