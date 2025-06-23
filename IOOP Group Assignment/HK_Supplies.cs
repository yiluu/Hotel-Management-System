using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace IOOP_Group_Assignment
{
    public partial class HK_Supplies : Form
    {
        public DataGridView SuppliesDataGridView
        {
            get { return data_Supplies; }
        }

        private List<string> RowValues;
        public string SupplyType;
        public int selectedRowId;
        public bool editable;

        public HK_Supplies()
        {
            InitializeComponent();
            data_Supplies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RowValues = new List<string>();

        }        

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string SupplyName = txtbox_SupplyName.Text;
            int SupplyCount = 0;
            try
            {
                SupplyCount = int.Parse(txtbox_SupplyCount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Supply Count value");
                return;
            }

            if (string.IsNullOrEmpty(SupplyName) || string.IsNullOrEmpty(SupplyType))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            if (editable)
            {
                string newSupplyName = txtbox_SupplyName.Text;
                UpdateSuppliesEntry(selectedRowId, newSupplyName);
            }
            else 
            {
                Housekeeper house = new Housekeeper();
                house.AddSupply(SupplyName, SupplyType, SupplyCount);
            }
            
            LoadData("Supplies");

        }

        

        private void radio_Cleaning_CheckedChanged(object sender, EventArgs e)
        {
            SupplyType = "CleaningSupplies";
        }

        private void radio_Equipment_CheckedChanged(object sender, EventArgs e)
        {
            SupplyType = "Equipment";
        }

        private void HK_Supplies_Load(object sender, EventArgs e)
        {
            LoadData("Supplies");
        }

        



        private void data_Supplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                RowValues.Clear();

                

                DataGridViewRow row = data_Supplies.Rows[e.RowIndex];
                foreach (DataGridViewCell rowCell in row.Cells)
                {
                    string rowCellValue = rowCell.Value?.ToString() ?? "No Value";
                    RowValues.Add(rowCellValue);
                    
                }

                txtbox_SupplyName.Text = RowValues[2].ToString();
                txtbox_SupplyName.Focus();

                try
                {
                    if (RowValues[1].ToString() == "CleaningSupplies")
                    {
                        radio_Cleaning.Checked = true;
                    }

                    else if (RowValues[1].ToString() == "Equipment")
                    {
                        radio_Equipment.Checked = true;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                txtbox_SupplyCount.Text = RowValues[3].ToString();

                selectedRowId = Convert.ToInt32(row.Cells["SuppliesID"].Value);

                editable = true;

            }
        }

        private void LoadData(string tableName)
        {
            string query = "SELECT * FROM " + tableName;

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, tableName);

                data_Supplies.DataSource = dataSet.Tables[tableName];
            }
        }

        private void UpdateSuppliesEntry(int id, string newSupplyName)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Supplies SET SuppliesName = @SupplyName WHERE SuppliesID = @ID", con);
            cmd.Parameters.AddWithValue("@SupplyName", newSupplyName);
            cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully.");

                    LoadData("Supplies");
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            if (data_Supplies.SelectedRows.Count > 0)
            {
                int rowIndex = data_Supplies.SelectedRows[0].Index;
                DataGridViewRow selectedRow = data_Supplies.Rows[rowIndex];

                // Retrieve the ID of the selected row
                int id = Convert.ToInt32(selectedRow.Cells["SuppliesID"].Value); // Ensure "ID" is the correct column name

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Call method to delete from database

                    Housekeeper housekeeper = new Housekeeper();
                    housekeeper.DeleteEntryFromSupplies(id);

                    // Optionally, refresh the DataGridView
                    LoadData("Supplies");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }

        
}
