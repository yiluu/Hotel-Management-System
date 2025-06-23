using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace IOOP_Group_Assignment
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        private void SaveImageToDatabase(string connectionString, string imagePath)
        {
            byte[] imageData = File.ReadAllBytes(imagePath);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Images (ImageData) VALUES (@ImageData)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ImageData", imageData);
                    command.ExecuteNonQuery();
                }
            }
        }



        private void execute(string imagePath)
        {



            try
            {
                SaveImageToDatabase(connectionString, imagePath);
                MessageBox.Show("Image saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void NewUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private bool passwordVisibility = false;
        private void PasswordVisibilityButton_Click(object sender, EventArgs e)
        {
            passwordVisibility = !passwordVisibility;

            if (passwordVisibility) 
            {
                PasswordBox.UseSystemPasswordChar = false;
                PasswordVisibilityButton.Text = "Hide";
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
                PasswordVisibilityButton.Text = "Show";
            }
        }

        private void LoginPagePrompt_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var (userType, name) = AuthenticateUser(UsernameBox.Text, PasswordBox.Text);

            if (userType != null)
            {

                MessageBox.Show($"Login successful. User type: {userType}\nName: {name}");

                switch (userType)
                {
                    case "Customer":
                        Customer customerForm = new Customer();
                        customerForm.Show();
                        break;
                    case "Receptionist":
                        Receptionist receptionForm = new Receptionist();
                        receptionForm.Show();
                        break;
                    case "Housekeeper":
                        HousekeepingPage housekeeingForm = new HousekeepingPage();
                        housekeeingForm.Show(); 
                        break;
                    case "Manager":
                        ManagerPage managerForm = new ManagerPage();
                        managerForm.Show();
                        break;
                    default:
                        MessageBox.Show("Unknown user type.");
                        break;
                }
            }
            else
            {

                MessageBox.Show("Invalid username or password.");
            }
        }


        private (string UserType, string Name) AuthenticateUser(string username, string password)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            string query = @"
            SELECT UserType, Name
            FROM (
                SELECT 'Customer' AS UserType, Name
                FROM Customers
                WHERE Username = @Username AND Password = @Password
                UNION
                SELECT 'Receptionist' AS UserType, Name
                FROM Receptionists
                WHERE Username = @Username AND Password = @Password
                UNION
                SELECT 'Housekeeper' AS UserType, Name
                FROM Housekeepers
                WHERE Username = @Username AND Password = @Password
                UNION
                SELECT 'Manager' AS UserType, Name
                FROM Managers
                WHERE Username = @Username AND Password = @Password
            ) AS UserTypes";

            string userType = null;
            string name = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userType = reader["UserType"].ToString();
                                name = reader["Name"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            return (userType, name);
        }

        private void HotelTitle_Click(object sender, EventArgs e)
        {

        }




    }
}
