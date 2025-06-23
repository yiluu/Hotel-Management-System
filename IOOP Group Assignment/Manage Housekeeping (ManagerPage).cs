using IOOP_Group_Assignment.GoodStayHotelDatabaseDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class ManageHousekeepingForm : Form
    {
        private Manager admin;

        public ManageHousekeepingForm(Manager admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            int housekeeperID = -1;
            if (datagrid_Schedule_Housekeepers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrid_Schedule_Housekeepers.SelectedRows[0];
                // Access cell values
                var cellValue = selectedRow.Cells[0].Value; // Example for first cell
                housekeeperID = Convert.ToInt32(cellValue);

            }

            int roomID = -1;
            if (datagrid_Schedule_Rooms.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrid_Schedule_Rooms.SelectedRows[0];
                // Access cell values
                var cellValue = selectedRow.Cells[0].Value; // Example for first cell
                roomID = Convert.ToInt32(cellValue);

            }

            if (housekeeperID != -1)
            {
                admin.AssignSchedule(housekeeperID.ToString(), roomID.ToString(), timebox_Maintenance_Date.Value);
            } else
            {
                MessageBox.Show("Please Select a Housekeeper and a Room!");
            }
            
        }

        private void ManageHousekeepingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goodStayHotelDatabaseROOMS.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.goodStayHotelDatabaseROOMS.Rooms);
            // TODO: This line of code loads data into the 'goodStayHotelDatabaseDataSetHOUSEKEEPERS.Housekeepers' table. You can move, or remove it, as needed.
            this.housekeepersTableAdapter.Fill(this.goodStayHotelDatabaseDataSetHOUSEKEEPERS.Housekeepers);

        }


    }
}