using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDesign.Db;

namespace ApplicationDesign.Models
{
    public class KingWilliamHotelModel : DbConnection
    {
        /// <summary>
        /// Property that is used to get the physician id and determine whether it matches any id in the database.
        /// </summary>
        public int id_username { get; private set; }


        /// <summary>
        /// This method is used to determine whether the Physician ID that is entered into the Physician Login textbox is valid. 
        /// This is completed by determining if the Physician ID matches any ID in the database. 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool UsernameValidation(string userId)
        {
            bool usernameValid = false;
            id_username = Int32.Parse(userId);
            //if (int.TryParse(userName, out id_username))
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT EMPLOYEE_ID FROM EEMPLOYEE_TBL WHERE EMPLOYEE_ID =" + id_username, connection))
                    {
                        SqlParameter usernameParam;
                        usernameParam = new SqlParameter("@username", id_username);

                        command.Parameters.Add(usernameParam);

                        SqlDataReader dr = command.ExecuteReader();

                        if (dr.HasRows)
                        {
                            usernameValid = true;
                        }
                        else
                        {
                            usernameValid = false;
                        }
                    }
                }
            }


            return usernameValid;
        }
    }
}
