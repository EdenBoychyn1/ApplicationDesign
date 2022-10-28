
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
            this.outOfOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.roomDirtyCheckBox = new System.Windows.Forms.CheckBox();
            this.housekeepingRoomsAvailableComboBox = new System.Windows.Forms.ComboBox();
            this.housekeepingRoomsLabel = new System.Windows.Forms.Label();
            this.housekeepingRoomTypeDropDownBox = new System.Windows.Forms.ComboBox();
            this.housekeepingRoomTypeLabel = new System.Windows.Forms.Label();
            this.houskeepingRoomLabel = new System.Windows.Forms.Label();
            this.roomStatusButton = new System.Windows.Forms.Button();
            this.roomTypeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.roomToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.roomDirtyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.outOfOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.submitStatusToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.housekeepingLogoPanel.Location = new System.Drawing.Point(12, 11);
            this.housekeepingLogoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.housekeepingLogoPanel.MaximumSize = new System.Drawing.Size(800, 130);
            this.housekeepingLogoPanel.MinimumSize = new System.Drawing.Size(800, 130);
            this.housekeepingLogoPanel.Name = "housekeepingLogoPanel";
            this.housekeepingLogoPanel.Size = new System.Drawing.Size(800, 130);
            this.housekeepingLogoPanel.TabIndex = 0;
            // 
            // housekeepingLabel
            // 
            this.housekeepingLabel.AutoSize = true;
            this.housekeepingLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housekeepingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.housekeepingLabel.Location = new System.Drawing.Point(430, 50);
            this.housekeepingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.housekeepingLabel.Name = "housekeepingLabel";
            this.housekeepingLabel.Size = new System.Drawing.Size(220, 38);
            this.housekeepingLabel.TabIndex = 1;
            this.housekeepingLabel.Text = "Housekeeping";
            // 
            // kingWilliamHotelPictureBox
            // 
            this.kingWilliamHotelPictureBox.Image = global::ApplicationDesign.Properties.Resources.KingWilliamHotelLogo;
            this.kingWilliamHotelPictureBox.Location = new System.Drawing.Point(19, 0);
            this.kingWilliamHotelPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.kingWilliamHotelPictureBox.Name = "kingWilliamHotelPictureBox";
            this.kingWilliamHotelPictureBox.Size = new System.Drawing.Size(268, 145);
            this.kingWilliamHotelPictureBox.TabIndex = 0;
            this.kingWilliamHotelPictureBox.TabStop = false;
            // 
            // housekeepingRoomPanel
            // 
            this.housekeepingRoomPanel.Controls.Add(this.roomStatusButton);
            this.housekeepingRoomPanel.Controls.Add(this.outOfOrderCheckBox);
            this.housekeepingRoomPanel.Controls.Add(this.roomDirtyCheckBox);
            this.housekeepingRoomPanel.Controls.Add(this.housekeepingRoomsAvailableComboBox);
            this.housekeepingRoomPanel.Controls.Add(this.housekeepingRoomsLabel);
            this.housekeepingRoomPanel.Controls.Add(this.housekeepingRoomTypeDropDownBox);
            this.housekeepingRoomPanel.Controls.Add(this.housekeepingRoomTypeLabel);
            this.housekeepingRoomPanel.Controls.Add(this.houskeepingRoomLabel);
            this.housekeepingRoomPanel.Location = new System.Drawing.Point(286, 157);
            this.housekeepingRoomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.housekeepingRoomPanel.Name = "housekeepingRoomPanel";
            this.housekeepingRoomPanel.Size = new System.Drawing.Size(526, 292);
            this.housekeepingRoomPanel.TabIndex = 2;
            // 
            // outOfOrderCheckBox
            // 
            this.outOfOrderCheckBox.AutoSize = true;
            this.outOfOrderCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outOfOrderCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.outOfOrderCheckBox.Location = new System.Drawing.Point(249, 192);
            this.outOfOrderCheckBox.Name = "outOfOrderCheckBox";
            this.outOfOrderCheckBox.Size = new System.Drawing.Size(235, 29);
            this.outOfOrderCheckBox.TabIndex = 9;
            this.outOfOrderCheckBox.Text = "Room Out Of Order?";
            this.outOfOrderToolTip.SetToolTip(this.outOfOrderCheckBox, "If the selected room is out of order, select Room Out Of Order.");
            this.outOfOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // roomDirtyCheckBox
            // 
            this.roomDirtyCheckBox.AutoSize = true;
            this.roomDirtyCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDirtyCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomDirtyCheckBox.Location = new System.Drawing.Point(29, 192);
            this.roomDirtyCheckBox.Name = "roomDirtyCheckBox";
            this.roomDirtyCheckBox.Size = new System.Drawing.Size(154, 29);
            this.roomDirtyCheckBox.TabIndex = 8;
            this.roomDirtyCheckBox.Text = "Room Dirty?";
            this.roomDirtyToolTip.SetToolTip(this.roomDirtyCheckBox, "If room is dirty, select this checkbox.");
            this.roomDirtyCheckBox.UseVisualStyleBackColor = true;
            // 
            // housekeepingRoomsAvailableComboBox
            // 
            this.housekeepingRoomsAvailableComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.housekeepingRoomsAvailableComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.housekeepingRoomsAvailableComboBox.ForeColor = System.Drawing.Color.White;
            this.housekeepingRoomsAvailableComboBox.FormattingEnabled = true;
            this.housekeepingRoomsAvailableComboBox.ItemHeight = 16;
            this.housekeepingRoomsAvailableComboBox.Location = new System.Drawing.Point(249, 110);
            this.housekeepingRoomsAvailableComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.housekeepingRoomsAvailableComboBox.MaximumSize = new System.Drawing.Size(265, 0);
            this.housekeepingRoomsAvailableComboBox.MinimumSize = new System.Drawing.Size(265, 0);
            this.housekeepingRoomsAvailableComboBox.Name = "housekeepingRoomsAvailableComboBox";
            this.housekeepingRoomsAvailableComboBox.Size = new System.Drawing.Size(265, 24);
            this.housekeepingRoomsAvailableComboBox.TabIndex = 7;
            // 
            // housekeepingRoomsLabel
            // 
            this.housekeepingRoomsLabel.AutoSize = true;
            this.housekeepingRoomsLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housekeepingRoomsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.housekeepingRoomsLabel.Location = new System.Drawing.Point(24, 109);
            this.housekeepingRoomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.housekeepingRoomsLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.housekeepingRoomsLabel.Name = "housekeepingRoomsLabel";
            this.housekeepingRoomsLabel.Size = new System.Drawing.Size(83, 25);
            this.housekeepingRoomsLabel.TabIndex = 6;
            this.housekeepingRoomsLabel.Text = "Rooms:";
            this.roomToolTip.SetToolTip(this.housekeepingRoomsLabel, "Find room in drop down menu.");
            // 
            // housekeepingRoomTypeDropDownBox
            // 
            this.housekeepingRoomTypeDropDownBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.housekeepingRoomTypeDropDownBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.housekeepingRoomTypeDropDownBox.ForeColor = System.Drawing.Color.White;
            this.housekeepingRoomTypeDropDownBox.FormattingEnabled = true;
            this.housekeepingRoomTypeDropDownBox.Items.AddRange(new object[] {
            "Single Room",
            "Double Room",
            "Suite"});
            this.housekeepingRoomTypeDropDownBox.Location = new System.Drawing.Point(249, 71);
            this.housekeepingRoomTypeDropDownBox.Margin = new System.Windows.Forms.Padding(4);
            this.housekeepingRoomTypeDropDownBox.MaximumSize = new System.Drawing.Size(265, 0);
            this.housekeepingRoomTypeDropDownBox.MinimumSize = new System.Drawing.Size(265, 0);
            this.housekeepingRoomTypeDropDownBox.Name = "housekeepingRoomTypeDropDownBox";
            this.housekeepingRoomTypeDropDownBox.Size = new System.Drawing.Size(265, 24);
            this.housekeepingRoomTypeDropDownBox.TabIndex = 5;
            // 
            // housekeepingRoomTypeLabel
            // 
            this.housekeepingRoomTypeLabel.AutoSize = true;
            this.housekeepingRoomTypeLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housekeepingRoomTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.housekeepingRoomTypeLabel.Location = new System.Drawing.Point(24, 70);
            this.housekeepingRoomTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.housekeepingRoomTypeLabel.MinimumSize = new System.Drawing.Size(71, 25);
            this.housekeepingRoomTypeLabel.Name = "housekeepingRoomTypeLabel";
            this.housekeepingRoomTypeLabel.Size = new System.Drawing.Size(125, 25);
            this.housekeepingRoomTypeLabel.TabIndex = 4;
            this.housekeepingRoomTypeLabel.Text = "Room Type:";
            this.roomTypeToolTip.SetToolTip(this.housekeepingRoomTypeLabel, "Find room by room type.");
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
            // roomStatusButton
            // 
            this.roomStatusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomStatusButton.FlatAppearance.BorderSize = 6;
            this.roomStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomStatusButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomStatusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.roomStatusButton.Location = new System.Drawing.Point(346, 240);
            this.roomStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.roomStatusButton.Name = "roomStatusButton";
            this.roomStatusButton.Size = new System.Drawing.Size(180, 52);
            this.roomStatusButton.TabIndex = 10;
            this.roomStatusButton.Text = "Submit Room Status";
            this.submitStatusToolTip.SetToolTip(this.roomStatusButton, "Select Submit Room Status to submit the status of the room to the database.");
            this.roomStatusButton.UseVisualStyleBackColor = true;
            // 
            // HousekeepingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(141)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(882, 467);
            this.Controls.Add(this.housekeepingRoomPanel);
            this.Controls.Add(this.housekeepingLogoPanel);
            this.MaximumSize = new System.Drawing.Size(900, 514);
            this.MinimumSize = new System.Drawing.Size(900, 514);
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
        private System.Windows.Forms.CheckBox outOfOrderCheckBox;
        private System.Windows.Forms.CheckBox roomDirtyCheckBox;
        private System.Windows.Forms.ComboBox housekeepingRoomsAvailableComboBox;
        private System.Windows.Forms.Label housekeepingRoomsLabel;
        private System.Windows.Forms.ComboBox housekeepingRoomTypeDropDownBox;
        private System.Windows.Forms.Label housekeepingRoomTypeLabel;
        private System.Windows.Forms.Label houskeepingRoomLabel;
        private System.Windows.Forms.Button roomStatusButton;
        private System.Windows.Forms.ToolTip submitStatusToolTip;
        private System.Windows.Forms.ToolTip outOfOrderToolTip;
        private System.Windows.Forms.ToolTip roomDirtyToolTip;
        private System.Windows.Forms.ToolTip roomToolTip;
        private System.Windows.Forms.ToolTip roomTypeToolTip;
    }
}