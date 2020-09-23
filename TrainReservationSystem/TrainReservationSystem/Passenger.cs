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
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();

            populateData();
            DataSet ds = new DataSet();
            SqlCommand cmd1 = new SqlCommand("select trainNo,TrainName from Trains group by trainNo, trainName", sql);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            da.Fill(ds);
            trainNameBox.DisplayMember ="trainNo";
            trainNameBox.ValueMember = "trainNo";
            trainNameBox.DataSource = ds.Tables[0];
            passengerIdBox.Focus();
        }
        
        // sql connection string ..... { change it according to yours }
        SqlConnection sql = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=TrainReservationSystem;Integrated Security=True");

        private void populateData()
        {
            try
            {
                // open the sql connection
                sql.Open();
                SqlCommand cmd = new SqlCommand("select * from Passengers", sql);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string userId = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string fName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string gender = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string age = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    string email = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    string cnic = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    string contact = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    string city = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    string seatNo = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    string destination = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    string source = ds.Tables[0].Rows[i].ItemArray[10].ToString();
                    string seatType = ds.Tables[0].Rows[i].ItemArray[11].ToString();
                    //string ticketNo = ds.Tables[0].Rows[i].ItemArray[12].ToString();
                    string trainNo = ds.Tables[0].Rows[i].ItemArray[13].ToString();
                    DateTime departureDate =Convert.ToDateTime( ds.Tables[0].Rows[i].ItemArray[14].ToString());
                    string coachNo = ds.Tables[0].Rows[i].ItemArray[15].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = userId;
                    row1.Cells[1].Value = fName;
                    row1.Cells[2].Value = cnic;
                    row1.Cells[3].Value = email;
                    row1.Cells[4].Value = age;
                    row1.Cells[5].Value = gender;
                    row1.Cells[6].Value = city;
                    row1.Cells[7].Value = contact;
                    row1.Cells[8].Value = seatNo;
                    row1.Cells[9].Value = seatType;
                    row1.Cells[10].Value = source;
                    row1.Cells[11].Value = destination;
                    row1.Cells[12].Value = coachNo;
                    row1.Cells[13].Value = trainNo;
                    row1.Cells[14].Value = departureDate;
                    
                    dataGridView1.Rows.Add(row1);
                }
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        void save()
        {
            // open the sql connection string 
            sql.Open();
            try
            {
                int ticketNo = RandomNumber(1,10000);
                SqlCommand cmd = new SqlCommand("insert into Passengers(userID,passengerName,userGender,userAge,userEmail,userCnic,userMobNo,userCity,seatNo,userDestination,userSource,coachNo,seatType,trainNo,departureDate,ticketNo) " +
                    "values(@ID,@Name,@gender,@age,@email,@cnic,@contact,@city,@seatNo,@destination,@source,@coachNo,@seatType,@tNo,@depDate,@ticketNo)", sql);
                cmd.Parameters.AddWithValue("@ID", passengerIdBox.Text);
                cmd.Parameters.AddWithValue("@Name",passengerNameBox.Text);
                string gender;
                if (maleRadioBttn.Checked == true)
                {
                    gender = "Male";
                }
                else if (femaleRadioBttn.Checked == true)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Other";
                }
                cmd.Parameters.AddWithValue("@gender",gender);
                cmd.Parameters.AddWithValue("@age", ageBox.Text);
                cmd.Parameters.AddWithValue("@contact", contactBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@cnic", cnicBox.Text);
                cmd.Parameters.AddWithValue("@city", cityBox.Text);
                cmd.Parameters.AddWithValue("@seatNo", seatNoBox.Text);
                cmd.Parameters.AddWithValue("@destination", destinationBox.Text);
                cmd.Parameters.AddWithValue("@source", sourceBox.Text);
                cmd.Parameters.AddWithValue("@seatType", seatTypeBox.Text);
                cmd.Parameters.AddWithValue("@coachNo", coachNoBox.Text);
                string trainNamee = trainNameBox.Text;
                //string subString =trainNamee.Substring(0,trainNamee.IndexOf("-"));

                cmd.Parameters.AddWithValue("@tNo",trainNamee);
                cmd.Parameters.AddWithValue("@depDate", depDatePicker.Value);
                cmd.Parameters.AddWithValue("@ticketNo",ticketNo);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Seat Booked Successfully :)");
                passengerIdBox.Text = "";
                passengerNameBox.Text = "";
                sourceBox.Text = "";
                destinationBox.Text = "";
                contactBox.Text = "";
                coachNoBox.Text = "";
                seatTypeBox.Text = "";
                seatNoBox.Text = "";
                emailBox.Text = "";
                cnicBox.Text = "";
                cityBox.Text = "";
                maleRadioBttn.Checked = false;
                femaleRadioBttn.Checked = false;
                otherRadioBttn.Checked = false;
                ageBox.Text = "";
                trainNameBox.Text = "";
                passengerIdBox.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql.Close();
        }

        private void update()
        {
            string userId = passengerIdBox.Text;
            string uName = passengerNameBox.Text;
            string gender;
            if (maleRadioBttn.Checked == true)
            {
                gender = "Male";
            }
            else if (femaleRadioBttn.Checked == true)
            {
                gender = "Female";
            }
            else
            {
                gender = "Other";
            }
            string age = ageBox.Text;
            string email = emailBox.Text;
            string cnic = cnicBox.Text;
            string contact = contactBox.Text;
            string city = cityBox.Text;
            string seatNo = seatNoBox.Text;
            string destination = destinationBox.Text;
            string source = sourceBox.Text;
            string seatType = seatTypeBox.Text;
            string coachNo = coachNoBox.Text;
            string trainNamee = trainNameBox.Text;
            //string trainName = trainNamee.Substring(0, trainNamee.IndexOf("-")+2);
            DateTime depDate = depDatePicker.Value;

            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("update Passengers set userID=@userID,passengerName=@userName,userSource=@source,userDestination=@destination,userAge=@age,userGender=@gender,userEmail=@email,userCnic=@cnic,userMobNo=@contact,userCity=@city,seatNo=@seatNo,seatType=@seatType,coachNo=@coachNo,trainNo=@trainName,departureDate=@depDate where userID=@userId", sql);

                cmd.Parameters.AddWithValue("@userID", userId);
                cmd.Parameters.AddWithValue("@userName", uName);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@seatNo", seatNo);
                cmd.Parameters.AddWithValue("@destination", destination);
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@seatType", seatType);
                cmd.Parameters.AddWithValue("@coachNo", coachNo);
                cmd.Parameters.AddWithValue("@trainName", trainNamee);
                cmd.Parameters.AddWithValue("@depDate", depDate);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Booked Seat Updated Successfully :)");
                sql.Close();
                populateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete()
        {
            try
            {
                sql.Open();
                string id = passengerIdBox.Text;
                SqlCommand cmd = new SqlCommand("delete from Passengers where userID=@a", sql);
                cmd.Parameters.AddWithValue("@a", id);
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Booked Seat Deleted Successfully ):");
                populateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Admin_Module am = new Admin_Module();
            am.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            save();
            populateData();
        }

        private void passengerIdBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                passengerNameBox.Focus();
            }
        }

        private void passengerNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                emailBox.Focus();
            }
        }

        private void cnicBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                contactBox.Focus();
        }

        private void emailBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               cnicBox.Focus();
        }

        private void ageBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cityBox.Focus();
        }

        private void genderBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cityBox.Focus();
        }

        private void cityBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sourceBox.Focus();
        }

        private void contactBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                maleRadioBttn.Focus();
        }

        private void seatNoBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                seatTypeBox.Focus();
        }

        private void seatTypeBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sourceBox.Focus();
        }

        private void sourceBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                destinationBox.Focus();
        }

        private void destinationBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                trainNameBox.Focus();
        }

        private void coachNoBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                seatTypeBox.Focus();
        }

        private void ticketNoBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addButton.Focus();
        }

        private void addButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                updateButton.Focus();
        }

        private void updateButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                deleteButton.Focus();
        }

        private void Passenger_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            passengerIdBox.Text = row.Cells[0].Value.ToString();
            passengerNameBox.Text= row.Cells[1].Value.ToString();
            cnicBox.Text = row.Cells[2].Value.ToString();
            emailBox.Text = row.Cells[3].Value.ToString();
            ageBox.Text= row.Cells[4].Value.ToString();
            string gender = row.Cells[5].Value.ToString();
            if(gender=="Male")
            {
                maleRadioBttn.Checked = true;
            }
            else if(gender=="Female")
            {
                femaleRadioBttn.Checked = true;
            }
            else 
            {
                otherRadioBttn.Checked = true; 
            }
            cityBox.Text = row.Cells[6].Value.ToString();
            contactBox.Text= row.Cells[7].Value.ToString();
            seatNoBox.Text = row.Cells[8].Value.ToString();
            seatTypeBox.Text = row.Cells[9].Value.ToString();
            
            sourceBox.Text= row.Cells[10].Value.ToString();
            destinationBox.Text = row.Cells[11].Value.ToString();
            coachNoBox.Text= row.Cells[12].Value.ToString();
            trainNameBox.Text = row.Cells[13].Value.ToString();
            depDatePicker.Value = Convert.ToDateTime(row.Cells[14].Value.ToString());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void search()
        {
            
            try
            {
                sql.Open();
                string data = searchBox.Text;
                SqlCommand cmd = new SqlCommand("select * from Passengers where userID like @a+'%' or passengerName like @a+'%' or userSource like @a+'%' or userDestination like @a+'%' or userCnic like @a+'%' or userEmail like @a+'%'or userAge like @a+'%' or userGender like @a+'%' or userMobNo like @a+ '%' or userCity like @a+'%' or trainNo like @a+'%' or departureDate like @a+'%' " , sql);
                cmd.Parameters.AddWithValue("@a", data);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string userId = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string fName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string gender = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string age = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    string email = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    string cnic = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    string contact = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    string city = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    string seatNo = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    string destination = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    string source = ds.Tables[0].Rows[i].ItemArray[10].ToString();
                    string seatType = ds.Tables[0].Rows[i].ItemArray[11].ToString();
                    //string ticketNo = ds.Tables[0].Rows[i].ItemArray[12].ToString();
                    string trainNo = ds.Tables[0].Rows[i].ItemArray[13].ToString();
                    DateTime departureDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[14].ToString());
                    string coachNo = ds.Tables[0].Rows[i].ItemArray[15].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = userId;
                    row1.Cells[1].Value = fName;
                    row1.Cells[2].Value = cnic;
                    row1.Cells[3].Value = email;
                    row1.Cells[4].Value = age;
                    row1.Cells[5].Value = gender;
                    row1.Cells[6].Value = city;
                    row1.Cells[7].Value = contact;
                    row1.Cells[8].Value = seatNo;
                    row1.Cells[9].Value = seatType;
                    row1.Cells[10].Value = source;
                    row1.Cells[11].Value = destination;
                    row1.Cells[12].Value = coachNo;
                    row1.Cells[13].Value = trainNo;
                    row1.Cells[14].Value = departureDate;
                    dataGridView1.Rows.Add(row1);
                    
                }
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trains train = new Trains();
            train.Show();
            this.Hide();
        }

        private void updateTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trains train = new Trains();
            train.Show();
            this.Hide();
        }

        private void removeTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trains train = new Trains();
            train.Show();
            this.Hide();
        }

        private void addNewPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Passenger p = new Passenger();
            p.Show();
            this.Hide();
        }

        private void updateExistingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Passenger p = new Passenger();
            p.Show();
            this.Hide();
        }

        private void unBookSeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Passenger p = new Passenger();
            p.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maleRadioBttn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maleRadioBttn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                femaleRadioBttn.Focus();
        }

        private void femaleRadioBttn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                otherRadioBttn.Focus();
        }

        private void otherRadioBttn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ageBox.Focus();
        }

        private void depDatePicker_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                coachNoBox.Focus();
        }

        private void seatTypeBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                seatNoBox.Focus();
        }

        private void seatNoBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addButton.Focus();
        }

        private void deleteButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchBox.Focus();
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchButton.Focus();
        }
    }
}
