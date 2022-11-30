
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
    public partial class AddAGuestForm : Form
    {
        public AddAGuestForm()
        {

            InitializeComponent();
        }

        private GuestModel model = new GuestModel();

        // TODO: Add comments
        // TODO: add validation 
        // TODO: clear form
        // TODO: messages indicating add guest was successful
        private void addGuest_Click(object sender, EventArgs e)
        {
            string first_name = clientFirstNameTextBox.Text;
            string last_name = guestLastNameTextBox.Text;
            string phone_number = guestPhoneNumber.Text;
            string email = clientEmailTextBox.Text;

            model.AddGuest(first_name, last_name, phone_number, email);
        }
    }
}
