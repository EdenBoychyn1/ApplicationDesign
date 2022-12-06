
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

        #region Events
        private void clientFirstNameTextBox_Click(object sender, EventArgs e)
        {
            clientFirstNameTextBox.SelectAll();
            invalidClientFirstNameLabel.Visible = false;
        }

        private void guestLastNameTextBox_Click(object sender, EventArgs e)
        {
            guestLastNameTextBox.SelectAll();
            invalidGuestLastNameLabel.Visible = false;
        }

        private void clientEmailTextBox_Click(object sender, EventArgs e)
        {
            clientEmailTextBox.SelectAll();
            invalidGuestEmailLabel.Visible = false;

        }

        private void guestPhoneNumber_Click(object sender, EventArgs e)
        {
            guestPhoneNumber.SelectAll();
            invalidPhoneLabel.Visible = false;
        }

        // TODO: Add comments
        // TODO: messages indicating add guest was successful


        private void addGuest_Click(object sender, EventArgs e)
        {
            GuestModel model = new GuestModel();
            string first_name = clientFirstNameTextBox.Text;
            string last_name = guestLastNameTextBox.Text;
            string phone_number = guestPhoneNumber.Text;
            string email = clientEmailTextBox.Text;

            if (first_name == "Enter Guest First Name" || first_name == "")
            {
                invalidClientFirstNameLabel.Visible = true;
            }
            else if (last_name == "Enter Guest Last Name" || last_name == "")
            {
                invalidGuestLastNameLabel.Visible = true;
            }
            else if (email == "Enter Guest Email" || email == "" || !IsValidEmail(email))
            {
                invalidGuestEmailLabel.Visible = true;
            }
            else if (phone_number == "Enter Guest Phone Number" || phone_number == "" || !IsNumeric(phone_number))
            {
                invalidPhoneLabel.Visible = true;
            }
            else
            {
                invalidPhoneLabel.Visible = false;
                model.AddGuest(first_name, last_name, phone_number, email);
                ResetForm();
            }
        }
        #endregion


        #region Functions/Methods

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        //public bool IsNumeric(string phone_number)
        //{
        //    bool isNumeric = false;
        //    int n;
        //    isNumeric = int.TryParse(phone_number, out n);
        //    return isNumeric;
        
        //}

        public static bool IsNumeric(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public void ResetForm()
        {
            clientFirstNameTextBox.Text = string.Empty;
            guestLastNameTextBox.Text = string.Empty;
            clientEmailTextBox.Text = string.Empty;
            guestPhoneNumber.Text = string.Empty;
        }

        #endregion


    }
}
