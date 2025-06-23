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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        public string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddCustomer Add = new AddCustomer();
            Add.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteCustomer Delete = new DeleteCustomer();
            Delete.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Check_In checkIn = new Check_In();
            checkIn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Checkout checkOUT = new Checkout();
            checkOUT.ShowDialog();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            Housekeeper housekeeper = new Housekeeper();
            int pfpid = housekeeper.GetProfilePictureId("Receptionists");
            housekeeper.LoadImageToButton(btn_Pfp, connectionString, pfpid);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
        }

        private void btn_Pfp_Click(object sender, EventArgs e)
        {
            UpdateProfile f3 = new UpdateProfile(1); //Please change 1 to HousekeeperID received when logging in
            f3.ShowDialog();
        }
    }
}
