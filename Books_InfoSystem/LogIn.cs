using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Books_InfoSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.passwordTxt.Text;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=localhost;uid=root;" +"pwd=erick;database=books";
            try
           {
               conn = new MySql.Data.MySqlClient.MySqlConnection();
               conn.ConnectionString = myConnectionString;
               conn.Open();
               string sql = "SELECT COUNT(*) from users where username = @username AND password = @password AND acc_type = 'user'";
               MySqlCommand cmd = new MySqlCommand(sql, conn);
               cmd.Parameters.AddWithValue("@username", username);
               cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Set the status to 1 for the logged-in user
                    string updateSql = "UPDATE users SET status = 1 WHERE username = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@username", username);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("You are now logged in");
                    UserInfo.Username = username;
                    var home = new Dashboard();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                }
            }
           catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
           }
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.passwordTxt.Text;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=localhost;uid=root;" +"pwd=erick;database=books";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string sql = "SELECT COUNT(*) from users where username = @username AND password = @password AND acc_type = 'admin'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Set the status to 1 for the logged-in user
                    string updateSql = "UPDATE users SET status = 1 WHERE username = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@username", username);
                    updateCmd.ExecuteNonQuery();

                    //MessageBox.Show("You are now logged in");
                    UserInfo.Username = username;
                    var home = new AdminDashboard();
                    this.Hide();
                    home.Show();

                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void signUpBtn_Click_1(object sender, EventArgs e)
        {
            var signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        private void showLoginPass_Click(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = '\0';
            showLoginPass.Visible = false;
            hideLoginPass.Visible = true;
        }

        private void hideLoginPass_Click(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar= '*';
            hideLoginPass.Visible = false;
            showLoginPass.Visible= true;
        }

        private void Users_Click(object sender, EventArgs e)
        {
            adminLabel.Visible = true;
            usersLabel.Visible = true;
        }

        private void adminLabel_Click(object sender, EventArgs e)
        {
            adminLabel.Visible = false;
            usersLabel.Visible = false;
            adminLoginLabel.Visible = true;
            userLoginLabel.Visible = false;
            adminLoginBtn.Visible = true;
            userLoginBtn.Visible = false;
        }

        private void usersLabel_Click(object sender, EventArgs e)
        {
            adminLabel.Visible = false;
            usersLabel.Visible = false;
            adminLoginLabel.Visible = false;
            userLoginLabel.Visible = true;
            adminLoginBtn.Visible = false;
            userLoginBtn.Visible = true;
        }

        private void forgotPassLabel_Click(object sender, EventArgs e)
        {
            var reset = new resetPassword();
            this.Hide();
            reset.Show();
        }
    }
}
