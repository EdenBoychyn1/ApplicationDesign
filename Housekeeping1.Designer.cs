
namespace ApplicationDesign
{
    partial class HousekeepingForm
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
            this.housekeepingLogoPanel = new System.Windows.Forms.Panel();
            this.housekeepingLabel = new System.Windows.Forms.Label();
            this.kingWilliamHotelPictureBox = new System.Windows.Forms.PictureBox();
            this.housekeepingRoomPanel = new System.Windows.Forms.Panel();
            this.invalidRoomTypeLabel = new System.Windows.Forms.Label();
            this.slectedItemsLabel = new System.Windows.Forms.Label();
            this.selectedRoomNumbersListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.roomNumbersLabel = new System.Windows.Forms.Label();
            this.roomNumbersListBox = new System.Windows.Forms.ListBox();
            this.roomTypeButton = new System.Windows.Forms.Button();
            this.roomStatusButton = new System.Windows.Forms.Button();
            this.housekeepingRoomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.housekeepingRoomsLabel = new System.Windows.Forms.Label();
            this.houskeepingRoomLabel = new System.Windows.Forms.Label();
            this.roomTypeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.roomToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.roomDirtyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.outOfOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.submitStatusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.invalidSelectedRoomsLabel = new System.Windows.Forms.Label();
            this.invalidAddedRoomsLabel = new System.Windows.Forms.Label();
            this.invalidAlreadySelectedLabel = new System.Windows.Forms.Label();
            this.housekeepingLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).BeginInit();
            this.housekeepingRoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // housekeepingLogoPanel
            // 
            this.housekeepingLogoPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.housekeepingLogoPanel.AutoSize = true;
            this.housekeepingLogoPanel.Controls.Add(this.housekeepingLabel);
            this.housekeepingLogoPanel.Controls.Add(this.kingWilliamHotelPictureBox);
            this.housekeepingLogoPanel.Location = new System.Drawing.Point(-38, 11);
            this.housekeepingLogoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.housekeepingLogoPanel.MaximumSize = new System.Drawing.Size(683, 130);
            this.housekeepingLogoPanel.MinimumSize = new System.Drawing.Size(683, 130);
            this.housekeepingLogoPanel.Name = "housekeepingLogoPanel";
            this.housekeepingLogoPanel.Size = new System.Drawing.Size(683, 130);
            this.housekeepingLogoPanel.TabIndex = 0;
            // 
            // housekeepingLabel
            // 
            this.housekeepingLabel.AutoSize = true;
            this.housekeepingLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housekeepingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.housekeepingLabel.Location = new System.Drawing.Point(376, 53);
            this.housekeepingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.housekeepingLabel.Name = "housekeepingLabel";
            this.housekeepingLabel.Size = new System.Drawing.Size(220, 38);
            this.housekeepingLabel.TabIndex = 1;
            this.housekeepingLabel.Text = "Housekeeping";
            // 
            // kingWilliamHotelPictureBox
            // 
            this.kingWilliamHotelPictureBox.Image = global::ApplicationDesign.Properties.Resources.KingWilliamHotelLogo;
            this.kingWilliamHotelPictureBox.Location = new System.Drawing.Point(69, 0);
            this.kingWilliamHotelPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.kingWilliamHotelPictureBox.Name = "kingWilliamHotelPictureBox";
            this.kingWilliamHotelPictureBox.Size = new System.Drawing.Size(268, 145);
            this.kingWilliamHotelPictureBox.TabIndex = 0;
            this.kingWilliamHotelPictureBox.TabStop = false;
            // 
            // housekeepingRoomPanel
            // 
            this.housekeepingRoomPanel.Controls.Add(this.invalidAlreadySelectedLabel);
            this.housekeepingRoomPanel.Controls.Add(this.invalidAddedRoomsLabel);
            this.housekeepingRoomPanel.Controls.Add(this.invalidSelectedRoomsLabel);
            this.housekeepingRoomPanel.Controls.Add(this.invalidRoomTypeLabel);
            this.housekeepingRoomPanel.Controls.Add(this.slectedItemsLabel);
            this.housekeepingRoomPanel.Controls.Add(this.selectedRoomNumbersListBox);
            this.housekeepingRoomPanel.Controls.Add(this.removeButton);
            this.housekeepingRoomPanel.Controls.Add(this.buttonAdd);
            this.housekeepingRoomPanel.Controls.Add(this.roomNumbersLabel);
            this.housekeepingRoomPanel.Controls.Add(this.roomNumbersListBox);
            this.housekeepingRoomPanel.Controls.Add(this.roomTypeButton);
            this.housekeepingRoomPanel.Controls.Add(this.roomStatusButton);
            this.housekeepingRoomPanel.Controls.Add(this.housekeepingRoomTypeComboBox);
            this.housekeepingRoomPanel.Controls.Add(this.housekeepingRoomsLabel);
            this.housekeepingRoomPanel.Controls.Add(this.houskeepingRoomLabel);
            this.housekeepingRoomPanel.Location = new System.Drawing.Point(31, 157);
            this.housekeepingRoomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.housekeepingRoomPanel.Name = "housekeepingRoomPanel";
            this.housekeepingRoomPanel.Size = new System.Drawing.Size(683, 483);
            this.housekeepingRoomPanel.TabIndex = 2;
            // 
            // invalidRoomTypeLabel
            // 
            this.invalidRoomTypeLabel.AutoSize = true;
            this.invalidRoomTypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidRoomTypeLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidRoomTypeLabel.Location = new System.Drawing.Point(173, 99);
            this.invalidRoomTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidRoomTypeLabel.MinimumSize = new System.Drawing.Size(267, 16);
            this.invalidRoomTypeLabel.Name = "invalidRoomTypeLabel";
            this.invalidRoomTypeLabel.Size = new System.Drawing.Size(267, 23);
            this.invalidRoomTypeLabel.TabIndex = 28;
            this.invalidRoomTypeLabel.Text = "Room Type not selected.";
            this.invalidRoomTypeLabel.Visible = false;
            // 
            // slectedItemsLabel
            // 
            this.slectedItemsLabel.AutoSize = true;
            this.slectedItemsLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slectedItemsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.slectedItemsLabel.Location = new System.Drawing.Point(359, 142);
            this.slectedItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slectedItemsLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.slectedItemsLabel.Name = "slectedItemsLabel";
            this.slectedItemsLabel.Size = new System.Drawing.Size(166, 25);
            this.slectedItemsLabel.TabIndex = 27;
            this.slectedItemsLabel.Text = "Selected Rooms:";
            // 
            // selectedRoomNumbersListBox
            // 
            this.selectedRoomNumbersListBox.FormattingEnabled = true;
            this.selectedRoomNumbersListBox.ItemHeight = 16;
            this.selectedRoomNumbersListBox.Location = new System.Drawing.Point(364, 170);
            this.selectedRoomNumbersListBox.Name = "selectedRoomNumbersListBox";
            this.selectedRoomNumbersListBox.Size = new System.Drawing.Size(211, 180);
            this.selectedRoomNumbersListBox.TabIndex = 26;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(266, 268);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(73, 45);
            this.removeButton.TabIndex = 25;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(266, 186);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 45);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // roomNumbersLabel
            // 
            this.roomNumbersLabel.AutoSize = true;
            this.roomNumbersLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumbersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomNumbersLabel.Location = new System.Drawing.Point(24, 142);
            this.roomNumbersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomNumbersLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.roomNumbersLabel.Name = "roomNumbersLabel";
            this.roomNumbersLabel.Size = new System.Drawing.Size(159, 25);
            this.roomNumbersLabel.TabIndex = 22;
            this.roomNumbersLabel.Text = "Room Numbers";
            // 
            // roomNumbersListBox
            // 
            this.roomNumbersListBox.FormattingEnabled = true;
            this.roomNumbersListBox.ItemHeight = 16;
            this.roomNumbersListBox.Location = new System.Drawing.Point(29, 170);
            this.roomNumbersListBox.Name = "roomNumbersListBox";
            this.roomNumbersListBox.Size = new System.Drawing.Size(211, 180);
            this.roomNumbersListBox.TabIndex = 23;
            this.roomNumbersListBox.SelectedIndexChanged += new System.EventHandler(this.roomNumbersListBox_SelectedIndexChanged);
            // 
            // roomTypeButton
            // 
            this.roomTypeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomTypeButton.FlatAppearance.BorderSize = 6;
            this.roomTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomTypeButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomTypeButton.Location = new System.Drawing.Point(475, 59);
            this.roomTypeButton.Margin = new System.Windows.Forms.Padding(4);
            this.roomTypeButton.Name = "roomTypeButton";
            this.roomTypeButton.Size = new System.Drawing.Size(180, 52);
            this.roomTypeButton.TabIndex = 20;
            this.roomTypeButton.Text = "Select Room Type";
            this.submitStatusToolTip.SetToolTip(this.roomTypeButton, "Select Submit Room Status to submit the status of the room to the database.");
            this.roomTypeButton.UseVisualStyleBackColor = true;
            this.roomTypeButton.Click += new System.EventHandler(this.roomTypeButton_Click);
            // 
            // roomStatusButton
            // 
            this.roomStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomStatusButton.FlatAppearance.BorderSize = 6;
            this.roomStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomStatusButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomStatusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomStatusButton.Location = new System.Drawing.Point(489, 427);
            this.roomStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.roomStatusButton.Name = "roomStatusButton";
            this.roomStatusButton.Size = new System.Drawing.Size(180, 52);
            this.roomStatusButton.TabIndex = 10;
            this.roomStatusButton.Text = "Submit Room Status";
            this.submitStatusToolTip.SetToolTip(this.roomStatusButton, "Select Submit Room Status to submit the status of the room to the database.");
            this.roomStatusButton.UseVisualStyleBackColor = true;
            this.roomStatusButton.Click += new System.EventHandler(this.roomStatusButton_Click);
            // 
            // housekeepingRoomTypeComboBox
            // 
            this.housekeepingRoomTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.housekeepingRoomTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.housekeepingRoomTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.housekeepingRoomTypeComboBox.FormattingEnabled = true;
            this.housekeepingRoomTypeComboBox.ItemHeight = 16;
            this.housekeepingRoomTypeComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suites"});
            this.housekeepingRoomTypeComboBox.Location = new System.Drawing.Point(175, 71);
            this.housekeepingRoomTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.housekeepingRoomTypeComboBox.MaximumSize = new System.Drawing.Size(265, 0);
            this.housekeepingRoomTypeComboBox.MinimumSize = new System.Drawing.Size(265, 0);
            this.housekeepingRoomTypeComboBox.Name = "housekeepingRoomTypeComboBox";
            this.housekeepingRoomTypeComboBox.Size = new System.Drawing.Size(265, 24);
            this.housekeepingRoomTypeComboBox.TabIndex = 7;
            // 
            // housekeepingRoomsLabel
            // 
            this.housekeepingRoomsLabel.AutoSize = true;
            this.housekeepingRoomsLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housekeepingRoomsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.housekeepingRoomsLabel.Location = new System.Drawing.Point(24, 71);
            this.housekeepingRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.housekeepingRoomsLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.housekeepingRoomsLabel.Name = "housekeepingRoomsLabel";
            this.housekeepingRoomsLabel.Size = new System.Drawing.Size(125, 25);
            this.housekeepingRoomsLabel.TabIndex = 6;
            this.housekeepingRoomsLabel.Text = "Room Type:";
            this.roomToolTip.SetToolTip(this.housekeepingRoomsLabel, "Find room in drop down menu.");
            // 
            // houskeepingRoomLabel
            // 
            this.houskeepingRoomLabel.AutoSize = true;
            this.houskeepingRoomLabel.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houskeepingRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.houskeepingRoomLabel.Location = new System.Drawing.Point(23, 19);
            this.houskeepingRoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.houskeepingRoomLabel.Name = "houskeepingRoomLabel";
            this.houskeepingRoomLabel.Size = new System.Drawing.Size(153, 32);
            this.houskeepingRoomLabel.TabIndex = 3;
            this.houskeepingRoomLabel.Text = "Find Room";
            // 
            // invalidSelectedRoomsLabel
            // 
            this.invalidSelectedRoomsLabel.AutoSize = true;
            this.invalidSelectedRoomsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidSelectedRoomsLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidSelectedRoomsLabel.Location = new System.Drawing.Point(360, 353);
            this.invalidSelectedRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidSelectedRoomsLabel.MinimumSize = new System.Drawing.Size(267, 16);
            this.invalidSelectedRoomsLabel.Name = "invalidSelectedRoomsLabel";
            this.invalidSelectedRoomsLabel.Size = new System.Drawing.Size(267, 46);
            this.invalidSelectedRoomsLabel.TabIndex = 29;
            this.invalidSelectedRoomsLabel.Text = "No rooms were selected \r\nto be removed.";
            this.invalidSelectedRoomsLabel.Visible = false;
            // 
            // invalidAddedRoomsLabel
            // 
            this.invalidAddedRoomsLabel.AutoSize = true;
            this.invalidAddedRoomsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAddedRoomsLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidAddedRoomsLabel.Location = new System.Drawing.Point(214, 427);
            this.invalidAddedRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidAddedRoomsLabel.MinimumSize = new System.Drawing.Size(267, 16);
            this.invalidAddedRoomsLabel.Name = "invalidAddedRoomsLabel";
            this.invalidAddedRoomsLabel.Size = new System.Drawing.Size(267, 46);
            this.invalidAddedRoomsLabel.TabIndex = 30;
            this.invalidAddedRoomsLabel.Text = "No rooms were selected \r\nto be added.";
            this.invalidAddedRoomsLabel.Visible = false;
            // 
            // invalidAlreadySelectedLabel
            // 
            this.invalidAlreadySelectedLabel.AutoSize = true;
            this.invalidAlreadySelectedLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAlreadySelectedLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidAlreadySelectedLabel.Location = new System.Drawing.Point(25, 353);
            this.invalidAlreadySelectedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidAlreadySelectedLabel.MinimumSize = new System.Drawing.Size(267, 16);
            this.invalidAlreadySelectedLabel.Name = "invalidAlreadySelectedLabel";
            this.invalidAlreadySelectedLabel.Size = new System.Drawing.Size(267, 46);
            this.invalidAlreadySelectedLabel.TabIndex = 31;
            this.invalidAlreadySelectedLabel.Text = "Selected room already \r\nexists in Selected Rooms Box.";
            this.invalidAlreadySelectedLabel.Visible = false;
            // 
            // HousekeepingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.housekeepingRoomPanel);
            this.Controls.Add(this.housekeepingLogoPanel);
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "HousekeepingForm";
            this.Text = "Housekeeping";
            this.housekeepingLogoPanel.ResumeLayout(false);
            this.housekeepingLogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingWilliamHotelPictureBox)).EndInit();
            this.housekeepingRoomPanel.ResumeLayout(false);
            this.housekeepingRoomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel housekeepingLogoPanel;
        private System.Windows.Forms.PictureBox kingWilliamHotelPictureBox;
        private System.Windows.Forms.Label housekeepingLabel;
        private System.Windows.Forms.Panel housekeepingRoomPanel;
        private System.Windows.Forms.ComboBox housekeepingRoomTypeComboBox;
        private System.Windows.Forms.Label housekeepingRoomsLabel;
        private System.Windows.Forms.Label houskeepingRoomLabel;
        private System.Windows.Forms.Button roomStatusButton;
        private System.Windows.Forms.ToolTip submitStatusToolTip;
        private System.Windows.Forms.ToolTip outOfOrderToolTip;
        private System.Windows.Forms.ToolTip roomDirtyToolTip;
        private System.Windows.Forms.ToolTip roomToolTip;
        private System.Windows.Forms.ToolTip roomTypeToolTip;
        private System.Windows.Forms.Button roomTypeButton;
        private System.Windows.Forms.Label slectedItemsLabel;
        private System.Windows.Forms.ListBox selectedRoomNumbersListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label roomNumbersLabel;
        private System.Windows.Forms.ListBox roomNumbersListBox;
        private System.Windows.Forms.Label invalidRoomTypeLabel;
        private System.Windows.Forms.Label invalidSelectedRoomsLabel;
        private System.Windows.Forms.Label invalidAddedRoomsLabel;
        private System.Windows.Forms.Label invalidAlreadySelectedLabel;
    }
}