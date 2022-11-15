
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
            this.employeeFirstNamePanel = new System.Windows.Forms.Panel();
            this.reservationEndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.reservationEndDateLabel = new System.Windows.Forms.Label();
            this.reservationStartDateLabel = new System.Windows.Forms.Label();
            this.reservationStartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.guestRoomNumberListBox = new System.Windows.Forms.ListBox();
            this.guestRoomNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.frontDeskListBox = new System.Windows.Forms.ListBox();
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).BeginInit();
            this.reservationsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.employeeFirstNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // frontDeskLabel
            // 
            this.frontDeskLabel.AutoSize = true;
            this.frontDeskLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontDeskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.frontDeskLabel.Location = new System.Drawing.Point(800, 65);
            this.frontDeskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frontDeskLabel.Name = "frontDeskLabel";
            this.frontDeskLabel.Size = new System.Drawing.Size(180, 38);
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
            this.reservationIDPanel.Location = new System.Drawing.Point(252, 177);
            this.reservationIDPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(776, 197);
            this.reservationIDPanel.TabIndex = 5;
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
            this.findReservationToolTip.SetToolTip(this.findReservationButton, "After entering a reservation ID, select Find Reservation to find the reservation." +
        "");
            this.findReservationButton.UseVisualStyleBackColor = true;
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
            this.reservationIDToolTip.SetToolTip(this.reservationIDLabel, "Enter a reservation ID.");
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
            // reservationsLabel
            // 
            this.reservationsLabel.AutoSize = true;
            this.reservationsLabel.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationsLabel.Location = new System.Drawing.Point(41, 35);
            this.reservationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationsLabel.Name = "reservationsLabel";
            this.reservationsLabel.Size = new System.Drawing.Size(172, 32);
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
            this.updateReservationButton.Location = new System.Drawing.Point(605, 266);
            this.updateReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateReservationButton.Name = "updateReservationButton";
            this.updateReservationButton.Size = new System.Drawing.Size(325, 73);
            this.updateReservationButton.TabIndex = 21;
            this.updateReservationButton.Text = "Update Reservation";
            this.updateReservationToolTip.SetToolTip(this.updateReservationButton, "Select Update reservation to update the reservation selected.");
            this.updateReservationButton.UseVisualStyleBackColor = true;
            // 
            // deleteReservationButton
            // 
            this.deleteReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.deleteReservationButton.FlatAppearance.BorderSize = 6;
            this.deleteReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteReservationButton.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.deleteReservationButton.Location = new System.Drawing.Point(976, 266);
            this.deleteReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteReservationButton.Name = "deleteReservationButton";
            this.deleteReservationButton.Size = new System.Drawing.Size(325, 73);
            this.deleteReservationButton.TabIndex = 22;
            this.deleteReservationButton.Text = "Delete Reservation";
            this.deleteReservationToolTip.SetToolTip(this.deleteReservationButton, "Select Delete Reservation to delete the selected reservation.");
            this.deleteReservationButton.UseVisualStyleBackColor = true;
            // 
            // reservationsPanel
            // 
            this.reservationsPanel.Controls.Add(this.employeeFirstNamePanel);
            this.reservationsPanel.Controls.Add(this.deleteReservationButton);
            this.reservationsPanel.Controls.Add(this.updateReservationButton);
            this.reservationsPanel.Location = new System.Drawing.Point(252, 382);
            this.reservationsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationsPanel.Name = "reservationsPanel";
            this.reservationsPanel.Size = new System.Drawing.Size(1305, 344);
            this.reservationsPanel.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.findGuestButton);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lastNameToolTip);
            this.panel3.Controls.Add(this.findGuestLabel);
            this.panel3.Location = new System.Drawing.Point(1036, 177);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 197);
            this.panel3.TabIndex = 11;
            // 
            // findGuestButton
            // 
            this.findGuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.FlatAppearance.BorderSize = 6;
            this.findGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findGuestButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.Location = new System.Drawing.Point(337, 141);
            this.findGuestButton.Margin = new System.Windows.Forms.Padding(4);
            this.findGuestButton.Name = "findGuestButton";
            this.findGuestButton.Size = new System.Drawing.Size(180, 52);
            this.findGuestButton.TabIndex = 17;
            this.findGuestButton.Text = "Find Guest";
            this.findGuestToolTip.SetToolTip(this.findGuestButton, "Select Find Guest to find a guest by their last name.");
            this.findGuestButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(215, 57);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.MinimumSize = new System.Drawing.Size(267, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 2);
            this.panel5.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(209, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(232, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 23);
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
            this.textBox1.Location = new System.Drawing.Point(213, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MinimumSize = new System.Drawing.Size(71, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 23);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Enter Guest Last Name";
            // 
            // lastNameToolTip
            // 
            this.lastNameToolTip.AutoSize = true;
            this.lastNameToolTip.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.lastNameToolTip.Location = new System.Drawing.Point(49, 34);
            this.lastNameToolTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameToolTip.MinimumSize = new System.Drawing.Size(71, 25);
            this.lastNameToolTip.Name = "lastNameToolTip";
            this.lastNameToolTip.Size = new System.Drawing.Size(122, 25);
            this.lastNameToolTip.TabIndex = 13;
            this.lastNameToolTip.Text = "Last Name:";
            this.lastName1ToolTip.SetToolTip(this.lastNameToolTip, "Enter a guest\'s last name.");
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
            // makeAReservationButton
            // 
            this.makeAReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.makeAReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeAReservationButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeAReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.makeAReservationButton.Image = global::ApplicationDesign.Properties.Resources.manager;
            this.makeAReservationButton.Location = new System.Drawing.Point(16, 330);
            this.makeAReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.makeAReservationButton.Name = "makeAReservationButton";
            this.makeAReservationButton.Size = new System.Drawing.Size(213, 145);
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
            this.addAGuestButton.Location = new System.Drawing.Point(16, 177);
            this.addAGuestButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAGuestButton.Name = "addAGuestButton";
            this.addAGuestButton.Size = new System.Drawing.Size(213, 145);
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
            this.kingWilliamHotelPictureBox.Location = new System.Drawing.Point(16, 15);
            this.kingWilliamHotelPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.kingWilliamHotelPictureBox.Name = "kingWilliamHotelPictureBox";
            this.kingWilliamHotelPictureBox.Size = new System.Drawing.Size(289, 145);
            this.kingWilliamHotelPictureBox.TabIndex = 1;
            this.kingWilliamHotelPictureBox.TabStop = false;
            // 
            // employeeFirstNamePanel
            // 
            this.employeeFirstNamePanel.Controls.Add(this.reservationEndDateDTP);
            this.employeeFirstNamePanel.Controls.Add(this.reservationsLabel);
            this.employeeFirstNamePanel.Controls.Add(this.reservationEndDateLabel);
            this.employeeFirstNamePanel.Controls.Add(this.reservationStartDateLabel);
            this.employeeFirstNamePanel.Controls.Add(this.reservationStartDateDTP);
            this.employeeFirstNamePanel.Controls.Add(this.guestRoomNumberListBox);
            this.employeeFirstNamePanel.Controls.Add(this.guestRoomNumberLabel);
            this.employeeFirstNamePanel.Controls.Add(this.label1);
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
            this.employeeFirstNamePanel.Location = new System.Drawing.Point(4, 4);
            this.employeeFirstNamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.employeeFirstNamePanel.Name = "employeeFirstNamePanel";
            this.employeeFirstNamePanel.Size = new System.Drawing.Size(1297, 254);
            this.employeeFirstNamePanel.TabIndex = 23;
            // 
            // reservationEndDateDTP
            // 
            this.reservationEndDateDTP.Location = new System.Drawing.Point(1013, 203);
            this.reservationEndDateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.reservationEndDateDTP.Name = "reservationEndDateDTP";
            this.reservationEndDateDTP.Size = new System.Drawing.Size(247, 22);
            this.reservationEndDateDTP.TabIndex = 28;
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
            // guestRoomNumberListBox
            // 
            this.guestRoomNumberListBox.FormattingEnabled = true;
            this.guestRoomNumberListBox.ItemHeight = 16;
            this.guestRoomNumberListBox.Location = new System.Drawing.Point(1015, 87);
            this.guestRoomNumberListBox.Name = "guestRoomNumberListBox";
            this.guestRoomNumberListBox.Size = new System.Drawing.Size(250, 20);
            this.guestRoomNumberListBox.TabIndex = 24;
            // 
            // guestRoomNumberLabel
            // 
            this.guestRoomNumberLabel.AutoSize = true;
            this.guestRoomNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestRoomNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestRoomNumberLabel.Location = new System.Drawing.Point(727, 82);
            this.guestRoomNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestRoomNumberLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.guestRoomNumberLabel.Name = "guestRoomNumberLabel";
            this.guestRoomNumberLabel.Size = new System.Drawing.Size(218, 25);
            this.guestRoomNumberLabel.TabIndex = 23;
            this.guestRoomNumberLabel.Text = "Guest Room Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(365, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Invalid Guest First Name.";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(308, 221);
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
            this.label3.Location = new System.Drawing.Point(54, 201);
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
            this.invalidGuestLastNameLabel.Location = new System.Drawing.Point(310, 169);
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
            this.guestLastNameUnderlinePanel.Location = new System.Drawing.Point(308, 163);
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
            this.guestFirstNameUnderlinePanel.Location = new System.Drawing.Point(310, 104);
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
            // frontDeskListBox
            // 
            this.frontDeskListBox.FormattingEnabled = true;
            this.frontDeskListBox.ItemHeight = 16;
            this.frontDeskListBox.Location = new System.Drawing.Point(337, 99);
            this.frontDeskListBox.Name = "frontDeskListBox";
            this.frontDeskListBox.Size = new System.Drawing.Size(225, 84);
            this.frontDeskListBox.TabIndex = 19;
            // 
            // FrontDeskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1579, 761);
            this.Controls.Add(this.makeAReservationButton);
            this.Controls.Add(this.addAGuestButton);
            this.Controls.Add(this.kingWilliamHotelPictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.reservationsPanel);
            this.Controls.Add(this.reservationIDPanel);
            this.Controls.Add(this.frontDeskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1800, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FrontDeskForm";
            this.Text = "FrontDeskForm";
            this.Load += new System.EventHandler(this.FrontDeskForm_Load);
            this.reservationIDPanel.ResumeLayout(false);
            this.reservationIDPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).EndInit();
            this.reservationsPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).EndInit();
            this.employeeFirstNamePanel.ResumeLayout(false);
            this.employeeFirstNamePanel.PerformLayout();
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
        private System.Windows.Forms.ListBox guestRoomNumberListBox;
        private System.Windows.Forms.Label guestRoomNumberLabel;
        private System.Windows.Forms.Label label1;
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
    }
}