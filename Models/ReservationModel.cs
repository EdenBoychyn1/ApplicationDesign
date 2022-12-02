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
    class ReservationModel : DbConnection
    {

        #region Properties

        
        #endregion

        #region Methods



        public int FindRoomID(int room_number)
        {
            int room_id = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT ROOM_ID FROM ROOMS_TBL WHERE ROOM_NUMBER=@room_number", connection))
                {
                    command.Parameters.Add("@room_number", SqlDbType.Int).Value = room_number;
                    command.Prepare();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            room_id = (int)reader[0];
                        }
                    }
                }
            }
            return room_id;
        }

        public int FindClientID(string last_name)
        {
            int client_id = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT CLIENT_ID FROM CLIENTS_TBL WHERE CLIENT_L_NAME=@client_l_name", connection))
                {
                    command.Parameters.Add("@client_l_name", SqlDbType.VarChar, 50).Value = last_name;
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

        public List<int> RoomList(string room_desc)
        {
            List<int> room_list = new List<int>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT ROOM_NUMBER FROM ROOMS_TBL WHERE ROOM_DESC=@roomDesc AND ROOM_READY=0", connection))
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
        public void UpdateOccupiedRoom(int room_id)
        {
            int zero = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(null, connection))
                {
                    command.CommandText = "UPDATE ROOMS_TBL SET ROOM_READY =@zero WHERE ROOM_ID =@room_id; ";

                    SqlParameter zeroParam = new SqlParameter("@zero", SqlDbType.Int, 0);
                    SqlParameter roomIdParam = new SqlParameter("@room_id", SqlDbType.Int);

                    command.Parameters.Add(zeroParam).Value = zero;
                    command.Parameters.Add(roomIdParam).Value = room_id;

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


        public void UpdateRoom(int room_number)
        {
            int room_ready = 1;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command  = new SqlCommand("UpdateRoom", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoomNum", SqlDbType.Int).Value = room_number;
                    command.Parameters.AddWithValue("@RoomReady", SqlDbType.Int).Value = room_ready;

                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}
