using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class Manage_reservations : Form
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataTable dataTable;

        private void ManageDataForm_Load(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string";

            string query = "SELECT * FROM Reservations";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                dataAdapter = new SqlDataAdapter(query, connection);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

       

        public Manage_reservations()
        {
            InitializeComponent();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
           
        }

        private void Manage_reservations_Load(object sender, EventArgs e)
        {
        

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the database with changes from the DataTable
                dataAdapter.Update(dataTable);
                MessageBox.Show("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
