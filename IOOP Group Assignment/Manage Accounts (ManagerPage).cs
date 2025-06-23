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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Group_Assignment
{
    public partial class ManageAccountsForm : Form
    {
        private Manager admin;

        public ManageAccountsForm(Manager admin)
        {

            InitializeComponent();
            this.admin = admin;
       
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            
            admin.AddAccount(cmbbx_User_Type.Text, txtbox_Add_Name.Text, txtbox_Add_Username.Text, txtbox_Add_Password.Text);
            datagrid_Add_Receptionists.DataSource = GetData("Receptionists");
            datagrid_Add_Housekeepers.DataSource = GetData("Housekeepers");
            cmbbx_User_Type.SelectedIndex = -1;
            txtbox_Add_Name.Clear();
            txtbox_Add_Username.Clear();
            txtbox_Add_Password.Clear();
            ClearAllGridSelections();

        }

        private void btn_Edit_User_Click(object sender, EventArgs e)
        {
            
            if (datagrid_Edit_Receptionists.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = datagrid_Edit_Receptionists.SelectedRows[0];

                // Access cell values
                var cellValue = selectedRow.Cells[0].Value; // Example for first cell
                int ID = Convert.ToInt32(cellValue);
                admin.EditAccount(ID, "Receptionists", "ReceptionistID", txtbox_Edit_Name.Text, txtbox_Edit_Username.Text, txtbox_Edit_Password.Text);
            }
            else if (datagrid_Edit_Housekeepers.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = datagrid_Edit_Housekeepers.SelectedRows[0];

                // Access cell values
                var cellValue = selectedRow.Cells[0].Value; // Example for first cell
                int ID = Convert.ToInt32(cellValue);
                admin.EditAccount(ID, "Housekeepers", "HousekeeperID", txtbox_Edit_Name.Text, txtbox_Edit_Username.Text, txtbox_Edit_Password.Text);

            }
            datagrid_Edit_Receptionists.DataSource = GetData("Receptionists");
            datagrid_Edit_Housekeepers.DataSource = GetData("Housekeepers");
            txtbox_Edit_Name.Clear();
            txtbox_Edit_Username.Clear();
            txtbox_Edit_Password.Clear();
        }


        private void ManageAccountsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'goodStayHotelDatabaseDataSet1.Housekeepers' table. You can move, or remove it, as needed.
            this.housekeepersTableAdapter.Fill(this.goodStayHotelDatabaseDataSet1.Housekeepers);
            // TODO: This line of code loads data into the 'goodStayHotelDatabaseDataSet.Receptionists' table. You can move, or remove it, as needed.
            this.receptionistsTableAdapter.Fill(this.goodStayHotelDatabaseDataSet.Receptionists);
            ClearAllGridSelections();
        }

        private void lbl_Housekeepers_Click(object sender, EventArgs e)
        {
            this.receptionistsTableAdapter.Fill(this.goodStayHotelDatabaseDataSet.Receptionists);
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

        private void ClearAllGridSelections()
        {
            datagrid_Edit_Housekeepers.ClearSelection();
            datagrid_Add_Housekeepers.ClearSelection();
            datagrid_Edit_Receptionists.ClearSelection();
            datagrid_Add_Receptionists.ClearSelection();
        }

        private void btn_Add_Clear_Click(object sender, EventArgs e)
        {
            ClearAllGridSelections();
        }

        private void btn_Edit_Clear_Click(object sender, EventArgs e)
        {
            ClearAllGridSelections();
        }
    }
}
