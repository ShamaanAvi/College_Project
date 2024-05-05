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
    public partial class fUserDetail : Form
    {
        public fUserDetail()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1");



        private void btnStuView_Click(object sender, EventArgs e)
        {

            // Get the userID from the UserID property
            int userID = fLogin.UserID;

            // SQL query to retrieve username and address based on userID
            string query = $"SELECT userName, Address FROM Users  WHERE Users.userID = {userID}";




            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1"))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a DataTable to hold the query resul=s
                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());

                        // Display the results in the data grid view
                        dgStuUserDet.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void fStudentDetail_Load(object sender, EventArgs e)
        {

            int roleID = fLogin.RoleID;
            // Hide btnAdvance for roleIDs 2, 3, and 4
            if (roleID != 1)
            {
                btnAdvance.Visible = false;
                bgExtra.Visible = false;
            }


            // Hide btnSearch for roleID 4
            if (roleID == 4)
            {
                btnSearch.Visible = false;
                
            }

        }

        private void btnStuUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve the updated name and address from the text boxes
            string newName = txtStuUserDet.Text;
            string newAddress = txtStuAddressDet.Text;
            string newPassword = txtNewPassword.Text;

            // Retrieve the userID from the login form
            int userID = fLogin.UserID;

            // Create the update query
            string updateQuery = "UPDATE Users SET ";
            List<string> updateFields = new List<string>();

            // Check if the name field is not empty and add it to the update query
            if (!string.IsNullOrEmpty(newName))
                updateFields.Add($"userName = '{newName}'");

            // Check if the address field is not empty and add it to the update query
            if (!string.IsNullOrEmpty(newAddress))
                updateFields.Add($"Address = '{newAddress}'");

            // Check if the password field is not empty and add it to the update query
            if (!string.IsNullOrEmpty(newPassword))
                updateFields.Add($"password = '{newPassword}'");

            // Combine the update fields into a single string
            string updateFieldsString = string.Join(", ", updateFields);

            // Check if any fields are being updated
            if (!string.IsNullOrEmpty(updateFieldsString))
            {
                // Construct the final update query
                updateQuery += updateFieldsString;
                updateQuery += $" WHERE userID = '{userID}'";

                // Create a SqlConnection object
                using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1"))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Create a SqlCommand object with the update query and connection
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Execute the update query
                            command.ExecuteNonQuery();

                            // Show a success message
                            MessageBox.Show("User data updated successfully!");
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
                // No fields to update
                MessageBox.Show("No changes to update.");
            }
        }

        private void btnStuBack_Click(object sender, EventArgs e)
        {
            // Go back to Login Form
            fUser studentForm = new fUser();
            studentForm.Show();

            // Hide the User Details form
            this.Hide();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            // Go back to Librarian Form
            fAdvanced librarianForm = new fAdvanced();
            librarianForm.Show();

            // Hide the User Details form
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Create a new instance of the fUser form
            fSearch searchForm = new fSearch();
            // Show the Search detail form
            searchForm.Show();

            // Hide the Search form
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Go back to Lend Form
            fLend lendForm = new fLend();
            lendForm.Show();

            // Hide the User Details form
            this.Hide();
        }
    }
}
