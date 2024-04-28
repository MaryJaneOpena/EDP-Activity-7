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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Books_InfoSystem
{
    public partial class Dashboard : Form
    {
        private string username;

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string username)
        {
            InitializeComponent(); 
            this.username = username;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bookTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var author = new Author(username);
            this.Hide();
            author.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var genre = new Genre(username);
            this.Hide();
            genre.Show();
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


        private void visitAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profile = new Profile(username);
            this.Hide();
            profile.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
