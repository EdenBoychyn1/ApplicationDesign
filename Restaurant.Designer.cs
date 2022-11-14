
namespace ApplicationDesign
{
    partial class RestaurantForm
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
            this.restaurantFormPanel = new System.Windows.Forms.Panel();
            this.restaurantLabel = new System.Windows.Forms.Label();
            this.kingWilliamHotelPictureBox = new System.Windows.Forms.PictureBox();
            this.reservationIDPanel = new System.Windows.Forms.Panel();
            this.findReservationButton = new System.Windows.Forms.Button();
            this.invalidReservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDLinePanel = new System.Windows.Forms.Panel();
            this.reservationIDPictureBox = new System.Windows.Forms.PictureBox();
            this.reservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDTextBox = new System.Windows.Forms.TextBox();
            this.restaurantItemCodeLabel = new System.Windows.Forms.Label();
            this.restauarantItemCodeDropDownBox = new System.Windows.Forms.ComboBox();
            this.restaurantItemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemDescriptionLinePanel = new System.Windows.Forms.Panel();
            this.itemInvoiceButton = new System.Windows.Forms.Button();
            this.reservationID2ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.findReservation2ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.restaurantCodeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.itemDescription2ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addItem1ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.employeeFirstNamePanel = new System.Windows.Forms.Panel();
            this.invalidGuestFirstNameLabel = new System.Windows.Forms.Label();
            this.guestFirstNameUnderlinePanel = new System.Windows.Forms.Panel();
            this.guestFirstNameLabel = new System.Windows.Forms.Label();
            this.guestFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.invalidGuestLastNameLabel = new System.Windows.Forms.Label();
            this.guestLastNameUnderlinePanel = new System.Windows.Forms.Panel();
            this.guestLastNameLabel = new System.Windows.Forms.Label();
            this.guestLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guestRoomNumberLabel = new System.Windows.Forms.Label();
            this.guestRoomNumberListBox = new System.Windows.Forms.ListBox();
            this.reservationEndDateDTP = new System.Windows.Forms.DateTimePicker();
            this.reservationEndDateLabel = new System.Windows.Forms.Label();
            this.reservationStartDateLabel = new System.Windows.Forms.Label();
            this.reservationStartDateDTP = new System.Windows.Forms.DateTimePicker();
            this.restaurantFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).BeginInit();
            this.employeeFirstNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // restaurantFormPanel
            // 
            this.restaurantFormPanel.Controls.Add(this.restaurantLabel);
            this.restaurantFormPanel.Controls.Add(this.kingWilliamHotelPictureBox);
            this.restaurantFormPanel.Location = new System.Drawing.Point(13, 13);
            this.restaurantFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.restaurantFormPanel.Name = "restaurantFormPanel";
            this.restaurantFormPanel.Size = new System.Drawing.Size(1296, 155);
            this.restaurantFormPanel.TabIndex = 1;
            // 
            // restaurantLabel
            // 
            this.restaurantLabel.AutoSize = true;
            this.restaurantLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.restaurantLabel.Location = new System.Drawing.Point(572, 53);
            this.restaurantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restaurantLabel.Name = "restaurantLabel";
            this.restaurantLabel.Size = new System.Drawing.Size(306, 38);
            this.restaurantLabel.TabIndex = 3;
            this.restaurantLabel.Text = "Restaurant Services";
            // 
            // kingWilliamHotelPictureBox
            // 
            this.kingWilliamHotelPictureBox.Image = global::ApplicationDesign.Properties.Resources.KingWilliamHotelLogo;
            this.kingWilliamHotelPictureBox.Location = new System.Drawing.Point(4, 6);
            this.kingWilliamHotelPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.kingWilliamHotelPictureBox.Name = "kingWilliamHotelPictureBox";
            this.kingWilliamHotelPictureBox.Size = new System.Drawing.Size(266, 145);
            this.kingWilliamHotelPictureBox.TabIndex = 1;
            this.kingWilliamHotelPictureBox.TabStop = false;
            // 
            // reservationIDPanel
            // 
            this.reservationIDPanel.Controls.Add(this.employeeFirstNamePanel);
            this.reservationIDPanel.Controls.Add(this.findReservationButton);
            this.reservationIDPanel.Controls.Add(this.invalidReservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDLinePanel);
            this.reservationIDPanel.Controls.Add(this.reservationIDPictureBox);
            this.reservationIDPanel.Controls.Add(this.reservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDTextBox);
            this.reservationIDPanel.Location = new System.Drawing.Point(17, 176);
            this.reservationIDPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(1292, 363);
            this.reservationIDPanel.TabIndex = 4;
            // 
            // findReservationButton
            // 
            this.findReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.FlatAppearance.BorderSize = 6;
            this.findReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.Location = new System.Drawing.Point(1070, 34);
            this.findReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.findReservationButton.Name = "findReservationButton";
            this.findReservationButton.Size = new System.Drawing.Size(180, 52);
            this.findReservationButton.TabIndex = 9;
            this.findReservationButton.Text = "Find Reservation";
            this.findReservation2ToolTip.SetToolTip(this.findReservationButton, "Select Find Reservation to find the guest\'s reservation.");
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
            this.invalidReservationIDLabel.TabIndex = 7;
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
            this.reservationIDLinePanel.TabIndex = 6;
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
            this.reservationIDLabel.Location = new System.Drawing.Point(78, 28);
            this.reservationIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationIDLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.reservationIDLabel.Name = "reservationIDLabel";
            this.reservationIDLabel.Size = new System.Drawing.Size(209, 32);
            this.reservationIDLabel.TabIndex = 4;
            this.reservationIDLabel.Text = "Reservation ID:";
            this.reservationID2ToolTip.SetToolTip(this.reservationIDLabel, "Enter guest\'s reservation ID.");
            // 
            // reservationIDTextBox
            // 
            this.reservationIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.reservationIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.reservationIDTextBox.Location = new System.Drawing.Point(337, 33);
            this.reservationIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDTextBox.MinimumSize = new System.Drawing.Size(71, 20);
            this.reservationIDTextBox.Name = "reservationIDTextBox";
            this.reservationIDTextBox.Size = new System.Drawing.Size(267, 23);
            this.reservationIDTextBox.TabIndex = 5;
            this.reservationIDTextBox.Text = "Enter Reservation ID";
            // 
            // restaurantItemCodeLabel
            // 
            this.restaurantItemCodeLabel.AutoSize = true;
            this.restaurantItemCodeLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantItemCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.restaurantItemCodeLabel.Location = new System.Drawing.Point(96, 567);
            this.restaurantItemCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restaurantItemCodeLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.restaurantItemCodeLabel.Name = "restaurantItemCodeLabel";
            this.restaurantItemCodeLabel.Size = new System.Drawing.Size(227, 25);
            this.restaurantItemCodeLabel.TabIndex = 11;
            this.restaurantItemCodeLabel.Text = "Restaurant Item Code:";
            this.restaurantCodeToolTip.SetToolTip(this.restaurantItemCodeLabel, "Find the Reservation Item Code in the drop down menu.");
            // 
            // restauarantItemCodeDropDownBox
            // 
            this.restauarantItemCodeDropDownBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.restauarantItemCodeDropDownBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restauarantItemCodeDropDownBox.ForeColor = System.Drawing.Color.White;
            this.restauarantItemCodeDropDownBox.FormattingEnabled = true;
            this.restauarantItemCodeDropDownBox.Items.AddRange(new object[] {
            "Breakfast",
            "Late-Night Snack ",
            "Dinner Special ",
            "Lunch ",
            "Room Service - Breakfast",
            "Room Service - Lunch",
            "Room Service - Dinner",
            "Room Service - Snack ",
            "Room Service - Drinks",
            "Room Service - Alcoholic Drinks",
            "Room Service - Premium Drinks"});
            this.restauarantItemCodeDropDownBox.Location = new System.Drawing.Point(354, 571);
            this.restauarantItemCodeDropDownBox.Margin = new System.Windows.Forms.Padding(4);
            this.restauarantItemCodeDropDownBox.MaximumSize = new System.Drawing.Size(265, 0);
            this.restauarantItemCodeDropDownBox.MinimumSize = new System.Drawing.Size(265, 0);
            this.restauarantItemCodeDropDownBox.Name = "restauarantItemCodeDropDownBox";
            this.restauarantItemCodeDropDownBox.Size = new System.Drawing.Size(265, 24);
            this.restauarantItemCodeDropDownBox.TabIndex = 12;
            // 
            // restaurantItemDescriptionLabel
            // 
            this.restaurantItemDescriptionLabel.AutoSize = true;
            this.restaurantItemDescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantItemDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.restaurantItemDescriptionLabel.Location = new System.Drawing.Point(762, 571);
            this.restaurantItemDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restaurantItemDescriptionLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.restaurantItemDescriptionLabel.Name = "restaurantItemDescriptionLabel";
            this.restaurantItemDescriptionLabel.Size = new System.Drawing.Size(177, 25);
            this.restaurantItemDescriptionLabel.TabIndex = 13;
            this.restaurantItemDescriptionLabel.Text = "Item Description:";
            this.itemDescription2ToolTip.SetToolTip(this.restaurantItemDescriptionLabel, "Item Description will be populated in this field.");
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.itemDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescriptionTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(1020, 573);
            this.itemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemDescriptionTextBox.MinimumSize = new System.Drawing.Size(53, 20);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.ReadOnly = true;
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(267, 23);
            this.itemDescriptionTextBox.TabIndex = 14;
            // 
            // itemDescriptionLinePanel
            // 
            this.itemDescriptionLinePanel.BackColor = System.Drawing.Color.White;
            this.itemDescriptionLinePanel.ForeColor = System.Drawing.Color.White;
            this.itemDescriptionLinePanel.Location = new System.Drawing.Point(1020, 604);
            this.itemDescriptionLinePanel.Margin = new System.Windows.Forms.Padding(4);
            this.itemDescriptionLinePanel.MinimumSize = new System.Drawing.Size(267, 2);
            this.itemDescriptionLinePanel.Name = "itemDescriptionLinePanel";
            this.itemDescriptionLinePanel.Size = new System.Drawing.Size(267, 2);
            this.itemDescriptionLinePanel.TabIndex = 15;
            // 
            // itemInvoiceButton
            // 
            this.itemInvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.itemInvoiceButton.FlatAppearance.BorderSize = 6;
            this.itemInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemInvoiceButton.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.itemInvoiceButton.Location = new System.Drawing.Point(1120, 619);
            this.itemInvoiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.itemInvoiceButton.Name = "itemInvoiceButton";
            this.itemInvoiceButton.Size = new System.Drawing.Size(167, 43);
            this.itemInvoiceButton.TabIndex = 16;
            this.itemInvoiceButton.Text = "Add Restaurant Item to Invoice";
            this.addItem1ToolTip.SetToolTip(this.itemInvoiceButton, "Select Add Restaurant Item to Invoice to add the item to the guest\'s invoice.");
            this.itemInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // employeeFirstNamePanel
            // 
            this.employeeFirstNamePanel.Controls.Add(this.reservationEndDateDTP);
            this.employeeFirstNamePanel.Controls.Add(this.reservationEndDateLabel);
            this.employeeFirstNamePanel.Controls.Add(this.reservationStartDateLabel);
            this.employeeFirstNamePanel.Controls.Add(this.reservationStartDateDTP);
            this.employeeFirstNamePanel.Controls.Add(this.guestRoomNumberListBox);
            this.employeeFirstNamePanel.Controls.Add(this.guestRoomNumberLabel);
            this.employeeFirstNamePanel.Controls.Add(this.label1);
            this.employeeFirstNamePanel.Controls.Add(this.panel1);
            this.employeeFirstNamePanel.Controls.Add(this.label2);
            this.employeeFirstNamePanel.Controls.Add(this.textBox1);
            this.employeeFirstNamePanel.Controls.Add(this.invalidGuestLastNameLabel);
            this.employeeFirstNamePanel.Controls.Add(this.guestLastNameUnderlinePanel);
            this.employeeFirstNamePanel.Controls.Add(this.guestLastNameLabel);
            this.employeeFirstNamePanel.Controls.Add(this.guestLastNameTextBox);
            this.employeeFirstNamePanel.Controls.Add(this.invalidGuestFirstNameLabel);
            this.employeeFirstNamePanel.Controls.Add(this.guestFirstNameUnderlinePanel);
            this.employeeFirstNamePanel.Controls.Add(this.guestFirstNameLabel);
            this.employeeFirstNamePanel.Controls.Add(this.guestFirstNameTextBox);
            this.employeeFirstNamePanel.Location = new System.Drawing.Point(25, 90);
            this.employeeFirstNamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.employeeFirstNamePanel.Name = "employeeFirstNamePanel";
            this.employeeFirstNamePanel.Size = new System.Drawing.Size(1259, 259);
            this.employeeFirstNamePanel.TabIndex = 10;
            // 
            // invalidGuestFirstNameLabel
            // 
            this.invalidGuestFirstNameLabel.AutoSize = true;
            this.invalidGuestFirstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidGuestFirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidGuestFirstNameLabel.Location = new System.Drawing.Point(310, 65);
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
            this.guestFirstNameUnderlinePanel.Location = new System.Drawing.Point(310, 59);
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
            this.guestFirstNameLabel.Location = new System.Drawing.Point(54, 28);
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
            this.guestFirstNameTextBox.Location = new System.Drawing.Point(311, 28);
            this.guestFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guestFirstNameTextBox.MinimumSize = new System.Drawing.Size(71, 20);
            this.guestFirstNameTextBox.Name = "guestFirstNameTextBox";
            this.guestFirstNameTextBox.Size = new System.Drawing.Size(364, 23);
            this.guestFirstNameTextBox.TabIndex = 7;
            this.guestFirstNameTextBox.Text = "Guest First Name";
            // 
            // invalidGuestLastNameLabel
            // 
            this.invalidGuestLastNameLabel.AutoSize = true;
            this.invalidGuestLastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidGuestLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidGuestLastNameLabel.Location = new System.Drawing.Point(310, 146);
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
            this.guestLastNameUnderlinePanel.Location = new System.Drawing.Point(310, 140);
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
            this.guestLastNameLabel.Location = new System.Drawing.Point(54, 109);
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
            this.guestLastNameTextBox.Location = new System.Drawing.Point(311, 109);
            this.guestLastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guestLastNameTextBox.MinimumSize = new System.Drawing.Size(71, 20);
            this.guestLastNameTextBox.Name = "guestLastNameTextBox";
            this.guestLastNameTextBox.Size = new System.Drawing.Size(364, 23);
            this.guestLastNameTextBox.TabIndex = 16;
            this.guestLastNameTextBox.Text = "Guest Last Name";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(54, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(71, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Guest Email:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(312, 196);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MinimumSize = new System.Drawing.Size(71, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 23);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Guest Email";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guestRoomNumberLabel
            // 
            this.guestRoomNumberLabel.AutoSize = true;
            this.guestRoomNumberLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestRoomNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestRoomNumberLabel.Location = new System.Drawing.Point(720, 28);
            this.guestRoomNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestRoomNumberLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.guestRoomNumberLabel.Name = "guestRoomNumberLabel";
            this.guestRoomNumberLabel.Size = new System.Drawing.Size(218, 25);
            this.guestRoomNumberLabel.TabIndex = 23;
            this.guestRoomNumberLabel.Text = "Guest Room Number:";
            // 
            // guestRoomNumberListBox
            // 
            this.guestRoomNumberListBox.FormattingEnabled = true;
            this.guestRoomNumberListBox.ItemHeight = 16;
            this.guestRoomNumberListBox.Location = new System.Drawing.Point(975, 33);
            this.guestRoomNumberListBox.Name = "guestRoomNumberListBox";
            this.guestRoomNumberListBox.Size = new System.Drawing.Size(250, 20);
            this.guestRoomNumberListBox.TabIndex = 24;
            // 
            // reservationEndDateDTP
            // 
            this.reservationEndDateDTP.Location = new System.Drawing.Point(978, 201);
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
            this.reservationEndDateLabel.Location = new System.Drawing.Point(720, 198);
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
            this.reservationStartDateLabel.Location = new System.Drawing.Point(720, 110);
            this.reservationStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationStartDateLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.reservationStartDateLabel.Name = "reservationStartDateLabel";
            this.reservationStartDateLabel.Size = new System.Drawing.Size(233, 25);
            this.reservationStartDateLabel.TabIndex = 25;
            this.reservationStartDateLabel.Text = "Reservation Start Date:";
            // 
            // reservationStartDateDTP
            // 
            this.reservationStartDateDTP.Location = new System.Drawing.Point(978, 112);
            this.reservationStartDateDTP.Margin = new System.Windows.Forms.Padding(4);
            this.reservationStartDateDTP.Name = "reservationStartDateDTP";
            this.reservationStartDateDTP.Size = new System.Drawing.Size(247, 22);
            this.reservationStartDateDTP.TabIndex = 26;
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1331, 693);
            this.Controls.Add(this.itemInvoiceButton);
            this.Controls.Add(this.itemDescriptionLinePanel);
            this.Controls.Add(this.itemDescriptionTextBox);
            this.Controls.Add(this.restaurantItemDescriptionLabel);
            this.Controls.Add(this.restauarantItemCodeDropDownBox);
            this.Controls.Add(this.restaurantItemCodeLabel);
            this.Controls.Add(this.reservationIDPanel);
            this.Controls.Add(this.restaurantFormPanel);
            this.Name = "RestaurantForm";
            this.Text = "Restaurant";
            this.restaurantFormPanel.ResumeLayout(false);
            this.restaurantFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).EndInit();
            this.reservationIDPanel.ResumeLayout(false);
            this.reservationIDPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).EndInit();
            this.employeeFirstNamePanel.ResumeLayout(false);
            this.employeeFirstNamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel restaurantFormPanel;
        private System.Windows.Forms.Label restaurantLabel;
        private System.Windows.Forms.PictureBox kingWilliamHotelPictureBox;
        private System.Windows.Forms.Panel reservationIDPanel;
        private System.Windows.Forms.Button findReservationButton;
        private System.Windows.Forms.Label invalidReservationIDLabel;
        private System.Windows.Forms.Panel reservationIDLinePanel;
        private System.Windows.Forms.PictureBox reservationIDPictureBox;
        private System.Windows.Forms.Label reservationIDLabel;
        private System.Windows.Forms.TextBox reservationIDTextBox;
        private System.Windows.Forms.Label restaurantItemCodeLabel;
        private System.Windows.Forms.ComboBox restauarantItemCodeDropDownBox;
        private System.Windows.Forms.Label restaurantItemDescriptionLabel;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.Panel itemDescriptionLinePanel;
        private System.Windows.Forms.Button itemInvoiceButton;
        private System.Windows.Forms.ToolTip findReservation2ToolTip;
        private System.Windows.Forms.ToolTip reservationID2ToolTip;
        private System.Windows.Forms.ToolTip restaurantCodeToolTip;
        private System.Windows.Forms.ToolTip itemDescription2ToolTip;
        private System.Windows.Forms.ToolTip addItem1ToolTip;
        private System.Windows.Forms.Panel employeeFirstNamePanel;
        private System.Windows.Forms.Label invalidGuestFirstNameLabel;
        private System.Windows.Forms.Panel guestFirstNameUnderlinePanel;
        private System.Windows.Forms.Label guestFirstNameLabel;
        private System.Windows.Forms.TextBox guestFirstNameTextBox;
        private System.Windows.Forms.Label invalidGuestLastNameLabel;
        private System.Windows.Forms.Panel guestLastNameUnderlinePanel;
        private System.Windows.Forms.Label guestLastNameLabel;
        private System.Windows.Forms.TextBox guestLastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox guestRoomNumberListBox;
        private System.Windows.Forms.Label guestRoomNumberLabel;
        private System.Windows.Forms.DateTimePicker reservationEndDateDTP;
        private System.Windows.Forms.Label reservationEndDateLabel;
        private System.Windows.Forms.Label reservationStartDateLabel;
        private System.Windows.Forms.DateTimePicker reservationStartDateDTP;
    }
}