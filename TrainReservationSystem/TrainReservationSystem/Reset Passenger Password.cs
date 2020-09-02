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
    public partial class Reset_Passenger_Password : Form
    {
        public Reset_Passenger_Password()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Passenger_Login pl = new Passenger_Login();
            pl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }
        SqlConnection sql = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=TrainReservationSystem;Integrated Security=True");
        private void update()
        {
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmPasswordBox.Text;
            sql.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from passenger_signup where pEmail='" + emailBox.Text + "'", sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (password == confirmPassword)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("update passenger_signup set pPassword=@password", sql);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Updated Successfully :)");
                        Passenger_Login pl = new Passenger_Login();
                        pl.Show();
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else 
                {
                    MessageBox.Show("Password Does Not Match !!!....");
                }
            }
            else
            {
                MessageBox.Show("Your Email is incorrect !..");
            }
            sql.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void emailBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                passwordBox.Focus();
        }

        private void passwordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                confirmPasswordBox.Focus();
        }

        private void confirmPasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                resetButton.Focus();
        }
    }
}
