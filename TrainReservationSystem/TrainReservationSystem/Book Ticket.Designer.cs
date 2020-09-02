namespace TrainReservationSystem
{
    partial class Book_Ticket
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromStationBox = new System.Windows.Forms.ComboBox();
            this.toStationBox = new System.Windows.Forms.ComboBox();
            this.trainNameBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.singleRadioBttn = new System.Windows.Forms.RadioButton();
            this.BerthRadioBttn = new System.Windows.Forms.RadioButton();
            this.coachNoBox = new System.Windows.Forms.ComboBox();
            this.classTypeBox = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketNoBox = new System.Windows.Forms.TextBox();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.trainNoBox = new System.Windows.Forms.TextBox();
            this.departureDateBox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(584, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 249);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(429, 395);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 42);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label7.Location = new System.Drawing.Point(16, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 105;
            this.label7.Text = "Coach No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label4.Location = new System.Drawing.Point(19, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 101;
            this.label4.Text = "Seat Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label15.Location = new System.Drawing.Point(16, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 23);
            this.label15.TabIndex = 97;
            this.label15.Text = "Class Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(280, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 22);
            this.label13.TabIndex = 95;
            this.label13.Text = "Departure Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(8, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 23);
            this.label11.TabIndex = 93;
            this.label11.Text = "Train Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(292, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 91;
            this.label8.Text = "To Station";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(945, 451);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 42);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(837, 453);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 42);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.updateButton.Location = new System.Drawing.Point(271, 395);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(124, 42);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.Transparent;
            this.bookButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold);
            this.bookButton.Location = new System.Drawing.Point(120, 395);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(118, 42);
            this.bookButton.TabIndex = 8;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 39);
            this.label2.TabIndex = 85;
            this.label2.Text = "Availability of Seat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "From Station";
            // 
            // fromStationBox
            // 
            this.fromStationBox.FormattingEnabled = true;
            this.fromStationBox.Items.AddRange(new object[] {
            "Islamabad",
            "Karachi",
            "Lahore",
            "Sialkot"});
            this.fromStationBox.Location = new System.Drawing.Point(128, 17);
            this.fromStationBox.Name = "fromStationBox";
            this.fromStationBox.Size = new System.Drawing.Size(145, 21);
            this.fromStationBox.Sorted = true;
            this.fromStationBox.TabIndex = 0;
            // 
            // toStationBox
            // 
            this.toStationBox.FormattingEnabled = true;
            this.toStationBox.Items.AddRange(new object[] {
            "Islamabad",
            "Karachi",
            "Lahore",
            "Sialkot"});
            this.toStationBox.Location = new System.Drawing.Point(415, 145);
            this.toStationBox.Name = "toStationBox";
            this.toStationBox.Size = new System.Drawing.Size(144, 21);
            this.toStationBox.Sorted = true;
            this.toStationBox.TabIndex = 1;
            this.toStationBox.SelectedIndexChanged += new System.EventHandler(this.toStationBox_SelectedIndexChanged);
            this.toStationBox.Leave += new System.EventHandler(this.toStationBox_Leave);
            // 
            // trainNameBox
            // 
            this.trainNameBox.FormattingEnabled = true;
            this.trainNameBox.Location = new System.Drawing.Point(126, 59);
            this.trainNameBox.Name = "trainNameBox";
            this.trainNameBox.Size = new System.Drawing.Size(147, 21);
            this.trainNameBox.TabIndex = 2;
            this.trainNameBox.SelectedIndexChanged += new System.EventHandler(this.trainNameBox_SelectedIndexChanged);
            this.trainNameBox.Leave += new System.EventHandler(this.trainNameBox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.departureDateBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trainNameBox);
            this.groupBox1.Controls.Add(this.fromStationBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 100);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(558, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 117;
            this.label6.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(268, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 24);
            this.label9.TabIndex = 118;
            this.label9.Text = "*";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(656, 93);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(241, 20);
            this.searchBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12.25F);
            this.label10.Location = new System.Drawing.Point(580, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 128;
            this.label10.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(903, 93);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // singleRadioBttn
            // 
            this.singleRadioBttn.AutoSize = true;
            this.singleRadioBttn.Location = new System.Drawing.Point(120, 303);
            this.singleRadioBttn.Name = "singleRadioBttn";
            this.singleRadioBttn.Size = new System.Drawing.Size(54, 17);
            this.singleRadioBttn.TabIndex = 5;
            this.singleRadioBttn.TabStop = true;
            this.singleRadioBttn.Text = "Single";
            this.singleRadioBttn.UseVisualStyleBackColor = true;
            // 
            // BerthRadioBttn
            // 
            this.BerthRadioBttn.AutoSize = true;
            this.BerthRadioBttn.Location = new System.Drawing.Point(217, 303);
            this.BerthRadioBttn.Name = "BerthRadioBttn";
            this.BerthRadioBttn.Size = new System.Drawing.Size(50, 17);
            this.BerthRadioBttn.TabIndex = 6;
            this.BerthRadioBttn.TabStop = true;
            this.BerthRadioBttn.Text = "Berth";
            this.BerthRadioBttn.UseVisualStyleBackColor = true;
            // 
            // coachNoBox
            // 
            this.coachNoBox.FormattingEnabled = true;
            this.coachNoBox.Location = new System.Drawing.Point(120, 338);
            this.coachNoBox.Name = "coachNoBox";
            this.coachNoBox.Size = new System.Drawing.Size(166, 21);
            this.coachNoBox.TabIndex = 7;
            // 
            // classTypeBox
            // 
            this.classTypeBox.FormattingEnabled = true;
            this.classTypeBox.Items.AddRange(new object[] {
            "AC",
            "Ecconomy"});
            this.classTypeBox.Location = new System.Drawing.Point(120, 262);
            this.classTypeBox.Name = "classTypeBox";
            this.classTypeBox.Size = new System.Drawing.Size(166, 21);
            this.classTypeBox.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ticket No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Train Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Source";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Destination";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Departure Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Class Type";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Seat Type";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Coach No";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "UserID";
            this.Column9.Name = "Column9";
            // 
            // ticketNoBox
            // 
            this.ticketNoBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ticketNoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketNoBox.Location = new System.Drawing.Point(449, 478);
            this.ticketNoBox.Name = "ticketNoBox";
            this.ticketNoBox.Size = new System.Drawing.Size(10, 13);
            this.ticketNoBox.TabIndex = 130;
            // 
            // userIdBox
            // 
            this.userIdBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIdBox.Location = new System.Drawing.Point(465, 478);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(10, 13);
            this.userIdBox.TabIndex = 131;
            // 
            // trainNoBox
            // 
            this.trainNoBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trainNoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trainNoBox.Location = new System.Drawing.Point(481, 491);
            this.trainNoBox.Name = "trainNoBox";
            this.trainNoBox.Size = new System.Drawing.Size(10, 13);
            this.trainNoBox.TabIndex = 132;
            this.trainNoBox.TextChanged += new System.EventHandler(this.trainNoBox_TextChanged);
            // 
            // departureDateBox
            // 
            this.departureDateBox.CustomFormat = "yyyy-mm-dd";
            this.departureDateBox.Location = new System.Drawing.Point(414, 60);
            this.departureDateBox.Name = "departureDateBox";
            this.departureDateBox.Size = new System.Drawing.Size(144, 20);
            this.departureDateBox.TabIndex = 3;
            this.departureDateBox.Value = new System.DateTime(2020, 9, 2, 7, 28, 17, 0);
            // 
            // Book_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 505);
            this.Controls.Add(this.trainNoBox);
            this.Controls.Add(this.userIdBox);
            this.Controls.Add(this.ticketNoBox);
            this.Controls.Add(this.classTypeBox);
            this.Controls.Add(this.coachNoBox);
            this.Controls.Add(this.BerthRadioBttn);
            this.Controls.Add(this.singleRadioBttn);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toStationBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Book_Ticket";
            this.Text = "Book_Ticket";
            this.Load += new System.EventHandler(this.Book_Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fromStationBox;
        private System.Windows.Forms.ComboBox toStationBox;
        private System.Windows.Forms.ComboBox trainNameBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton singleRadioBttn;
        private System.Windows.Forms.RadioButton BerthRadioBttn;
        private System.Windows.Forms.ComboBox coachNoBox;
        private System.Windows.Forms.ComboBox classTypeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox ticketNoBox;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.TextBox trainNoBox;
        private System.Windows.Forms.DateTimePicker departureDateBox;
    }
}