using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class DeleteCustomer : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }

        private void DeleteCustomer_Btn_Click_1(object sender, EventArgs e)
        {
            string customerID = CustomerID_TextBox.Text;

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please enter a Customer ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the given Customer ID.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error deleting customer: ");
                }
            }
        }
    }
}

