using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace IOOP_Group_Assignment
{
   
    public partial class send_a_review : Form
    {
        public int Rating { get; set; }
        public string Comment { get; set; }

        public send_a_review()
        {
            InitializeComponent();

        }

        private void txtcomment_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsend_a_review_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            using (connection)
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Reviews (Rating, ReviewMessage) VALUES (@Rating, @Comment)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Rating", numUpDown_rating.Value);
                        command.Parameters.AddWithValue("@Comment", txtcomment.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Review submitted successfully.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void send_a_review_Load(object sender, EventArgs e)
        {

        }
    }
}
