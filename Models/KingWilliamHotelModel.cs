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
    public class KingWilliamHotelModel : DbConnection
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public KingWilliamHotelModel()
        {

        }

        #region Properties
        /// <summary>
        /// Property that is used to get the physician id and determine whether it matches any id in the database.
        /// </summary>
        public int user_id { get; private set; }

        // TODO: Need to comment and clean/organize code
        public string user_password { get; private set; }

        public string employee_password { get; private set; }

        public string securityLevel { get; private set; }

        public string employee_f_name { get; private set; }

        public string employee_l_name { get; private set; }

        public int security_level { get; private set; }

        #endregion

        #region Methods
        /// <summary>
        /// ************************NEEDS TO BE A PREPARED STATEMENT*********************************************
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="securityLevel"></param>
        /// <param name="password"></param>
        // TODO: NEEDS TO BE A PREPARED STATEMENT
        public void AddEmployee(string firstName, string lastName, int securityLevel, string password)
        {
            // Convert nesseccary data types to match the data types in the database
            employee_f_name = firstName;
            employee_l_name = lastName;
            security_level = securityLevel;
            employee_password = password;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO EMPLOYEE_TBL(EMPLOYEE_FIRSTNAME, EMPLOYEE_LASTNAME, EMPLOYEE_SEC_LEVEL, EMPLOYEE_PASSWORD) VALUES(@employeeFirstName, @employeeLastName, @securityLevel, @employeePassword) ", connection))
                {
                    command.Parameters.AddWithValue("@employeeFirstName", employee_f_name);
                    command.Parameters.AddWithValue("@employeeLastName", employee_l_name);
                    command.Parameters.AddWithValue("@securityLevel", security_level);
                    command.Parameters.AddWithValue("@employeePassword", employee_password);

                    command.ExecuteNonQuery();
                }
            }
        }

        public string SecurityLevel(int userId)
        {
            user_id = userId;
            //int security_level = new int();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT EMPLOYEE_SEC_LEVEL FROM EMPLOYEE_TBL WHERE EMPLOYEE_ID= " + user_id, connection))
                {
                    SqlParameter userIdParam = new SqlParameter("@userid", user_id);

                    command.Parameters.Add(userIdParam);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            securityLevel = reader[0].ToString();
                        }
                    }
                }
            }
            return securityLevel;
        }

        /// <summary>
        /// This method is used to determine whether the Employee ID that is entered into the Employee Login textbox is valid. 
        /// This is completed by determining if the Employee ID matches any ID in the database. 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool LogInValidation(string userId, string employeePassword)
        {
            bool loginValid = false;
            user_id = Int32.Parse(userId);
            user_password = employeePassword;
            //if (int.TryParse(userName, out user_id))
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var sqa = new SqlDataAdapter("SELECT COUNT(*) FROM EMPLOYEE_TBL WHERE EMPLOYEE_ID = '" + user_id + "' AND EMPLOYEE_PASSWORD = '" + user_password + "'", connection))
                    {
                        DataTable dt = new DataTable();

                        sqa.Fill(dt); 

                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            loginValid = true;
                        }
                        else
                        {
                            loginValid = false;
                        }
                    }
                }
            }
            return loginValid;
        }
    }
    #endregion
}
