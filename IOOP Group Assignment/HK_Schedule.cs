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
    public partial class HK_Schedule : Form
    {
        DateTime today = DateTime.Today;
        public string sqlDateFormat;
        public List<string> rowData;

        public HK_Schedule()
        {
            InitializeComponent();
            data_Reservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_RoomCleaning.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rowData = new List<string>();
            string shortDate = today.ToString("yyyy-MM-dd");
            sqlDateFormat = shortDate;
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            try
            {
                string roomid = rowData[1];
                Housekeeper house = new Housekeeper();
                var roomInfo = house.RetrieveRoomInformation(roomid);

                string roomnum = roomInfo.Item1;

                HK_IssueReport f3 = new HK_IssueReport(roomnum, roomid);
                f3.ShowDialog();
            }

            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a room first");
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

            
        }

        //RESERVATION SCHEDULE

        private void btn_RoomChoose2_Click(object sender, EventArgs e)
        {

            if (data_Reservations.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = data_Reservations.SelectedRows[0];
                rowData.Clear();

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "NULL");
                }

                UpdateReservationsPnl();
            }
            else
            {
                MessageBox.Show("Please select a row to view.");
            }
        }

        private void UpdateReservationsPnl()
        {
            if (rowData.Count > 2)
            {
                lbl_Checkin.Text = "Check-in Time: " + rowData[2];
                string roomid = rowData[1];

                Housekeeper house = new Housekeeper();
                var roomInfo = house.RetrieveRoomInformation(roomid);

                lbl_RoomNum2.Text = "Room Number: " + roomInfo.Item1;
                lbl_Condition2.Text = "Condition: " + roomInfo.Item2;

                if (roomInfo.Item2 == "Clean")
                {
                    lbl_Warning.Text = "*Room must be prepared";
                }
                else if (roomInfo.Item2 == "Dirty")
                {
                    lbl_Warning.Text = "*Room must be cleaned then prepared";
                }
            }
            else
            {
                MessageBox.Show("Row data is incomplete.");
            }
        }




        private void LoadCleaning()
        {
            string query = "SELECT * FROM HousekeepingSchedule WHERE CAST(CleanDate AS DATE) = @CleanDate";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@CleanDate", sqlDateFormat);

                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "HousekeepingSchedule");

                    data_RoomCleaning.DataSource = dataSet.Tables["HousekeepingSchedule"];
                }
            }
        }

        private void LoadReservations()
        {

            string query = $"SELECT ReservationID, RoomID, CheckinDateTime, Notes FROM Reservations WHERE CAST(CheckinDateTime AS DATE) = DATEADD(day, 1, '{sqlDateFormat}');";

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Reservations");
                data_Reservations.DataSource = dataSet.Tables["Reservations"];
            }
        }


        private void tabClnSchdl_Click(object sender, EventArgs e)
        {
            LoadCleaning();
        }

        private void tabReservations_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void HK_Schedule_Load(object sender, EventArgs e)
        {
            LoadCleaning();
            LoadReservations();
        }

        private void cal_Reservations_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start.Date;
            sqlDateFormat = selectedDate.ToString("yyyy-MM-dd");

            LoadReservations();

        }

        private void btn_Refresh2_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadCleaning();
        }

        private void btn_MarkPrepared_Click(object sender, EventArgs e)
        {
            if (rowData.Count > 2)
            {
                int roomID = Convert.ToInt32(rowData[1]);

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("UPDATE Rooms SET Condition = 'Prepared' WHERE RoomID = @RoomNumber", con))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber", roomID);

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.");
                                LoadReservations();
                                UpdateReservationsPnl();
                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified Room Number.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No room number available for update.");
            }
        }

        //CLEANING SCHEDULE

        private void cal_Cleaning_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start.Date;
            sqlDateFormat = selectedDate.ToString("yyyy-MM-dd");

            LoadCleaning();
        }

        private void btn_RoomChoose_Click(object sender, EventArgs e)
        {
            if (data_RoomCleaning.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = data_RoomCleaning.SelectedRows[0];
                rowData.Clear();

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "NULL");
                }

                UpdateCleaningPnl();


            }
            else
            {
                MessageBox.Show("Please select a row to view.");
            }



        }
        private void UpdateCleaningPnl()
        {
            if (rowData.Count > 2)
            {
                string roomid = rowData[1];

                Housekeeper house = new Housekeeper();
                var roomInfo = house.RetrieveRoomInformation(roomid);

                lbl_RoomNum.Text = "Room Number: " + roomInfo.Item1;
                lbl_Availability.Text = "Availability: " + roomInfo.Item3;
                lbl_Condition.Text = "Condition: " + roomInfo.Item2;
            }
            else
            {
                MessageBox.Show("Row data is incomplete.");
            }
        }

        private void btn_MarkClean_Click(object sender, EventArgs e)
        {
            if (rowData.Count > 2)
            {
                int roomID = Convert.ToInt32(rowData[1]);
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Rooms SET Condition = 'Clean' WHERE RoomID = @RoomNumber", con))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber", roomID);

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.");
                                LoadCleaning();
                                UpdateCleaningPnl();
                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified Room Number.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No room number available for update.");
            }
        }

        private void btn_MarkDirty_Click(object sender, EventArgs e)
        {
            if (rowData.Count > 2)
            {
                int roomID = Convert.ToInt32(rowData[1]);
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Rooms SET Condition = 'Dirty' WHERE RoomID = @RoomNumber", con))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber", roomID);

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record updated successfully.");
                                LoadCleaning();
                                UpdateCleaningPnl();
                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified Room Number.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No room number available for update.");
            }
        }
    }
}
