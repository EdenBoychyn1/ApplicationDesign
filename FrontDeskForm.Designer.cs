
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
            this.retrieveReservationDGV = new System.Windows.Forms.DataGridView();
            this.clientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomReady = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrieveReservationDGV)).BeginInit();
            this.reservationsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
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
            this.reservationIDPanel.Controls.Add(this.findReservationButton);
            this.reservationIDPanel.Controls.Add(this.invalidReservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDLinePanel);
            this.reservationIDPanel.Controls.Add(this.reservationIDPictureBox);
            this.reservationIDPanel.Controls.Add(this.reservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDTextBox);
            this.reservationIDPanel.Location = new System.Drawing.Point(248, 229);
            this.reservationIDPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(631, 145);
            this.reservationIDPanel.TabIndex = 5;
            // 
            // findReservationButton
            // 
            this.findReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.FlatAppearance.BorderSize = 6;
            this.findReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.Location = new System.Drawing.Point(447, 94);
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
            this.reservationIDLinePanel.Size = new System.Drawing.Size(267, 2);
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
            this.reservationsLabel.Location = new System.Drawing.Point(19, 21);
            this.reservationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationsLabel.Name = "reservationsLabel";
            this.reservationsLabel.Size = new System.Drawing.Size(172, 32);
            this.reservationsLabel.TabIndex = 19;
            this.reservationsLabel.Text = "Reservations";
            // 
            // retrieveReservationDGV
            // 
            this.retrieveReservationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.retrieveReservationDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientFirstName,
            this.clientLastName,
            this.clientEmail,
            this.roomNumber,
            this.roomType,
            this.roomDesc,
            this.roomReady,
            this.reservationStartDate,
            this.reservationEndDate});
            this.retrieveReservationDGV.Location = new System.Drawing.Point(19, 66);
            this.retrieveReservationDGV.Margin = new System.Windows.Forms.Padding(4);
            this.retrieveReservationDGV.Name = "retrieveReservationDGV";
            this.retrieveReservationDGV.RowHeadersWidth = 51;
            this.retrieveReservationDGV.Size = new System.Drawing.Size(1535, 126);
            this.retrieveReservationDGV.TabIndex = 20;
            // 
            // clientFirstName
            // 
            this.clientFirstName.HeaderText = "Guest First Name";
            this.clientFirstName.MinimumWidth = 6;
            this.clientFirstName.Name = "clientFirstName";
            this.clientFirstName.Width = 125;
            // 
            // clientLastName
            // 
            this.clientLastName.HeaderText = "Guest Last Name";
            this.clientLastName.MinimumWidth = 6;
            this.clientLastName.Name = "clientLastName";
            this.clientLastName.Width = 125;
            // 
            // clientEmail
            // 
            this.clientEmail.HeaderText = "Guest Email";
            this.clientEmail.MinimumWidth = 6;
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Width = 125;
            // 
            // roomNumber
            // 
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.MinimumWidth = 6;
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Width = 125;
            // 
            // roomType
            // 
            this.roomType.HeaderText = "Room Type";
            this.roomType.MinimumWidth = 6;
            this.roomType.Name = "roomType";
            this.roomType.Width = 125;
            // 
            // roomDesc
            // 
            this.roomDesc.HeaderText = "Room Description";
            this.roomDesc.MinimumWidth = 6;
            this.roomDesc.Name = "roomDesc";
            this.roomDesc.Width = 125;
            // 
            // roomReady
            // 
            this.roomReady.HeaderText = "Room Ready";
            this.roomReady.MinimumWidth = 6;
            this.roomReady.Name = "roomReady";
            this.roomReady.Width = 125;
            // 
            // reservationStartDate
            // 
            this.reservationStartDate.HeaderText = "Reservation Start Date";
            this.reservationStartDate.MinimumWidth = 6;
            this.reservationStartDate.Name = "reservationStartDate";
            this.reservationStartDate.Width = 125;
            // 
            // reservationEndDate
            // 
            this.reservationEndDate.HeaderText = "Reservation End Date";
            this.reservationEndDate.MinimumWidth = 6;
            this.reservationEndDate.Name = "reservationEndDate";
            this.reservationEndDate.Width = 125;
            // 
            // updateReservationButton
            // 
            this.updateReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.updateReservationButton.FlatAppearance.BorderSize = 6;
            this.updateReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateReservationButton.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.updateReservationButton.Location = new System.Drawing.Point(886, 215);
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
            this.deleteReservationButton.Location = new System.Drawing.Point(1229, 215);
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
            this.reservationsPanel.Controls.Add(this.reservationsLabel);
            this.reservationsPanel.Controls.Add(this.deleteReservationButton);
            this.reservationsPanel.Controls.Add(this.retrieveReservationDGV);
            this.reservationsPanel.Controls.Add(this.updateReservationButton);
            this.reservationsPanel.Location = new System.Drawing.Point(248, 401);
            this.reservationsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationsPanel.Name = "reservationsPanel";
            this.reservationsPanel.Size = new System.Drawing.Size(1558, 330);
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
            this.panel3.Location = new System.Drawing.Point(907, 230);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 145);
            this.panel3.TabIndex = 11;
            // 
            // findGuestButton
            // 
            this.findGuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.FlatAppearance.BorderSize = 6;
            this.findGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findGuestButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.Location = new System.Drawing.Point(472, 94);
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
            // FrontDeskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1818, 753);
            this.Controls.Add(this.makeAReservationButton);
            this.Controls.Add(this.addAGuestButton);
            this.Controls.Add(this.kingWilliamHotelPictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.reservationsPanel);
            this.Controls.Add(this.reservationIDPanel);
            this.Controls.Add(this.frontDeskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1836, 800);
            this.MinimumSize = new System.Drawing.Size(1836, 800);
            this.Name = "FrontDeskForm";
            this.Text = "FrontDeskForm";
            this.reservationIDPanel.ResumeLayout(false);
            this.reservationIDPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrieveReservationDGV)).EndInit();
            this.reservationsPanel.ResumeLayout(false);
            this.reservationsPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView retrieveReservationDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomReady;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationEndDate;
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
    }
}