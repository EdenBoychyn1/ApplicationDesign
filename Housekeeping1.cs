
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
    public partial class HousekeepingForm : Form
    {
        public HousekeepingForm()
        {
            InitializeComponent();
        }

        #region Properties
        ReservationModel model = new ReservationModel();

        #endregion

        #region Events
        private void roomTypeButton_Click(object sender, EventArgs e)
        {
            if (housekeepingRoomTypeComboBox.SelectedIndex < 0)
            {
                invalidRoomTypeLabel.Visible = true;
            }
            else
            {
                string room_type = housekeepingRoomTypeComboBox.SelectedItem.ToString();
                if (room_type == "Single")
                {
                    roomNumbersListBox.DataSource = model.RoomList(room_type);
                }
                else if (room_type == "Double")
                {
                    roomNumbersListBox.DataSource = model.RoomList(room_type);
                }
                else
                {
                    roomNumbersListBox.DataSource = model.RoomList(room_type);
                }

                invalidRoomTypeLabel.Visible = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool similarItem = false;
            invalidSelectedRoomsLabel.Visible = false;
            invalidAddedRoomsLabel.Visible = false;
            foreach (string listItem in selectedRoomNumbersListBox.Items)
            {
                if (listItem == roomNumbersListBox.SelectedItem.ToString())
                {
                    invalidAlreadySelectedLabel.Visible = true;
                    similarItem = true;
                    break;
                }
            }

            if (!similarItem)
            {
                selectedRoomNumbersListBox.Items.Add(roomNumbersListBox.SelectedItem.ToString());
            }
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (selectedRoomNumbersListBox.Items.Count <= 0)
            {
                invalidSelectedRoomsLabel.Visible = true;
            }
            else
            {
                MoveListBoxItemsBack(selectedRoomNumbersListBox);
            }
        }

        private void roomStatusButton_Click(object sender, EventArgs e)
        {
            if (selectedRoomNumbersListBox.Items.Count <= 0)
            {
                invalidAddedRoomsLabel.Visible = true;
            }
            else
            {
                int room_number;
                foreach (string item in selectedRoomNumbersListBox.Items)
                {
                    room_number = Int32.Parse(item);
                    model.UpdateRoom(room_number);
                }

                ResetForm();
            }
        }

        private void roomNumbersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            invalidAlreadySelectedLabel.Visible = false;
        }

        #endregion

        #region Methods/Functions
        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
        }

        private void MoveListBoxItemsBack(ListBox source)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void ResetForm()
        {
            housekeepingRoomTypeComboBox.Items.Clear();
            //roomNumbersListBox.Items.Clear();
            selectedRoomNumbersListBox.Items.Clear();
        }


        #endregion


    }
}
