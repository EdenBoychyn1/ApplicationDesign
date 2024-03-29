﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDesign.Db
{
    public abstract class DbConnection
    {

        /// <summary>
        /// Store the connection string to the database into the connectionString property 
        /// </summary>
        private readonly string connectionString;


        /// <summary>
        /// Public constructor that initializes the Db Connection string
        /// </summary>
        public DbConnection()
        {
            connectionString = "Data Source=LAPTOP-0FETGFJO;Initial Catalog=KingWilliamHotelDatabase;Integrated Security=True";


        }


        /// <summary>
        /// Create a SqlConnection object function that returns an SqlConnection object 
        /// </summary>
        /// <returns></returns>
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
