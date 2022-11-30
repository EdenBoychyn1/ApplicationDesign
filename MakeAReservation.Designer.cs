
namespace ApplicationDesign
{
    partial class MakeAReservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.findRoomButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.findGuest1Label = new System.Windows.Forms.Label();
            this.findGuestListBox = new System.Windows.Forms.ListBox();
            this.findGuestButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.invalidPhoneLabel = new System.Windows.Forms.Label();
            this.guestsPhoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.findGuestLabel = new System.Windows.Forms.Label();
            this.addReservationButton = new System.Windows.Forms.Button();
            this.reservationEndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.reservationEndDateLabel = new System.Windows.Forms.Label();
            this.reservationStartDateLabel = new System.Windows.Forms.Label();
            this.reservationStartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.roomsAvailableComboBox = new System.Windows.Forms.ComboBox();
            this.roomsAvailable = new System.Windows.Forms.Label();
            this.roomTypeDropDownBox = new System.Windows.Forms.ComboBox();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.findRoomLabel = new System.Windows.Forms.Label();
            this.conciergeFormPanel = new System.Windows.Forms.Panel();
            this.conciergeLabel = new System.Windows.Forms.Label();
            this.kingWilliamHotelPictureBox = new System.Windows.Forms.PictureBox();
            this.designPanel = new System.Windows.Forms.Panel();
            this.roomType1ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.roomAvailableToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addReservationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.startToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.endToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.noGuestSelectedLabel = new System.Windows.Forms.Label();
            this.invalidRoomTypeLabel = new System.Windows.Forms.Label();
            this.invalidDatesLabel = new System.Windows.Forms.Label();
            this.invalidRoomNumberLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.conciergeFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.invalidRoomNumberLabel);
            this.panel1.Controls.Add(this.invalidDatesLabel);
            this.panel1.Controls.Add(this.invalidRoomTypeLabel);
            this.panel1.Controls.Add(this.noGuestSelectedLabel);
            this.panel1.Controls.Add(this.findRoomButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.addReservationButton);
            this.panel1.Controls.Add(this.reservationEndDateDTP);
            this.panel1.Controls.Add(this.reservationEndDateLabel);
            this.panel1.Controls.Add(this.reservationStartDateLabel);
            this.panel1.Controls.Add(this.reservationStartDateDTP);
            this.panel1.Controls.Add(this.roomsAvailableComboBox);
            this.panel1.Controls.Add(this.roomsAvailable);
            this.panel1.Controls.Add(this.roomTypeDropDownBox);
            this.panel1.Controls.Add(this.roomTypeLabel);
            this.panel1.Controls.Add(this.findRoomLabel);
            this.panel1.Location = new System.Drawing.Point(301, 173);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 648);
            this.panel1.TabIndex = 3;
            // 
            // findRoomButton
            // 
            this.findRoomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findRoomButton.FlatAppearance.BorderSize = 6;
            this.findRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findRoomButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findRoomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findRoomButton.Location = new System.Drawing.Point(557, 331);
            this.findRoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.findRoomButton.Name = "findRoomButton";
            this.findRoomButton.Size = new System.Drawing.Size(180, 52);
            this.findRoomButton.TabIndex = 15;
            this.findRoomButton.Text = "Find Rooms";
            this.addReservationToolTip.SetToolTip(this.findRoomButton, "Add reservation to database.");
            this.findRoomButton.UseVisualStyleBackColor = true;
            this.findRoomButton.Click += new System.EventHandler(this.findRoomButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.findGuest1Label);
            this.panel3.Controls.Add(this.findGuestListBox);
            this.panel3.Controls.Add(this.findGuestButton);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.invalidPhoneLabel);
            this.panel3.Controls.Add(this.guestsPhoneTextBox);
            this.panel3.Controls.Add(this.phoneLabel);
            this.panel3.Controls.Add(this.findGuestLabel);
            this.panel3.Location = new System.Drawing.Point(14, 19);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 264);
            this.panel3.TabIndex = 14;
            // 
            // findGuest1Label
            // 
            this.findGuest1Label.AutoSize = true;
            this.findGuest1Label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuest1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuest1Label.Location = new System.Drawing.Point(26, 116);
            this.findGuest1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findGuest1Label.MinimumSize = new System.Drawing.Size(71, 25);
            this.findGuest1Label.Name = "findGuest1Label";
            this.findGuest1Label.Size = new System.Drawing.Size(135, 25);
            this.findGuest1Label.TabIndex = 19;
            this.findGuest1Label.Text = "Select Guest:";
            this.findGuest1Label.Click += new System.EventHandler(this.findGuest1Label_Click);
            // 
            // findGuestListBox
            // 
            this.findGuestListBox.FormattingEnabled = true;
            this.findGuestListBox.ItemHeight = 16;
            this.findGuestListBox.Location = new System.Drawing.Point(195, 116);
            this.findGuestListBox.Name = "findGuestListBox";
            this.findGuestListBox.Size = new System.Drawing.Size(267, 84);
            this.findGuestListBox.TabIndex = 18;
            this.findGuestListBox.Enter += new System.EventHandler(this.findGuestListBox_Enter);
            // 
            // findGuestButton
            // 
            this.findGuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.FlatAppearance.BorderSize = 6;
            this.findGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findGuestButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.Location = new System.Drawing.Point(526, 48);
            this.findGuestButton.Margin = new System.Windows.Forms.Padding(4);
            this.findGuestButton.Name = "findGuestButton";
            this.findGuestButton.Size = new System.Drawing.Size(180, 52);
            this.findGuestButton.TabIndex = 17;
            this.findGuestButton.Text = "Find Guest";
            this.findGuestButton.UseVisualStyleBackColor = true;
            this.findGuestButton.Click += new System.EventHandler(this.findGuestButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(195, 73);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.MinimumSize = new System.Drawing.Size(267, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 2);
            this.panel5.TabIndex = 15;
            // 
            // invalidPhoneLabel
            // 
            this.invalidPhoneLabel.AutoSize = true;
            this.invalidPhoneLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidPhoneLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidPhoneLabel.Location = new System.Drawing.Point(200, 79);
            this.invalidPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidPhoneLabel.MinimumSize = new System.Drawing.Size(232, 23);
            this.invalidPhoneLabel.Name = "invalidPhoneLabel";
            this.invalidPhoneLabel.Size = new System.Drawing.Size(232, 23);
            this.invalidPhoneLabel.TabIndex = 16;
            this.invalidPhoneLabel.Text = "No guest could be found.";
            this.invalidPhoneLabel.Visible = false;
            // 
            // guestsPhoneTextBox
            // 
            this.guestsPhoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.guestsPhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestsPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsPhoneTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.guestsPhoneTextBox.Location = new System.Drawing.Point(195, 45);
            this.guestsPhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guestsPhoneTextBox.MinimumSize = new System.Drawing.Size(71, 20);
            this.guestsPhoneTextBox.Name = "guestsPhoneTextBox";
            this.guestsPhoneTextBox.Size = new System.Drawing.Size(274, 21);
            this.guestsPhoneTextBox.TabIndex = 14;
            this.guestsPhoneTextBox.Text = "Enter Guest\'s Phone Number";
            this.guestsPhoneTextBox.Click += new System.EventHandler(this.guestsPhoneTextBox_Click);
            this.guestsPhoneTextBox.TextChanged += new System.EventHandler(this.guestsPhoneTextBox_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.phoneLabel.Location = new System.Drawing.Point(17, 48);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(161, 25);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // findGuestLabel
            // 
            this.findGuestLabel.AutoSize = true;
            this.findGuestLabel.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestLabel.Location = new System.Drawing.Point(16, 0);
            this.findGuestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findGuestLabel.Name = "findGuestLabel";
            this.findGuestLabel.Size = new System.Drawing.Size(152, 32);
            this.findGuestLabel.TabIndex = 12;
            this.findGuestLabel.Text = "Find Guest";
            // 
            // addReservationButton
            // 
            this.addReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.addReservationButton.FlatAppearance.BorderSize = 6;
            this.addReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.addReservationButton.Location = new System.Drawing.Point(557, 578);
            this.addReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.addReservationButton.Name = "addReservationButton";
            this.addReservationButton.Size = new System.Drawing.Size(180, 52);
            this.addReservationButton.TabIndex = 13;
            this.addReservationButton.Text = "Add Reservation";
            this.addReservationToolTip.SetToolTip(this.addReservationButton, "Add reservation to database.");
            this.addReservationButton.UseVisualStyleBackColor = true;
            this.addReservationButton.Click += new System.EventHandler(this.addReservationButton_Click);
            // 
            // reservationEndDateDTP
            // 
            this.reservationEndDateDTP.Location = new System.Drawing.Point(423, 526);
            this.reservationEndDateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.reservationEndDateDTP.Name = "reservationEndDateDTP";
            this.reservationEndDateDTP.Size = new System.Drawing.Size(247, 22);
            this.reservationEndDateDTP.TabIndex = 12;
            this.reservationEndDateDTP.ValueChanged += new System.EventHandler(this.reservationEndDateDTP_ValueChanged);
            // 
            // reservationEndDateLabel
            // 
            this.reservationEndDateLabel.AutoSize = true;
            this.reservationEndDateLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationEndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationEndDateLabel.Location = new System.Drawing.Point(418, 482);
            this.reservationEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationEndDateLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.reservationEndDateLabel.Name = "reservationEndDateLabel";
            this.reservationEndDateLabel.Size = new System.Drawing.Size(226, 25);
            this.reservationEndDateLabel.TabIndex = 11;
            this.reservationEndDateLabel.Text = "Reservation End Date:";
            this.endToolTip.SetToolTip(this.reservationEndDateLabel, "Select Reservation End Date.");
            // 
            // reservationStartDateLabel
            // 
            this.reservationStartDateLabel.AutoSize = true;
            this.reservationStartDateLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationStartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationStartDateLabel.Location = new System.Drawing.Point(40, 482);
            this.reservationStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationStartDateLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.reservationStartDateLabel.Name = "reservationStartDateLabel";
            this.reservationStartDateLabel.Size = new System.Drawing.Size(233, 25);
            this.reservationStartDateLabel.TabIndex = 9;
            this.reservationStartDateLabel.Text = "Reservation Start Date:";
            this.startToolTip.SetToolTip(this.reservationStartDateLabel, "Select Reservation Start Date.");
            // 
            // reservationStartDateDTP
            // 
            this.reservationStartDateDTP.Location = new System.Drawing.Point(45, 526);
            this.reservationStartDateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.reservationStartDateDTP.Name = "reservationStartDateDTP";
            this.reservationStartDateDTP.Size = new System.Drawing.Size(247, 22);
            this.reservationStartDateDTP.TabIndex = 10;
            this.reservationStartDateDTP.ValueChanged += new System.EventHandler(this.reservationStartDateDTP_ValueChanged);
            // 
            // roomsAvailableComboBox
            // 
            this.roomsAvailableComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.roomsAvailableComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomsAvailableComboBox.ForeColor = System.Drawing.Color.White;
            this.roomsAvailableComboBox.FormattingEnabled = true;
            this.roomsAvailableComboBox.ItemHeight = 16;
            this.roomsAvailableComboBox.Location = new System.Drawing.Point(232, 412);
            this.roomsAvailableComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomsAvailableComboBox.MaximumSize = new System.Drawing.Size(265, 0);
            this.roomsAvailableComboBox.MinimumSize = new System.Drawing.Size(265, 0);
            this.roomsAvailableComboBox.Name = "roomsAvailableComboBox";
            this.roomsAvailableComboBox.Size = new System.Drawing.Size(265, 24);
            this.roomsAvailableComboBox.TabIndex = 8;
            // 
            // roomsAvailable
            // 
            this.roomsAvailable.AutoSize = true;
            this.roomsAvailable.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomsAvailable.Location = new System.Drawing.Point(40, 412);
            this.roomsAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomsAvailable.MinimumSize = new System.Drawing.Size(71, 25);
            this.roomsAvailable.Name = "roomsAvailable";
            this.roomsAvailable.Size = new System.Drawing.Size(175, 25);
            this.roomsAvailable.TabIndex = 7;
            this.roomsAvailable.Text = "Rooms Available:";
            this.roomAvailableToolTip.SetToolTip(this.roomsAvailable, "Select RoomAvilable to find the available rooms.");
            // 
            // roomTypeDropDownBox
            // 
            this.roomTypeDropDownBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.roomTypeDropDownBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomTypeDropDownBox.ForeColor = System.Drawing.Color.White;
            this.roomTypeDropDownBox.FormattingEnabled = true;
            this.roomTypeDropDownBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suites"});
            this.roomTypeDropDownBox.Location = new System.Drawing.Point(232, 335);
            this.roomTypeDropDownBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomTypeDropDownBox.MaximumSize = new System.Drawing.Size(265, 0);
            this.roomTypeDropDownBox.MinimumSize = new System.Drawing.Size(265, 0);
            this.roomTypeDropDownBox.Name = "roomTypeDropDownBox";
            this.roomTypeDropDownBox.Size = new System.Drawing.Size(265, 24);
            this.roomTypeDropDownBox.TabIndex = 6;
            this.roomTypeDropDownBox.Click += new System.EventHandler(this.roomTypeDropDownBox_Click);
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomTypeLabel.Location = new System.Drawing.Point(40, 331);
            this.roomTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomTypeLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(125, 25);
            this.roomTypeLabel.TabIndex = 5;
            this.roomTypeLabel.Text = "Room Type:";
            this.roomType1ToolTip.SetToolTip(this.roomTypeLabel, "Find room by selecting room type first.");
            // 
            // findRoomLabel
            // 
            this.findRoomLabel.AutoSize = true;
            this.findRoomLabel.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findRoomLabel.Location = new System.Drawing.Point(39, 287);
            this.findRoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findRoomLabel.Name = "findRoomLabel";
            this.findRoomLabel.Size = new System.Drawing.Size(153, 32);
            this.findRoomLabel.TabIndex = 4;
            this.findRoomLabel.Text = "Find Room";
            // 
            // conciergeFormPanel
            // 
            this.conciergeFormPanel.Controls.Add(this.conciergeLabel);
            this.conciergeFormPanel.Controls.Add(this.kingWilliamHotelPictureBox);
            this.conciergeFormPanel.Location = new System.Drawing.Point(13, 13);
            this.conciergeFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.conciergeFormPanel.Name = "conciergeFormPanel";
            this.conciergeFormPanel.Size = new System.Drawing.Size(1008, 132);
            this.conciergeFormPanel.TabIndex = 0;
            // 
            // conciergeLabel
            // 
            this.conciergeLabel.AutoSize = true;
            this.conciergeLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conciergeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.conciergeLabel.Location = new System.Drawing.Point(453, 41);
            this.conciergeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conciergeLabel.Name = "conciergeLabel";
            this.conciergeLabel.Size = new System.Drawing.Size(311, 38);
            this.conciergeLabel.TabIndex = 1;
            this.conciergeLabel.Text = "Make A Reservation";
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
            // designPanel
            // 
            this.designPanel.Location = new System.Drawing.Point(13, 156);
            this.designPanel.Margin = new System.Windows.Forms.Padding(4);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(267, 665);
            this.designPanel.TabIndex = 2;
            // 
            // noGuestSelectedLabel
            // 
            this.noGuestSelectedLabel.AutoSize = true;
            this.noGuestSelectedLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noGuestSelectedLabel.ForeColor = System.Drawing.Color.Red;
            this.noGuestSelectedLabel.Location = new System.Drawing.Point(214, 237);
            this.noGuestSelectedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noGuestSelectedLabel.MinimumSize = new System.Drawing.Size(232, 23);
            this.noGuestSelectedLabel.Name = "noGuestSelectedLabel";
            this.noGuestSelectedLabel.Size = new System.Drawing.Size(232, 23);
            this.noGuestSelectedLabel.TabIndex = 20;
            this.noGuestSelectedLabel.Text = "You must select the guest.";
            this.noGuestSelectedLabel.Visible = false;
            // 
            // invalidRoomTypeLabel
            // 
            this.invalidRoomTypeLabel.AutoSize = true;
            this.invalidRoomTypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidRoomTypeLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidRoomTypeLabel.Location = new System.Drawing.Point(230, 372);
            this.invalidRoomTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidRoomTypeLabel.MinimumSize = new System.Drawing.Size(232, 23);
            this.invalidRoomTypeLabel.Name = "invalidRoomTypeLabel";
            this.invalidRoomTypeLabel.Size = new System.Drawing.Size(267, 23);
            this.invalidRoomTypeLabel.TabIndex = 21;
            this.invalidRoomTypeLabel.Text = "You must select the room type.";
            this.invalidRoomTypeLabel.Visible = false;
            // 
            // invalidDatesLabel
            // 
            this.invalidDatesLabel.AutoSize = true;
            this.invalidDatesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidDatesLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidDatesLabel.Location = new System.Drawing.Point(44, 568);
            this.invalidDatesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidDatesLabel.MinimumSize = new System.Drawing.Size(232, 23);
            this.invalidDatesLabel.Name = "invalidDatesLabel";
            this.invalidDatesLabel.Size = new System.Drawing.Size(473, 58);
            this.invalidDatesLabel.TabIndex = 22;
            this.invalidDatesLabel.Text = "The reservation end date must be later than\r\nthe start date.";
            this.invalidDatesLabel.Visible = false;
            // 
            // invalidRoomNumberLabel
            // 
            this.invalidRoomNumberLabel.AutoSize = true;
            this.invalidRoomNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidRoomNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidRoomNumberLabel.Location = new System.Drawing.Point(230, 450);
            this.invalidRoomNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidRoomNumberLabel.MinimumSize = new System.Drawing.Size(232, 23);
            this.invalidRoomNumberLabel.Name = "invalidRoomNumberLabel";
            this.invalidRoomNumberLabel.Size = new System.Drawing.Size(364, 29);
            this.invalidRoomNumberLabel.TabIndex = 23;
            this.invalidRoomNumberLabel.Text = "You must select the room number.";
            this.invalidRoomNumberLabel.Visible = false;
            // 
            // MakeAReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1068, 844);
            this.Controls.Add(this.designPanel);
            this.Controls.Add(this.conciergeFormPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MakeAReservation";
            this.Text = "MakeAReservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.conciergeFormPanel.ResumeLayout(false);
            this.conciergeFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addReservationButton;
        private System.Windows.Forms.DateTimePicker reservationEndDateDTP;
        private System.Windows.Forms.Label reservationEndDateLabel;
        private System.Windows.Forms.Label reservationStartDateLabel;
        private System.Windows.Forms.DateTimePicker reservationStartDateDTP;
        private System.Windows.Forms.ComboBox roomsAvailableComboBox;
        private System.Windows.Forms.Label roomsAvailable;
        private System.Windows.Forms.ComboBox roomTypeDropDownBox;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.Label findRoomLabel;
        private System.Windows.Forms.Panel conciergeFormPanel;
        private System.Windows.Forms.Label conciergeLabel;
        private System.Windows.Forms.PictureBox kingWilliamHotelPictureBox;
        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.ToolTip addReservationToolTip;
        private System.Windows.Forms.ToolTip endToolTip;
        private System.Windows.Forms.ToolTip startToolTip;
        private System.Windows.Forms.ToolTip roomAvailableToolTip;
        private System.Windows.Forms.ToolTip roomType1ToolTip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label findGuest1Label;
        private System.Windows.Forms.ListBox findGuestListBox;
        private System.Windows.Forms.Button findGuestButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label invalidPhoneLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label findGuestLabel;
        private System.Windows.Forms.TextBox guestsPhoneTextBox;
        private System.Windows.Forms.Button findRoomButton;
        private System.Windows.Forms.Label noGuestSelectedLabel;
        private System.Windows.Forms.Label invalidRoomTypeLabel;
        private System.Windows.Forms.Label invalidDatesLabel;
        private System.Windows.Forms.Label invalidRoomNumberLabel;
    }
}