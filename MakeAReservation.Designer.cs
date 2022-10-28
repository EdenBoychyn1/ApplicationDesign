
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
            this.panel1.SuspendLayout();
            this.conciergeFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(720, 356);
            this.panel1.TabIndex = 3;
            // 
            // addReservationButton
            // 
            this.addReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.addReservationButton.FlatAppearance.BorderSize = 6;
            this.addReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.addReservationButton.Location = new System.Drawing.Point(490, 274);
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
            this.reservationEndDateDTP.Location = new System.Drawing.Point(423, 216);
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
            this.reservationEndDateLabel.Location = new System.Drawing.Point(418, 178);
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
            this.reservationStartDateLabel.Location = new System.Drawing.Point(40, 178);
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
            this.reservationStartDateDTP.Location = new System.Drawing.Point(45, 216);
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
            this.roomsAvailableComboBox.Location = new System.Drawing.Point(281, 110);
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
            this.roomsAvailable.Location = new System.Drawing.Point(51, 110);
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
            this.roomTypeDropDownBox.Location = new System.Drawing.Point(281, 71);
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
            this.roomTypeLabel.Location = new System.Drawing.Point(51, 70);
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
            this.findRoomLabel.Location = new System.Drawing.Point(39, 21);
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
            this.designPanel.Size = new System.Drawing.Size(267, 373);
            this.designPanel.TabIndex = 2;
            // 
            // MakeAReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1057, 565);
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
    }
}