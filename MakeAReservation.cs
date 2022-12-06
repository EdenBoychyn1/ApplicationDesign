
/**
 * Authors:          Eden Boychyn, 100752815' & Angaran Yogeswaran 100754161
 * Date:            October 28th, 2022
 * Description:     This application design demonstrates the potential functionality of the software application. Form1 is used to allow employees to login and according to
 *                  their security level the window that they have access to should display on the screen after signing on. Only Basil (Management) has access to the management
 *                  window which allows him to register new employees. Basil's ecurity role is Management and he is the only one who has this security role. Our group will 
 *                  incorporate a singleton pattern so that only one instance of a form is accessible at a time; I.E. if an employee repeatedly selects the Front Desk button 
 *                  it should only show that form, not multiple windows of that form. Basil (management) will have access to all forms. Front Desk employees will also have 
 *                  access to add restaurant itmes to guests; invoices.  
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationDesign.Models;

namespace ApplicationDesign
{
    public partial class MakeAReservation : Form
    {
        public MakeAReservation()
        {
            InitializeComponent();
        }

        #region Properties
        private GuestModel model = new GuestModel();

        private ReservationModel reservationModel = new ReservationModel();

        private string guest_phone_number { get; set; }
        #endregion

        private void findGuest1Label_Click(object sender, EventArgs e)
        {

        }

        #region Events
        private void guestsPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidPhoneLabel.Visible = false;
        }
        private void findGuestListBox_Enter(object sender, EventArgs e)
        {
            noGuestSelectedLabel.Visible = false;
        }

        private void guestsPhoneTextBox_Click(object sender, EventArgs e)
        {
            guestsPhoneTextBox.SelectAll();
        }

        private void roomTypeDropDownBox_Click(object sender, EventArgs e)
        {
            invalidRoomTypeLabel.Visible = false;
        }

        private void reservationEndDateDTP_ValueChanged(object sender, EventArgs e)
        {
            invalidDatesLabel.Visible = false;
        }

        private void reservationStartDateDTP_ValueChanged(object sender, EventArgs e)
        {
            invalidDatesLabel.Visible = false;
        }

        private void findGuestButton_Click(object sender, EventArgs e)
        {
            guest_phone_number = guestsPhoneTextBox.Text;

            string client_name = model.ClientName(guest_phone_number);
            if (guestsPhoneTextBox.Text == "Enter Guest's Phone Number" || guestsPhoneTextBox.Text.Equals(""))
            {
                invalidPhoneLabel.Visible = true;
            }
            else
            {
                findGuestListBox.Items.Add(model.ClientName(guest_phone_number));
            }
        }

        private void findRoomButton_Click(object sender, EventArgs e)
        {

            if (guestsPhoneTextBox.Text == "Enter Guest's Phone Number" || guestsPhoneTextBox.Text.Equals(""))
            {
                invalidPhoneLabel.Visible = true;
            }
            else if (findGuestListBox.SelectedIndex < 0 )
            {
                noGuestSelectedLabel.Visible = true;
            }
            else if (findGuestListBox.SelectedIndex == 2)
            {
                noGuestSelectedLabel.Text = "You must select the guest's last name.";
            }
            else if (roomTypeDropDownBox.SelectedIndex < 0)
            {
                invalidRoomTypeLabel.Visible = true;
            }
            else
            {
                string room_type = roomTypeDropDownBox.SelectedItem.ToString();
                if (room_type == "Single" )
                {
                    roomsAvailableComboBox.DataSource = model.RoomList(room_type);
                }
                else if (room_type == "Double")
                {
                    roomsAvailableComboBox.DataSource = model.RoomList(room_type);
                }
                else
                {
                    roomsAvailableComboBox.DataSource = model.RoomList(room_type);
                }

                invalidRoomNumberLabel.Visible = false;


            }

        }

        #endregion

        private void addReservationButton_Click(object sender, EventArgs e)
        {



            DateTime startDate = reservationStartDateDTP.Value;
            DateTime endDate = reservationEndDateDTP.Value;
            if (guestsPhoneTextBox.Text == "Enter Guest's Phone Number" || guestsPhoneTextBox.Text.Equals(""))
            {
                invalidPhoneLabel.Visible = true;
            }
            else if (findGuestListBox.SelectedIndex < 0)
            {
                noGuestSelectedLabel.Visible = true;
            }
            else if (findGuestListBox.SelectedIndex == 1)
            {
                noGuestSelectedLabel.Text = "You must select the guest's last name.";
            }
            else if (roomTypeDropDownBox.SelectedIndex < 0)
            {
                invalidRoomTypeLabel.Visible = true;
            }
            else if (roomsAvailableComboBox.SelectedIndex < 0)
            {
                invalidRoomNumberLabel.Visible = true;
            }
            else if (startDate > endDate)
            {
                invalidDatesLabel.Visible = true;
            }
            else
            {
                int room_number = Int32.Parse(roomsAvailableComboBox.SelectedValue.ToString());
                string client_l_name = findGuestListBox.GetItemText(findGuestListBox.SelectedItem);
                int room_id = reservationModel.FindRoomID(room_number);
                int client_id = reservationModel.FindClientID(client_l_name);

                reservationModel.AddReservation(startDate, endDate, client_id, room_id);

                reservationModel.UpdateOccupiedRoom(room_id);
                ResetForm();
            }

        }

        private void ResetForm()
        {
            guestsPhoneTextBox.Text = string.Empty;
            findGuestListBox.Items.Clear();
            roomTypeDropDownBox.Items.Clear();
            reservationStartDateDTP.Value = DateTime.Now;
            reservationEndDateDTP.Value = DateTime.Now;

        }
    }
}
