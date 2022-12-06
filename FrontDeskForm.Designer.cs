
namespace ApplicationDesign
{
    partial class FrontDeskForm
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
            this.components = new System.ComponentModel.Container();
            this.frontDeskLabel = new System.Windows.Forms.Label();
            this.reservationIDPanel = new System.Windows.Forms.Panel();
            this.frontDeskListBox = new System.Windows.Forms.ListBox();
            this.findReservationButton = new System.Windows.Forms.Button();
            this.invalidReservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDLinePanel = new System.Windows.Forms.Panel();
            this.reservationIDPictureBox = new System.Windows.Forms.PictureBox();
            this.reservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDTextBox = new System.Windows.Forms.TextBox();
            this.reservationsLabel = new System.Windows.Forms.Label();
            this.updateReservationButton = new System.Windows.Forms.Button();
            this.deleteReservationButton = new System.Windows.Forms.Button();
            this.reservationsPanel = new System.Windows.Forms.Panel();
            this.employeeFirstNamePanel = new System.Windows.Forms.Panel();
            this.reservationEndDateDTP = new System.Windows.Forms.DateTimePicker();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.findGuestButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastNameToolTip = new System.Windows.Forms.Label();
            this.findGuestLabel = new System.Windows.Forms.Label();
            this.makeAReservationButton = new System.Windows.Forms.Button();
            this.addAGuestButton = new System.Windows.Forms.Button();
            this.kingWilliamHotelPictureBox = new System.Windows.Forms.PictureBox();
            this.addGuestToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.reservationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.reservationIDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.findReservationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lastName1ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.findGuestToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.updateReservationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteReservationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.InvalidPhoneLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.InvalidRoomLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).BeginInit();
            this.reservationsPanel.SuspendLayout();
            this.employeeFirstNamePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // frontDeskLabel
            // 
            this.frontDeskLabel.AutoSize = true;
            this.frontDeskLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontDeskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.frontDeskLabel.Location = new System.Drawing.Point(600, 53);
            this.frontDeskLabel.Name = "frontDeskLabel";
            this.frontDeskLabel.Size = new System.Drawing.Size(146, 31);
            this.frontDeskLabel.TabIndex = 2;
            this.frontDeskLabel.Text = "Front Desk";
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
            this.reservationIDPanel.Location = new System.Drawing.Point(189, 144);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(582, 160);
            this.reservationIDPanel.TabIndex = 5;
            // 
            // frontDeskListBox
            // 
            this.frontDeskListBox.FormattingEnabled = true;
            this.frontDeskListBox.Location = new System.Drawing.Point(253, 80);
            this.frontDeskListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frontDeskListBox.Name = "frontDeskListBox";
            this.frontDeskListBox.Size = new System.Drawing.Size(170, 69);
            this.frontDeskListBox.TabIndex = 19;
            // 
            // findReservationButton
            // 
            this.findReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.FlatAppearance.BorderSize = 6;
            this.findReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.Location = new System.Drawing.Point(437, 28);
            this.findReservationButton.Name = "findReservationButton";
            this.findReservationButton.Size = new System.Drawing.Size(135, 42);
            this.findReservationButton.TabIndex = 10;
            this.findReservationButton.Text = "Find Reservation";
            this.findReservationToolTip.SetToolTip(this.findReservationButton, "After entering a reservation ID, select Find Reservation to find the reservation." +
        "");
            this.findReservationButton.UseVisualStyleBackColor = true;
            this.findReservationButton.Click += new System.EventHandler(this.findReservationButton_Click);
            // 
            // invalidReservationIDLabel
            // 
            this.invalidReservationIDLabel.AutoSize = true;
            this.invalidReservationIDLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidReservationIDLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidReservationIDLabel.Location = new System.Drawing.Point(249, 51);
            this.invalidReservationIDLabel.MinimumSize = new System.Drawing.Size(200, 13);
            this.invalidReservationIDLabel.Name = "invalidReservationIDLabel";
            this.invalidReservationIDLabel.Size = new System.Drawing.Size(200, 19);
            this.invalidReservationIDLabel.TabIndex = 9;
            this.invalidReservationIDLabel.Text = "Invalid Reservation ID.";
            this.invalidReservationIDLabel.Visible = false;
            // 
            // reservationIDLinePanel
            // 
            this.reservationIDLinePanel.BackColor = System.Drawing.Color.White;
            this.reservationIDLinePanel.ForeColor = System.Drawing.Color.White;
            this.reservationIDLinePanel.Location = new System.Drawing.Point(253, 46);
            this.reservationIDLinePanel.Name = "reservationIDLinePanel";
            this.reservationIDLinePanel.Size = new System.Drawing.Size(169, 2);
            this.reservationIDLinePanel.TabIndex = 8;
            // 
            // reservationIDPictureBox
            // 
            this.reservationIDPictureBox.Image = global::ApplicationDesign.Properties.Resources.time_management;
            this.reservationIDPictureBox.Location = new System.Drawing.Point(19, 23);
            this.reservationIDPictureBox.Name = "reservationIDPictureBox";
            this.reservationIDPictureBox.Size = new System.Drawing.Size(34, 42);
            this.reservationIDPictureBox.TabIndex = 7;
            this.reservationIDPictureBox.TabStop = false;
            // 
            // reservationIDLabel
            // 
            this.reservationIDLabel.AutoSize = true;
            this.reservationIDLabel.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationIDLabel.Location = new System.Drawing.Point(59, 23);
            this.reservationIDLabel.MinimumSize = new System.Drawing.Size(53, 20);
            this.reservationIDLabel.Name = "reservationIDLabel";
            this.reservationIDLabel.Size = new System.Drawing.Size(171, 25);
            this.reservationIDLabel.TabIndex = 6;
            this.reservationIDLabel.Text = "Reservation ID:";
            this.reservationIDToolTip.SetToolTip(this.reservationIDLabel, "Enter a reservation ID.");
            // 
            // reservationIDTextBox
            // 
            this.reservationIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.reservationIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.reservationIDTextBox.Location = new System.Drawing.Point(253, 26);
            this.reservationIDTextBox.MinimumSize = new System.Drawing.Size(53, 20);
            this.reservationIDTextBox.Name = "reservationIDTextBox";
            this.reservationIDTextBox.Size = new System.Drawing.Size(200, 19);
            this.reservationIDTextBox.TabIndex = 7;
            this.reservationIDTextBox.Text = "Enter Reservation ID";
            this.reservationIDTextBox.Click += new System.EventHandler(this.reservationIDTextBox_Click);
            // 
            // reservationsLabel
            // 
            this.reservationsLabel.AutoSize = true;
            this.reservationsLabel.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationsLabel.Location = new System.Drawing.Point(31, 28);
            this.reservationsLabel.Name = "reservationsLabel";
            this.reservationsLabel.Size = new System.Drawing.Size(140, 25);
            this.reservationsLabel.TabIndex = 19;
            this.reservationsLabel.Text = "Reservations";
            // 
            // updateReservationButton
            // 
            this.updateReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.updateReservationButton.FlatAppearance.BorderSize = 6;
            this.updateReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateReservationButton.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.updateReservationButton.Location = new System.Drawing.Point(454, 216);
            this.updateReservationButton.Name = "updateReservationButton";
            this.updateReservationButton.Size = new System.Drawing.Size(244, 59);
            this.updateReservationButton.TabIndex = 21;
            this.updateReservationButton.Text = "Update Reservation";
            this.updateReservationToolTip.SetToolTip(this.updateReservationButton, "Select Update reservation to update the reservation selected.");
            this.updateReservationButton.UseVisualStyleBackColor = true;
            this.updateReservationButton.Click += new System.EventHandler(this.updateReservationButton_Click);
            // 
            // deleteReservationButton
            // 
            this.deleteReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.deleteReservationButton.FlatAppearance.BorderSize = 6;
            this.deleteReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteReservationButton.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.deleteReservationButton.Location = new System.Drawing.Point(732, 216);
            this.deleteReservationButton.Name = "deleteReservationButton";
            this.deleteReservationButton.Size = new System.Drawing.Size(244, 59);
            this.deleteReservationButton.TabIndex = 22;
            this.deleteReservationButton.Text = "Delete Reservation";
            this.deleteReservationToolTip.SetToolTip(this.deleteReservationButton, "Select Delete Reservation to delete the selected reservation.");
            this.deleteReservationButton.UseVisualStyleBackColor = true;
            this.deleteReservationButton.Click += new System.EventHandler(this.deleteReservationButton_Click);
            // 
            // reservationsPanel
            // 
            this.reservationsPanel.Controls.Add(this.employeeFirstNamePanel);
            this.reservationsPanel.Controls.Add(this.deleteReservationButton);
            this.reservationsPanel.Controls.Add(this.updateReservationButton);
            this.reservationsPanel.Location = new System.Drawing.Point(189, 310);
            this.reservationsPanel.Name = "reservationsPanel";
            this.reservationsPanel.Size = new System.Drawing.Size(979, 280);
            this.reservationsPanel.TabIndex = 18;
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
            this.employeeFirstNamePanel.Location = new System.Drawing.Point(3, 3);
            this.employeeFirstNamePanel.Name = "employeeFirstNamePanel";
            this.employeeFirstNamePanel.Size = new System.Drawing.Size(973, 206);
            this.employeeFirstNamePanel.TabIndex = 23;
            // 
            // reservationEndDateDTP
            // 
            this.reservationEndDateDTP.Location = new System.Drawing.Point(760, 165);
            this.reservationEndDateDTP.Name = "reservationEndDateDTP";
            this.reservationEndDateDTP.Size = new System.Drawing.Size(186, 20);
            this.reservationEndDateDTP.TabIndex = 28;
            // 
            // reservationEndDateLabel
            // 
            this.reservationEndDateLabel.AutoSize = true;
            this.reservationEndDateLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationEndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationEndDateLabel.Location = new System.Drawing.Point(545, 163);
            this.reservationEndDateLabel.MinimumSize = new System.Drawing.Size(53, 20);
            this.reservationEndDateLabel.Name = "reservationEndDateLabel";
            this.reservationEndDateLabel.Size = new System.Drawing.Size(183, 20);
            this.reservationEndDateLabel.TabIndex = 27;
            this.reservationEndDateLabel.Text = "Reservation End Date:";
            // 
            // reservationStartDateLabel
            // 
            this.reservationStartDateLabel.AutoSize = true;
            this.reservationStartDateLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationStartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationStartDateLabel.Location = new System.Drawing.Point(545, 114);
            this.reservationStartDateLabel.MinimumSize = new System.Drawing.Size(53, 20);
            this.reservationStartDateLabel.Name = "reservationStartDateLabel";
            this.reservationStartDateLabel.Size = new System.Drawing.Size(190, 20);
            this.reservationStartDateLabel.TabIndex = 25;
            this.reservationStartDateLabel.Text = "Reservation Start Date:";
            // 
            // reservationStartDateDTP
            // 
            this.reservationStartDateDTP.Location = new System.Drawing.Point(761, 116);
            this.reservationStartDateDTP.Name = "reservationStartDateDTP";
            this.reservationStartDateDTP.Size = new System.Drawing.Size(186, 20);
            this.reservationStartDateDTP.TabIndex = 26;
            // 
            // guestRoomNumberLabel
            // 
            this.guestRoomNumberLabel.AutoSize = true;
            this.guestRoomNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestRoomNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestRoomNumberLabel.Location = new System.Drawing.Point(509, 67);
            this.guestRoomNumberLabel.MinimumSize = new System.Drawing.Size(53, 20);
            this.guestRoomNumberLabel.Name = "guestRoomNumberLabel";
            this.guestRoomNumberLabel.Size = new System.Drawing.Size(180, 20);
            this.guestRoomNumberLabel.TabIndex = 23;
            this.guestRoomNumberLabel.Text = "Guest Room Number:";
            // 
            // InvaildEmailLbl
            // 
            this.InvaildEmailLbl.AutoSize = true;
            this.InvaildEmailLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvaildEmailLbl.ForeColor = System.Drawing.Color.Red;
            this.InvaildEmailLbl.Location = new System.Drawing.Point(231, 184);
            this.InvaildEmailLbl.MinimumSize = new System.Drawing.Size(274, 13);
            this.InvaildEmailLbl.Name = "InvaildEmailLbl";
            this.InvaildEmailLbl.Size = new System.Drawing.Size(274, 19);
            this.InvaildEmailLbl.TabIndex = 22;
            this.InvaildEmailLbl.Text = "Invalid Guest Email";
            this.InvaildEmailLbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(231, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 2);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(40, 163);
            this.label3.MinimumSize = new System.Drawing.Size(53, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Guest Email:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(234, 159);
            this.textBox2.MinimumSize = new System.Drawing.Size(53, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 19);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Guest Email";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // invalidGuestLastNameLabel
            // 
            this.invalidGuestLastNameLabel.AutoSize = true;
            this.invalidGuestLastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidGuestLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidGuestLastNameLabel.Location = new System.Drawing.Point(232, 137);
            this.invalidGuestLastNameLabel.MinimumSize = new System.Drawing.Size(274, 13);
            this.invalidGuestLastNameLabel.Name = "invalidGuestLastNameLabel";
            this.invalidGuestLastNameLabel.Size = new System.Drawing.Size(274, 19);
            this.invalidGuestLastNameLabel.TabIndex = 18;
            this.invalidGuestLastNameLabel.Text = "Invalid Guest Last Name.";
            this.invalidGuestLastNameLabel.Visible = false;
            // 
            // guestLastNameUnderlinePanel
            // 
            this.guestLastNameUnderlinePanel.BackColor = System.Drawing.Color.White;
            this.guestLastNameUnderlinePanel.ForeColor = System.Drawing.Color.White;
            this.guestLastNameUnderlinePanel.Location = new System.Drawing.Point(231, 132);
            this.guestLastNameUnderlinePanel.Name = "guestLastNameUnderlinePanel";
            this.guestLastNameUnderlinePanel.Size = new System.Drawing.Size(274, 2);
            this.guestLastNameUnderlinePanel.TabIndex = 17;
            // 
            // guestLastNameLabel
            // 
            this.guestLastNameLabel.AutoSize = true;
            this.guestLastNameLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestLastNameLabel.Location = new System.Drawing.Point(43, 114);
            this.guestLastNameLabel.MinimumSize = new System.Drawing.Size(53, 20);
            this.guestLastNameLabel.Name = "guestLastNameLabel";
            this.guestLastNameLabel.Size = new System.Drawing.Size(148, 20);
            this.guestLastNameLabel.TabIndex = 15;
            this.guestLastNameLabel.Text = "Guest Last Name:";
            // 
            // guestLastNameTextBox
            // 
            this.guestLastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.guestLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLastNameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.guestLastNameTextBox.Location = new System.Drawing.Point(231, 112);
            this.guestLastNameTextBox.MinimumSize = new System.Drawing.Size(53, 20);
            this.guestLastNameTextBox.Name = "guestLastNameTextBox";
            this.guestLastNameTextBox.Size = new System.Drawing.Size(273, 20);
            this.guestLastNameTextBox.TabIndex = 16;
            this.guestLastNameTextBox.Text = "Guest Last Name";
            this.guestLastNameTextBox.Click += new System.EventHandler(this.guestLastNameTextBox_Click);
            // 
            // invalidGuestFirstNameLabel
            // 
            this.invalidGuestFirstNameLabel.AutoSize = true;
            this.invalidGuestFirstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidGuestFirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidGuestFirstNameLabel.Location = new System.Drawing.Point(233, 89);
            this.invalidGuestFirstNameLabel.MinimumSize = new System.Drawing.Size(274, 13);
            this.invalidGuestFirstNameLabel.Name = "invalidGuestFirstNameLabel";
            this.invalidGuestFirstNameLabel.Size = new System.Drawing.Size(274, 19);
            this.invalidGuestFirstNameLabel.TabIndex = 9;
            this.invalidGuestFirstNameLabel.Text = "Invalid Guest First Name.";
            this.invalidGuestFirstNameLabel.Visible = false;
            // 
            // guestFirstNameUnderlinePanel
            // 
            this.guestFirstNameUnderlinePanel.BackColor = System.Drawing.Color.White;
            this.guestFirstNameUnderlinePanel.ForeColor = System.Drawing.Color.White;
            this.guestFirstNameUnderlinePanel.Location = new System.Drawing.Point(232, 84);
            this.guestFirstNameUnderlinePanel.Name = "guestFirstNameUnderlinePanel";
            this.guestFirstNameUnderlinePanel.Size = new System.Drawing.Size(274, 2);
            this.guestFirstNameUnderlinePanel.TabIndex = 8;
            // 
            // guestFirstNameLabel
            // 
            this.guestFirstNameLabel.AutoSize = true;
            this.guestFirstNameLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestFirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestFirstNameLabel.Location = new System.Drawing.Point(43, 67);
            this.guestFirstNameLabel.MinimumSize = new System.Drawing.Size(53, 20);
            this.guestFirstNameLabel.Name = "guestFirstNameLabel";
            this.guestFirstNameLabel.Size = new System.Drawing.Size(149, 20);
            this.guestFirstNameLabel.TabIndex = 6;
            this.guestFirstNameLabel.Text = "Guest First Name:";
            // 
            // guestFirstNameTextBox
            // 
            this.guestFirstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.guestFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestFirstNameTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.guestFirstNameTextBox.Location = new System.Drawing.Point(230, 67);
            this.guestFirstNameTextBox.MinimumSize = new System.Drawing.Size(53, 20);
            this.guestFirstNameTextBox.Name = "guestFirstNameTextBox";
            this.guestFirstNameTextBox.Size = new System.Drawing.Size(273, 20);
            this.guestFirstNameTextBox.TabIndex = 7;
            this.guestFirstNameTextBox.Text = "Guest First Name";
            this.guestFirstNameTextBox.Click += new System.EventHandler(this.guestFirstNameTextBox_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.findGuestButton);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lastNameToolTip);
            this.panel3.Controls.Add(this.findGuestLabel);
            this.panel3.Location = new System.Drawing.Point(777, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 160);
            this.panel3.TabIndex = 11;
            // 
            // findGuestButton
            // 
            this.findGuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.FlatAppearance.BorderSize = 6;
            this.findGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findGuestButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.Location = new System.Drawing.Point(253, 115);
            this.findGuestButton.Name = "findGuestButton";
            this.findGuestButton.Size = new System.Drawing.Size(135, 42);
            this.findGuestButton.TabIndex = 17;
            this.findGuestButton.Text = "Find Guest";
            this.findGuestToolTip.SetToolTip(this.findGuestButton, "Select Find Guest to find a guest by their last name.");
            this.findGuestButton.UseVisualStyleBackColor = true;
            this.findGuestButton.Click += new System.EventHandler(this.findGuestButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(161, 46);
            this.panel5.MinimumSize = new System.Drawing.Size(200, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(157, 51);
            this.label2.MinimumSize = new System.Drawing.Size(174, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Invalid Guest Last Name.";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(160, 25);
            this.textBox1.MinimumSize = new System.Drawing.Size(53, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 19);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Enter Guest Last Name";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // lastNameToolTip
            // 
            this.lastNameToolTip.AutoSize = true;
            this.lastNameToolTip.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.lastNameToolTip.Location = new System.Drawing.Point(37, 28);
            this.lastNameToolTip.MinimumSize = new System.Drawing.Size(53, 20);
            this.lastNameToolTip.Name = "lastNameToolTip";
            this.lastNameToolTip.Size = new System.Drawing.Size(98, 20);
            this.lastNameToolTip.TabIndex = 13;
            this.lastNameToolTip.Text = "Last Name:";
            this.lastName1ToolTip.SetToolTip(this.lastNameToolTip, "Enter a guest\'s last name.");
            // 
            // findGuestLabel
            // 
            this.findGuestLabel.AutoSize = true;
            this.findGuestLabel.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestLabel.Location = new System.Drawing.Point(12, 0);
            this.findGuestLabel.Name = "findGuestLabel";
            this.findGuestLabel.Size = new System.Drawing.Size(123, 25);
            this.findGuestLabel.TabIndex = 12;
            this.findGuestLabel.Text = "Find Guest";
            // 
            // makeAReservationButton
            // 
            this.makeAReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.makeAReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeAReservationButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeAReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.makeAReservationButton.Image = global::ApplicationDesign.Properties.Resources.manager;
            this.makeAReservationButton.Location = new System.Drawing.Point(12, 268);
            this.makeAReservationButton.Name = "makeAReservationButton";
            this.makeAReservationButton.Size = new System.Drawing.Size(160, 118);
            this.makeAReservationButton.TabIndex = 4;
            this.makeAReservationButton.Text = "Make A Reservation";
            this.makeAReservationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reservationToolTip.SetToolTip(this.makeAReservationButton, "Select Reservation to make a reservation.");
            this.makeAReservationButton.UseVisualStyleBackColor = true;
            this.makeAReservationButton.Click += new System.EventHandler(this.makeAReservationButton_Click);
            // 
            // addAGuestButton
            // 
            this.addAGuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.addAGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAGuestButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAGuestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.addAGuestButton.Image = global::ApplicationDesign.Properties.Resources.manager;
            this.addAGuestButton.Location = new System.Drawing.Point(12, 144);
            this.addAGuestButton.Name = "addAGuestButton";
            this.addAGuestButton.Size = new System.Drawing.Size(160, 118);
            this.addAGuestButton.TabIndex = 3;
            this.addAGuestButton.Text = "Add A Guest";
            this.addAGuestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addGuestToolTip.SetToolTip(this.addAGuestButton, "Select Add a Guest to add a guest to the database.");
            this.addAGuestButton.UseVisualStyleBackColor = true;
            this.addAGuestButton.Click += new System.EventHandler(this.addAGuestButton_Click);
            // 
            // kingWilliamHotelPictureBox
            // 
            this.kingWilliamHotelPictureBox.Image = global::ApplicationDesign.Properties.Resources.KingWilliamHotelLogo;
            this.kingWilliamHotelPictureBox.Location = new System.Drawing.Point(12, 12);
            this.kingWilliamHotelPictureBox.Name = "kingWilliamHotelPictureBox";
            this.kingWilliamHotelPictureBox.Size = new System.Drawing.Size(217, 118);
            this.kingWilliamHotelPictureBox.TabIndex = 1;
            this.kingWilliamHotelPictureBox.TabStop = false;
            // 
            // InvalidPhoneLbl
            // 
            this.InvalidPhoneLbl.AutoSize = true;
            this.InvalidPhoneLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidPhoneLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidPhoneLbl.Location = new System.Drawing.Point(694, 36);
            this.InvalidPhoneLbl.MinimumSize = new System.Drawing.Size(274, 13);
            this.InvalidPhoneLbl.Name = "InvalidPhoneLbl";
            this.InvalidPhoneLbl.Size = new System.Drawing.Size(274, 19);
            this.InvalidPhoneLbl.TabIndex = 22;
            this.InvalidPhoneLbl.Text = "Invalid Guest Phone Number";
            this.InvalidPhoneLbl.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(693, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 2);
            this.panel2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(506, 14);
            this.label5.MinimumSize = new System.Drawing.Size(53, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Guest Phone Number:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox3.Location = new System.Drawing.Point(691, 14);
            this.textBox3.MinimumSize = new System.Drawing.Size(53, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Guest Phone Number";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // InvalidRoomLbl
            // 
            this.InvalidRoomLbl.AutoSize = true;
            this.InvalidRoomLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidRoomLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidRoomLbl.Location = new System.Drawing.Point(696, 88);
            this.InvalidRoomLbl.MinimumSize = new System.Drawing.Size(274, 13);
            this.InvalidRoomLbl.Name = "InvalidRoomLbl";
            this.InvalidRoomLbl.Size = new System.Drawing.Size(274, 19);
            this.InvalidRoomLbl.TabIndex = 21;
            this.InvalidRoomLbl.Text = "Invalid Guest Room Number";
            this.InvalidRoomLbl.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(695, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 2);
            this.panel4.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox4.Location = new System.Drawing.Point(693, 66);
            this.textBox4.MinimumSize = new System.Drawing.Size(53, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(273, 20);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "Guest Room Number";
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // FrontDeskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1184, 618);
            this.Controls.Add(this.makeAReservationButton);
            this.Controls.Add(this.addAGuestButton);
            this.Controls.Add(this.kingWilliamHotelPictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.reservationsPanel);
            this.Controls.Add(this.reservationIDPanel);
            this.Controls.Add(this.frontDeskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1354, 739);
            this.MinimumSize = new System.Drawing.Size(904, 535);
            this.Name = "FrontDeskForm";
            this.Text = "FrontDeskForm";
            this.Load += new System.EventHandler(this.FrontDeskForm_Load);
            this.reservationIDPanel.ResumeLayout(false);
            this.reservationIDPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).EndInit();
            this.reservationsPanel.ResumeLayout(false);
            this.employeeFirstNamePanel.ResumeLayout(false);
            this.employeeFirstNamePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox kingWilliamHotelPictureBox;
        private System.Windows.Forms.Label frontDeskLabel;
        private System.Windows.Forms.Panel reservationIDPanel;
        private System.Windows.Forms.Label invalidReservationIDLabel;
        private System.Windows.Forms.Panel reservationIDLinePanel;
        private System.Windows.Forms.PictureBox reservationIDPictureBox;
        private System.Windows.Forms.Label reservationIDLabel;
        private System.Windows.Forms.TextBox reservationIDTextBox;
        private System.Windows.Forms.Label reservationsLabel;
        private System.Windows.Forms.Button updateReservationButton;
        private System.Windows.Forms.Button deleteReservationButton;
        private System.Windows.Forms.Panel reservationsPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lastNameToolTip;
        private System.Windows.Forms.Label findGuestLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button findReservationButton;
        private System.Windows.Forms.Button findGuestButton;
        private System.Windows.Forms.Button addAGuestButton;
        private System.Windows.Forms.Button makeAReservationButton;
        private System.Windows.Forms.ToolTip findReservationToolTip;
        private System.Windows.Forms.ToolTip reservationIDToolTip;
        private System.Windows.Forms.ToolTip reservationToolTip;
        private System.Windows.Forms.ToolTip addGuestToolTip;
        private System.Windows.Forms.ToolTip lastName1ToolTip;
        private System.Windows.Forms.ToolTip updateReservationToolTip;
        private System.Windows.Forms.ToolTip deleteReservationToolTip;
        private System.Windows.Forms.ToolTip findGuestToolTip;
        private System.Windows.Forms.ListBox frontDeskListBox;
        private System.Windows.Forms.Panel employeeFirstNamePanel;
        private System.Windows.Forms.DateTimePicker reservationEndDateDTP;
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
        private System.Windows.Forms.Label InvalidPhoneLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label InvalidRoomLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox4;
    }
}