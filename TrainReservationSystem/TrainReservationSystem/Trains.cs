using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainReservationSystem
{
    public partial class Trains : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=TrainReservationSystem;Integrated Security=True");


        public Trains()
        {   
            InitializeComponent();
            populateData();
            trainIdBox.Focus();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Admin_Module am = new Admin_Module();
            am.Show();
            this.Hide();
        }

        private void populateData()
        {
            sql.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from trains", sql);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string trainID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string trainName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string trainSource = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string destination = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    DateTime arrivalTime =Convert.ToDateTime( ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    DateTime departureTime =Convert.ToDateTime( ds.Tables[0].Rows[i].ItemArray[5].ToString());
                    string trainCoaches = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    string acSeats = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    string ecconomySeats = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    string fare = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = trainID;
                    row1.Cells[1].Value = trainName;
                    row1.Cells[2].Value = trainSource;
                    row1.Cells[3].Value = destination;
                    row1.Cells[4].Value = arrivalTime.TimeOfDay;
                    row1.Cells[5].Value = departureTime.TimeOfDay;
                    row1.Cells[6].Value = trainCoaches;
                    row1.Cells[7].Value = acSeats;
                    row1.Cells[8].Value = ecconomySeats;
                    row1.Cells[9].Value = fare;

                    dataGridView1.Rows.Add(row1);
                }
                sql.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void update()
        {
            string trainID = trainIdBox.Text;
            string trainName = trainNameBox.Text;
            string source = sourceBox.Text;
            string destination = destinationBox.Text;
            DateTime arrivalTime = arrivalTimePicker.Value;
            DateTime departureTime = departureTimePicker.Value;
            string coaches = coachesBox.Text;
            string acSeats = acSeatsBox.Text;
            string ecconomySeats = ecconomySeatsBox.Text;
            string fare = fareBox.Text;
           
            try
            {
                sql.Open();
                SqlCommand updateTrain = new SqlCommand("update Trains set trainNo=@trainID,trainName=@trainName,trainSource=@trainsource,destination=@destination,arrivalTime=@arrivalTime,departureTime=@departureTime,trainCoaches=@coaches,acSeats=@acSeats,economySeats=@ecconomySeats,fare=@fare where trainNo=@trainID", sql);

                updateTrain.Parameters.AddWithValue("@trainID", trainID);
                updateTrain.Parameters.AddWithValue("@trainName", trainName);
                updateTrain.Parameters.AddWithValue("@trainSource", source);
                updateTrain.Parameters.AddWithValue("@destination", destination);
                updateTrain.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                updateTrain.Parameters.AddWithValue("@departureTime", departureTime);
                updateTrain.Parameters.AddWithValue("@coaches", coaches);
                updateTrain.Parameters.AddWithValue("@acSeats", acSeats);
                updateTrain.Parameters.AddWithValue("@ecconomySeats", ecconomySeats);
                updateTrain.Parameters.AddWithValue("@fare", fare);
                updateTrain.ExecuteNonQuery();

                MessageBox.Show("Train Data Updated Successfully :)");
                sql.Close();
                populateData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void save()
        {
            string trainID = trainIdBox.Text;
            string trainName = trainNameBox.Text;
            string source = sourceBox.Text;
            string destination = destinationBox.Text;
            DateTime arrivalTime = arrivalTimePicker.Value;
            DateTime departureTime = departureTimePicker.Value;
            string coaches = coachesBox.Text;
            string acSeats = acSeatsBox.Text;
            string ecconomySeats = ecconomySeatsBox.Text;
            string fare = fareBox.Text;
            sql.Open();
            try
            {
                int stationNo = RandomNumber(1, 1000);
                SqlCommand insertTrain = new SqlCommand("insert into trains(trainNo,trainName,trainSource,destination,arrivalTime,departureTime,trainCoaches,acSeats,economySeats,fare) values(@trainID,@trainName,@trainSource,@destination,@arrivaltime,@departureTime,@coaches,@acSeats,@ecconomySeats,@fare)", sql);
                //SqlCommand insertStation = new SqlCommand("insert into Stations(stationNo,stationName,trainNo) Values(@sNo,@sName,@tNo)", sql);

                insertTrain.Parameters.AddWithValue("@trainID", trainID);
                insertTrain.Parameters.AddWithValue("@trainName", trainName);
                insertTrain.Parameters.AddWithValue("@trainSource", source);
                insertTrain.Parameters.AddWithValue("@destination", destination);
                insertTrain.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                insertTrain.Parameters.AddWithValue("@departureTime", departureTime);
                insertTrain.Parameters.AddWithValue("@coaches", coaches);
                insertTrain.Parameters.AddWithValue("@acSeats", acSeats);
                insertTrain.Parameters.AddWithValue("@ecconomySeats", ecconomySeats);
                insertTrain.Parameters.AddWithValue("@fare", fare);
                insertTrain.ExecuteNonQuery();
                
               /* for(int i=0;i<2;++i)
                {
                    stationNo = RandomNumber(1, 1000);
                    insertStation.Parameters.AddWithValue("@sNo", stationNo);
                    insertStation.Parameters.AddWithValue("@sName", source);
                    insertStation.Parameters.AddWithValue("@tNo", trainID);
                    insertStation.ExecuteNonQuery();
                }*/
                

                MessageBox.Show("Train Added Successfully :)");
                trainIdBox.Text = "";
                trainNameBox.Text = "";
                sourceBox.Text = "";
                destinationBox.Text = "";
                arrivalTimePicker.Text = "";
                departureTimePicker.Text = "";
                coachesBox.Text = "";
                acSeatsBox.Text = "";
                ecconomySeatsBox.Text = "";
                fareBox.Text = "";
                trainIdBox.Focus();   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql.Close();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            save();
            populateData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }
        private void delete()
        {
            try
            {
                sql.Open();
                string name = trainIdBox.Text;
                SqlCommand cmd = new SqlCommand("delete from Trains where trainNo=@a", sql);
                cmd.Parameters.AddWithValue("@a", name);
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Data Deleted Successfully ):");
                populateData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void search()
        {
            
            try
            {
                sql.Open();
                string data = searchBox.Text;
                SqlCommand cmd = new SqlCommand("select * from trains where trainNo like @a+'%'or trainName like @a+'%' or trainSource like @a+'%' or destination like @a+'%' or departureTime like @a+'%' or trainCoaches like @a+'%'or fare like @a+'%' or acSeats like @a+'%' or economySeats like @a+ '%'", sql);
                cmd.Parameters.AddWithValue("@a", data);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();
              
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string trainID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string trainName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string trainSource = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string destination = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    string arrivalTime = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    string departureTime = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    string trainCoaches = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    string acSeats = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    string ecconomySeats = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    string fare = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = trainID;
                    row1.Cells[1].Value = trainName;
                    row1.Cells[2].Value = trainSource;
                    row1.Cells[3].Value = destination;
                    row1.Cells[4].Value = arrivalTime;
                    row1.Cells[5].Value = departureTime;
                    row1.Cells[6].Value = trainCoaches;
                    row1.Cells[7].Value = acSeats;
                    row1.Cells[8].Value = ecconomySeats;
                    row1.Cells[9].Value = fare;
                    dataGridView1.Rows.Add(row1);
                }
                sql.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            trainIdBox.Text = row.Cells[0].Value.ToString();
            trainNameBox.Text = row.Cells[1].Value.ToString();
            sourceBox.Text = row.Cells[2].Value.ToString();
            destinationBox.Text = row.Cells[3].Value.ToString();
            arrivalTimePicker.Text = row.Cells[4].Value.ToString();
            departureTimePicker.Text = row.Cells[5].Value.ToString();
            coachesBox.Text = row.Cells[6].Value.ToString();
            acSeatsBox.Text = row.Cells[7].Value.ToString();
            ecconomySeatsBox.Text = row.Cells[8].Value.ToString();
            fareBox.Text = row.Cells[9].Value.ToString();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == null)
            {
                //if (e.KeyCode == Keys.Enter)
                // search();
                // search();
                populateData();
            }
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                // populateData();
            search();
            //search();
        }

        private void trainNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sourceBox.Focus();
        }
        

        private void trainIdBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                trainNameBox.Focus();
        }

        private void sourceBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                destinationBox.Focus();
        }

        private void destinationBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                arrivalTimePicker.Focus();
        }

        private void arrivalTimeBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
              departureTimePicker.Focus();
        }

        private void departureTimeBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                acSeatsBox.Focus();
        }

        private void acSeatsBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               ecconomySeatsBox.Focus();
        }

        private void ecconomySeatsBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                coachesBox.Focus();
        }

        private void coachesBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fareBox.Focus();
        }

        private void fareBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addButton.Focus();
        }

        private void trainIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void trainsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void departureTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
