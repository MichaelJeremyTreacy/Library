using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class FormMain : Form
    {
        private string _connectionString;
        private SqlConnection _connection;

        public FormMain()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateBooks();
            PopulateGenres();
        }

        private void PopulateBooks()
        {
            using (_connection = new SqlConnection(_connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Book", _connection))
            {
                DataTable bookTable = new DataTable();
                adapter.Fill(bookTable);

                ListBooks.DisplayMember = "Name";
                ListBooks.ValueMember = "Id";
                ListBooks.DataSource = bookTable;
            }
        }

        private void PopulateGenres()
        {
            using (_connection = new SqlConnection(_connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Genre", _connection))
            {
                DataTable genreTable = new DataTable();
                adapter.Fill(genreTable);

                ListGenres.DisplayMember = "Name";
                ListGenres.ValueMember = "Id";
                ListGenres.DataSource = genreTable;
            }
        }
    }
}
