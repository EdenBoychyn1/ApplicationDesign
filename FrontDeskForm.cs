
/**
 * Authors:         Eden Boychyn, 100752815 & Angaran Yogeswaran 100754161
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
    public partial class FrontDeskForm : Form
    {

        private KingWilliamHotelModel model;
        public FrontDeskForm()
        {
            InitializeComponent();
            model = new KingWilliamHotelModel();
        }


        /// <summary>
        /// Instantiates a new AddAGuestForm object and shows it upon Add a Guest button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addAGuestButton_Click(object sender, EventArgs e)
        {
            AddAGuestForm addAGuestForm = new AddAGuestForm();
            addAGuestForm.Show();
        }


        /// <summary>
        /// Instantiates a new MakeAReservationForm object and shows it upon make a reservation button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void makeAReservationButton_Click(object sender, EventArgs e)
        {
            MakeAReservation makeAReservation = new MakeAReservation();
            makeAReservation.Show();
        }

        private void FrontDeskForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1200, 650);
        }

        private void reservationIDTextBox_Click(object sender, EventArgs e)
        {
            reservationIDTextBox.SelectAll();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void guestFirstNameTextBox_Click(object sender, EventArgs e)
        {
            guestFirstNameTextBox.SelectAll();
        }

        private void guestLastNameTextBox_Click(object sender, EventArgs e)
        {
            guestLastNameTextBox.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void findReservationButton_Click(object sender, EventArgs e)
        {
            string ResId = reservationIDTextBox.Text;

            List<string> resList = new List<string>(model.ReservationFill(Int32.Parse(ResId)));

            if (resList.Count == 0)
            {
                MessageBox.Show("Reservation Not Found in the System");
            }
            else
            {
                guestFirstNameTextBox.Text = resList[0];
                guestLastNameTextBox.Text = resList[1];
                textBox2.Text = resList[2];
                textBox3.Text = resList[3];
                textBox4.Text = resList[6];
                reservationStartDateDTP.Text = resList[4];
                reservationEndDateDTP.Text = resList[5];
            }

        }

        private void updateReservationButton_Click(object sender, EventArgs e)
        {
            invalidGuestFirstNameLabel.Visible = false;
            invalidGuestLastNameLabel.Visible = false;
            invalidReservationIDLabel.Visible = false;
            InvaildEmailLbl.Visible = false;
            InvalidPhoneLbl.Visible = false;
            InvalidRoomLbl.Visible = false;

            string ResId = reservationIDTextBox.Text;
            string guestFname = guestFirstNameTextBox.Text;
            string guestLname = guestLastNameTextBox.Text;
            string guestEmail = textBox2.Text;
            string phone = textBox3.Text;
            string resStart = reservationStartDateDTP.Text;
            string resEnd = reservationEndDateDTP.Text;
            string roomNum = textBox4.Text;
            

            if (reservationIDTextBox.Text.Equals("") || guestFirstNameTextBox.Text.Equals("") || guestLastNameTextBox.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || reservationStartDateDTP.Text.Equals("") || reservationEndDateDTP.Text.Equals("") || textBox4.Text.Equals(""))
            {
                invalidGuestFirstNameLabel.Visible = true;
                invalidGuestLastNameLabel.Visible = true;
                invalidReservationIDLabel.Visible = true;
                InvaildEmailLbl.Visible = true;
                InvalidPhoneLbl.Visible = true;
                InvalidRoomLbl.Visible = true;

            }
            else 
            {
                try
                {
                    model.ReservationUpdate(Int32.Parse(ResId), guestFname, guestLname, guestEmail, phone, resStart, resEnd, roomNum);
                    MessageBox.Show("Reservation Updated");
                }
                catch
                {
                    MessageBox.Show("Update Failed");
                }
            }

        }

        private void findGuestButton_Click(object sender, EventArgs e)
        {
            string GuestLast = textBox1.Text;

            List<string> resList = new List<string>(model.ReservationFillLastName(GuestLast));
            if (resList.Count == 0)
            {
                MessageBox.Show("Reservation Not Found in the System");
            }
            else
            {
                reservationIDTextBox.Text = resList[0];
                guestFirstNameTextBox.Text = resList[1];
                guestLastNameTextBox.Text = resList[2];
                textBox2.Text = resList[3];
                textBox3.Text = resList[4];
                textBox4.Text = resList[7];
                reservationStartDateDTP.Text = resList[5];
                reservationEndDateDTP.Text = resList[6];
            }
        }

        private void deleteReservationButton_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to Delete this Reservation, Reservation Will Be Lost Forever and Room Will Be Updated.", 
                "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string ResId = reservationIDTextBox.Text;

            if (d == DialogResult.Yes)
            {
                try 
                { 
                  model.ReservationDelete(Int32.Parse(ResId));
                  MessageBox.Show("SucessFul Delete");
                    reservationIDTextBox.Clear();
                    guestFirstNameTextBox.Clear(); 
                    guestLastNameTextBox.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();


                }
                  catch
               {
                   MessageBox.Show("Deletion Failed");
                }
            }else if (d == DialogResult.No)
            {
                MessageBox.Show("Deletion Canceled");
            }



        }
    }
}
