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
    public partial class SimpleForm : Form
    {
        SqlConnection connection = Scripts.DataSettings.connection;

        public SimpleForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the input values
                decimal loanAmount = decimal.Parse(txtAmount.Text);
                int loanTerm = int.Parse(txtTerm.Text) * 12; // Convert years to months

                // No interest rate in simple mode; assume 0% for simplicity
                decimal monthlyPayment = loanAmount / loanTerm;

                // Display the result
                txtMonthly.Text = $"₱{monthlyPayment:F2}";

                //Database
                Scripts.DataSettings.simple(txtAmount, txtTerm, txtMonthly);
            }
            catch (Exception)
            {

               // Catch the error
            }
           
        }

        private void Step_Tick(object sender, EventArgs e)
        {
            if (DataSettings.DarkMode == true)
            {
                this.BackColor = Color.FromArgb(33, 33, 33);

                label1.ForeColor = Color.FromArgb(255, 255, 255);
                label2.ForeColor = Color.FromArgb(255, 255, 255);
                label3.ForeColor = Color.FromArgb(255, 255, 255);

                txtAmount.FillColor = Color.FromArgb(64, 64, 64);
                txtAmount.ForeColor = Color.FromArgb(255, 255, 255);

                txtTerm.FillColor = Color.FromArgb(64, 64, 64);
                txtTerm.ForeColor = Color.FromArgb(255, 255, 255);

                txtMonthly.FillColor = Color.FromArgb(64, 64, 64);
                txtMonthly.ForeColor = Color.FromArgb(255, 255, 255);

            }
            else
            {
                this.BackColor = Color.FromArgb(255, 255, 255);

                label1.ForeColor = Color.FromArgb(8, 8, 8);
                label2.ForeColor = Color.FromArgb(8, 8, 8);
                label3.ForeColor = Color.FromArgb(8, 8, 8);

                txtAmount.FillColor = Color.FromArgb(255, 255, 255);
                txtAmount.ForeColor = Color.FromArgb(8, 8, 8);

                txtTerm.FillColor = Color.FromArgb(255, 255, 255);
                txtTerm.ForeColor = Color.FromArgb(8, 8, 8);

                txtMonthly.FillColor = Color.FromArgb(255, 255, 255);
                txtMonthly.ForeColor = Color.FromArgb(8, 8, 8);

            }
        }

        private void cmsLight_Click(object sender, EventArgs e)
        {
            Scripts.DataSettings.DarkMode = false;
        }

        private void cmsDark_Click(object sender, EventArgs e)
        {
            Scripts.DataSettings.DarkMode = true;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
