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
using System.IO;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace IOOP_Group_Assignment
{
    public partial class HousekeepingPage : Form
    {

        public HousekeepingPage() 
        {
            InitializeComponent();
            
        }

        public string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            HK_Schedule f1 = new HK_Schedule();
            f1.ShowDialog();
        }

        private void btn_ManageSupply_Click(object sender, EventArgs e)
        {
            HK_Supplies f2 = new HK_Supplies();
            f2.ShowDialog();
        }

        private void btn_Pfp_Click(object sender, EventArgs e)
        {
            UpdateProfile f3 = new UpdateProfile(1); //Please change 1 to HousekeeperID received when logging in
            f3.ShowDialog();
        }

        private void HousekeepingPage_Load(object sender, EventArgs e)
        {
            Housekeeper housekeeper = new Housekeeper();
            int pfpid = housekeeper.GetProfilePictureId("Housekeepers");
            housekeeper.LoadImageToButton(btn_Pfp, connectionString, pfpid);
            
        }
    }
}
