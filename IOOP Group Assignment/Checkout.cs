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
    public partial class Checkout : Form
    {
        private string connectionString = @"Server=(localdb)\mssqllocaldb;Integrated Security=true;AttachDbFilename=D:\ioop\ioop\IOOP Group Assignment\GoodStayHotelDatabase.mdf;";
        private CheckoutHandler checkoutHandler;

        public Checkout()
        {
            InitializeComponent();
            checkoutHandler = new CheckoutHandler(connectionString);
            CheckOut_btn.Click += new EventHandler(CheckOut_btn_Click_1);
            paymBtn.Click += new EventHandler(paymBtn_Click_1);
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void paymBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(name_TextBox.Text);
                int reservationID = checkoutHandler.GetReservationIDByName(customerId);

                if (reservationID > 0)
                {
                    checkoutHandler.UpdatePaymentStatus(reservationID);
                    paymTextbox.Text = "Payment has been collected. Thank you for using GoodStay Hotel.";
                }
                else
                {
                    MessageBox.Show("Reservation not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void paymTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckOut_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(name_TextBox.Text);
                int reservationID = checkoutHandler.GetReservationIDByName(customerId);

                if (reservationID > 0)
                {
                    MessageBox.Show("Done Check Out");
                }
                else
                {
                    MessageBox.Show("Reservation not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}