namespace TrainReservationSystem
{
    partial class Passenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cnicBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.passengerNameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.coachNoBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.trainNameBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.depDatePicker = new System.Windows.Forms.DateTimePicker();
            this.seatNoBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBookSeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatTypeBox = new System.Windows.Forms.ComboBox();
            this.maleRadioBttn = new System.Windows.Forms.RadioButton();
            this.otherRadioBttn = new System.Windows.Forms.RadioButton();
            this.femaleRadioBttn = new System.Windows.Forms.RadioButton();
            this.passengerIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.sourceBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridView1.Location = new System.Drawing.Point(611, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 259);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Passenger ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Passenger Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CNIC";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Age";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "City";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Contact";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Seat No";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Seat Type";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Source";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Destination";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Coach No";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Train Number";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Departure Date";
            this.Column15.Name = "Column15";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(419, 401);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(134, 42);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Un-Book";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.deleteButton_KeyUp);
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(106, 171);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(148, 20);
            this.contactBox.TabIndex = 4;
            this.contactBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.contactBox_KeyUp);
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(405, 197);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(148, 20);
            this.cityBox.TabIndex = 9;
            this.cityBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cityBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label3.Location = new System.Drawing.Point(565, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label4.Location = new System.Drawing.Point(311, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 102;
            this.label4.Text = "City";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(106, 194);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(148, 20);
            this.ageBox.TabIndex = 8;
            this.ageBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ageBox_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label14.Location = new System.Drawing.Point(8, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 99;
            this.label14.Text = "Contact";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label15.Location = new System.Drawing.Point(26, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 23);
            this.label15.TabIndex = 98;
            this.label15.Text = "Age";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(106, 145);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(148, 20);
            this.emailBox.TabIndex = 2;
            this.emailBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.emailBox_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label13.Location = new System.Drawing.Point(16, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 23);
            this.label13.TabIndex = 96;
            this.label13.Text = "Email";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cnicBox
            // 
            this.cnicBox.Location = new System.Drawing.Point(405, 144);
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.Size = new System.Drawing.Size(150, 20);
            this.cnicBox.TabIndex = 3;
            this.cnicBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cnicBox_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label11.Location = new System.Drawing.Point(311, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 23);
            this.label11.TabIndex = 94;
            this.label11.Text = "CNIC";
            // 
            // passengerNameBox
            // 
            this.passengerNameBox.Location = new System.Drawing.Point(405, 116);
            this.passengerNameBox.Name = "passengerNameBox";
            this.passengerNameBox.Size = new System.Drawing.Size(148, 20);
            this.passengerNameBox.TabIndex = 1;
            this.passengerNameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passengerNameBox_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label8.Location = new System.Drawing.Point(315, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 91;
            this.label8.Text = "Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(981, 450);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 42);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(863, 450);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 42);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.updateButton.Location = new System.Drawing.Point(261, 401);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(124, 42);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Re-Book";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            this.updateButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.updateButton_KeyUp);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(110, 401);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 42);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Book";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addButton_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 39);
            this.label2.TabIndex = 85;
            this.label2.Text = "Passengers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label6.Location = new System.Drawing.Point(311, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 112;
            this.label6.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label9.Location = new System.Drawing.Point(293, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 125;
            this.label9.Text = "Destination";
            // 
            // coachNoBox
            // 
            this.coachNoBox.Location = new System.Drawing.Point(110, 330);
            this.coachNoBox.Name = "coachNoBox";
            this.coachNoBox.Size = new System.Drawing.Size(144, 20);
            this.coachNoBox.TabIndex = 14;
            this.coachNoBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.coachNoBox_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label16.Location = new System.Drawing.Point(270, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 22);
            this.label16.TabIndex = 118;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label18.Location = new System.Drawing.Point(12, 330);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 22);
            this.label18.TabIndex = 114;
            this.label18.Text = "Coach No";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label19.Location = new System.Drawing.Point(10, 222);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 23);
            this.label19.TabIndex = 113;
            this.label19.Text = "Source";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label10.Location = new System.Drawing.Point(606, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 126;
            this.label10.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(673, 81);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(243, 20);
            this.searchBox.TabIndex = 20;
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(940, 80);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(119, 23);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // trainNameBox
            // 
            this.trainNameBox.FormattingEnabled = true;
            this.trainNameBox.Location = new System.Drawing.Point(112, 303);
            this.trainNameBox.Name = "trainNameBox";
            this.trainNameBox.Size = new System.Drawing.Size(144, 21);
            this.trainNameBox.TabIndex = 12;
            this.trainNameBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label12.Location = new System.Drawing.Point(272, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 22);
            this.label12.TabIndex = 135;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label20.Location = new System.Drawing.Point(-2, 303);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 23);
            this.label20.TabIndex = 134;
            this.label20.Text = "Train Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label21.Location = new System.Drawing.Point(295, 305);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 22);
            this.label21.TabIndex = 133;
            this.label21.Text = "Dep. Date";
            // 
            // depDatePicker
            // 
            this.depDatePicker.CustomFormat = "yyyy-mm-dd";
            this.depDatePicker.Location = new System.Drawing.Point(407, 303);
            this.depDatePicker.Name = "depDatePicker";
            this.depDatePicker.Size = new System.Drawing.Size(148, 20);
            this.depDatePicker.TabIndex = 13;
            this.depDatePicker.KeyUp += new System.Windows.Forms.KeyEventHandler(this.depDatePicker_KeyUp);
            // 
            // seatNoBox
            // 
            this.seatNoBox.Location = new System.Drawing.Point(110, 356);
            this.seatNoBox.Name = "seatNoBox";
            this.seatNoBox.Size = new System.Drawing.Size(144, 20);
            this.seatNoBox.TabIndex = 16;
            this.seatNoBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.seatNoBox_KeyUp_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label5.Location = new System.Drawing.Point(293, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 138;
            this.label5.Text = "Seat Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label7.Location = new System.Drawing.Point(18, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 137;
            this.label7.Text = "SeatNo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 118);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Train Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 180);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passenger Details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainsToolStripMenuItem,
            this.passengersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 25);
            this.menuStrip1.TabIndex = 143;
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
            // seatTypeBox
            // 
            this.seatTypeBox.FormattingEnabled = true;
            this.seatTypeBox.Items.AddRange(new object[] {
            "AC",
            "Ecconomy"});
            this.seatTypeBox.Location = new System.Drawing.Point(405, 332);
            this.seatTypeBox.Name = "seatTypeBox";
            this.seatTypeBox.Size = new System.Drawing.Size(150, 21);
            this.seatTypeBox.TabIndex = 15;
            this.seatTypeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.seatTypeBox_KeyUp_1);
            // 
            // maleRadioBttn
            // 
            this.maleRadioBttn.AutoSize = true;
            this.maleRadioBttn.Location = new System.Drawing.Point(405, 170);
            this.maleRadioBttn.Name = "maleRadioBttn";
            this.maleRadioBttn.Size = new System.Drawing.Size(48, 17);
            this.maleRadioBttn.TabIndex = 5;
            this.maleRadioBttn.TabStop = true;
            this.maleRadioBttn.Text = "Male";
            this.maleRadioBttn.UseVisualStyleBackColor = true;
            this.maleRadioBttn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maleRadioBttn_KeyUp);
            // 
            // otherRadioBttn
            // 
            this.otherRadioBttn.AutoSize = true;
            this.otherRadioBttn.Location = new System.Drawing.Point(524, 170);
            this.otherRadioBttn.Name = "otherRadioBttn";
            this.otherRadioBttn.Size = new System.Drawing.Size(51, 17);
            this.otherRadioBttn.TabIndex = 7;
            this.otherRadioBttn.TabStop = true;
            this.otherRadioBttn.Text = "Other";
            this.otherRadioBttn.UseVisualStyleBackColor = true;
            this.otherRadioBttn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.otherRadioBttn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.otherRadioBttn_KeyUp);
            // 
            // femaleRadioBttn
            // 
            this.femaleRadioBttn.AutoSize = true;
            this.femaleRadioBttn.Location = new System.Drawing.Point(459, 170);
            this.femaleRadioBttn.Name = "femaleRadioBttn";
            this.femaleRadioBttn.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioBttn.TabIndex = 6;
            this.femaleRadioBttn.TabStop = true;
            this.femaleRadioBttn.Text = "Female";
            this.femaleRadioBttn.UseVisualStyleBackColor = true;
            this.femaleRadioBttn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.femaleRadioBttn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.femaleRadioBttn_KeyUp);
            // 
            // passengerIdBox
            // 
            this.passengerIdBox.Location = new System.Drawing.Point(108, 114);
            this.passengerIdBox.Name = "passengerIdBox";
            this.passengerIdBox.Size = new System.Drawing.Size(148, 20);
            this.passengerIdBox.TabIndex = 0;
            this.passengerIdBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passengerIdBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label1.Location = new System.Drawing.Point(-2, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 148;
            this.label1.Text = "Passenger ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // destinationBox
            // 
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Items.AddRange(new object[] {
            "Lahore",
            "Karachi",
            "Sialkot",
            "Islamabad"});
            this.destinationBox.Location = new System.Drawing.Point(407, 227);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(146, 21);
            this.destinationBox.TabIndex = 11;
            // 
            // sourceBox
            // 
            this.sourceBox.FormattingEnabled = true;
            this.sourceBox.Items.AddRange(new object[] {
            "Lahore",
            "Karachi",
            "Sialkot",
            "Islamabad"});
            this.sourceBox.Location = new System.Drawing.Point(106, 222);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(150, 21);
            this.sourceBox.TabIndex = 10;
            // 
            // Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1171, 506);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.passengerIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.femaleRadioBttn);
            this.Controls.Add(this.otherRadioBttn);
            this.Controls.Add(this.maleRadioBttn);
            this.Controls.Add(this.seatTypeBox);
            this.Controls.Add(this.seatNoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.depDatePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.trainNameBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.coachNoBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cnicBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.passengerNameBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Passenger";
            this.Text = "Passenger";
            this.Load += new System.EventHandler(this.Passenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cnicBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passengerNameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox coachNoBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox trainNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private System.Windows.Forms.TextBox seatNoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExistingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBookSeatToolStripMenuItem;
        private System.Windows.Forms.ComboBox seatTypeBox;
        private System.Windows.Forms.RadioButton maleRadioBttn;
        private System.Windows.Forms.RadioButton otherRadioBttn;
        private System.Windows.Forms.RadioButton femaleRadioBttn;
        private System.Windows.Forms.TextBox passengerIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.ComboBox sourceBox;
    }
}