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
    public partial class fUser : Form
    {
        public fUser()
        {
            InitializeComponent();
        }

        private bool CanBorrowMoreBooks()
        {
            int userID = fLogin.UserID; // Get the user ID from the fLogin form's public variable

            string query = $"SELECT COUNT(*) FROM LendBook WHERE userID = {userID} AND retDate IS NULL";
            int booksBorrowed;

            using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    booksBorrowed = (int)command.ExecuteScalar();
                }
            }

            return booksBorrowed < 2;
        }

        SqlConnection con = new SqlConnection(@"Data Source = localhost; Initial Catalog = DIPLOMA; Persist Security Info=True;User ID = sa; Password=1Secure*Password1");

        private void Student_Load(object sender, EventArgs e)
        {
            
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            // Go back to Login Form
            fLogin loginForm = new fLogin();
            loginForm.Show();

            // Hide the login form
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the userID from the UserID property
            int userID = fLogin.UserID;

            // SQL query
            string query = "SELECT Users.userID, Users.userName, Users.Address, Book.bookID, Book.bookName, LendBook.borDate, LendBook.retDate " +
                           "FROM Users " +
                           "JOIN LendBook ON Users.UserID = LendBook.userID " +
                           "JOIN Book ON LendBook.bookID = Book.bookID" +
                           $" WHERE Users.userID = {userID} AND retDate is NULL" ;

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
                        // Create a DataTable to hold the query results
                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());

                        // Display the results in the data grid view
                        dataGStu.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void txtStuQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create instance for Login form
            fLogin loginForm = new fLogin();
            // Get the userID from the UserID property
            int userID = fLogin.UserID;

            DateTime currentDate = DateTime.Now;

            // SQL query
            string query = "SELECT Users.userID, Users.userName, Users.Address, Book.bookID, Book.bookName, LendBook.borDate, LendBook.retDate " +
                           "FROM Users, LendBook, Book " +
                           "WHERE Users.userID = LendBook.userID " +
                           "AND LendBook.bookID = Book.bookID " +
                           $"AND (DATEDIFF(DAY, LendBook.borDate, LendBook.retDate) >= 14 OR DATEDIFF(DAY, LendBook.borDate, GETDATE()) >= 14) " +
                           $"AND Users.userID = {userID} and LendBook.retDate is null";

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
                        // Create a DataTable to hold the query results
                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());

                        // Display the results in the data grid view
                        dataGStu.DataSource = dt;

                        // Calculate and display the fine
                        int fine = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            DateTime borDate = Convert.ToDateTime(row["borDate"]);
                            int dateDiff = (int)(currentDate - borDate).TotalDays;

                            if (dateDiff >= 14) 
                            {
                                
                                fine += (dateDiff -14)* 10;
                                
                            }
                        }
                        string message = $"Fine for Student ID {userID}:LKR {fine}";
                        MessageBox.Show(message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if the user can borrow more books
            if (!CanBorrowMoreBooks())
            {
                MessageBox.Show("Maximum books lent. Please return a book before borrowing another one.");
            }

            string strCat = "All";

            strCat = lbCat.SelectedItem.ToString();

            if (strCat == "All")
            {
                strCat = "%";
            }

            // SQL query
            string query = "SELECT Book.bookID, Book.bookName, Book.cat " +
                           "FROM Book " +
                           "WHERE Book.bookID NOT IN (" +
                           "    SELECT LendBook.bookID " +
                           "    FROM LendBook WHERE LendBook.retDate IS Null" +
                           ") AND Book.cat LIKE '%" + strCat + "%'";

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
                        // Create a DataTable to hold the query results
                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());

                        // Display the results in the data grid view
                        dataGStu.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create a new instance of the fStudentDetail form
            fUserDetail studentDetailForm = new fUserDetail();
            // Show the student detail form
            studentDetailForm.ShowDialog();

            // Hide the Student form
            this.Hide();
        }
    }
}
