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
using System.Globalization;

namespace FinalProject
{
    public partial class fLend : Form
    {
        public fLend()
        {
            InitializeComponent();
        }

        private void Lend_Load(object sender, EventArgs e)
        {

        }

        private void UpdateRetDateInDatabase()
        {
            // Get the BookID and RetDate values from the form controls
            int bookID = int.Parse(txtBIDret.Text);
            DateTime retDate = DateTime.Parse(txtRet.Text);

            // Create the SQL UPDATE statement
            string updateQuery = $"UPDATE LendBook SET retDate = '{retDate}' WHERE bookID = {bookID} AND retDate IS NULL";

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
                        MessageBox.Show("Return updated successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRetDateInDatabase();

            // Get the bookID and retDate from the text boxes
            int bookID = int.Parse(txtBIDret.Text);
            DateTime retDate = DateTime.Parse(txtRet.Text);

            // Retrieve borDate from the LendBook table for the corresponding bookID
            DateTime borDate = RetrieveBorDateFromDatabase(bookID);

            // Calculate the difference between retDate and borDate
            TimeSpan difference = retDate - borDate;
            int daysDifference = (int)difference.TotalDays;

            // Check if the book is overdue (more than 14 days)
            if (daysDifference > 14)
            {
                // Calculate the fine
                int fineAmount = (daysDifference - 14) * 10;

                // Display the fine in a message box
                MessageBox.Show($"Fine: LKR {fineAmount}");
            }
        }

        private DateTime RetrieveBorDateFromDatabase(int bookID)
        {
            // TODO: Implement your database retrieval logic here
            // Use your preferred method (ADO.NET, Entity Framework, etc.) to execute the query and retrieve the borDate based on the provided bookID.

            // Example using ADO.NET:
            string query = $"SELECT borDate FROM LendBook WHERE bookID = {bookID}";

            using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                DateTime borDate = (DateTime)command.ExecuteScalar();
                return borDate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userID = txtUID.Text;
            string bookIDText = txtBIDbor.Text;
            string borDateText = txtBor.Text;

            // Validate and parse the entered values
            if (int.TryParse(bookIDText, out int bookID) &&
                DateTime.TryParse(borDateText, out DateTime borDate))
            {
                string insertQuery = $"INSERT INTO LendBook (userID, bookID, borDate) VALUES ('{userID}', {bookID}, '{borDate.ToString("yyyy-MM-dd")}')";

                using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert record.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid values for BookID and Borrow Date.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
