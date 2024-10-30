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

namespace LetsGrowApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection("Server=tcp:st10435769db1.database.windows.net,1433;Initial Catalog=Group3;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=Active Directory Default;"))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                {
                    checkCommand.Parameters.AddWithValue("@Username", username);
                    int userExists = (int)checkCommand.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;
                    }
                }

                // Insert new user
                string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password); // Consider hashing passwords for security
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Registration successful! You can now log in.");

            // Navigate to Login Form after successful registration
            this.Hide(); // Hide the registration form
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Show the login form
        }
        private void btnLogin_Click(object sender, EventArgs e) 
            {
            MainForm main = new MainForm();
            main.Show();    
            this.Hide();
            }


        }
    }
