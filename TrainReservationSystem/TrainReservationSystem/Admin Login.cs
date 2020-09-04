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
    public partial class Admin_Login : Form
    { 
        // sql data connection //// change it according to your sql server connection
        SqlConnection con = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=TrainReservationSystem;Integrated Security=True");
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login_Options lo = new Login_Options();
            lo.Show();
            this.Hide();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // login buttton functinality
        private void enterButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from trainAdmin where adminID='"+ adminIdBox.Text +"' and adminPassword='" + passwordBox.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                MessageBox.Show("Login Successfully ");
                Admin_Module am = new Admin_Module();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your Admin ID or Password is incorrect !..");
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void adminIdBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                passwordBox.Focus();
        }

        private void passwordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginButton.Focus();
        }
    }
}
