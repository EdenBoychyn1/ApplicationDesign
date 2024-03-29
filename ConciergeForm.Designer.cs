﻿
namespace ApplicationDesign
{
    partial class ConciergeForm
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
            this.conciergeFormPanel = new System.Windows.Forms.Panel();
            this.conciergeLabel = new System.Windows.Forms.Label();
            this.kingWilliamHotelPictureBox = new System.Windows.Forms.PictureBox();
            this.designPanel = new System.Windows.Forms.Panel();
            this.itemInvoiceButton = new System.Windows.Forms.Button();
            this.itemCodeLabel = new System.Windows.Forms.Label();
            this.reservationIDPanel = new System.Windows.Forms.Panel();
            this.guestReservationLabel = new System.Windows.Forms.Label();
            this.reservationListBox = new System.Windows.Forms.ListBox();
            this.findReservationButton = new System.Windows.Forms.Button();
            this.invalidReservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDLinePanel = new System.Windows.Forms.Panel();
            this.reservationIDPictureBox = new System.Windows.Forms.PictureBox();
            this.reservationIDLabel = new System.Windows.Forms.Label();
            this.reservationIDTextBox = new System.Windows.Forms.TextBox();
            this.reservationIDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.itemCodeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.slectedItemsLabel = new System.Windows.Forms.Label();
            this.itemDescriptionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.findReservationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addItemToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.itemsAvailableListBox = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.selecteditemsListBox = new System.Windows.Forms.ListBox();
            this.invalidClientSelectionLabel = new System.Windows.Forms.Label();
            this.invalidSelecteditemsLabel = new System.Windows.Forms.Label();
            this.invalidAddedItemsLabel = new System.Windows.Forms.Label();
            this.conciergeFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.reservationIDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // conciergeFormPanel
            // 
            this.conciergeFormPanel.Controls.Add(this.conciergeLabel);
            this.conciergeFormPanel.Controls.Add(this.kingWilliamHotelPictureBox);
            this.conciergeFormPanel.Location = new System.Drawing.Point(16, 15);
            this.conciergeFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.conciergeFormPanel.Name = "conciergeFormPanel";
            this.conciergeFormPanel.Size = new System.Drawing.Size(1152, 132);
            this.conciergeFormPanel.TabIndex = 0;
            // 
            // conciergeLabel
            // 
            this.conciergeLabel.AutoSize = true;
            this.conciergeLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conciergeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.conciergeLabel.Location = new System.Drawing.Point(571, 60);
            this.conciergeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conciergeLabel.Name = "conciergeLabel";
            this.conciergeLabel.Size = new System.Drawing.Size(291, 38);
            this.conciergeLabel.TabIndex = 3;
            this.conciergeLabel.Text = "Concierge Services";
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
            this.designPanel.Location = new System.Drawing.Point(22, 156);
            this.designPanel.Margin = new System.Windows.Forms.Padding(4);
            this.designPanel.Name = "designPanel";
            this.designPanel.Size = new System.Drawing.Size(267, 460);
            this.designPanel.TabIndex = 1;
            // 
            // itemInvoiceButton
            // 
            this.itemInvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.itemInvoiceButton.FlatAppearance.BorderSize = 6;
            this.itemInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemInvoiceButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInvoiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.itemInvoiceButton.Location = new System.Drawing.Point(1017, 529);
            this.itemInvoiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.itemInvoiceButton.Name = "itemInvoiceButton";
            this.itemInvoiceButton.Size = new System.Drawing.Size(180, 52);
            this.itemInvoiceButton.TabIndex = 15;
            this.itemInvoiceButton.Text = "Add Item to Invoice";
            this.addItemToolTip.SetToolTip(this.itemInvoiceButton, "Add item to guest\'s invoice.");
            this.itemInvoiceButton.UseVisualStyleBackColor = true;
            this.itemInvoiceButton.Click += new System.EventHandler(this.itemInvoiceButton_Click);
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.itemCodeLabel.Location = new System.Drawing.Point(432, 380);
            this.itemCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemCodeLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(118, 25);
            this.itemCodeLabel.TabIndex = 10;
            this.itemCodeLabel.Text = "Item Code:";
            this.itemCodeToolTip.SetToolTip(this.itemCodeLabel, "Find the item code to apply to the guest\'s invoice.");
            // 
            // reservationIDPanel
            // 
            this.reservationIDPanel.Controls.Add(this.guestReservationLabel);
            this.reservationIDPanel.Controls.Add(this.reservationListBox);
            this.reservationIDPanel.Controls.Add(this.findReservationButton);
            this.reservationIDPanel.Controls.Add(this.invalidReservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDLinePanel);
            this.reservationIDPanel.Controls.Add(this.reservationIDPictureBox);
            this.reservationIDPanel.Controls.Add(this.reservationIDLabel);
            this.reservationIDPanel.Controls.Add(this.reservationIDTextBox);
            this.reservationIDPanel.Location = new System.Drawing.Point(315, 171);
            this.reservationIDPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDPanel.Name = "reservationIDPanel";
            this.reservationIDPanel.Size = new System.Drawing.Size(882, 205);
            this.reservationIDPanel.TabIndex = 3;
            // 
            // guestReservationLabel
            // 
            this.guestReservationLabel.AutoSize = true;
            this.guestReservationLabel.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestReservationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.guestReservationLabel.Location = new System.Drawing.Point(79, 103);
            this.guestReservationLabel.Name = "guestReservationLabel";
            this.guestReservationLabel.Size = new System.Drawing.Size(254, 32);
            this.guestReservationLabel.TabIndex = 11;
            this.guestReservationLabel.Text = "Guest Reservations:";
            // 
            // reservationListBox
            // 
            this.reservationListBox.FormattingEnabled = true;
            this.reservationListBox.ItemHeight = 16;
            this.reservationListBox.Location = new System.Drawing.Point(385, 103);
            this.reservationListBox.Name = "reservationListBox";
            this.reservationListBox.Size = new System.Drawing.Size(268, 52);
            this.reservationListBox.TabIndex = 10;
            // 
            // findReservationButton
            // 
            this.findReservationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.FlatAppearance.BorderSize = 6;
            this.findReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findReservationButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.findReservationButton.Location = new System.Drawing.Point(684, 34);
            this.findReservationButton.Margin = new System.Windows.Forms.Padding(4);
            this.findReservationButton.Name = "findReservationButton";
            this.findReservationButton.Size = new System.Drawing.Size(180, 52);
            this.findReservationButton.TabIndex = 9;
            this.findReservationButton.Text = "Find Reservation";
            this.findReservationToolTip.SetToolTip(this.findReservationButton, "Find the guest\'s reservation so that the item code(s) can be applied.");
            this.findReservationButton.UseVisualStyleBackColor = true;
            this.findReservationButton.Click += new System.EventHandler(this.findReservationButton_Click);
            // 
            // invalidReservationIDLabel
            // 
            this.invalidReservationIDLabel.AutoSize = true;
            this.invalidReservationIDLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidReservationIDLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidReservationIDLabel.Location = new System.Drawing.Point(386, 63);
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
            this.reservationIDLinePanel.Location = new System.Drawing.Point(385, 58);
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
            this.reservationIDLabel.Location = new System.Drawing.Point(79, 28);
            this.reservationIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservationIDLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.reservationIDLabel.Name = "reservationIDLabel";
            this.reservationIDLabel.Size = new System.Drawing.Size(209, 32);
            this.reservationIDLabel.TabIndex = 4;
            this.reservationIDLabel.Text = "Reservation ID:";
            this.reservationIDToolTip.SetToolTip(this.reservationIDLabel, "Enter guest\'s reservation ID.");
            // 
            // reservationIDTextBox
            // 
            this.reservationIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.reservationIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIDTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.reservationIDTextBox.Location = new System.Drawing.Point(385, 33);
            this.reservationIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reservationIDTextBox.MinimumSize = new System.Drawing.Size(71, 20);
            this.reservationIDTextBox.Name = "reservationIDTextBox";
            this.reservationIDTextBox.Size = new System.Drawing.Size(267, 23);
            this.reservationIDTextBox.TabIndex = 5;
            this.reservationIDTextBox.Text = "Enter Reservation ID";
            this.reservationIDTextBox.Click += new System.EventHandler(this.reservationIDTextBox_Click);
            // 
            // slectedItemsLabel
            // 
            this.slectedItemsLabel.AutoSize = true;
            this.slectedItemsLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slectedItemsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.slectedItemsLabel.Location = new System.Drawing.Point(763, 380);
            this.slectedItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slectedItemsLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.slectedItemsLabel.Name = "slectedItemsLabel";
            this.slectedItemsLabel.Size = new System.Drawing.Size(155, 25);
            this.slectedItemsLabel.TabIndex = 16;
            this.slectedItemsLabel.Text = "Selected Items:";
            this.itemCodeToolTip.SetToolTip(this.slectedItemsLabel, "Find the item code to apply to the guest\'s invoice.");
            // 
            // itemsAvailableListBox
            // 
            this.itemsAvailableListBox.FormattingEnabled = true;
            this.itemsAvailableListBox.ItemHeight = 16;
            this.itemsAvailableListBox.Items.AddRange(new object[] {
            "Long-Distance Phone Charge",
            "Movie Rental",
            "Dry-Cleaning,"});
            this.itemsAvailableListBox.Location = new System.Drawing.Point(437, 410);
            this.itemsAvailableListBox.Name = "itemsAvailableListBox";
            this.itemsAvailableListBox.Size = new System.Drawing.Size(211, 180);
            this.itemsAvailableListBox.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(671, 440);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 45);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(671, 520);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(73, 45);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // selecteditemsListBox
            // 
            this.selecteditemsListBox.FormattingEnabled = true;
            this.selecteditemsListBox.ItemHeight = 16;
            this.selecteditemsListBox.Location = new System.Drawing.Point(768, 410);
            this.selecteditemsListBox.Name = "selecteditemsListBox";
            this.selecteditemsListBox.Size = new System.Drawing.Size(211, 180);
            this.selecteditemsListBox.TabIndex = 15;
            this.selecteditemsListBox.SelectedValueChanged += new System.EventHandler(this.selecteditemsListBox_SelectedValueChanged);
            // 
            // invalidClientSelectionLabel
            // 
            this.invalidClientSelectionLabel.AutoSize = true;
            this.invalidClientSelectionLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidClientSelectionLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidClientSelectionLabel.Location = new System.Drawing.Point(701, 332);
            this.invalidClientSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidClientSelectionLabel.MinimumSize = new System.Drawing.Size(267, 16);
            this.invalidClientSelectionLabel.Name = "invalidClientSelectionLabel";
            this.invalidClientSelectionLabel.Size = new System.Drawing.Size(312, 38);
            this.invalidClientSelectionLabel.TabIndex = 12;
            this.invalidClientSelectionLabel.Text = "You must confirm the guest name\r\nby selecting the Find Reservation button.";
            this.invalidClientSelectionLabel.Visible = false;
            // 
            // invalidSelecteditemsLabel
            // 
            this.invalidSelecteditemsLabel.AutoSize = true;
            this.invalidSelecteditemsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidSelecteditemsLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidSelecteditemsLabel.Location = new System.Drawing.Point(764, 594);
            this.invalidSelecteditemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidSelecteditemsLabel.MinimumSize = new System.Drawing.Size(267, 16);
            this.invalidSelecteditemsLabel.Name = "invalidSelecteditemsLabel";
            this.invalidSelecteditemsLabel.Size = new System.Drawing.Size(267, 46);
            this.invalidSelecteditemsLabel.TabIndex = 17;
            this.invalidSelecteditemsLabel.Text = "No items were selected \r\nto be removed.";
            this.invalidSelecteditemsLabel.Visible = false;
            // 
            // invalidAddedItemsLabel
            // 
            this.invalidAddedItemsLabel.AutoSize = true;
            this.invalidAddedItemsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAddedItemsLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidAddedItemsLabel.Location = new System.Drawing.Point(995, 594);
            this.invalidAddedItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidAddedItemsLabel.MinimumSize = new System.Drawing.Size(267, 16);
            this.invalidAddedItemsLabel.Name = "invalidAddedItemsLabel";
            this.invalidAddedItemsLabel.Size = new System.Drawing.Size(267, 46);
            this.invalidAddedItemsLabel.TabIndex = 18;
            this.invalidAddedItemsLabel.Text = "No items were selected \r\nto be added.";
            this.invalidAddedItemsLabel.Visible = false;
            // 
            // ConciergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1210, 657);
            this.Controls.Add(this.invalidAddedItemsLabel);
            this.Controls.Add(this.invalidClientSelectionLabel);
            this.Controls.Add(this.invalidSelecteditemsLabel);
            this.Controls.Add(this.slectedItemsLabel);
            this.Controls.Add(this.selecteditemsListBox);
            this.Controls.Add(this.itemInvoiceButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.itemCodeLabel);
            this.Controls.Add(this.itemsAvailableListBox);
            this.Controls.Add(this.reservationIDPanel);
            this.Controls.Add(this.designPanel);
            this.Controls.Add(this.conciergeFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConciergeForm";
            this.Text = "ConciergeForm";
            this.conciergeFormPanel.ResumeLayout(false);
            this.conciergeFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).EndInit();
            this.reservationIDPanel.ResumeLayout(false);
            this.reservationIDPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationIDPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel conciergeFormPanel;
        private System.Windows.Forms.PictureBox kingWilliamHotelPictureBox;
        private System.Windows.Forms.Panel designPanel;
        private System.Windows.Forms.Label conciergeLabel;
        private System.Windows.Forms.Button itemInvoiceButton;
        private System.Windows.Forms.Label itemCodeLabel;
        private System.Windows.Forms.Panel reservationIDPanel;
        private System.Windows.Forms.Button findReservationButton;
        private System.Windows.Forms.Label invalidReservationIDLabel;
        private System.Windows.Forms.Panel reservationIDLinePanel;
        private System.Windows.Forms.PictureBox reservationIDPictureBox;
        private System.Windows.Forms.Label reservationIDLabel;
        private System.Windows.Forms.TextBox reservationIDTextBox;
        private System.Windows.Forms.ToolTip reservationIDToolTip;
        private System.Windows.Forms.ToolTip addItemToolTip;
        private System.Windows.Forms.ToolTip itemCodeToolTip;
        private System.Windows.Forms.ToolTip itemDescriptionToolTip;
        private System.Windows.Forms.ToolTip findReservationToolTip;
        private System.Windows.Forms.Label guestReservationLabel;
        private System.Windows.Forms.ListBox reservationListBox;
        private System.Windows.Forms.ListBox itemsAvailableListBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox selecteditemsListBox;
        private System.Windows.Forms.Label slectedItemsLabel;
        private System.Windows.Forms.Label invalidClientSelectionLabel;
        private System.Windows.Forms.Label invalidSelecteditemsLabel;
        private System.Windows.Forms.Label invalidAddedItemsLabel;
    }
}