using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class ManageRoomsForm : Form
    {
        private Manager admin;


        public ManageRoomsForm(Manager admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goodStayHotelDatabaseROOMS.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.goodStayHotelDatabaseROOMS.Rooms);

        }

        private void btn_Edit_Room_Click(object sender, EventArgs e)
        {
            if (datagrid_Rooms.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrid_Rooms.SelectedRows[0];
                var cellValue = selectedRow.Cells[0].Value; // Example for first cell
                int ID = Convert.ToInt32(cellValue);

                 //datetime convert to stringifiied datetime sql

                admin.EditRoom(ID.ToString(), txtbox_Edit_Room_Number.Text, txtbox_Edit_Floor.Text, txtbox_Edit_Rate.Text, cmbbox_Edit_Condition.Text, timebox_Edit_Cleaned.Value, txtbox_Amenities.Text, cmbbox_Availability.Text, txtbox_Notes.Text, cmbbx_Scheduled.Text);
            } else
            {
                admin.AddRoom(txtbox_Edit_Room_Number.Text, txtbox_Edit_Floor.Text, txtbox_Edit_Rate.Text, cmbbox_Edit_Condition.Text, timebox_Edit_Cleaned.Value, txtbox_Amenities.Text, cmbbox_Availability.Text, txtbox_Notes.Text, cmbbx_Scheduled.Text);
            }

            datagrid_Rooms.DataSource = GetData("Rooms");
            datagrid_Rooms.ClearSelection();

            txtbox_Edit_Room_Number.Clear();
            txtbox_Edit_Floor.Clear();
            txtbox_Edit_Rate.Clear();
            txtbox_Amenities.Clear();
            cmbbox_Availability.SelectedIndex = -1;
            cmbbox_Edit_Condition.SelectedIndex = -1;
            txtbox_Notes.Clear();
            cmbbx_Scheduled.SelectedIndex = -1;
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (datagrid_Rooms.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrid_Rooms.SelectedRows[0];
                // Access cell values
                var cellValue = selectedRow.Cells[0].Value; // Example for first cell
                int ID = Convert.ToInt32(cellValue);

                //datetime convert to stringifiied datetime sql

                admin.DeleteRoom(ID);
            }
            else
            {
                MessageBox.Show("Please select a room to delete!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            datagrid_Rooms.DataSource = GetData("Rooms");
            datagrid_Rooms.ClearSelection();
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            datagrid_Rooms.ClearSelection();
        } 
    }
}
