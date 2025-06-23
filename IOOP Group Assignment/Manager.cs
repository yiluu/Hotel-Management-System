using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public class Manager
    {
        string username;
        string password;
        string managerID;


        public Manager(string userName, string Password, string ManagerID)
        {
            username = userName;
            password = Password;
            managerID = ManagerID;
        }

        public void AddAccount(string accountType, string accountName, string accountUsername, string accountPass)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand query = new SqlCommand($"INSERT INTO {accountType} (Name, Username, Password) VALUES (@accountName, @accountUsername, @accountPass)", connection);
            query.Parameters.AddWithValue("@accountType", accountType);
            query.Parameters.AddWithValue("@accountName", accountName);
            query.Parameters.AddWithValue("@accountUsername", accountUsername);
            query.Parameters.AddWithValue("@accountPass", accountPass);

            try
            {
                connection.Open();
                int result = query.ExecuteNonQuery();

                // Check if the insertion was successful
                if (result > 0)
                {
                    MessageBox.Show("User Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Add User.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill up all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void EditAccount(int accountID, string accountType, string accountIDstr, string accountName, string accountUsername, string accountPass)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand query = new SqlCommand($"UPDATE {accountType} SET Name = @accountName, Username = @accountUsername, Password = @accountPass WHERE {accountIDstr} = @accountID", connection);
            query.Parameters.AddWithValue("@accountID", accountID);
            query.Parameters.AddWithValue("@accountName", accountName);
            query.Parameters.AddWithValue("@accountUsername", accountUsername);
            query.Parameters.AddWithValue("@accountPass", accountPass);

            try
            {
                connection.Open();
                int result = query.ExecuteNonQuery();

                // Check if the insertion was successful
                if (result > 0)
                {
                    MessageBox.Show("User Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Add User.");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please fill up all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void EditRoom(string roomID, string roomNumber, string floor, string ratePerNight, string condition, DateTime lastCleaned, string amenities, string availability, string maintenanceNotes, string sheduled)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand query = new SqlCommand("UPDATE Rooms SET RoomNumber  = @roomnumber, Floor = @floor, RatePerNight = @ratepernight, Condition = @condition, LastCleanedDate = @lastcleaned, Amenities = @amenities, Availability = @availability, MaintenanceNotes = @maintenancenotes, ScheduledForClean = @scheduled WHERE RoomID = @roomid", connection);
            query.Parameters.AddWithValue("@roomnumber", roomNumber);
            query.Parameters.AddWithValue("@floor", floor);
            query.Parameters.AddWithValue("@ratepernight", ratePerNight);
            query.Parameters.AddWithValue("@condition", condition);
            query.Parameters.AddWithValue("@lastcleaned", lastCleaned);
            query.Parameters.AddWithValue("@amenities", amenities);
            query.Parameters.AddWithValue("@availability", availability);
            query.Parameters.AddWithValue("@maintenancenotes", maintenanceNotes);
            query.Parameters.AddWithValue("@roomid", roomID);
            query.Parameters.AddWithValue("@scheduled", sheduled);
            try
            {
                connection.Open();
                int result = query.ExecuteNonQuery();

                // Check if the insertion was successful
                if (result > 0)
                {
                    MessageBox.Show("Room Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Edit Room.");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please fill up all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void AddRoom(string roomNumber, string floor, string ratePerNight, string condition, DateTime lastCleaned, string amenities, string availability, string maintenanceNotes, string sheduled)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand query = new SqlCommand($"INSERT INTO Rooms (RoomNumber, Floor, RatePerNight, Condition, LastCleanedDate, Amenities, Availability, MaintenanceNotes, ScheduledForClean)" +
                $" VALUES (@roomnumber, @floor, @ratepernight, @condition, @lastcleaned, @amenities, @availability, @maintenancenotes, @scheduled)", connection);
            query.Parameters.AddWithValue("@roomnumber", roomNumber);
            query.Parameters.AddWithValue("@floor", floor);
            query.Parameters.AddWithValue("@ratepernight", ratePerNight);
            query.Parameters.AddWithValue("@condition", condition);
            query.Parameters.AddWithValue("@lastcleaned", lastCleaned);
            query.Parameters.AddWithValue("@amenities", amenities);
            query.Parameters.AddWithValue("@availability", availability);
            query.Parameters.AddWithValue("@maintenancenotes", maintenanceNotes);
            query.Parameters.AddWithValue("@scheduled", sheduled);
            try
            {
                connection.Open();
                int result = query.ExecuteNonQuery();

                // Check if the insertion was successful
                if (result > 0)
                {
                    MessageBox.Show("Room Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Add Room.");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please fill up all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public void DeleteRoom(int roomID)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand query = new SqlCommand("DELETE FROM Rooms WHERE RoomID = @roomid", connection);
            query.Parameters.AddWithValue("@roomid", roomID);
            try
            {
                connection.Open();
                int result = query.ExecuteNonQuery();

                // Check if the insertion was successful
                if (result > 0)
                {
                    MessageBox.Show("Room Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Delete Room.");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please fill up all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void AssignSchedule(string HousekeeperID, string RoomID, DateTime cleanDate)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand query = new SqlCommand("INSERT INTO HousekeepingSchedule (HousekeeperID, RoomID, CleanDate) VALUES (@housekeeperid, @roomid, @cleandate)", connection);
            query.Parameters.AddWithValue("@housekeeperid", HousekeeperID);
            query.Parameters.AddWithValue("@roomid", RoomID);
            query.Parameters.AddWithValue("@cleandate", cleanDate);
            try
            {
                connection.Open();
                int result = query.ExecuteNonQuery();

                // Check if the insertion was successful
                if (result > 0)
                {
                    MessageBox.Show("Scheduled Room For Cleaning Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Delete Room.");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please fill up all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public int[] GetRoomData(DateTime date)
        {
            List<int> roomIDs = new List<int>();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand command = new SqlCommand("SELECT RoomID FROM Reservations WHERE CheckInDateTime = @date", connection);
            using (connection)
            {
                {
                    // Add parameter to prevent SQL injection and set the date value
                    command.Parameters.AddWithValue("@date", date);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command and retrieve the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if any rows are returned
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Read the RoomID from the result set
                                    int roomID = reader.GetInt32(0);

                                    // Process the RoomID (e.g., display it, store it, etc.)
                                    roomIDs.Add(roomID);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No rooms found for the given date.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occurred during the process
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            return roomIDs.ToArray();
        }

        public decimal GetRevenueByDate(DateTime date)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand command = new SqlCommand("SELECT SUM(Balance) AS TotalRevenue FROM Reservations WHERE CheckInDateTime = @date", connection);

            // Initialize the total revenue
            decimal totalRevenue = 0;

            // Create a SqlConnection and SqlCommand to execute the query
            using (connection)
            {
                using (command)
                {
                    // Add parameter to prevent SQL injection and set the date value
                    command.Parameters.AddWithValue("@date", date.Date);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command and retrieve the result
                        object result = command.ExecuteScalar();

                        // Check if the result is not null and convert to decimal
                        if (result != DBNull.Value)
                        {
                            totalRevenue = Convert.ToDecimal(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occurred during the process
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // Return the total revenue
            return totalRevenue;
        }

        public int GetTotalRooms()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand command = new SqlCommand("SELECT COUNT(*) AS TotalRooms FROM Reservations", connection);

            int totalRooms = 0;

            // Create a SqlConnection and SqlCommand to execute the query
            using (connection)
            {
                using (command)
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command and retrieve the result
                        object result = command.ExecuteScalar();

                        // Check if the result is not null and convert to decimal
                        if (result != DBNull.Value)
                        {
                            totalRooms = (int)result;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occurred during the process
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // Return the total revenue
            return totalRooms;
        }
        public decimal GetTotalRevenue()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            SqlCommand command = new SqlCommand("SELECT SUM(Balance) AS TotalRevenue FROM Reservations", connection);

            // Initialize the total revenue
            decimal totalRevenue = 0;

            // Create a SqlConnection and SqlCommand to execute the query
            using (connection)
            {
                using (command)
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command and retrieve the result
                        object result = command.ExecuteScalar();

                        // Check if the result is not null and convert to decimal
                        if (result != DBNull.Value)
                        {
                            totalRevenue = Convert.ToDecimal(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occurred during the process
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // Return the total revenue
            return totalRevenue;
        }
    }
}

