using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDesign.Db;


namespace ApplicationDesign.Models
{
    class ConciergeModel : DbConnection
    {
        public int FindClientID(int reservation_id)
        {
            int client_id = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT CLIENT_ID FROM RESERVATION_TBL WHERE RESERVATION_ID=@reservation_id", connection))
                {
                    command.Parameters.Add("@reservation_id", SqlDbType.Int).Value = reservation_id;
                    command.Prepare();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            client_id = (int)reader[0];

                        }
                    }
                }
            }
            return client_id;
        }


        public int FindItemCode(string item_description)
        {
            int item_code = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT ITEM_CODE FROM ITEM_TBL WHERE ITEM_DESCRIPTION=@item_description", connection))
                {
                    command.Parameters.Add("@item_description", SqlDbType.VarChar, 30).Value = item_description;
                    command.Prepare();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            item_code = (int)reader[0];

                        }
                    }
                }
            }
            return item_code;
        }


        public double FindAmountCharged(string item_description)
        {
            double amount_charged = 0.00D;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT COST FROM ITEM_TBL WHERE ITEM_DESCRIPTION=@item_description", connection))
                {
                    command.Parameters.Add("@item_description", SqlDbType.VarChar, 30).Value = item_description;
                    command.Prepare();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            amount_charged = Convert.ToDouble(reader[0]);

                        }
                    }
                }
            }
            return amount_charged;
        }

        public int FindInvoiceID(int reservation_id)
        { 
            int invoice_id = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT TOP 1 INVOICE_ID FROM INVOICE_TBL WHERE RESERVATION_ID = @reservation_id", connection))
                {
                    command.Parameters.Add("@reservation_id", SqlDbType.Int).Value = reservation_id;
                    command.Prepare();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            invoice_id = (int) reader[0];

                        }   
                    }
                }
            }
            return invoice_id;
        }


        public void AddTransaction(int item_code, int client_id, double amount_charged, int invoice_id)
        {
            int quantity = 1;
            DateTime today = DateTime.Now;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(null, connection))
                {
                    command.CommandText = "INSERT INTO TRANSACTIONS_TBL (ITEM_CODE, CLIENT_ID, QUANTITY, DATE_CHARGED, AMOUNT_CHARGED, INVOICE_ID) VALUES(@ItemCode, @ClientId, @Quantity, @DateCharged, @AmountCharged, @InvoiceId)";
                    SqlParameter itemCodeParam = new SqlParameter("@ItemCode", SqlDbType.NVarChar, 30);
                    SqlParameter clientIdParam = new SqlParameter("@ClientId", SqlDbType.NVarChar, 30);
                    SqlParameter quantityParam = new SqlParameter("@Quantity", SqlDbType.NVarChar, 30);
                    SqlParameter dateChargedParam = new SqlParameter("@DateCharged", SqlDbType.NVarChar, 30);
                    SqlParameter amountChargedParam = new SqlParameter("@AmountCharged", SqlDbType.NVarChar, 30);
                    SqlParameter invoiceIdParam = new SqlParameter("@InvoiceId", SqlDbType.NVarChar, 30);

                    //command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(itemCodeParam).Value = item_code;
                    command.Parameters.Add(clientIdParam).Value = client_id;
                    command.Parameters.Add(quantityParam).Value = quantity;
                    command.Parameters.Add(dateChargedParam).Value = today;
                    command.Parameters.Add(amountChargedParam).Value = amount_charged;
                    command.Parameters.Add(invoiceIdParam).Value = invoice_id;

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
        }


        public void AddReservation(DateTime start_date, DateTime end_date, int client_id, int room_id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(null, connection))
                {
                    command.CommandText = "INSERT INTO RESERVATION_TBL (ROOM_ID,CLIENT_ID,RESERVATION_START_DATE,RESERVATION_END_DATE) VALUES (@room_id, @client_id, @start_date, @end_date)";
                    SqlParameter roomIdParam = new SqlParameter("@room_id", SqlDbType.Int, 0);
                    SqlParameter clientIdParam = new SqlParameter("@client_id", SqlDbType.Int, 0);
                    SqlParameter startDateParam = new SqlParameter("@start_date", SqlDbType.DateTime);
                    SqlParameter endDateParam = new SqlParameter("@end_date", SqlDbType.DateTime);

                    command.Parameters.Add(roomIdParam).Value = room_id;
                    command.Parameters.Add(clientIdParam).Value = client_id;
                    command.Parameters.Add(startDateParam).Value = start_date;
                    command.Parameters.Add(endDateParam).Value = end_date;

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
    
}
