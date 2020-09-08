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
    public partial class Passenger_Login : Form
    {
        // connection string .....{change it according to yours }
        SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=TrainReservationSystem;Integrated Security=True");

        public Passenger_Login()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login_Options lo = new Login_Options();
            lo.Show();
            this.Hide();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                // open the connection string
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from passenger_signup where pEmail='" + passengerEmailBox.Text + "' and pPassword='" + passwordBox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Successfully ");
                    Passenger_Module pm = new Passenger_Module();
                    pm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your Login Email or Password is incorrect !..");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset_Passenger_Password rp = new Reset_Passenger_Password();
            rp.Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Passenger_Registeration pr = new Passenger_Registeration();
            pr.Show();
            this.Hide();
        }
    }
}
