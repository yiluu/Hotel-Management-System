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
    public partial class Booking : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        public Booking()
        {
            InitializeComponent();
            BokingBtn.Click += new EventHandler(this.BokingBtn_Click);
        }

        private void booking_Load(object sender, EventArgs e)
        {

        }

        private void BokingBtn_Click(object sender, EventArgs e)
        {
            string cusID = CusIDTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(cusID))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            string query = "SELECT ReservationID, CheckinDateTime, CheckoutDateTime, Nights FROM Reservations WHERE CustomerID = @CusID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CusID", cusID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        data_Booking.Rows.Clear();
                        data_Booking.Columns.Clear();

                        if (reader.HasRows)
                        {
                            data_Booking.Columns.Add("ReservationID", "Reservation ID");
                            data_Booking.Columns.Add("CheckinDateTime", "Check-in DateTime");
                            data_Booking.Columns.Add("CheckoutDateTime", "Check-out DateTime");
                            data_Booking.Columns.Add("Nights", "Nights");

                            while (reader.Read())
                            {
                                string reservationID = reader["ReservationID"].ToString();
                                DateTime checkin = Convert.ToDateTime(reader["CheckinDateTime"]);
                                DateTime checkout = Convert.ToDateTime(reader["CheckoutDateTime"]);
                                int nights = Convert.ToInt32(reader["Nights"]);

                                data_Booking.Rows.Add(reservationID, checkin, checkout, nights);
                            }
                            data_Booking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        }
                        else
                        {
                            MessageBox.Show("No reservation found for the provided customer ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void BokingBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}