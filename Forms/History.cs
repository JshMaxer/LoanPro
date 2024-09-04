using MySql.Data.MySqlClient;
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

namespace LoanCalculator.Forms
{
    public partial class History : Form
    {
        SqlConnection connection = Scripts.DataSettings.connection;

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            Scripts.DataSettings.historyLoad(ViewHistory);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Scripts.DataSettings.historyClear(ViewHistory);
        }

        private void Step_Tick(object sender, EventArgs e)
        {
            if (Scripts.DataSettings.DarkMode == true)
            {
                this.BackColor = Color.FromArgb(33, 33, 33);
                ViewHistory.BackgroundColor = Color.FromArgb(33, 33, 33);
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
                ViewHistory.BackgroundColor = Color.FromArgb(255, 255, 255);
            }
        }
    }
}
