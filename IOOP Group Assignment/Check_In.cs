/*using System;
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

    public partial class Check_In : Form
    {
        private string connectionString = @"Server=(localdb)\mssqllocaldb;Integrated Security=true;AttachDbFilename=D:\ioop\ioop\IOOP Group Assignment\GoodStayHotelDatabase.mdf;";
        int roomPrice;
        public Check_In()
        {
            InitializeComponent();
            LoadRoomTypes();
            roomPriceTextBox.ReadOnly = true; // Make room price textbox read-only
        }

        private void LoadRoomTypes()
        {
            // Add only price to combo items
            roomTypeComboBox.Items.Add("Single");
            roomTypeComboBox.Items.Add("Double");
            roomTypeComboBox.Items.Add("Suite");
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Get selected room type and set price accordingly
            string selectedRoom = roomTypeComboBox.SelectedItem?.ToString();
            if (selectedRoom == "Single")
            {
                //roomPriceTextBox.Text = "100";
                roomPrice = 100;

            }
            else if (selectedRoom == "Double")
            {
                //roomPriceTextBox.Text = "150";
                roomPrice = 150;
            }
            else if (selectedRoom == "Suite")
            {
                //roomPriceTextBox.Text = "250";
                roomPrice = 250;
            }

            // Calculate total balance
            CalculateTotalBalance();
        }

        private void CalculateTotalBalance()
        {
            // Ensure room price text is in the correct format
            //if (int.TryParse(roomPriceTextBox.Text, out int roomPrice))
            //{
            DateTime checkinDate = checkinDateTimePicker.Value;
            DateTime checkoutDate = checkoutDateTimePicker.Value;

            // Calculate number of nights
            int nights = (checkoutDate - checkinDate).Days;
            if (nights < 1) nights = 1; // Minimum stay is 1 night

            // Calculate total balance based on the number of nights
            int totalBalance = roomPrice * nights;

            roomPriceTextBox.Text=roomPrice.ToString();
            // Display total balance
            totalBalanceTextBox.Text = totalBalance.ToString();
            //}
            // else
            //{
            //MessageBox.Show("Invalid room price format.");
            //}
        }

        private void Check_In_Load(object sender, EventArgs e)
        {

        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            string customerID = customerIDTextBox.Text;
            string roomType = roomTypeComboBox.SelectedItem?.ToString();
            DateTime checkinDate = checkinDateTimePicker.Value;
            DateTime checkoutDate = checkoutDateTimePicker.Value;

            // Calculate number of nights
            int nights = (checkoutDate - checkinDate).Days;
            if (nights < 1) nights = 1; // Minimum stay is 1 night
            
            // Parse and validate room price
            //if (!int.TryParse(roomPriceTextBox.Text, out int roomPrice))
            {
                MessageBox.Show("Please enter a valid room price.");
                return;
            }

            // Calculate total balance
            int totalBalance = roomPrice * nights;

            // Validate customer ID and room type
            if (string.IsNullOrWhiteSpace(customerID) || string.IsNullOrWhiteSpace(roomType))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Define RoomID based on the selected room type
            int roomID = -1;
            if (roomType == "Single") roomID = 1;
            else if (roomType == "Double") roomID = 2;
            else if (roomType == "Suite") roomID = 3;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Reservations (CustomerID, RoomID, CheckinDateTime, CheckoutDateTime, Nights, Balance, ReservationStatus) " +
                                   "VALUES (@CustomerID, @RoomID, @CheckinDateTime, @CheckoutDateTime, @Nights, @Balance, @ReservationStatus)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    cmd.Parameters.AddWithValue("@CheckinDateTime", checkinDate);
                    cmd.Parameters.AddWithValue("@CheckoutDateTime", checkoutDate);
                    cmd.Parameters.AddWithValue("@Nights", nights);
                    cmd.Parameters.AddWithValue("@Balance", totalBalance);
                    cmd.Parameters.AddWithValue("@ReservationStatus", "Unpaid");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer checked in successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving reservation: " + ex.Message);
                }
            }
        }

        private void getBillButton_Click(object sender, EventArgs e)
        {
            CalculateTotalBalance();
        }
    }
}*/

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class Check_In : Form
    {
        private string connectionString = @"Server=(localdb)\mssqllocaldb;Integrated Security=true;AttachDbFilename=D:\ioop\ioop\IOOP Group Assignment\GoodStayHotelDatabase.mdf;";
        private int roomPrice;

        public Check_In()
        {
            InitializeComponent();
            LoadRoomTypes();
           
            totalBalanceTextBox.ReadOnly = true; 
        }

        private void LoadRoomTypes()
        {
            
            roomTypeComboBox.Items.Add("Single");
            roomTypeComboBox.Items.Add("Double");
            roomTypeComboBox.Items.Add("Suite");
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CalculateTotalBalance()
        {
            string selectedRoom = roomTypeComboBox.SelectedItem?.ToString();
            if (selectedRoom == "Single")
            {
                roomPrice = 100;
            }
            else if (selectedRoom == "Double")
            {
                roomPrice = 150;
            }
            else if (selectedRoom == "Suite")
            {
                roomPrice = 250;
            }
            DateTime checkinDate = checkinDateTimePicker.Value;
            DateTime checkoutDate = checkoutDateTimePicker.Value;

            
            int nights = (checkoutDate - checkinDate).Days;
            if (nights < 1) nights = 1; // Minimum stay is 1 night

            
            Console.WriteLine(roomPrice);
            Console.WriteLine(nights);
            int totalBalance = roomPrice * nights;

            
            totalBalanceTextBox.Text = totalBalance.ToString();
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            string customerID = customerIDTextBox.Text;
            string roomType = roomTypeComboBox.SelectedItem?.ToString();
            DateTime checkinDate = checkinDateTimePicker.Value;
            DateTime checkoutDate = checkoutDateTimePicker.Value;

            
            int nights = (checkoutDate - checkinDate).Days;
            if (nights < 1) nights = 1; // Minimum stay is 1 night

            

            
            int totalBalance = roomPrice * nights;

            
            if (string.IsNullOrWhiteSpace(customerID) || string.IsNullOrWhiteSpace(roomType))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            
            int roomID = -1;
            if (roomType == "Single") roomID = 1;
            else if (roomType == "Double") roomID = 2;
            else if (roomType == "Suite") roomID = 3;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Reservations (CustomerID, RoomID, CheckinDateTime, CheckoutDateTime, Nights, Balance, ReservationStatus) " +
                                   "VALUES (@CustomerID, @RoomID, @CheckinDateTime, @CheckoutDateTime, @Nights, @Balance, @ReservationStatus)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    cmd.Parameters.AddWithValue("@CheckinDateTime", checkinDate);
                    cmd.Parameters.AddWithValue("@CheckoutDateTime", checkoutDate);
                    cmd.Parameters.AddWithValue("@Nights", nights);
                    cmd.Parameters.AddWithValue("@Balance", totalBalance);
                    cmd.Parameters.AddWithValue("@ReservationStatus", "Unpaid");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer checked in successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving reservation: " + ex.Message);
                }
            }
        }

        private void getBillButton_Click(object sender, EventArgs e)
        {
            CalculateTotalBalance();
        }

        private void Check_In_Load(object sender, EventArgs e)
        {
            
        }
    }
}

