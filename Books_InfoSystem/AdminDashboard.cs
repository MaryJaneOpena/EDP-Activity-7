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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Load user accounts when the form loads
            LoadUserAccounts();
        }

        private void LoadUserAccounts()
        {
            // Clear any existing data in the DataGridView
            dataGridView1.Rows.Clear();

            // Query to select all user accounts
            string query = "SELECT username, password, name, contact, acc_type, status FROM users";

            // Connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create a MySqlCommand object
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the query and retrieve the data
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there are rows in the result set
                        if (reader.HasRows)
                        {
                            // Loop through each row in the result set
                            while (reader.Read())
                            {
                                // Get the boolean value of the status column
                                bool isActive = reader.GetBoolean("status");

                                // Convert the boolean value to a string representation
                                string status = isActive ? "Active" : "Inactive";

                                // Add a new row to the DataGridView
                                dataGridView1.Rows.Add(reader.GetString("username"), reader.GetString("password"), reader.GetString("name"), reader.GetString("contact"), reader.GetString("acc_type"), status);
                            }
                        }
                    }
                }
            }
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            formAccount.Visible = true;
            saveAddAccBtn.Visible = true;
            SaveEditAccBtn.Visible = false;
            addAccLabel.Visible = true;
            editAccLabel.Visible = false;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            saveAddAccBtn.Visible=false;
            SaveEditAccBtn.Visible=true;
            addAccLabel.Visible = false;
            editAccLabel.Visible = true;
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                formAccount.Visible = true;

                // Populate the TextBoxes with the values of the selected row
                usernameTxtBx.Text = selectedRow.Cells["Username"].Value.ToString();
                nameTxtBx.Text = selectedRow.Cells["Name"].Value.ToString();
                contactTxtBx.Text = selectedRow.Cells["Contacts"].Value.ToString();
                passTxtBx.Text = selectedRow.Cells["Password"].Value.ToString();
                typeTxtBx.Text = selectedRow.Cells["acc_type"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        // Event handler for deleting selected record
        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the username of the selected row
                string username = selectedRow.Cells["Username"].Value.ToString();

                // Perform the database operation to delete the selected record
                string connectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";
                string query = "DELETE FROM users WHERE username = @username";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@username", username);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Remove the selected row from the DataGridView
                                dataGridView1.Rows.Remove(selectedRow);
                                MessageBox.Show("Record deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No records deleted.");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error deleting record: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Users_Click(object sender, EventArgs e)
        {

        }

        private void usersList_Click(object sender, EventArgs e)
        {

        }

        private void savePassBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBx.Text;
            string name = nameTxtBx.Text;
            string contact = contactTxtBx.Text;
            string password = passTxtBx.Text;
            string type = typeTxtBx.Text;
            // Create a connection string
            string connectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";

            // Create an SQL INSERT statement
            string query = "INSERT INTO users (username, name, contact, password, acc_type) VALUES (@username, @name, @contact, @password, @type)";

            // Create a MySqlConnection object
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create a MySqlCommand object
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@contact", contact);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@type", type);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the data was successfully added
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data added successfully.");
                            formAccount.Visible = false;
                            LoadUserAccounts();

                            // Clear the TextBoxes
                            usernameTxtBx.Clear();
                            nameTxtBx.Clear();
                            contactTxtBx.Clear();
                            passTxtBx.Clear();
                            typeTxtBx.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Failed to add data.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Check if the exception is due to a duplicate username
                        if (ex.Number == 1062)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                        }
                        else
                        {
                            MessageBox.Show("Error adding data: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void cancelPass_Click(object sender, EventArgs e)
        {
            formAccount.Visible = false;
            LoadUserAccounts();

            // Clear the TextBoxes
            usernameTxtBx.Clear();
            nameTxtBx.Clear();
            contactTxtBx.Clear();
            passTxtBx.Clear();
            typeTxtBx.Clear();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadUserAccounts();
        }

        private void SaveEditAccBtn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the values from the TextBoxes
                string username = usernameTxtBx.Text;
                string name = nameTxtBx.Text;
                string contact = contactTxtBx.Text;
                string password = passTxtBx.Text;
                string type = typeTxtBx.Text;

                // Create a connection string
                string connectionString = "server=127.0.0.1;uid=root;pwd=0511;database=books";

                // Create an SQL UPDATE statement
                string query = "UPDATE users SET username = @newUsername, name = @name, contact = @contact, password = @password, acc_type = @type WHERE username = @oldUsername";

                // Create a MySqlConnection object
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Create a MySqlCommand object
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@newUsername", username);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@contact", contact);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@type", type);
                        command.Parameters.AddWithValue("@oldUsername", selectedRow.Cells["Username"].Value.ToString()); // Use the old username for the WHERE clause

                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Execute the command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the data was successfully updated
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data updated successfully.");
                                LoadUserAccounts();
                                formAccount.Visible = false;
                                usernameTxtBx.Clear();
                                nameTxtBx.Clear();
                                contactTxtBx.Clear();
                                passTxtBx.Clear();
                                typeTxtBx.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update data.");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error updating data: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword from the TextBox
            string keyword = SearchBox.Text.Trim().ToLower();

            // Clear the current selection
            dataGridView1.ClearSelection();

            // Filter the DataGridView based on the search keyword
            if (!string.IsNullOrEmpty(keyword))
            {
                // Iterate through each row in the DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Check if the name column contains the search keyword
                    if (row.Cells["name"].Value.ToString().ToLower().Contains(keyword))
                    {
                        // Display the row that matches the search keyword
                        row.Visible = true;
                    }
                    else
                    {
                        // Hide rows that do not match the search keyword
                        row.Visible = false;
                    }
                }
            }
            else
            {
                // Show all rows if the search keyword is empty
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
            }
        }


    }
}
