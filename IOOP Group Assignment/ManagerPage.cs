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
    public partial class ManagerPage : Form
    {
        public Manager admin;

        public ManagerPage()
        {
            InitializeComponent();
            admin = new Manager("testusername", "testpassword", "testID");
        }


        public void ManagerPage_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Manage_Accounts_Click(object sender, EventArgs e)
        {
            ManageAccountsForm form = new ManageAccountsForm(admin);
            form.Show();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            ManageRoomsForm form = new ManageRoomsForm(admin);
            form.Show();
        }
        private void btn_Manage_Housekeeping_Click(object sender, EventArgs e)
        {
            ManageHousekeepingForm form = new ManageHousekeepingForm(admin);
            form.Show();
        }
        private void btn_View_Report_Click(object sender, EventArgs e)
        {
            ViewReportForm form = new ViewReportForm(admin);
            form.Show();
        }

        

        

        
    }
}
