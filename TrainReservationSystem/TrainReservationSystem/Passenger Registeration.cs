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
    public partial class Passenger_Registeration : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=TrainReservationSystem;Integrated Security=True");

        public Passenger_Registeration()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Passenger_Login pl = new Passenger_Login();
            pl.Show();
            this.Hide();
        }
        // Generate a random number between two numbers  
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string cnic = cnicBox.Text;
            string email = emailBox.Text;
            string contact = contactBox.Text;
            string age = ageBox.Text;
            string gender;
            if(maleRadioBttn.Checked==true)
            {
                gender = "Male";
            }
            else if(femaleRadioBttn.Checked==true)
            {
                gender = "Female";
            }
            else
            {
                gender = "Other";
            }
            string city = cityBox.Text;
            string password = passwordBox.Text;
            try
            {
                sql.Open();
                int userID = RandomNumber(1, 1000);
                SqlCommand sc = new SqlCommand("select pId from passenger_signup where pId=@a", sql);
                sc.Parameters.AddWithValue("@a", userID);
                
                SqlCommand cmd = new SqlCommand("insert into passenger_signup(pId,pFirstName,pLastName,pCnic,pEmail,pContact,age,pGender,pCity,pPassword) values(@userID,@firstName,@lastName,@cnic,@email,@contact,@age,@gender,@city,@password)", sql);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (passwordBox.Text == confirmPasswordBox.Text)
            {
                MessageBox.Show("User Registered Successfully :)");
                firstNameBox.Text = "";
                lastNameBox.Text = "";
                cnicBox.Text = "";
                emailBox.Text = "";
                ageBox.Text = "";
                contactBox.Text = "";
                cityBox.Text = "";
                passwordBox.Text = "";
                confirmPasswordBox.Text = "";
                firstNameBox.Focus();
                

                Passenger_Login pl = new Passenger_Login();
                pl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password does not Match ");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            cnicBox.Text = "";
            emailBox.Text = "";
            ageBox.Text = "";
            contactBox.Text = "";
            cityBox.Text = "";
            passwordBox.Text = "";
            confirmPasswordBox.Text = "";
            firstNameBox.Focus();
        }
    }
}
