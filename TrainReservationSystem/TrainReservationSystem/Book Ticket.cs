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

    public partial class Book_Ticket : Form
    {
        public Book_Ticket()
        {
            InitializeComponent();
            populateData();
            fromStationBox.Focus();
        }

        SqlConnection sql = new SqlConnection("Data Source=REHMAN-PC\\REHMANSQLSERVER;Initial Catalog=TrainReservationSystem;Integrated Security=True");

        private void populateData()
        {
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("select * from Ticket", sql);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var TicketNo = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string trainNo = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    var userID = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string seatType = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    string destination = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    string tSource = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    DateTime depDate =Convert.ToDateTime( ds.Tables[0].Rows[i].ItemArray[6].ToString());
                    string classType = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    var coachNo = ds.Tables[0].Rows[i].ItemArray[8].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = TicketNo;
                    row1.Cells[1].Value = trainNo;
                    row1.Cells[2].Value = tSource;
                    row1.Cells[3].Value = destination;
                    row1.Cells[4].Value = depDate;
                    row1.Cells[5].Value = classType;
                    row1.Cells[6].Value = seatType;
                    row1.Cells[7].Value = coachNo;
                    row1.Cells[8].Value = userID;
                    
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
            sql.Open();
            try
            {
                int ticketNo = RandomNumber(1, 10000);
                int userId = RandomNumber(1, 10000);
                SqlCommand cmd = new SqlCommand("insert into Ticket(ticketNo,trainNo,userID,tSource,destination,departureDate,classType,seatType,coachNo) " +
                    "values(@ticketNo,@trainNo,@userId,@source,@destination,@depDate,@classType,@seatType,@coachNo)", sql);
                cmd.Parameters.AddWithValue("@ticketNo",ticketNo);
                string trainNamee = trainNameBox.Text;
                string subString =trainNamee.Substring(0,trainNamee.IndexOf("-"));
                trainNoBox.Text = subString;
                cmd.Parameters.AddWithValue("@trainNo", trainNoBox.Text);
                string seatType="";
                if (singleRadioBttn.Checked == true)
                {
                    seatType = "Single";
                }
                else if (BerthRadioBttn.Checked == true)
                {
                    seatType = "Berth";
                }
            
                cmd.Parameters.AddWithValue("@seatType", seatType);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@source", fromStationBox.Text);
                cmd.Parameters.AddWithValue("@destination", toStationBox.Text);
                cmd.Parameters.AddWithValue("@depDate", departureDateBox.Value);
                cmd.Parameters.AddWithValue("@classType", classTypeBox.Text);
                cmd.Parameters.AddWithValue("@coachNo", coachNoBox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Seat Booked Successfully :)");
                toStationBox.Text = "";
                fromStationBox.Text = "";
                trainNameBox.Text = "";
                classTypeBox.Text = "";

                coachNoBox.Text = "";
                singleRadioBttn.Checked = false;
                BerthRadioBttn.Checked = false;
                toStationBox.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql.Close();
        }

        private void update()
        {
            string ticketNo = ticketNoBox.Text;
            string userId = userIdBox.Text;
            string seatType="";
            if (singleRadioBttn.Checked == true)
            {
                seatType = "Male";
            }
            else if (BerthRadioBttn.Checked == true)
            {
                seatType = "Female";
            }
            string source = fromStationBox.Text;
            string destination = toStationBox.Text;
            string classType = classTypeBox.Text;
            string coachNo = coachNoBox.Text;    
            string trainName = trainNameBox.Text;
            //string trainName = trainNamee.Substring(0, trainNamee.IndexOf("-"));
            DateTime depDate = departureDateBox.Value;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("update Ticket set ticketNo=@ticketNo,trainNo=@trainNo,seatType=@seatType,tSource=@source,destination=@destination,classType=@classType,coachNo=@coachNo,departureDate=@depDate where ticketNo=@ticketNo", sql);

                cmd.Parameters.AddWithValue("@ticketNo", ticketNo);
                cmd.Parameters.AddWithValue("@trainNo", trainName);
                cmd.Parameters.AddWithValue("@seatType", seatType);
                cmd.Parameters.AddWithValue("@source", source);
                cmd.Parameters.AddWithValue("@destination", destination);
                cmd.Parameters.AddWithValue("@classType", classType);
                cmd.Parameters.AddWithValue("@coachNo", coachNo);
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

                var ticketNo = ticketNoBox.Text;
                SqlCommand cmd = new SqlCommand("delete from Ticket where ticketNo=@a", sql);
                cmd.Parameters.AddWithValue("@a", ticketNo);
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Booked Seat Cancelled Successfully ):");
                populateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            fromStationBox.Text = row.Cells[2].Value.ToString();
            toStationBox.Text = row.Cells[3].Value.ToString();
            trainNameBox.Text = row.Cells[1].Value.ToString();
            classTypeBox.Text = row.Cells[5].Value.ToString();
            string seatType = row.Cells[6].Value.ToString();
            if (seatType == "Single")
            {
                singleRadioBttn.Checked = true;
            }
            else if (seatType == "Berth")
            {
                BerthRadioBttn.Checked = true;
            }
            coachNoBox.Text = row.Cells[7].Value.ToString();
            departureDateBox.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
        }

        private void search()
        {

            try
            {
                sql.Open();
                string data = searchBox.Text;
                SqlCommand cmd = new SqlCommand("select * from Ticket where ticketNo like @a+'%' or trainNo like @a+'%' or tSource like @a+'%' or destination like @a+'%' or userID like @a+'%' or classType like @a+'%'or SeatType like @a+'%' or coachNo like @a+'%' or departureDate like @a+ '%' ", sql);
                cmd.Parameters.AddWithValue("@a", data);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string ticketNo = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string trainName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string source = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string destination = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    
                    string classType = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    string seatType = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    string coachNo = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    string userId = ds.Tables[0].Rows[i].ItemArray[8].ToString();
               
                    DateTime depDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = ticketNo;
                    row1.Cells[1].Value = trainName;
                    row1.Cells[2].Value = source;
                    row1.Cells[3].Value = destination;
                    row1.Cells[4].Value = depDate;
                    row1.Cells[5].Value = classType;
                    row1.Cells[6].Value = seatType;
                    row1.Cells[7].Value = coachNo;
                    row1.Cells[8].Value = userId;
                    dataGridView1.Rows.Add(row1);

                }
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void backButton_Click(object sender, EventArgs e)
        {
            Passenger_Module pm = new Passenger_Module();
            pm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toStationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd1 = new SqlCommand("select concat(trainNo,'-',TrainName) AS trainNam from Trains where Trains.trainSource='" + fromStationBox.Text + "' and Trains.destination='" + toStationBox.Text + "' group by trainNo, trainName", sql);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            da.Fill(ds);
            trainNameBox.DisplayMember = "trainNam";
            trainNameBox.ValueMember = "trainNo";
            trainNameBox.DataSource = ds.Tables[0];
        }

        private void toStationBox_Leave(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd1 = new SqlCommand("select concat(trainNo,'-',TrainName) AS trainNam from Trains where Trains.trainSource='"+fromStationBox.Text+"' and Trains.destination='"+toStationBox.Text+"' group by trainNo, trainName", sql);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            da.Fill(ds);
            trainNameBox.DisplayMember = "trainNam";
            trainNameBox.ValueMember = "trainNo";
            trainNameBox.DataSource = ds.Tables[0];
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            save();
            populateData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            delete();
            populateData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            fromStationBox.Text = row.Cells[2].Value.ToString();
            toStationBox.Text = row.Cells[3].Value.ToString();
            trainNameBox.Text = row.Cells[1].Value.ToString();
            classTypeBox.Text = row.Cells[5].Value.ToString();
            string seatType = row.Cells[6].Value.ToString();
            if (seatType == "Single")
            {
                singleRadioBttn.Checked = true;
            }
            else if (seatType == "Berth")
            {
                BerthRadioBttn.Checked = true;
            }
            coachNoBox.Text = row.Cells[7].Value.ToString();
            departureDateBox.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());

            trainNoBox.Text = trainNameBox.Text; ;
            ticketNoBox.Text= row.Cells[0].Value.ToString();
            userIdBox.Text= row.Cells[8].Value.ToString();
        }

        private void trainNameBox_Leave(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd1 = new SqlCommand("select trainCoaches from Trains where trainNo='" + trainNoBox.Text + "'", sql);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            da.Fill(ds);
            coachNoBox.DisplayMember = "trainCoaches";
            coachNoBox.ValueMember = "trainNo";
            coachNoBox.DataSource = ds.Tables[0];
        }

        private void trainNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trainNamee = trainNameBox.Text;
            string trainName = trainNamee.Substring(0, trainNamee.IndexOf("-"));

            DataSet ds = new DataSet();
            SqlCommand cmd1 = new SqlCommand("select trainCoaches from Trains where trainNo='" + trainName + "'", sql);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            da.Fill(ds);
            coachNoBox.DisplayMember = "trainCoaches";
            coachNoBox.ValueMember = "trainNo";
            coachNoBox.DataSource = ds.Tables[0];
        }

        private void Book_Ticket_Load(object sender, EventArgs e)
        {

        }

        private void trainNoBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
