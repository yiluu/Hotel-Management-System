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
    public partial class HK_IssueReport : Form
    {
        private string _roomnum;
        private string _roomid;
        public HK_IssueReport(string roomnum, string roomid)
        {
            InitializeComponent();
            _roomnum = roomnum;
            _roomid = roomid;

        }

        private void HK_IssueReport_Load(object sender, EventArgs e)
        {
            lbl_RoomNum.Text = "Room Number: " + _roomnum;
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            string maintenanceNotes = txtbox_Notes.Text;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"UPDATE Rooms SET MaintenanceNotes = '{maintenanceNotes}' WHERE RoomID = @RoomID", con))
                {
                    cmd.Parameters.AddWithValue("@RoomID", Convert.ToInt32(_roomid));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Maintenance notes updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified Room ID.");
                    }
                }
            }
        }

        private void txtbox_Notes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}