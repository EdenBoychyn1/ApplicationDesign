﻿
namespace ApplicationDesign
{
    partial class Invoice
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
            this.reservationIDPanel = new System.Windows.Forms.Panel();
            this.frontDeskListBox = new System.Windows.Forms.ListBox();
            this.findReservationButton = new System.Windows.Forms.Button();
            this.invalidReservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDLinePanel = new System.Windows.Forms.Panel();
            this.reservationIDPictureBox = new System.Windows.Forms.PictureBox();
            this.reservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeFirstNamePanel = new System.Windows.Forms.Panel();
            this.InvalidRoomLbl = new System.Windows.Forms.Label();
            this.InvalidPhoneLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reservationEndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reservationsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.reservationEndDateLabel = new System.Windows.Forms.Label();
            this.reservationStartDateLabel = new System.Windows.Forms.Label();
            this.reservationStartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.guestRoomNumberLabel = new System.Windows.Forms.Label();
            this.InvaildEmailLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.invalidGuestLastNameLabel = new System.Windows.Forms.Label();
            this.guestLastNameUnderlinePanel = new System.Windows.Forms.Panel();
            this.guestLastNameLabel = new System.Windows.Forms.Label();
            this.guestLastNameTextBox = new System.Windows.Forms.TextBox();
            this.invalidGuestFirstNameLabel = new System.Windows.Forms.Label();
            this.guestFirstNameUnderlinePanel = new System.Windows.Forms.Panel();
            this.guestFirstNameLabel = new System.Windows.Forms.Label();
            this.guestFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.conciergeFormPanel = new System.Windows.Forms.Panel();
            this.conciergeLabel = new System.Windows.Forms.Label();
            this.kingWilliamHotelPictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).BeginInit();
            this.employeeFirstNamePanel.SuspendLayout();
            this.conciergeFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationIDPanel
            // 
            this.reservationIDPanel.Controls.Add(this.frontDeskListBox);
            this.reservationIDPanel.Controls.Add(this.findReservationButton);
            this.reservationIDPanel.Controls.Add(this.invalidReservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDLinePanel);
            this.reservationIDPanel.Controls.Add(this.reservationIDPictureBox);
            this.reservationIDPanel.Controls.Add(this.reservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDTextBox);
            this.reservationIDPanel.Location = new System.Drawing.Point(283, 173);
            this.reservationIDPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(776, 197);
            this.reservationIDPanel.TabIndex = 6;
            // 
            // frontDeskListBox
            // 
            this.frontDeskListBox.FormattingEnabled = true;
            this.frontDeskListBox.ItemHeight = 16;
            this.frontDeskListBox.Location = new System.Drawing.Point(337, 98);
            this.frontDeskListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frontDeskListBox.Name = "frontDeskListBox";
            this.frontDeskListBox.Size = new System.Drawing.Size(225, 84);
            this.frontDeskListBox.TabIndex = 19;
            // 
            // findReservationButton
            // 
            this.findReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.FlatAppearance.BorderSize = 6;
            this.findReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.Location = new System.Drawing.Point(583, 34);
            this.findReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.findReservationButton.Name = "findReservationButton";
            this.findReservationButton.Size = new System.Drawing.Size(180, 52);
            this.findReservationButton.TabIndex = 10;
            this.findReservationButton.Text = "Find Reservation";
            this.findReservationButton.UseVisualStyleBackColor = true;
            this.findReservationButton.Click += new System.EventHandler(this.findReservationButton_Click);
            // 
            // invalidReservationIDLabel
            // 
            this.invalidReservationIDLabel.AutoSize = true;
            this.invalidReservationIDLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidReservationIDLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidReservationIDLabel.Location = new System.Drawing.Point(332, 63);
            this.invalidReservationIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidReservationIDLabel.MinimumSize = new System.Drawing.Size(267, 16);
            this.invalidReservationIDLabel.Name = "invalidReservationIDLabel";
            this.invalidReservationIDLabel.Size = new System.Drawing.Size(267, 23);
            this.invalidReservationIDLabel.TabIndex = 9;
            this.invalidReservationIDLabel.Text = "Invalid Reservation ID.";
            this.invalidReservationIDLabel.Visible = false;
            // 
            // reservationIDLinePanel
            // 
            this.reservationIDLinePanel.BackColor = System.Drawing.Color.White;
            this.reservationIDLinePanel.ForeColor = System.Drawing.Color.White;
            this.reservationIDLinePanel.Location = new System.Drawing.Point(337, 57);
            this.reservationIDLinePanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDLinePanel.Name = "reservationIDLinePanel";
            this.reservationIDLinePanel.Size = new System.Drawing.Size(225, 2);
            this.reservationIDLinePanel.TabIndex = 8;
            // 
            // reservationIDPictureBox
            // 
            this.reservationIDPictureBox.Image = global::ApplicationDesign.Properties.Resources.time_management;
            this.reservationIDPictureBox.Location = new System.Drawing.Point(25, 28);
            this.reservationIDPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDPictureBox.Name = "reservationIDPictureBox";
            this.reservationIDPictureBox.Size = new System.Drawing.Size(45, 52);
            this.reservationIDPictureBox.TabIndex = 7;
            this.reservationIDPictureBox.TabStop = false;
            // 
            // reservationIDLabel
            // 
            this.reservationIDLabel.AutoSize = true;
            this.reservationIDLabel.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationIDLabel.Location = new System.Drawing.Point(79, 28);
            this.reservationIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationIDLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.reservationIDLabel.Name = "reservationIDLabel";
            this.reservationIDLabel.Size = new System.Drawing.Size(209, 32);
            this.reservationIDLabel.TabIndex = 6;
            this.reservationIDLabel.Text = "Reservation ID:";
            // 
            // reservationIDTextBox
            // 
            this.reservationIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.reservationIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.reservationIDTextBox.Location = new System.Drawing.Point(337, 32);
            this.reservationIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDTextBox.MinimumSize = new System.Drawing.Size(71, 20);
            this.reservationIDTextBox.Name = "reservationIDTextBox";
            this.reservationIDTextBox.Size = new System.Drawing.Size(267, 23);
            this.reservationIDTextBox.TabIndex = 7;
            this.reservationIDTextBox.Text = "Enter Reservation ID";
            // 
            // employeeFirstNamePanel
            // 
            this.employeeFirstNamePanel.Controls.Add(this.InvalidRoomLbl);
            this.employeeFirstNamePanel.Controls.Add(this.InvalidPhoneLbl);
            this.employeeFirstNamePanel.Controls.Add(this.panel4);
            this.employeeFirstNamePanel.Controls.Add(this.reservationEndDateDTP);
            this.employeeFirstNamePanel.Controls.Add(this.textBox4);
            this.employeeFirstNamePanel.Controls.Add(this.panel2);
            this.employeeFirstNamePanel.Controls.Add(this.reservationsLabel);
            this.employeeFirstNamePanel.Controls.Add(this.label5);
            this.employeeFirstNamePanel.Controls.Add(this.textBox3);
            this.employeeFirstNamePanel.Controls.Add(this.reservationEndDateLabel);
            this.employeeFirstNamePanel.Controls.Add(this.reservationStartDateLabel);
            this.employeeFirstNamePanel.Controls.Add(this.reservationStartDateDTP);
            this.employeeFirstNamePanel.Controls.Add(this.guestRoomNumberLabel);
            this.employeeFirstNamePanel.Controls.Add(this.InvaildEmailLbl);
            this.employeeFirstNamePanel.Controls.Add(this.panel1);
            this.employeeFirstNamePanel.Controls.Add(this.label3);
            this.employeeFirstNamePanel.Controls.Add(this.textBox2);
            this.employeeFirstNamePanel.Controls.Add(this.invalidGuestLastNameLabel);
            this.employeeFirstNamePanel.Controls.Add(this.guestLastNameUnderlinePanel);
            this.employeeFirstNamePanel.Controls.Add(this.guestLastNameLabel);
            this.employeeFirstNamePanel.Controls.Add(this.guestLastNameTextBox);
            this.employeeFirstNamePanel.Controls.Add(this.invalidGuestFirstNameLabel);
            this.employeeFirstNamePanel.Controls.Add(this.guestFirstNameUnderlinePanel);
            this.employeeFirstNamePanel.Controls.Add(this.guestFirstNameLabel);
            this.employeeFirstNamePanel.Controls.Add(this.guestFirstNameTextBox);
            this.employeeFirstNamePanel.Location = new System.Drawing.Point(52, 407);
            this.employeeFirstNamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.employeeFirstNamePanel.Name = "employeeFirstNamePanel";
            this.employeeFirstNamePanel.Size = new System.Drawing.Size(1234, 234);
            this.employeeFirstNamePanel.TabIndex = 24;
            // 
            // InvalidRoomLbl
            // 
            this.InvalidRoomLbl.AutoSize = true;
            this.InvalidRoomLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidRoomLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidRoomLbl.Location = new System.Drawing.Point(928, 108);
            this.InvalidRoomLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InvalidRoomLbl.MinimumSize = new System.Drawing.Size(365, 16);
            this.InvalidRoomLbl.Name = "InvalidRoomLbl";
            this.InvalidRoomLbl.Size = new System.Drawing.Size(365, 23);
            this.InvalidRoomLbl.TabIndex = 21;
            this.InvalidRoomLbl.Text = "Invalid Guest Room Number";
            this.InvalidRoomLbl.Visible = false;
            // 
            // InvalidPhoneLbl
            // 
            this.InvalidPhoneLbl.AutoSize = true;
            this.InvalidPhoneLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidPhoneLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidPhoneLbl.Location = new System.Drawing.Point(925, 44);
            this.InvalidPhoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InvalidPhoneLbl.MinimumSize = new System.Drawing.Size(365, 16);
            this.InvalidPhoneLbl.Name = "InvalidPhoneLbl";
            this.InvalidPhoneLbl.Size = new System.Drawing.Size(365, 23);
            this.InvalidPhoneLbl.TabIndex = 22;
            this.InvalidPhoneLbl.Text = "Invalid Guest Phone Number";
            this.InvalidPhoneLbl.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(927, 102);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 2);
            this.panel4.TabIndex = 20;
            // 
            // reservationEndDateDTP
            // 
            this.reservationEndDateDTP.Location = new System.Drawing.Point(1013, 203);
            this.reservationEndDateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.reservationEndDateDTP.Name = "reservationEndDateDTP";
            this.reservationEndDateDTP.Size = new System.Drawing.Size(247, 22);
            this.reservationEndDateDTP.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox4.Location = new System.Drawing.Point(924, 81);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.MinimumSize = new System.Drawing.Size(71, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(364, 23);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "Guest Room Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(924, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 2);
            this.panel2.TabIndex = 21;
            // 
            // reservationsLabel
            // 
            this.reservationsLabel.AutoSize = true;
            this.reservationsLabel.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationsLabel.Location = new System.Drawing.Point(41, 34);
            this.reservationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationsLabel.Name = "reservationsLabel";
            this.reservationsLabel.Size = new System.Drawing.Size(172, 32);
            this.reservationsLabel.TabIndex = 19;
            this.reservationsLabel.Text = "Reservations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(675, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.MinimumSize = new System.Drawing.Size(71, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Guest Phone Number:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox3.Location = new System.Drawing.Point(921, 17);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MinimumSize = new System.Drawing.Size(71, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(364, 23);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Guest Phone Number";
            // 
            // reservationEndDateLabel
            // 
            this.reservationEndDateLabel.AutoSize = true;
            this.reservationEndDateLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationEndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationEndDateLabel.Location = new System.Drawing.Point(727, 201);
            this.reservationEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationEndDateLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.reservationEndDateLabel.Name = "reservationEndDateLabel";
            this.reservationEndDateLabel.Size = new System.Drawing.Size(226, 25);
            this.reservationEndDateLabel.TabIndex = 27;
            this.reservationEndDateLabel.Text = "Reservation End Date:";
            // 
            // reservationStartDateLabel
            // 
            this.reservationStartDateLabel.AutoSize = true;
            this.reservationStartDateLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationStartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationStartDateLabel.Location = new System.Drawing.Point(727, 140);
            this.reservationStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationStartDateLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.reservationStartDateLabel.Name = "reservationStartDateLabel";
            this.reservationStartDateLabel.Size = new System.Drawing.Size(233, 25);
            this.reservationStartDateLabel.TabIndex = 25;
            this.reservationStartDateLabel.Text = "Reservation Start Date:";
            // 
            // reservationStartDateDTP
            // 
            this.reservationStartDateDTP.Location = new System.Drawing.Point(1015, 143);
            this.reservationStartDateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.reservationStartDateDTP.Name = "reservationStartDateDTP";
            this.reservationStartDateDTP.Size = new System.Drawing.Size(247, 22);
            this.reservationStartDateDTP.TabIndex = 26;
            // 
            // guestRoomNumberLabel
            // 
            this.guestRoomNumberLabel.AutoSize = true;
            this.guestRoomNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestRoomNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestRoomNumberLabel.Location = new System.Drawing.Point(679, 82);
            this.guestRoomNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestRoomNumberLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.guestRoomNumberLabel.Name = "guestRoomNumberLabel";
            this.guestRoomNumberLabel.Size = new System.Drawing.Size(218, 25);
            this.guestRoomNumberLabel.TabIndex = 23;
            this.guestRoomNumberLabel.Text = "Guest Room Number:";
            // 
            // InvaildEmailLbl
            // 
            this.InvaildEmailLbl.AutoSize = true;
            this.InvaildEmailLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvaildEmailLbl.ForeColor = System.Drawing.Color.Red;
            this.InvaildEmailLbl.Location = new System.Drawing.Point(308, 226);
            this.InvaildEmailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InvaildEmailLbl.MinimumSize = new System.Drawing.Size(365, 16);
            this.InvaildEmailLbl.Name = "InvaildEmailLbl";
            this.InvaildEmailLbl.Size = new System.Drawing.Size(365, 23);
            this.InvaildEmailLbl.TabIndex = 22;
            this.InvaildEmailLbl.Text = "Invalid Guest Email";
            this.InvaildEmailLbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(308, 222);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 2);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(53, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MinimumSize = new System.Drawing.Size(71, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Guest Email:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(312, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.MinimumSize = new System.Drawing.Size(71, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 23);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Guest Email";
            // 
            // invalidGuestLastNameLabel
            // 
            this.invalidGuestLastNameLabel.AutoSize = true;
            this.invalidGuestLastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidGuestLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidGuestLastNameLabel.Location = new System.Drawing.Point(309, 169);
            this.invalidGuestLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidGuestLastNameLabel.MinimumSize = new System.Drawing.Size(365, 16);
            this.invalidGuestLastNameLabel.Name = "invalidGuestLastNameLabel";
            this.invalidGuestLastNameLabel.Size = new System.Drawing.Size(365, 23);
            this.invalidGuestLastNameLabel.TabIndex = 18;
            this.invalidGuestLastNameLabel.Text = "Invalid Guest Last Name.";
            this.invalidGuestLastNameLabel.Visible = false;
            // 
            // guestLastNameUnderlinePanel
            // 
            this.guestLastNameUnderlinePanel.BackColor = System.Drawing.Color.White;
            this.guestLastNameUnderlinePanel.ForeColor = System.Drawing.Color.White;
            this.guestLastNameUnderlinePanel.Location = new System.Drawing.Point(308, 162);
            this.guestLastNameUnderlinePanel.Margin = new System.Windows.Forms.Padding(4);
            this.guestLastNameUnderlinePanel.Name = "guestLastNameUnderlinePanel";
            this.guestLastNameUnderlinePanel.Size = new System.Drawing.Size(365, 2);
            this.guestLastNameUnderlinePanel.TabIndex = 17;
            // 
            // guestLastNameLabel
            // 
            this.guestLastNameLabel.AutoSize = true;
            this.guestLastNameLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestLastNameLabel.Location = new System.Drawing.Point(57, 140);
            this.guestLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestLastNameLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.guestLastNameLabel.Name = "guestLastNameLabel";
            this.guestLastNameLabel.Size = new System.Drawing.Size(183, 25);
            this.guestLastNameLabel.TabIndex = 15;
            this.guestLastNameLabel.Text = "Guest Last Name:";
            // 
            // guestLastNameTextBox
            // 
            this.guestLastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.guestLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLastNameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.guestLastNameTextBox.Location = new System.Drawing.Point(308, 138);
            this.guestLastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guestLastNameTextBox.MinimumSize = new System.Drawing.Size(71, 20);
            this.guestLastNameTextBox.Name = "guestLastNameTextBox";
            this.guestLastNameTextBox.Size = new System.Drawing.Size(364, 23);
            this.guestLastNameTextBox.TabIndex = 16;
            this.guestLastNameTextBox.Text = "Guest Last Name";
            // 
            // invalidGuestFirstNameLabel
            // 
            this.invalidGuestFirstNameLabel.AutoSize = true;
            this.invalidGuestFirstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidGuestFirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidGuestFirstNameLabel.Location = new System.Drawing.Point(311, 110);
            this.invalidGuestFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidGuestFirstNameLabel.MinimumSize = new System.Drawing.Size(365, 16);
            this.invalidGuestFirstNameLabel.Name = "invalidGuestFirstNameLabel";
            this.invalidGuestFirstNameLabel.Size = new System.Drawing.Size(365, 23);
            this.invalidGuestFirstNameLabel.TabIndex = 9;
            this.invalidGuestFirstNameLabel.Text = "Invalid Guest First Name.";
            this.invalidGuestFirstNameLabel.Visible = false;
            // 
            // guestFirstNameUnderlinePanel
            // 
            this.guestFirstNameUnderlinePanel.BackColor = System.Drawing.Color.White;
            this.guestFirstNameUnderlinePanel.ForeColor = System.Drawing.Color.White;
            this.guestFirstNameUnderlinePanel.Location = new System.Drawing.Point(309, 103);
            this.guestFirstNameUnderlinePanel.Margin = new System.Windows.Forms.Padding(4);
            this.guestFirstNameUnderlinePanel.Name = "guestFirstNameUnderlinePanel";
            this.guestFirstNameUnderlinePanel.Size = new System.Drawing.Size(365, 2);
            this.guestFirstNameUnderlinePanel.TabIndex = 8;
            // 
            // guestFirstNameLabel
            // 
            this.guestFirstNameLabel.AutoSize = true;
            this.guestFirstNameLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestFirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestFirstNameLabel.Location = new System.Drawing.Point(57, 82);
            this.guestFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestFirstNameLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.guestFirstNameLabel.Name = "guestFirstNameLabel";
            this.guestFirstNameLabel.Size = new System.Drawing.Size(186, 25);
            this.guestFirstNameLabel.TabIndex = 6;
            this.guestFirstNameLabel.Text = "Guest First Name:";
            // 
            // guestFirstNameTextBox
            // 
            this.guestFirstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.guestFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestFirstNameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.guestFirstNameTextBox.Location = new System.Drawing.Point(307, 82);
            this.guestFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guestFirstNameTextBox.MinimumSize = new System.Drawing.Size(71, 20);
            this.guestFirstNameTextBox.Name = "guestFirstNameTextBox";
            this.guestFirstNameTextBox.Size = new System.Drawing.Size(364, 23);
            this.guestFirstNameTextBox.TabIndex = 7;
            this.guestFirstNameTextBox.Text = "Guest First Name";
            // 
            // conciergeFormPanel
            // 
            this.conciergeFormPanel.Controls.Add(this.conciergeLabel);
            this.conciergeFormPanel.Controls.Add(this.kingWilliamHotelPictureBox);
            this.conciergeFormPanel.Location = new System.Drawing.Point(94, 13);
            this.conciergeFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.conciergeFormPanel.Name = "conciergeFormPanel";
            this.conciergeFormPanel.Size = new System.Drawing.Size(873, 132);
            this.conciergeFormPanel.TabIndex = 25;
            // 
            // conciergeLabel
            // 
            this.conciergeLabel.AutoSize = true;
            this.conciergeLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conciergeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.conciergeLabel.Location = new System.Drawing.Point(453, 41);
            this.conciergeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conciergeLabel.Name = "conciergeLabel";
            this.conciergeLabel.Size = new System.Drawing.Size(264, 38);
            this.conciergeLabel.TabIndex = 1;
            this.conciergeLabel.Text = "Generate Invoice";
            this.conciergeLabel.Click += new System.EventHandler(this.conciergeLabel_Click);
            // 
            // kingWilliamHotelPictureBox
            // 
            this.kingWilliamHotelPictureBox.Image = global::ApplicationDesign.Properties.Resources.KingWilliamHotelLogo;
            this.kingWilliamHotelPictureBox.Location = new System.Drawing.Point(5, 0);
            this.kingWilliamHotelPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.kingWilliamHotelPictureBox.Name = "kingWilliamHotelPictureBox";
            this.kingWilliamHotelPictureBox.Size = new System.Drawing.Size(268, 145);
            this.kingWilliamHotelPictureBox.TabIndex = 1;
            this.kingWilliamHotelPictureBox.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 648);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1615, 150);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1738, 806);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.conciergeFormPanel);
            this.Controls.Add(this.employeeFirstNamePanel);
            this.Controls.Add(this.reservationIDPanel);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.reservationIDPanel.ResumeLayout(false);
            this.reservationIDPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).EndInit();
            this.employeeFirstNamePanel.ResumeLayout(false);
            this.employeeFirstNamePanel.PerformLayout();
            this.conciergeFormPanel.ResumeLayout(false);
            this.conciergeFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reservationIDPanel;
        private System.Windows.Forms.ListBox frontDeskListBox;
        private System.Windows.Forms.Button findReservationButton;
        private System.Windows.Forms.Label invalidReservationIDLabel;
        private System.Windows.Forms.Panel reservationIDLinePanel;
        private System.Windows.Forms.PictureBox reservationIDPictureBox;
        private System.Windows.Forms.Label reservationIDLabel;
        private System.Windows.Forms.TextBox reservationIDTextBox;
        private System.Windows.Forms.Panel employeeFirstNamePanel;
        private System.Windows.Forms.Label InvalidRoomLbl;
        private System.Windows.Forms.Label InvalidPhoneLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker reservationEndDateDTP;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label reservationsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label reservationEndDateLabel;
        private System.Windows.Forms.Label reservationStartDateLabel;
        private System.Windows.Forms.DateTimePicker reservationStartDateDTP;
        private System.Windows.Forms.Label guestRoomNumberLabel;
        private System.Windows.Forms.Label InvaildEmailLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label invalidGuestLastNameLabel;
        private System.Windows.Forms.Panel guestLastNameUnderlinePanel;
        private System.Windows.Forms.Label guestLastNameLabel;
        private System.Windows.Forms.TextBox guestLastNameTextBox;
        private System.Windows.Forms.Label invalidGuestFirstNameLabel;
        private System.Windows.Forms.Panel guestFirstNameUnderlinePanel;
        private System.Windows.Forms.Label guestFirstNameLabel;
        private System.Windows.Forms.TextBox guestFirstNameTextBox;
        private System.Windows.Forms.Panel conciergeFormPanel;
        private System.Windows.Forms.Label conciergeLabel;
        private System.Windows.Forms.PictureBox kingWilliamHotelPictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}