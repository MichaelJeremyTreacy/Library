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
            PopulateGenres();
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

        private void ListGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateBooks();
        }

        private void PopulateBooks()
        {
            string query = "SELECT a.Name FROM Book a " +
                           "INNER JOIN BookGenre b ON a.Id = b.BookId " +
                           "WHERE b.GenreId = @GenreId";

            using (_connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, _connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@GenreId", ListGenres.SelectedValue);

                DataTable bookTable = new DataTable();
                adapter.Fill(bookTable);

                ListBooks.DisplayMember = "Name";
                ListBooks.ValueMember = "Id";
                ListBooks.DataSource = bookTable;
            }
        }
    }
}
