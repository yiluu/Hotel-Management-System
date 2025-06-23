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
using System.Xml.Linq;


namespace IOOP_Group_Assignment
{
    public partial class Rooms1 : Form
    {
        public Rooms1()
        {
            InitializeComponent();

            CBRoom_Type.SelectedIndexChanged += CBRoom_Type_SelectedIndexChanged;
            CBRoom_Floor.SelectedIndexChanged += CBRoom_Floor_SelectedIndexChanged;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            CBRoom_Type.SelectedIndexChanged += CBRoom_Type_SelectedIndexChanged;

            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Floor", "Floor");

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = e.Start;
            DateTime endDate = e.End;

            int numberOfDays = (endDate - startDate).Days + 1; // +1 to include the end date

            int basePrice = 0;
            string selectedRoomType = CBRoom_Type.SelectedItem?.ToString();

            switch (selectedRoomType)
            {
                case "Single":
                    basePrice = 100;
                    break;
                case "Double":
                    basePrice = 150;
                    break;
                case "Suite":
                    basePrice = 250;
                    break;
                default:
                    basePrice = 0;
                    break;
            }

            int extraChargePerDay = +50;
            int totalPrice = (basePrice * numberOfDays) + (numberOfDays * extraChargePerDay);

            lblThe_Price.Text = $"{totalPrice} RM";

            lblDate.Text = $"From: {startDate.ToShortDateString()} To: {endDate.ToShortDateString()}";

            DateTime endOfMonth = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));

            lblDate.Text = $"From: {startDate.ToShortDateString()} To: {endOfMonth.ToShortDateString()}";
        }


        private void btn_Checkin_Click(object sender, EventArgs e)
        {
            string roomType = CBRoom_Type.SelectedItem?.ToString();

            string roomFloor = CBRoom_Floor.SelectedItem?.ToString();

            DateTime startDate = monthCalendar2.SelectionStart;
            DateTime endDate = monthCalendar2.SelectionEnd;

            int numberOfDays = (endDate - startDate).Days + 1; // +1 to include the end date

            int basePrice = 0;
            switch (roomType)
            {
                case "Single":
                    basePrice = 100;
                    break;
                case "Double":
                    basePrice = 150;
                    break;
                case "Suite":
                    basePrice = 250;
                    break;
                default:
                    basePrice = 0;
                    break;
            }

            int extraChargePerDay = 50;
            int totalPrice = (basePrice * numberOfDays) + (numberOfDays * extraChargePerDay);

            dataGridView1.Rows.Add(roomType, $"{totalPrice} RM", roomFloor);

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

            using (connection)
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Reservations (Room_Type, Room_Floor, @Date) VALUES (@Room_Type, @Room_Floor, @Date)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Room_Type", CBRoom_Type.Text);
                        command.Parameters.AddWithValue("@Room_Floor", CBRoom_Floor.Text);
                        command.Parameters.AddWithValue("@Date", monthCalendar2.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("You Have Checked in.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void CBRoom_Floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBRoom_Floor.SelectedItem != null)
            {
                lblRoom_Floor.Text = CBRoom_Floor.SelectedItem.ToString();
            }
            
        }

        private void CBRoom_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBRoom_Type.SelectedItem != null)
            {
                lblRoom_Type.Text = CBRoom_Type.SelectedItem.ToString();
            }
            string selectedRoomType = CBRoom_Type.SelectedItem.ToString();

            int price;
            switch (selectedRoomType)
            {
                case "Single":
                    price = 100;
                    break;
                case "Double":
                    price = 150;
                    break;
                case "Suite":
                    price = 250;
                    break;
                default:
                    price = 0; // Default price if no valid room type is selected
                    break;

            }
            lblThe_Price.Text = $"{price} RM";
        }

        private void tabPageRoomCheck_in_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
