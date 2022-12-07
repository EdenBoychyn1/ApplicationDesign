using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationDesign.Models;

namespace ApplicationDesign
{
    public partial class ConciergeForm : Form
    {
        public ConciergeForm()
        {
            InitializeComponent();
        }


        #region Events
        private void findReservationButton_Click(object sender, EventArgs e)
        {
            GuestModel guestModel = new GuestModel();
            invalidClientSelectionLabel.Visible = false;
            if (reservationIDTextBox.Text == "Enter Reservation ID" || reservationIDTextBox.Text == "")
            {
                invalidReservationIDLabel.Visible = true;
            }
            else
            {
                int reservation_id = Int32.Parse(reservationIDTextBox.Text);
                string reservation_name = guestModel.ReservationName(reservation_id);
                if (reservation_name == null)
                {
                    invalidReservationIDLabel.Visible = true;
                }
                else
                {
                    reservationListBox.Items.Add(guestModel.ReservationName(reservation_id));
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            invalidSelecteditemsLabel.Visible = false;
            invalidAddedItemsLabel.Visible = false;
            MoveListBoxItems(itemsAvailableListBox, selecteditemsListBox);
        }
        private void selecteditemsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            invalidSelecteditemsLabel.Visible = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
            if (selecteditemsListBox.SelectedItems.Count <= 0)
            {
                invalidSelecteditemsLabel.Visible = true;
            }
            else
            {
                MoveListBoxItemsBack(selecteditemsListBox);
            }
        }

        private void reservationIDTextBox_Click(object sender, EventArgs e)
        {
            reservationIDTextBox.SelectAll();
            invalidReservationIDLabel.Visible = false;
        }

        private void itemInvoiceButton_Click(object sender, EventArgs e)
        {
            if (reservationIDTextBox.Text == "Enter Reservation ID" || reservationIDTextBox.Text == "")
            {
                invalidReservationIDLabel.Visible = true;
            }
            else if (reservationListBox.Items.Count != 1)
            {
                invalidClientSelectionLabel.Visible = true;
            }
            else if (selecteditemsListBox.Items.Count <= 0)
            {
                invalidAddedItemsLabel.Visible = true;
            }
            else
            {
                invalidClientSelectionLabel.Visible = false;

                GuestModel guestModel = new GuestModel();
                ConciergeModel conciergeModel = new ConciergeModel();
                int reservation_id = Int32.Parse(reservationIDTextBox.Text);
                string reservation_name = guestModel.ReservationName(reservation_id);
                int client_id = conciergeModel.FindClientID(reservation_id);
                int item_code = 0;
                int invoice_id = conciergeModel.FindInvoiceID(reservation_id);
                
                if (reservation_name == null)
                {
                    invalidReservationIDLabel.Visible = true;
                }

                foreach (string item in selecteditemsListBox.Items)
                {
                    item_code = conciergeModel.FindItemCode(item);
                    double amount_charged = conciergeModel.FindAmountCharged(item);
                    conciergeModel.AddTransaction(item_code, client_id, amount_charged, invoice_id);
                }

                ResetForm();
            }
        }

        #endregion

        #region Methods

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

        #endregion

        #region Functions

        public void ResetForm()
        {
            reservationIDTextBox.Text = string.Empty;
            reservationListBox.Items.Clear();
            selecteditemsListBox.Items.Clear();
        }
        #endregion
    }
}
