using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data;

namespace LoanCalculator.Scripts
{
    public class DataSettings
    {
        //Database
        public static string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\joshu\\source\\repos\\LoanCalculator\\History.mdf;Integrated Security=True";

        public static SqlConnection connection = new SqlConnection(ConnectionString);

        //Settings
        public static bool DarkMode = false;

        //History
        public static string Tools = "";

        //Simple
        public static void simple(Guna2TextBox amount, Guna2TextBox term, Guna2TextBox monthly)
        {
            //Insert Query
            string InsertQuery = $"INSERT INTO History VALUES ('{Tools}', +'{amount.Text}', + 'N/A', + '{term.Text}', + 'N/A', + '{monthly.Text}')";
            connection.Close();
            connection.Open();
            SqlCommand cmd = new SqlCommand(InsertQuery, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //Advance
        public static void advance(Guna2TextBox amount, Guna2TextBox rate, Guna2TextBox term, Guna2TextBox down, Guna2TextBox monthly)
        {
            //Insert Query
            string InsertQuery = $"INSERT INTO History VALUES ('{Tools}', + '{amount.Text}', + '{rate.Text}', + '{term.Text}', + '{down.Text}', + '{monthly.Text}')";
            connection.Close();
            connection.Open();
            SqlCommand cmd = new SqlCommand(InsertQuery, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //History Load
        public static void historyLoad(Guna2DataGridView ViewHistory)
        {
            try
            {
                connection.Close();
                connection.Open();
                string query = "SELECT * FROM History"; // Replace with your table name and column name
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ViewHistory.DataSource = dataTable;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            connection.Close();
        }

        //History clear
        public static void historyClear(Guna2DataGridView ViewHistory)
        {
            string deleteQuery = "DELETE FROM History";
            connection.Close();
            connection.Open();
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
            deleteCmd.ExecuteNonQuery();

            //Select
            historyLoad(ViewHistory);

            connection.Close();
        }
    }
}
