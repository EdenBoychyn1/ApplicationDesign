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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void conciergeLabel_Click(object sender, EventArgs e)
        {

        }

        private void findReservationButton_Click(object sender, EventArgs e)
        {
            KingWilliamHotelModel hotelModel = new KingWilliamHotelModel();
            //frontDeskListBox.Items.Clear();
            int ResId = Int32.Parse(reservationIDTextBox.Text);

            List<string> resList = new List<string>(hotelModel.ReservationFill(ResId));

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
                reservationStartDateDTP.Text = resList[5];
                reservationEndDateDTP.Text = resList[4];

                string guestFullName = resList[0] + " " + resList[1];

                
                dataGridView1.DataSource = hotelModel.GenerateInvoice(ResId);

                dataGridView1.Columns["GuestName"].HeaderText = "Guest Name";
                dataGridView1.Columns["ITEM_DESCRIPTION"].HeaderText = "Concierge Services/Items";
                dataGridView1.Columns["CHARGED_AMOUNT"].HeaderText = "Amount Charged";
                dataGridView1.Columns["QUANTITY"].HeaderText = "Quantity";
                dataGridView1.Columns["DATE_CHARGED"].HeaderText = "Date Charged";

                totalwithTaxTextBox.Text = hotelModel.TotalWithTax(ResId);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
