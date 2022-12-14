
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
using ApplicationDesign.Hash;

namespace ApplicationDesign
{
    public partial class ManagementForm : Form
    {

        private KingWilliamHotelModel model;
        public ManagementForm()
        {
            model = new KingWilliamHotelModel();
            InitializeComponent();
        }

        #region GUI Appearance
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1000, 900);
        }

        #endregion

        #region Events
        private void signUpButton_Click(object sender, EventArgs e)
        {

            // TODO: NEED A TRY & CATCH
            if (employeeFirstNameTextBox.Text == "Enter Employee First Name" || employeeFirstNameTextBox.Text.Equals(""))
            {
                invalidEmployeeFirstNameLabel.Visible = true;
                invalidEmployeeFirstNameLabel.Focus();
            }
            else if (employeeLastNameTextBox.Text == "Enter Employee Last Name" || employeeLastNameTextBox.Text.Equals(""))
            {
                invalidEmployeeLastNameLabel.Visible = true;
                invalidEmployeeLastNameLabel.Focus();
            }
            else if (string.IsNullOrEmpty(securityLevelDropDownBox.Text))
            {
                invalidSecurityRoleLabel.Visible = true;
                invalidSecurityRoleLabel.Focus();
            }
            else if (employeePasswordTextBox.Text.Equals(""))
            {
                invalidEmployeePasswordLabel.Visible = true;
                invalidEmployeePasswordLabel.Focus();
            }
            else if (confirmPasswordTextBox.Text.Equals(""))
            {
                invalidEmployeePasswordLabel.Visible = true;
                invalidEmployeePasswordLabel.Focus();
            }
            else if (employeePasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                invalidConfirmPasswordLabel.Visible = true;
                invalidConfirmPasswordLabel.Focus();
            }
            else
            {

                string first_name = employeeFirstNameTextBox.Text;
                string last_name = employeeLastNameTextBox.Text;
                int security_number = SecurityStringToNumber(securityLevelDropDownBox.SelectedItem.ToString());
                string password = Hash.Hash.PasswordHash(employeePasswordTextBox.Text);


                model.AddEmployee(first_name, last_name, security_number, password);

                ResetForm();
                // TODO: NEED TO HASH PASSWORD
            }
        }

        private void employeeFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidEmployeeFirstNameLabel.Visible = false;
        }

        private void employeeLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidEmployeeLastNameLabel.Visible = false;
        }

        private void employeePasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidEmployeePasswordLabel.Visible = false;
            invalidConfirmPasswordLabel.Visible = false;
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidEmployeePasswordLabel.Visible = false;
            invalidConfirmPasswordLabel.Visible = false;
        }

        private void employeeFirstNameTextBox_Click(object sender, EventArgs e)
        {
            employeeFirstNameTextBox.SelectAll();
        }

        private void employeeLastNameTextBox_Click(object sender, EventArgs e)
        {
            employeeLastNameTextBox.SelectAll();
        }

        private void employeePasswordTextBox_Click(object sender, EventArgs e)
        {
            employeePasswordTextBox.SelectAll();
        }

        private void confirmPasswordTextBox_Click(object sender, EventArgs e)
        {
            confirmPasswordTextBox.SelectAll();
        }

        #endregion

        #region Functions

        public int SecurityStringToNumber(string securityString)
        {
            int security_number = 0;

            if (securityString == "Security Level 5 - Management")
            {
                security_number = 5;
            }
            else if (securityString == "Security Level 4 - Front Desk")
            {
                security_number = 4;
            }
            else if (securityString == "Security Level 3 - Concierge")
            {
                security_number = 3;
            }
            else if (securityString == "Security Level 2 - Housekeeping")
            {
                security_number = 2;
            }
            else 
            {
                security_number = 1;
            }
            return security_number; 
        }

        public void ResetForm()
        {
            employeeFirstNameTextBox.Text = string.Empty;
            employeeLastNameTextBox.Text = string.Empty;
            employeePasswordTextBox.Text = string.Empty;
            confirmPasswordTextBox.Text = string.Empty;
        }
        #endregion
    }





}
