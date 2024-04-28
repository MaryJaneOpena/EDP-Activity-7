using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Books_InfoSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //signup button
        {
            string connectionString = "server=localhost;user=root;password=0511;database=books";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {
                    // Open the connection
                    connection.Open();

                    // Check if password and confirm password match
                    if (password.Text != confirmpass.Text)
                    {
                        MessageBox.Show("Password and Confirm Password do not match. Please try again.");
                        return; // Exit the method to prevent further execution
                    }

                    // Check if password is empty
                    if (string.IsNullOrEmpty(password.Text))
                    {
                        MessageBox.Show("Password cannot be empty. Please enter a password.");
                        return; // Exit the method to prevent further execution
                    }

                    // SQL command to check if the user exists
                    string checkUserSql = "SELECT COUNT(*) FROM users WHERE username = @username";

                    // Create a MySqlCommand object to check if the user exists
                    using (MySqlCommand checkUserCmd = new MySqlCommand(checkUserSql, connection))
                    {
                        // Set parameter value for username
                        checkUserCmd.Parameters.AddWithValue("@username", username.Text);

                        // Execute the command to check if the user exists
                        int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return; // Exit the method to prevent further execution
                        }
                    }

                    // SQL command to insert data into the database
                    string sql = "INSERT INTO users (username, password) VALUES (@value1, @value2)";

                    // Create a MySqlCommand object
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Set parameter values from textboxes
                        cmd.Parameters.AddWithValue("@value1", username.Text);
                        cmd.Parameters.AddWithValue("@value2", password.Text);
                        cmd.Parameters.AddWithValue("@value3", confirmpass.Text);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("You have successfully signed up!");
                        }
                        else
                        {
                            MessageBox.Show("No data inserted.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = new LogIn();
            this.Hide();
            login.Show();
        }

        private void hideLoginPass_Click(object sender, EventArgs e)
        {

        }

        private void showPass_Click(object sender, EventArgs e)
        {
            password.PasswordChar = '\0';
            showPass.Visible = false;
            hidePass.Visible = true;
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            showPass.Visible = true;
            hidePass.Visible = false;
        }

        private void showConfPass_Click(object sender, EventArgs e)
        {
            confirmpass.PasswordChar = '\0';
            showConfPass.Visible = false;
            hideConfPass.Visible = true;
        }

        private void hideConfPass_Click(object sender, EventArgs e)
        {
            confirmpass.PasswordChar = '*';
            showConfPass.Visible = true;
            hideConfPass.Visible = false;
        }
    }
}
