using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ApplicationDesign.Db;
using System.Data;

namespace ApplicationDesign.Models
{
    class GuestModel : DbConnection
    {
        #region Properties

        public List<int> room_list { get; private set; }
        public string guest_fname { get; private set; }
        public string guest_lname { get; private set; }
        public string guest_phone { get; private set; }
        public string guest_email { get;private set;}
        #endregion

        #region Methods
        // TODO: Prepare statement
        public void AddGuest(string firstName, string lastName, string phone, string email)
        {
            // Convert nesseccary data types to match the data types in the database
            guest_fname = firstName;
            guest_lname = lastName;
            guest_phone = phone;
            guest_email = email;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO CLIENTS_TBL(CLIENT_F_NAME, CLIENT_L_NAME, CLIENT_PHONE, CLIENT_EMAIL) VALUES(@guestFirstName, @guestLastName, @guestPhone, @guestEmail) ", connection))
                {
                    command.Parameters.AddWithValue("@guestFirstName", guest_fname);
                    command.Parameters.AddWithValue("@guestLastName", guest_lname);
                    command.Parameters.AddWithValue("@guestPhone", guest_phone);
                    command.Parameters.AddWithValue("@guestEmail", guest_email);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<GuestModel> FindGuestByPhone(string phone)
        {
            List<GuestModel> list = new List<GuestModel>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT CLIENT_L_NAME, CLIENT_F_NAME FROM CLIENTS_TBL WHERE CLIENT_PHONE= @client_phone", connection))
                {
                    command.Parameters.Add("@client_phone", SqlDbType.VarChar, 20).Value = phone;
                    command.Prepare();
                    using (var reader = command.ExecuteReader())
                    {
                        GuestModel model = new GuestModel();
                        while (reader.Read())
                        {
                            model.guest_lname = reader[0].ToString();
                            model.guest_fname = reader[1].ToString();
                            list.Add(model);
                        }
                    }
                }
            }
            return list;
        }


        public List<int> RoomList(string room_desc)
        {
            List<int> room_list = new List<int>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT ROOM_NUMBER FROM ROOMS_TBL WHERE ROOM_DESC=@roomDesc AND ROOM_READY=1", connection))
                {
                    command.Parameters.Add("@roomDesc", SqlDbType.VarChar, 40).Value = room_desc;
                    command.Prepare();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            room_list.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return room_list;

        }
        #endregion
    }
}
