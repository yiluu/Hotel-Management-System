using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class Customer : Form
    {

        public string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        public Customer()
        {
            InitializeComponent();
        }

        private void HotelTitle_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Housekeeper housekeeper = new Housekeeper();
            int pfpid = housekeeper.GetProfilePictureId("Housekeepers");
            housekeeper.LoadImageToButton(btn_Pfp, connectionString, pfpid);
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            Rooms1 f2 = new Rooms1();
            f2.Show();
        }


        private void btn_Managereservations_Click(object sender, EventArgs e)
        {
            Manage_reservations f2 = new Manage_reservations();
            f2.Show();
        }

        private void btnSend_review_Click(object sender, EventArgs e)
        {
            send_a_review f2 = new send_a_review();
            f2.Show();
        }

        private void btn_Pfp_Click(object sender, EventArgs e)
        {
            UpdateProfile f3 = new UpdateProfile(1); //Please change 1 to HousekeeperID received when logging in
            f3.ShowDialog();
        }
    }
}
