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
                using (var command = new SqlCommand("AddGuest", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientFname", SqlDbType.NVarChar).Value = guest_fname;
                    command.Parameters.AddWithValue("@ClientLname", SqlDbType.NVarChar).Value = guest_lname;
                    command.Parameters.AddWithValue("@Clientemail", SqlDbType.NVarChar).Value = guest_email;
                    command.Parameters.AddWithValue("@ClientePhone", SqlDbType.NVarChar).Value = guest_phone;

                    command.ExecuteNonQuery();
                }
            }
        }


        public string ClientName(string client_phone)
        {
            string client_name = null;
            //int security_level = new int();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("ClientName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientPhone", SqlDbType.Int).Value = client_phone;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                client_name = reader.GetString(0);
                        }
                    }
                }
            }
            return client_name;
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

        public string ReservationName(int resId)
        {
            string resName = null;
            //int security_level = new int();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("ReseverationName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ResID", SqlDbType.Int).Value = resId;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                resName = reader.GetString(0);
                        }
                    }
                }
            }
            return resName;
        }
        #endregion
    }
}
