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
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            string myConnectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";
            using (MySqlConnection conn = new MySqlConnection(myConnectionString))
            {
                string sql = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Set the parameters
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Username not found.");
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
                sql = "UPDATE users SET password = @password WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // Set the parameters
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Recovery Succesfully!");
                        }
                        else
                        {
                            MessageBox.Show("Account Recovery Failed!");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            // Clear the textboxes after saving
            usernameTxtBox.Clear();
            passwordTxtBox.Clear();

            //go back to the login Form
            var login = new LogIn();
            this.Hide();
            login.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var login = new LogIn();
            this.Hide();
            login.Show();
        }
    }
}
