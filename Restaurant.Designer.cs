
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
            this.restaurantFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retrieveReservationDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantFormPanel
            // 
            this.restaurantFormPanel.Controls.Add(this.restaurantLabel);
            this.restaurantFormPanel.Controls.Add(this.kingWilliamHotelPictureBox);
            this.restaurantFormPanel.Location = new System.Drawing.Point(13, 13);
            this.restaurantFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.restaurantFormPanel.Name = "restaurantFormPanel";
            this.restaurantFormPanel.Size = new System.Drawing.Size(1686, 155);
            this.restaurantFormPanel.TabIndex = 1;
            // 
            // restaurantLabel
            // 
            this.restaurantLabel.AutoSize = true;
            this.restaurantLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.restaurantLabel.Location = new System.Drawing.Point(636, 53);
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
            this.reservationIDPanel.Controls.Add(this.findReservationButton);
            this.reservationIDPanel.Controls.Add(this.invalidReservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDLinePanel);
            this.reservationIDPanel.Controls.Add(this.retrieveReservationDGV);
            this.reservationIDPanel.Controls.Add(this.reservationIDPictureBox);
            this.reservationIDPanel.Controls.Add(this.reservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDTextBox);
            this.reservationIDPanel.Location = new System.Drawing.Point(223, 176);
            this.reservationIDPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(1476, 324);
            this.reservationIDPanel.TabIndex = 4;
            // 
            // findReservationButton
            // 
            this.findReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.FlatAppearance.BorderSize = 6;
            this.findReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.Location = new System.Drawing.Point(1292, 257);
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
            this.retrieveReservationDGV.Location = new System.Drawing.Point(25, 110);
            this.retrieveReservationDGV.Margin = new System.Windows.Forms.Padding(4);
            this.retrieveReservationDGV.Name = "retrieveReservationDGV";
            this.retrieveReservationDGV.RowHeadersWidth = 51;
            this.retrieveReservationDGV.Size = new System.Drawing.Size(1447, 126);
            this.retrieveReservationDGV.TabIndex = 8;
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
            this.restaurantItemCodeLabel.Location = new System.Drawing.Point(283, 567);
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
            this.restauarantItemCodeDropDownBox.Location = new System.Drawing.Point(562, 567);
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
            this.restaurantItemDescriptionLabel.Location = new System.Drawing.Point(890, 567);
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
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(1086, 567);
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
            this.itemDescriptionLinePanel.Location = new System.Drawing.Point(1086, 589);
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
            this.itemInvoiceButton.Font = new System.Drawing.Font("Times New Roman", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.itemInvoiceButton.Location = new System.Drawing.Point(1515, 540);
            this.itemInvoiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.itemInvoiceButton.Name = "itemInvoiceButton";
            this.itemInvoiceButton.Size = new System.Drawing.Size(180, 58);
            this.itemInvoiceButton.TabIndex = 16;
            this.itemInvoiceButton.Text = "Add Restaurant Item to Invoice";
            this.addItem1ToolTip.SetToolTip(this.itemInvoiceButton, "Select Add Restaurant Item to Invoice to add the item to the guest\'s invoice.");
            this.itemInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1721, 675);
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
            ((System.ComponentModel.ISupportInitialize)(this.retrieveReservationDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).EndInit();
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
    }
}