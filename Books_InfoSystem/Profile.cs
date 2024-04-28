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

namespace Books_InfoSystem
{
    public partial class Profile : Form
    {
        private string user;
        public Profile()
        {
            InitializeComponent();
        }

        public Profile(string username)
        {
            InitializeComponent();
            this.user = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard("Username");
            this.Hide();
            dashboard.Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var author = new Author();
            this.Hide(); 
            author.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var genre = new Genre();
            this.Hide();
            genre.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=0511;database=books";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // SQL command to select data from the database based on the logged-in user's username
                    string sql = "SELECT username, name, contact FROM users WHERE username = @username";

                    // Create a MySqlCommand object
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Set parameter value for username (assuming loggedInUsername is the username of the authenticated user)
                        //cmd.Parameters.AddWithValue("@username", loggedInUsername);

                        // Execute the command and get a MySqlDataReader
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if the reader has any rows
                            if (reader.Read())
                            {
                                // Set the text property of the textboxes with the retrieved values
                                usernameTextBox.Text = reader["username"].ToString();
                                nameTextBox.Text = reader["name"].ToString();
                                contactTextBox.Text = reader["contact"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";

            // Create a MySqlConnection object
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Open the connection
                conn.Open();

                // Set the status to 0 for the logged-in user
                string updateSql = "UPDATE users SET status = 0 WHERE username = @username";
                MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                updateCmd.Parameters.AddWithValue("@username", UserInfo.Username);
                updateCmd.ExecuteNonQuery();

                // Navigate to the login form
                var login = new LogIn();
                this.Hide();
                login.Show();
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // Fetch name and contact from the database using the username value
            string username = UserInfo.Username;
            MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT name, contact FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nameTextBox.Text = reader["name"].ToString();
                    contactTextBox.Text = reader["contact"].ToString();
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Display the username
            usernameTextBox.Text = username;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            //username.Text = user;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            usernameTextBox.ReadOnly = false;
            editUsername.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Get the updated name, contact, and username information from the textboxes
            string name = nameTextBox.Text;
            string contact = contactTextBox.Text;
            string newUsername = usernameTextBox.Text; // Get the new username from the textbox

            // Update the table with the new information
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";
            using (MySqlConnection conn = new MySqlConnection(myConnectionString))
            {
                string sql = "UPDATE users SET name = @name, contact = @contact, username = @newUsername WHERE username = @oldUsername";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Set the parameters
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@newUsername", newUsername);
                    cmd.Parameters.AddWithValue("@oldUsername", UserInfo.Username); // Use the old username from UserInfo

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully.");
                            // Update the UserInfo.Username with the new username
                            UserInfo.Username = newUsername;
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Profile update failed.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Make textboxes read-only after saving
            usernameTextBox.ReadOnly = true;
            editUsername.Visible = true;
            editName.Visible = true;
            editContact.Visible = true;
            nameTextBox.ReadOnly = true;
            contactTextBox.ReadOnly = true;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nameTextBox.ReadOnly = false;
            editName.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            contactTextBox.ReadOnly = false;
            editContact.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Reload the original values from the database
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";
            using (MySqlConnection conn = new MySqlConnection(myConnectionString))
            {
                string sql = "SELECT username, name, contact FROM users WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Set the parameter
                    cmd.Parameters.AddWithValue("@username", UserInfo.Username); // Use the username from UserInfo

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set the original values in the textboxes
                                usernameTextBox.Text = reader.GetString("username");
                                nameTextBox.Text = reader.GetString("name");
                                contactTextBox.Text = reader.GetString("contact");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Make textboxes read-only after canceling
            usernameTextBox.ReadOnly = true;
            nameTextBox.ReadOnly = true;
            contactTextBox.ReadOnly = true;
            editUsername.Visible = true;
            editName.Visible = true;
            editContact.Visible = true;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
        }

        private void savePassBtn_Click(object sender, EventArgs e)
        {
            string currentPassword = currentTxtBox.Text;
            string newPassword = newPassTxtBox.Text;
            string confirmPassword = confPassTxtBox.Text;

            // Validate if new password and confirmation password match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation password do not match.");
                return;
            }

            // Validate if current password matches the password stored in the database
            string username = UserInfo.Username;
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";
            using (MySqlConnection conn = new MySqlConnection(myConnectionString))
            {
                string sql = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Set the parameters
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", currentPassword);

                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Incorrect current password.");
                            return;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

                // Update the password in the database
                sql = "UPDATE users SET password = @newPassword WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Set the parameters
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Password update failed.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Clear the textboxes after saving
            currentTxtBox.Clear();
            newPassTxtBox.Clear();
            confPassTxtBox.Clear();
        }


        private void cancelPass_Click(object sender, EventArgs e)
        {
            currentTxtBox.Clear();
            newPassTxtBox.Clear();
            confPassTxtBox.Clear();
        }
    }
}
