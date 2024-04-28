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
using System.IO;//needed packages
using OfficeOpenXml;//needed packages
using LicenseContext = OfficeOpenXml.LicenseContext; //EPP packages to manipulate the excel file
using OfficeOpenXml.Drawing.Chart;// for charts and graphs
using OfficeOpenXml.Style; // changes fonts, style, etc
using System.Windows.Forms.DataVisualization.Charting;



namespace Books_InfoSystem
{
    public partial class Genre : Form
    {
        // Declare private fields for database connection and command
        private MySqlConnection connection;
        private MySqlCommand command;
        // Database connection parameters
        private string server;
        private string database;
        private string uid;
        private string pass;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public Genre()
        {
            InitializeComponent();
            InitializeDatabase(); // Initialize database connection
            LoadDataIntoDataGridView(); // Load data into DataGridView 
        }
        public Genre(string username)
        {
            InitializeComponent();
            InitializeDatabase(); // Initialize database connection
            LoadDataIntoDataGridView();
        }
        private void InitializeDatabase()
        {
            server = "localhost";
            database = "books";
            uid = "root";
            // Construct connection string
            pass = "erick";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={pass};";
            connection = new MySqlConnection(connectionString); // Create MySqlConnection object named "connection"
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM books";
                command = new MySqlCommand(query, connection);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void Genre_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[] genres = { "Fiction", "Science Fiction" };
            FilterBooksByGenres(genres);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bookTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookTitle = new Dashboard("hehe");
            this.Hide();
            bookTitle.Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var author = new Author();
            this.Hide();
            author.Show();
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
            var profile = new Profile();
            this.Hide();
            profile.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void FilterBooksByGenres(string[] genres)
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM books WHERE Genre IN (" + string.Join(",", genres.Select(g => "'" + g + "'")) + ")";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@genre", genres);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FilterBooksByGenre(string genre)
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM books WHERE Genre = @genre";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@genre", genre);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FilterBooksByGenre("Romance");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FilterBooksByGenre("Fantasy");
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\avell\OneDrive\Desktop\Book Record.xlsx";

            try
            {
                connection.Open();

                string query = "SELECT * FROM books ";
                string getgenre = "SELECT Genre FROM books";


                using (MySqlCommand Command = new MySqlCommand(query, connection))// command for books
                {
                    using (MySqlDataReader Reader = Command.ExecuteReader())//reader for  books
                    {
                        ExcelPackage excelPackage = new ExcelPackage(); //using the excel package

                        // Add a worksheet to the Excel package
                        ExcelWorksheet worksheet_1 = excelPackage.Workbook.Worksheets.Add("Books"); //creating first sheet
                        ExcelWorksheet worksheet_2 = excelPackage.Workbook.Worksheets.Add("Graphs"); // second sheet

                        //for logo and set up property
                        var picture = worksheet_1.Drawings.AddPicture("Logo", new FileInfo("F:\\Downloads\\librarylogo.png"));//logo of the shop
                        // Set the size of the picture
                        picture.SetSize(70, 70); // Set the picture size in pixels

                        // Set the width of column 1 and height of row 1 
                        worksheet_1.Column(1).Width = 13.71;
                        worksheet_1.Row(1).Height = 52.50;
                        worksheet_1.Cells[1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet_1.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(Color.Brown);

                        // Calculate the offsets to center the picture in cell A1
                        double cellWidth = worksheet_1.Column(1).Width;
                        double cellHeight = worksheet_1.Row(1).Height;
                        double xOffset = cellWidth / 13.71; // Calculate horizontal offset
                        double yOffset = cellHeight / 4; // Calculate vertical offset

                        // Set the position of the picture to center it in cell A1
                        picture.SetPosition(0, (int)xOffset, 0, (int)yOffset);

                        //Merging and adding the company name
                        ExcelRange cellsToMerge = worksheet_1.Cells["B1:F1"];
                        cellsToMerge.Merge = true;
                        cellsToMerge.Value = "Books Information System";
                        cellsToMerge.Style.Font.Size = 16;
                        cellsToMerge.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cellsToMerge.Style.Fill.BackgroundColor.SetColor(Color.Brown);
                        cellsToMerge.Style.Font.Name = "Britannic Bold";
                        cellsToMerge.Style.Font.Color.SetColor(Color.Black);
                        cellsToMerge.Style.Font.Bold = true;
                        cellsToMerge.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cellsToMerge.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        ExcelRange cellsToMerge1 = worksheet_1.Cells["A3:F3"];
                        cellsToMerge1.Merge = true;
                        cellsToMerge1.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cellsToMerge1.Style.Fill.BackgroundColor.SetColor(Color.Brown);
                        cellsToMerge1.Style.Font.Name = "Britannic Bold";
                        cellsToMerge1.Style.Font.Color.SetColor(Color.Black);
                        cellsToMerge1.Value = "Available Books";
                        cellsToMerge1.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cellsToMerge1.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        //headers
                        worksheet_1.Cells["A4"].Value = "BookID";
                        worksheet_1.Cells["B4"].Value = "Title";
                        worksheet_1.Cells["C4"].Value = "ISBN";
                        worksheet_1.Cells["D4"].Value = "Publish Date";
                        worksheet_1.Cells["E4"].Value = "Genre";
                        worksheet_1.Cells["F4"].Value = "Author";

                        int row = 5;

                        while (Reader.Read()) //populate the table
                        {
                            worksheet_1.Cells[row, 1].Value = Reader.GetString(0); 
                            worksheet_1.Cells[row, 2].Value = Reader.GetString(1); 
                            worksheet_1.Cells[row, 3].Value = Reader.GetString(2); 
                            worksheet_1.Cells[row, 4].Value = Reader.GetString(3);
                            worksheet_1.Cells[row, 5].Value = Reader.GetString(4);
                            worksheet_1.Cells[row, 6].Value = Reader.GetString(5);

                            row++;
                        }
                        worksheet_1.Cells[18, 5].Value = "_________________________";
                        worksheet_1.Cells[19, 5].Value = "Librarian";


                        worksheet_1.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet_1.Cells.AutoFitColumns();

                        //Similar with the first page
                        var picture1 = worksheet_2.Drawings.AddPicture("Logo", new FileInfo("F:\\Downloads\\librarylogo.png"));//logo of the shop
                        // Set the size of the picture
                        picture1.SetSize(70, 70); // Set the picture size in pixels

                        // Set the width of column 1 and height of row 1
                        worksheet_2.Column(1).Width = 13.71;
                        worksheet_2.Row(1).Height = 52.50;
                        worksheet_2.Cells[1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet_2.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(Color.Brown);

                        // Calculate the offsets to center the picture in cell A1
                        double cellWidths = worksheet_2.Column(1).Width;
                        double cellHeights = worksheet_2.Row(1).Height;
                        double xOffsets = cellWidth / 13.71; // Calculate horizontal offset
                        double yOffsets = cellHeight / 4; // Calculate vertical offset

                        // Set the position of the picture to center it in cell A1
                        picture.SetPosition(0, (int)xOffsets, 0, (int)yOffsets);

                        //Merging and adding the company name
                        ExcelRange cellsToMerge2 = worksheet_2.Cells["B1:F1"];
                        cellsToMerge2.Merge = true;
                        cellsToMerge2.Value = "Books Information System";
                        cellsToMerge2.Style.Font.Size = 16;
                        cellsToMerge2.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cellsToMerge2.Style.Fill.BackgroundColor.SetColor(Color.Brown);
                        cellsToMerge2.Style.Font.Name = "Britannic Bold";
                        cellsToMerge2.Style.Font.Color.SetColor(Color.Black);
                        cellsToMerge2.Style.Font.Bold = true;
                        cellsToMerge2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cellsToMerge2.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        Reader.Close();

                        using (MySqlCommand genreCommand = new MySqlCommand(getgenre, connection))// command for genre
                        {
                            using (MySqlDataReader genreReader = Command.ExecuteReader())//reader to get the genre
                            {
                                Dictionary<string, int> genreCounts = new Dictionary<string, int>();

                                while (genreReader.Read())
                                {
                                    string genre = genreReader.GetString(4);

                                    if (genreCounts.ContainsKey(genre))
                                    {
                                        genreCounts[genre]++;
                                    }
                                    else
                                    {
                                        genreCounts.Add(genre, 1);
                                    }
                                }// basically read the database in Genre if genre is repeated or equal then count as 1 or 1+1

                                int rowCount = genreCounts.Count;

                                // Define the range for the data series
                                string countRange = $"C4:C{rowCount + 3}";
                                string genreRange = $"B4:B{rowCount + 3}";

                                // Headers
                                worksheet_2.Cells["B3"].Value = "Genre";
                                worksheet_2.Cells["C3"].Value = "Count";


                                // Populate the worksheet with genre counts
                                int row1 = 4;
                                foreach (var pair in genreCounts)
                                {
                                    worksheet_2.Cells[row1, 2].Value = pair.Key;
                                    worksheet_2.Cells[row1, 3].Value = pair.Value;
                                    row1++;
                                }

                                ExcelChart chart = worksheet_2.Drawings.AddChart("Book Genre Distribution", eChartType.PieExploded3D);
                                chart.SetPosition(2, 0, 0, 0);
                                chart.SetSize(415, 300);

                                // Add data series to the first chart for the 
                                ExcelChartSerie serie = chart.Series.Add(worksheet_2.Cells[countRange], worksheet_2.Cells[genreRange]);
                                serie.Header = "Book Genre Total";

                                // Set the chart title for the first chart
                                chart.Title.Text = "Book Genre Distribution";

                                worksheet_2.Cells[20, 5].Value = "_________________________";//similar with the first page
                                worksheet_2.Cells[21, 5].Value = "Librarian";

                                worksheet_2.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                                worksheet_2.Cells.AutoFitColumns();

                                // Save the Excel file
                                excelPackage.SaveAs(new FileInfo(filePath));
                                MessageBox.Show("Excel file saved successfully!");

                                // Dispose the ExcelPackage object
                                excelPackage.Dispose();

                            }
                        }
                    }
                }
                    }
            catch   (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message); 
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
