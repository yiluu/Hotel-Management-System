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
    public partial class ViewReportForm : Form
    {
        private Manager admin;

        public ViewReportForm(Manager admin)
        {
            InitializeComponent();
            cal_Reservation.DateChanged += cal_DateChanged;
            this.admin = admin;

        }

        private void ViewReportForm_Load(object sender, EventArgs e)
        {
            RefreshTotalRooms();
            RefreshTotalRevenue();
            datagrid_Reviews.DataSource = GetData("Reviews");
        }
        private void cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            listview_Rooms.Clear();
            lbl_Revenue.Text = "[]";

            DateTime startDate = e.Start;
            DateTime endDate = e.End;


            int[] roomIDs =  admin.GetRoomData(startDate);
            foreach (int roomID in roomIDs)
            {
                ListViewItem item = new ListViewItem(roomID.ToString());

                listview_Rooms.Items.Add(item);
            }

            lbl_Revenue.Text = admin.GetRevenueByDate(startDate).ToString();
        }

        private void RefreshTotalRooms()
        {
            lbl_Total_Rooms.Text = admin.GetTotalRooms().ToString();
        }
        private void RefreshTotalRevenue()
        {
            lbl_Total_Revenue.Text = admin.GetTotalRevenue().ToString();
        }

        public DataTable GetData(string TableName)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM {TableName}";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}
