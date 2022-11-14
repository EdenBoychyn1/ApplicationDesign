
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.findGuestButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastNameToolTip = new System.Windows.Forms.Label();
            this.findGuestLabel = new System.Windows.Forms.Label();
            this.findGuestListBox = new System.Windows.Forms.ListBox();
            this.findGuest1Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.conciergeFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(720, 600);
            this.panel1.TabIndex = 3;
            // 
            // addReservationButton
            // 
            this.addReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.addReservationButton.FlatAppearance.BorderSize = 6;
            this.addReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.addReservationButton.Location = new System.Drawing.Point(490, 544);
            this.addReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.addReservationButton.Name = "addReservationButton";
            this.addReservationButton.Size = new System.Drawing.Size(180, 52);
            this.addReservationButton.TabIndex = 13;
            this.addReservationButton.Text = "Add Reservation";
            this.addReservationToolTip.SetToolTip(this.addReservationButton, "Add reservation to database.");
            this.addReservationButton.UseVisualStyleBackColor = true;
            // 
            // reservationEndDateDTP
            // 
            this.reservationEndDateDTP.Location = new System.Drawing.Point(423, 492);
            this.reservationEndDateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.reservationEndDateDTP.Name = "reservationEndDateDTP";
            this.reservationEndDateDTP.Size = new System.Drawing.Size(247, 22);
            this.reservationEndDateDTP.TabIndex = 12;
            // 
            // reservationEndDateLabel
            // 
            this.reservationEndDateLabel.AutoSize = true;
            this.reservationEndDateLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationEndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.reservationEndDateLabel.Location = new System.Drawing.Point(418, 432);
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
            this.reservationStartDateLabel.Location = new System.Drawing.Point(40, 432);
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
            this.reservationStartDateDTP.Location = new System.Drawing.Point(45, 492);
            this.reservationStartDateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.reservationStartDateDTP.Name = "reservationStartDateDTP";
            this.reservationStartDateDTP.Size = new System.Drawing.Size(247, 22);
            this.reservationStartDateDTP.TabIndex = 10;
            // 
            // roomsAvailableComboBox
            // 
            this.roomsAvailableComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.roomsAvailableComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomsAvailableComboBox.ForeColor = System.Drawing.Color.White;
            this.roomsAvailableComboBox.FormattingEnabled = true;
            this.roomsAvailableComboBox.ItemHeight = 16;
            this.roomsAvailableComboBox.Location = new System.Drawing.Point(281, 385);
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
            this.roomsAvailable.Location = new System.Drawing.Point(40, 381);
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
            "Single Room",
            "Double Room",
            "Suite"});
            this.roomTypeDropDownBox.Location = new System.Drawing.Point(281, 331);
            this.roomTypeDropDownBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomTypeDropDownBox.MaximumSize = new System.Drawing.Size(265, 0);
            this.roomTypeDropDownBox.MinimumSize = new System.Drawing.Size(265, 0);
            this.roomTypeDropDownBox.Name = "roomTypeDropDownBox";
            this.roomTypeDropDownBox.Size = new System.Drawing.Size(265, 24);
            this.roomTypeDropDownBox.TabIndex = 6;
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
            this.designPanel.Size = new System.Drawing.Size(267, 617);
            this.designPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.findGuest1Label);
            this.panel3.Controls.Add(this.findGuestListBox);
            this.panel3.Controls.Add(this.findGuestButton);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lastNameToolTip);
            this.panel3.Controls.Add(this.findGuestLabel);
            this.panel3.Location = new System.Drawing.Point(14, 19);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 264);
            this.panel3.TabIndex = 14;
            // 
            // findGuestButton
            // 
            this.findGuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.FlatAppearance.BorderSize = 6;
            this.findGuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findGuestButton.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuestButton.Location = new System.Drawing.Point(472, 34);
            this.findGuestButton.Margin = new System.Windows.Forms.Padding(4);
            this.findGuestButton.Name = "findGuestButton";
            this.findGuestButton.Size = new System.Drawing.Size(180, 52);
            this.findGuestButton.TabIndex = 17;
            this.findGuestButton.Text = "Find Guest";
            this.findGuestButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(179, 57);
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
            this.label2.Location = new System.Drawing.Point(185, 63);
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
            this.textBox1.Location = new System.Drawing.Point(179, 32);
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
            this.lastNameToolTip.Location = new System.Drawing.Point(26, 34);
            this.lastNameToolTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameToolTip.MinimumSize = new System.Drawing.Size(71, 25);
            this.lastNameToolTip.Name = "lastNameToolTip";
            this.lastNameToolTip.Size = new System.Drawing.Size(122, 25);
            this.lastNameToolTip.TabIndex = 13;
            this.lastNameToolTip.Text = "Last Name:";
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
            // findGuestListBox
            // 
            this.findGuestListBox.FormattingEnabled = true;
            this.findGuestListBox.ItemHeight = 16;
            this.findGuestListBox.Location = new System.Drawing.Point(179, 101);
            this.findGuestListBox.Name = "findGuestListBox";
            this.findGuestListBox.Size = new System.Drawing.Size(267, 132);
            this.findGuestListBox.TabIndex = 18;
            // 
            // findGuest1Label
            // 
            this.findGuest1Label.AutoSize = true;
            this.findGuest1Label.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGuest1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findGuest1Label.Location = new System.Drawing.Point(26, 101);
            this.findGuest1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findGuest1Label.MinimumSize = new System.Drawing.Size(71, 25);
            this.findGuest1Label.Name = "findGuest1Label";
            this.findGuest1Label.Size = new System.Drawing.Size(135, 25);
            this.findGuest1Label.TabIndex = 19;
            this.findGuest1Label.Text = "Select Guest:";
            this.findGuest1Label.Click += new System.EventHandler(this.findGuest1Label_Click);
            // 
            // MakeAReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1068, 786);
            this.Controls.Add(this.designPanel);
            this.Controls.Add(this.conciergeFormPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MakeAReservation";
            this.Text = "MakeAReservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.conciergeFormPanel.ResumeLayout(false);
            this.conciergeFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lastNameToolTip;
        private System.Windows.Forms.Label findGuestLabel;
    }
}