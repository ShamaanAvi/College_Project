using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class fSearch : Form
    {
        public fSearch()
        {
            InitializeComponent();
        }

        private void fSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string usernameID = txtUsernameID.Text;

            // Retrieve the roleID from the database based on the provided usernameID
            int roleID = GetRoleIDFromDatabase(usernameID);

            if (roleID != 1)
            {
                // Query the data for roleID 1 (Librarian) and display it in the data grid view
                string query = $"SELECT userID, userName, Address FROM Users WHERE userID = '{usernameID}' OR userName = '{usernameID}'";

                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost; Initial Catalog=DIPLOMA; Persist Security Info=True; User ID=sa; Password=1Secure*Password1"))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Create a SqlCommand object with the query and connection
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Create a DataTable to hold the query results
                            DataTable dt = new DataTable();
                            dt.Load(command.ExecuteReader());

                            // Display the results in the data grid view
                            dgQuery.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("The menu only shows lender details");
            }
        }

        private int GetRoleIDFromDatabase(string usernameID)
        {
            int roleID = 0;

            string query = $"SELECT roleID FROM Users WHERE userID = '{usernameID}' OR userName = '{usernameID}'";

            using (SqlConnection connection = new SqlConnection(@"Data Source=localhost; Initial Catalog=DIPLOMA; Persist Security Info=True; User ID=sa; Password=1Secure*Password1"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int parsedRoleID))
                {
                    roleID = parsedRoleID;
                }
            }

            return roleID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create a new instance of the fUserDetail form
            fUserDetail userDetailForm = new fUserDetail();
            // Show the User detail form
            userDetailForm.Show();

            // Hide the User Detail form
            this.Hide();
        }
    }
}