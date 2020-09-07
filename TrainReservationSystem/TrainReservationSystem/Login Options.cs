﻿using System;
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
    
    public partial class Login_Options : Form
    {
        // connection string .....{change it according to yours }
        SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQL;Initial Catalog=TrainReservationSystem;Integrated Security=True");
        public Login_Options()
        {
            InitializeComponent();
        }

        private void Login_Options_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Admin_Login al = new Admin_Login();
            al.Show();
            this.Hide();
        }

        private void passengerButton_Click(object sender, EventArgs e)
        {
            Passenger_Login pl = new Passenger_Login();
            pl.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
