using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace IOOP_Group_Assignment
{
    internal class Housekeeper
    {

        public string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();


        public int GetProfilePictureId(string userType)
        {
            if (string.IsNullOrEmpty(userType) ||
                (userType != "Customers" && userType != "Receptionists" && userType != "Housekeepers"))
            {
                throw new ArgumentException("Invalid user type.");
            }

            string tableName = userType; // Directly use userType as tableName

            string query = $"SELECT pfpid FROM {tableName}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int pfpid))
                    {
                        return pfpid;
                    }
                    else
                    {
                        throw new Exception("Profile picture ID not found.");
                    }
                }
            }
        }

        public void UpdateProfilePictureId(string userType, int newPfpid)
        {
            if (string.IsNullOrEmpty(userType) ||
                (userType != "Customer" && userType != "Receptionist" && userType != "Housekeeping"))
            {
                throw new ArgumentException("Invalid user type.");
            }

            string tableName = userType; // Directly use userType as tableName

            string query = $"UPDATE {tableName} SET pfpid = @NewPfpid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewPfpid", newPfpid);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("No rows updated. Ensure the table and column exist.");
                    }
                }
            }
        }

        public void LoadImageToButton(Button button, string connectionString, int imageId)
        {
            byte[] imageData = null;

            // Retrieve image data from the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ImageData FROM Images WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", imageId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            imageData = reader["ImageData"] as byte[];
                        }
                    }
                }
            }

            // Set image to button if data is available
            if (imageData != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        button.Image = image;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Image not found.");
            }
        }

        private void MarkCLeaned()
        {

        }

        public void DeleteEntryFromSupplies(int id)
        {
            

            string query = "DELETE FROM Supplies WHERE SuppliesID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public void AddSupply(string SupplyName, string SupplyType, int SupplyCount)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Supplies(SupplyType, SuppliesName, Count)" +
                "values (@a, @b, @c)", con);
            cmd.Parameters.AddWithValue("@a", SupplyType);
            cmd.Parameters.AddWithValue("@b", SupplyName);
            cmd.Parameters.AddWithValue("@c", SupplyCount);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supply added successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while adding the supply: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        public Tuple<string, string, string> RetrieveRoomInformation(string roomid)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT RoomNumber, Condition, Availability FROM Rooms WHERE RoomID = @RoomID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomid);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string roomNumber = reader["RoomNumber"].ToString();
                            string condition = reader["Condition"].ToString();
                            string availability = reader["Availability"].ToString();

                            return Tuple.Create(roomNumber, condition, availability);
                        }
                        else
                        {
                            return Tuple.Create("Not Found", "Not Found", "Not Found");
                        }
                    }
                }
            }
        }

    }
}
