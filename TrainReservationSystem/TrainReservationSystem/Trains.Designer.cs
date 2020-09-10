namespace TrainReservationSystem
{
    partial class Trains
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        ///
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.destinationBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sourceBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trainNameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.trainIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ecconomySeatsBox = new System.Windows.Forms.TextBox();
            this.acSeatsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fareBox = new System.Windows.Forms.TextBox();
            this.coachesBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Train_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_Coaches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC_Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ecconomy_Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBookSeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label14.Location = new System.Drawing.Point(281, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 22);
            this.label14.TabIndex = 71;
            this.label14.Text = "Departure Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label15.Location = new System.Drawing.Point(6, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 23);
            this.label15.TabIndex = 70;
            this.label15.Text = "Arrival Time";
            // 
            // destinationBox
            // 
            this.destinationBox.Location = new System.Drawing.Point(416, 167);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(148, 20);
            this.destinationBox.TabIndex = 3;
            this.destinationBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.destinationBox_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label13.Location = new System.Drawing.Point(304, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 23);
            this.label13.TabIndex = 66;
            this.label13.Text = "Destination";
            // 
            // sourceBox
            // 
            this.sourceBox.Location = new System.Drawing.Point(121, 167);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(144, 20);
            this.sourceBox.TabIndex = 2;
            this.sourceBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sourceBox_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label11.Location = new System.Drawing.Point(27, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 23);
            this.label11.TabIndex = 60;
            this.label11.Text = "Source";
            // 
            // trainNameBox
            // 
            this.trainNameBox.Location = new System.Drawing.Point(416, 129);
            this.trainNameBox.Name = "trainNameBox";
            this.trainNameBox.Size = new System.Drawing.Size(148, 20);
            this.trainNameBox.TabIndex = 1;
            this.trainNameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trainNameBox_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label8.Location = new System.Drawing.Point(302, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 55;
            this.label8.Text = "Train Name";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(910, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 42);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(792, 398);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 42);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.updateButton.Location = new System.Drawing.Point(272, 337);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(124, 42);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(121, 337);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 42);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // trainIdBox
            // 
            this.trainIdBox.Location = new System.Drawing.Point(121, 126);
            this.trainIdBox.Name = "trainIdBox";
            this.trainIdBox.Size = new System.Drawing.Size(144, 20);
            this.trainIdBox.TabIndex = 0;
            this.trainIdBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trainIdBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 39);
            this.label2.TabIndex = 45;
            this.label2.Text = "Trains";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label1.Location = new System.Drawing.Point(27, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Train ID";
            // 
            // ecconomySeatsBox
            // 
            this.ecconomySeatsBox.Location = new System.Drawing.Point(416, 245);
            this.ecconomySeatsBox.Name = "ecconomySeatsBox";
            this.ecconomySeatsBox.Size = new System.Drawing.Size(148, 20);
            this.ecconomySeatsBox.TabIndex = 7;
            this.ecconomySeatsBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ecconomySeatsBox_KeyUp);
            // 
            // acSeatsBox
            // 
            this.acSeatsBox.Location = new System.Drawing.Point(121, 244);
            this.acSeatsBox.Name = "acSeatsBox";
            this.acSeatsBox.Size = new System.Drawing.Size(144, 20);
            this.acSeatsBox.TabIndex = 6;
            this.acSeatsBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.acSeatsBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label3.Location = new System.Drawing.Point(281, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Ecconomy Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label4.Location = new System.Drawing.Point(20, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 74;
            this.label4.Text = "AC Seats";
            // 
            // fareBox
            // 
            this.fareBox.Location = new System.Drawing.Point(416, 282);
            this.fareBox.Name = "fareBox";
            this.fareBox.Size = new System.Drawing.Size(148, 20);
            this.fareBox.TabIndex = 9;
            this.fareBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fareBox_KeyUp);
            // 
            // coachesBox
            // 
            this.coachesBox.Location = new System.Drawing.Point(121, 281);
            this.coachesBox.Name = "coachesBox";
            this.coachesBox.Size = new System.Drawing.Size(144, 20);
            this.coachesBox.TabIndex = 8;
            this.coachesBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.coachesBox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label5.Location = new System.Drawing.Point(304, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 79;
            this.label5.Text = "Fare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label7.Location = new System.Drawing.Point(17, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 78;
            this.label7.Text = "Coaches";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(430, 337);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(134, 42);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.CursorChanged += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Train_ID,
            this.Train_Name,
            this.Train_Source,
            this.Train_Destination,
            this.arrivalTime,
            this.departure_Time,
            this.Train_Coaches,
            this.AC_Seats,
            this.Ecconomy_Seats,
            this.fare});
            this.dataGridView1.Location = new System.Drawing.Point(590, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 250);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Train_ID
            // 
            this.Train_ID.HeaderText = "Train ID";
            this.Train_ID.Name = "Train_ID";
            // 
            // Train_Name
            // 
            this.Train_Name.HeaderText = "Train Name";
            this.Train_Name.Name = "Train_Name";
            // 
            // Train_Source
            // 
            this.Train_Source.HeaderText = "Train Source";
            this.Train_Source.Name = "Train_Source";
            // 
            // Train_Destination
            // 
            this.Train_Destination.HeaderText = "Train Destination";
            this.Train_Destination.Name = "Train_Destination";
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.Name = "arrivalTime";
            // 
            // departure_Time
            // 
            this.departure_Time.HeaderText = "Departure Time";
            this.departure_Time.Name = "departure_Time";
            // 
            // Train_Coaches
            // 
            this.Train_Coaches.HeaderText = "Coaches";
            this.Train_Coaches.Name = "Train_Coaches";
            // 
            // AC_Seats
            // 
            this.AC_Seats.HeaderText = "AC Seats";
            this.AC_Seats.Name = "AC_Seats";
            // 
            // Ecconomy_Seats
            // 
            this.Ecconomy_Seats.HeaderText = "Ecconomy Seats";
            this.Ecconomy_Seats.Name = "Ecconomy_Seats";
            // 
            // fare
            // 
            this.fare.HeaderText = "Fare";
            this.fare.Name = "fare";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(653, 104);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(288, 20);
            this.searchBox.TabIndex = 13;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label10.Location = new System.Drawing.Point(586, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 128;
            this.label10.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(947, 102);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainsToolStripMenuItem,
            this.passengersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 25);
            this.menuStrip1.TabIndex = 144;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trainsToolStripMenuItem
            // 
            this.trainsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTrainToolStripMenuItem,
            this.updateTrainToolStripMenuItem,
            this.removeTrainToolStripMenuItem});
            this.trainsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainsToolStripMenuItem.Name = "trainsToolStripMenuItem";
            this.trainsToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.trainsToolStripMenuItem.Text = "Trains";
            this.trainsToolStripMenuItem.Click += new System.EventHandler(this.trainsToolStripMenuItem_Click);
            // 
            // addTrainToolStripMenuItem
            // 
            this.addTrainToolStripMenuItem.Name = "addTrainToolStripMenuItem";
            this.addTrainToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addTrainToolStripMenuItem.Text = "Add Train";
            this.addTrainToolStripMenuItem.Click += new System.EventHandler(this.addTrainToolStripMenuItem_Click);
            // 
            // updateTrainToolStripMenuItem
            // 
            this.updateTrainToolStripMenuItem.Name = "updateTrainToolStripMenuItem";
            this.updateTrainToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateTrainToolStripMenuItem.Text = "Update Train";
            this.updateTrainToolStripMenuItem.Click += new System.EventHandler(this.updateTrainToolStripMenuItem_Click);
            // 
            // removeTrainToolStripMenuItem
            // 
            this.removeTrainToolStripMenuItem.Name = "removeTrainToolStripMenuItem";
            this.removeTrainToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.removeTrainToolStripMenuItem.Text = "Remove Train";
            this.removeTrainToolStripMenuItem.Click += new System.EventHandler(this.removeTrainToolStripMenuItem_Click);
            // 
            // passengersToolStripMenuItem
            // 
            this.passengersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPassengerToolStripMenuItem,
            this.updateExistingToolStripMenuItem,
            this.unBookSeatToolStripMenuItem});
            this.passengersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengersToolStripMenuItem.Name = "passengersToolStripMenuItem";
            this.passengersToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.passengersToolStripMenuItem.Text = "Passengers";
            // 
            // addNewPassengerToolStripMenuItem
            // 
            this.addNewPassengerToolStripMenuItem.Name = "addNewPassengerToolStripMenuItem";
            this.addNewPassengerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addNewPassengerToolStripMenuItem.Text = "Book Seat";
            this.addNewPassengerToolStripMenuItem.Click += new System.EventHandler(this.addNewPassengerToolStripMenuItem_Click);
            // 
            // updateExistingToolStripMenuItem
            // 
            this.updateExistingToolStripMenuItem.Name = "updateExistingToolStripMenuItem";
            this.updateExistingToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.updateExistingToolStripMenuItem.Text = "Re-Book Seat";
            this.updateExistingToolStripMenuItem.Click += new System.EventHandler(this.updateExistingToolStripMenuItem_Click);
            // 
            // unBookSeatToolStripMenuItem
            // 
            this.unBookSeatToolStripMenuItem.Name = "unBookSeatToolStripMenuItem";
            this.unBookSeatToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.unBookSeatToolStripMenuItem.Text = "Un-Book Seat";
            this.unBookSeatToolStripMenuItem.Click += new System.EventHandler(this.unBookSeatToolStripMenuItem_Click);
            // 
            // arrivalTimePicker
            // 
            this.arrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTimePicker.Location = new System.Drawing.Point(121, 205);
            this.arrivalTimePicker.Name = "arrivalTimePicker";
            this.arrivalTimePicker.ShowUpDown = true;
            this.arrivalTimePicker.Size = new System.Drawing.Size(144, 20);
            this.arrivalTimePicker.TabIndex = 145;
            this.arrivalTimePicker.Value = new System.DateTime(2020, 9, 2, 3, 46, 1, 0);
            // 
            // departureTimePicker
            // 
            this.departureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departureTimePicker.Location = new System.Drawing.Point(416, 205);
            this.departureTimePicker.Name = "departureTimePicker";
            this.departureTimePicker.ShowUpDown = true;
            this.departureTimePicker.Size = new System.Drawing.Size(148, 20);
            this.departureTimePicker.TabIndex = 146;
            this.departureTimePicker.Value = new System.DateTime(2020, 9, 2, 3, 46, 1, 0);
            this.departureTimePicker.ValueChanged += new System.EventHandler(this.departureTimePicker_ValueChanged);
            // 
            // Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1047, 452);
            this.Controls.Add(this.departureTimePicker);
            this.Controls.Add(this.arrivalTimePicker);
            this.Controls.Add(this.fareBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.coachesBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ecconomySeatsBox);
            this.Controls.Add(this.acSeatsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trainNameBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.trainIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Trains";
            this.Text = "Trains";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox destinationBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox trainNameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox trainIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ecconomySeatsBox;
        private System.Windows.Forms.TextBox acSeatsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fareBox;
        private System.Windows.Forms.TextBox coachesBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_Coaches;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC_Seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ecconomy_Seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn fare;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBookSeatToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker arrivalTimePicker;
        private System.Windows.Forms.DateTimePicker departureTimePicker;
    }
}
