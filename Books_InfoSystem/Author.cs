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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }
        public Author(string username)
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bookTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookTitle = new Dashboard("hehe");
            this.Hide();
            bookTitle.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var genreTitle = new Genre();
            this.Hide();
            genreTitle.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new LogIn();
            this.Hide();
            login.Show();
        }

        private void visitAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var profile = new Profile();
            this.Hide();
            profile.Show();
        }

        private void Author_Load(object sender, EventArgs e)
        {

        }
    }
}
