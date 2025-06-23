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
    public partial class UpdateProfile : Form
    {
        private int _housekeeperid;

        public UpdateProfile(int housekeeperid)
        {
            InitializeComponent();
            _housekeeperid = housekeeperid;
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT Name, Username, Password FROM Housekeepers WHERE HousekeeperID = @HousekeeperID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@HousekeeperID", _housekeeperid);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string name = reader["Name"].ToString();
                            string username = reader["Username"].ToString();
                            string password = reader["Password"].ToString();

                            txtbox_Name.Text = name;
                            txtbox_Username.Text = username;
                            txtbox_Password.Text = password;
                        }
                        else
                        {
                            MessageBox.Show("Error while reading information");
                        }
                    }
                }
            }
        }

        private void btn_Pfp_Click(object sender, EventArgs e)
        {
            ChangeProfilePicturePage f4 = new ChangeProfilePicturePage();
            f4.ShowDialog();
        }



        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string name = txtbox_Name.Text;
            string username = txtbox_Username.Text;
            string password = txtbox_Password.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    string query = "UPDATE Housekeepers SET Name = @name, Username = @username, Password = @password WHERE HousekeeperID = @HousekeeperID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@HousekeeperID", Convert.ToInt32(_housekeeperid));
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No records updated. Please ensure the HousekeeperID is correct.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
