﻿
/**
 * Authors:         Eden Boychyn, 100752815' & Angaran Yogeswaran 100754161
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
using System.Data.SqlClient;
using ApplicationDesign.Models;


namespace ApplicationDesign
{
    public partial class kingWilliamHotelForm : Form
    {
        private KingWilliamHotelModel model;

        public int user_id { get; set; }
        public kingWilliamHotelForm()
        {
            model = new KingWilliamHotelModel();
            InitializeComponent();
        }


        #region Events
        /// <summary>
        /// When the user selects the user id textbox, all the text in the textbox will be selected. When the user starts typing it will overwrite the text
        /// ***Have to change to textchanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userIDTextBox_Click(object sender, EventArgs e)
        {
            userIDTextBox.SelectAll();
        }

        /// <summary>
        /// When the user selects the password textbox, all the text in the textbox will be selected. When the user starts typing it will overwrite the text
        /// ***Have to change to textchanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.SelectAll();
        }

        private void userIDTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidPasswordLabel.Visible = false;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidPasswordLabel.Visible = false;
        }

        /// <summary>
        /// Need to change this for Data Validation. Only for Demonstration purposes rn. Currently validating if the textbox is empty
        /// ***Need to find a suitable way to get rid of the text when the user moves to the next textbox after inputting a value
        /// *** Based on User ID, automatically open the window that the security role is in accoradance with. I.E. Front Desk Security Role 
        ///     would automactically open the Front Desk form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signInButton_Click(object sender, EventArgs e)
        {
            string userId = userIDTextBox.Text;
            string employeePassword = passwordTextBox.Text;


            string hashed_password = Hash.Hash.PasswordHash(employeePassword);
            if (userIDTextBox.Text == "Enter User ID" || userIDTextBox.Text.Equals("") || passwordTextBox.Text == "Enter Password" || passwordTextBox.Text.Equals(""))
            {
                invalidPasswordLabel.Visible = true;
                userIDTextBox.Focus();
                passwordTextBox.Focus();
            }
            else if (model.LogInValidation(userId, hashed_password) == true)
            {

                    MessageBox.Show("User ID is in the database.");
                    user_id = Int32.Parse(userId);
                    int number = Int32.Parse(model.SecurityLevel(user_id));
                    switch (number)
                    {
                        case 5:
                            ManagementForm managementForm = new ManagementForm();
                            managementForm.Show();
                            break;
                        case 4:
                            FrontDeskForm frontDeskForm = new FrontDeskForm();
                            frontDeskForm.Show();
                            break;
                        case 3:
                            ConciergeForm conciergeForm = new ConciergeForm();
                            conciergeForm.Show();
                            break;
                        case 2:
                            HousekeepingForm housekeepingForm = new HousekeepingForm();
                            housekeepingForm.Show();
                            break;
                        case 1:
                            RestaurantForm restaurantForm = new RestaurantForm();
                            restaurantForm.Show();
                            break;
                    }
                
            }
            else
            {
                MessageBox.Show("Error, User ID entered does not match any User ID in the database.");
            }
        }


        ///// <summary>
        ///// Instantiates a new ManagementForm object and shows it upon Management button click event.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void managementButton_Click(object sender, EventArgs e)
        {
            string number = model.SecurityLevel(user_id) ;
            if (number == "5")
            {
                ManagementForm managementForm = new ManagementForm();
                managementForm.Show();
            }
            else
            {
                MessageBox.Show("Error, your security level does not allow you to access this.");
                managementButton.Enabled = false;
            }
        }

        ///// <summary>
        ///// Instantiates a new FrontDeskForm object and shows it upon Front Desk button click event.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void frontDeskButton_Click(object sender, EventArgs e)
        {
            string number = model.SecurityLevel(user_id);
            if (number == "5" || number == "4")
            {
                FrontDeskForm frontDeskForm = new FrontDeskForm();
                frontDeskForm.Show();
            }
            else
            {
                MessageBox.Show("Error, your security level does not allow you to access this.");
                frontDeskButton.Enabled = false;
            }
        }

        ///// <summary>
        ///// Instantiates a new ConciergeForm object and shows it upon Concierge button click event.
        ///// **********When exiting Concierge Form, user cannot select the Concierge button, it does not work********************
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void conciergeButton_Click(object sender, EventArgs e)
        {
            string number = model.SecurityLevel(user_id);
            if (number == "5" || number == "3")
            {
                ConciergeForm conciergeForm = new ConciergeForm();
                conciergeForm.Show();
            }
            else
            {
                MessageBox.Show("Error, your security level does not allow you to access this.");
                conciergeButton.Enabled = false;
            }
        }

        ///// <summary>
        ///// Instantiates a new HousekeepingForm object and shows it upon Housekeeping button click event.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void housekeepingButton_Click_1(object sender, EventArgs e)
        {
            string number = model.SecurityLevel(user_id);
            if (number == "5" || number == "2")
            {
                HousekeepingForm housekeepingForm = new HousekeepingForm();
                housekeepingForm.Show();
            }
            else
            {
                MessageBox.Show("Error, your security level does not allow you to access this.");
                housekeepingButton.Enabled = false;
            }
        }

        ///// <summary>
        ///// Instantiates a new Restaurant Form object and shows it upon Restaurant button click event.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void restaurantButton_Click(object sender, EventArgs e)
        {
            string number = model.SecurityLevel(user_id);
            if (number == "5" || number == "4" || number == "1")
            {
                RestaurantForm restaurantForm = new RestaurantForm();
                restaurantForm.Show();
            }
            else
            {
                MessageBox.Show("Error, your security level does not allow you to access this.");
                housekeepingButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = model.SecurityLevel(user_id);
            if (number == "5")
            {
                Invoice invoice = new Invoice();
                invoice.Show();
            }
            else
            {
                MessageBox.Show("Error, your security level does not allow you to access this.");
                button1.Enabled = false;
            }
        }
    }

    #endregion
}
