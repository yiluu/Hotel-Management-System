using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    internal class CheckoutHandler
    {
        private string connectionString;

        public CheckoutHandler(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int GetReservationIDByName(int customerId)
        {
            int reservationID = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ReservationID FROM Reservations WHERE CustomerID = @CustomerID", conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reservationID = (int)reader["ReservationID"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return reservationID;
        }

        
        public void UpdatePaymentStatus(int reservationID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Reservations SET PaymentStatus = 'Collected' WHERE ReservationID = @ReservationID", conn);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
