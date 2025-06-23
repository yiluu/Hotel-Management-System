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
    public partial class AddCustomer : Form
    {
        
        private string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        public AddCustomer()
        {
            InitializeComponent();
        }

        // Event handler for Add Customer button click
       

        
        private bool IsValidDateOfBirth(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (dob > DateTime.Now.AddYears(-age)) age--;
            return age >= 12;
        }

        // Method to validate phone number
        private bool IsValidPhoneNumber(string phoneNo)
        {
            return phoneNo.All(char.IsDigit) && phoneNo.Length == 10;
        }

        
        private string GenerateCustomerID()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            char[] customerID = new char[3];
            for (int i = 0; i < customerID.Length; i++)
            {
                customerID[i] = characters[random.Next(characters.Length)];
            }
            return new string(customerID);
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomr_Btn_Click(object sender, EventArgs e)
        {
            
            string fullName = Full_NameTextBox.Text;
            string ic = IC_TextBox.Text;
            string address = Address_TextBox.Text;
            string phoneNo = PhnNoTextBox.Text;
            DateTime dob = DOB.Value;
            string email = Email_TextBox.Text;
            string password = Pass_TextBox.Text;

            
            if (!IsValidDateOfBirth(dob))
            {
                MessageBox.Show("Customer must be at least 12 years old.");
                return;
            }

            if (!IsValidPhoneNumber(phoneNo))
            {
                MessageBox.Show("Phone number must be 10 digits and only contain numbers.");
                return;
            }

            
            string customerID = GenerateCustomerID();

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Customers ( IC_Passport, Name, Address, PhoneNumber, DOB, Email, Password) " +
                                   "VALUES ( @IC_Passport, @Name, @Address, @PhoneNumber, @DOB, @Email, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@IC_Passport", ic);
                        cmd.Parameters.AddWithValue("@Name", fullName);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNo);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        
                        cmd.ExecuteNonQuery();
                    }

                    
                    MessageBox.Show($"Customer added successfully!");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error saving customer: " + ex.Message);
                }
            }
        }

        private void Full_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}