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


namespace TrainReservationSystem
{
    public partial class Admin_Module : Form
    {
        public Admin_Module()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Admin_Login al = new Admin_Login();
            al.Show();
            this.Hide();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            Trains train = new Trains();
            train.Show();
            this.Hide();
        }

        private void passergersButton_Click(object sender, EventArgs e)
        {
            Passenger passnger = new Passenger();
            passnger.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
