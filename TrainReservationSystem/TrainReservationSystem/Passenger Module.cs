using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainReservationSystem
{
    public partial class Passenger_Module : Form
    {
        public Passenger_Module()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Open the new passenger login form
            Passenger_Login pl = new Passenger_Login();
            pl.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit from application
            Application.Exit();
        }

        private void bookTicketButton_Click(object sender, EventArgs e)
        {
            // Open the new book tickets form
            Book_Ticket bk = new Book_Ticket();
            bk.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Open the new passenger registration form
            Passenger_Registeration pr = new Passenger_Registeration();
            pr.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Passenger_Login pl = new Passenger_Login();
            pl.Show();
            this.Hide();
        }
    }
}
