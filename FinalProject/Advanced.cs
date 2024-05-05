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
    public partial class fAdvanced : Form
    {
        public fAdvanced()
        {
            InitializeComponent();
        }
        private int GetRoleIDFromListBox()
        {
            string selectedRole = lbRID.SelectedItem.ToString();

            switch (selectedRole)
            {
                case "Librarian":
                    return 1;
                case "Professor":
                    return 2;
                case "Lecturer":
                    return 3;
                case "Student":
                    return 4;
                default:
                    throw new Exception("Invalid role selected");
            }
        }

        private void AddUserToDatabase()
        {
            // Get the values from the form controls
            string userID = txtUID.Text;
            string userName = txtUname.Text;
            string password = txtPass.Text;
            string address = txtAdd.Text;
            int roleID = GetRoleIDFromListBox();

            // Create the SQL INSERT statement
            string insertQuery = "INSERT INTO Users (userID, userName, password, Address, roleID) VALUES ('" +userID+"','"+userName+"','"+password+"','"+address+"',"+roleID+")";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1"))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand object with the insert query and connection
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Execute the insert query
                        command.ExecuteNonQuery();

                        // Show a success message
                        MessageBox.Show("User added successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AddBookToDatabase()
        {
            // Get the values from the form controls
            int bookID = int.Parse(txtBID.Text);
            string bookName = txtBN.Text;
            string category = lbCat.SelectedItem.ToString();

            // Create the SQL INSERT statement
            string insertQuery = "INSERT INTO Book (bookID, bookName, cat) " +
                                 $"VALUES ({bookID}, '{bookName}', '{category}')";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1"))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand object with the insert query and connection
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Execute the insert query
                        command.ExecuteNonQuery();

                        // Show a success message
                        MessageBox.Show("Book added successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Go back to Login Form
            fUserDetail userDetailForm = new fUserDetail();
            userDetailForm.Show();

            // Hide the login form
            this.Hide();
        }

        private void fLibrarian_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUserToDatabase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBookToDatabase();
        }
    }
}
