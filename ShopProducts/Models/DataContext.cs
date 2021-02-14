﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    static class DataContext
    {
        private static SqlConnection sqlConnection;
        
        static DataContext()
        {
            string connectionString = GetConnectionString();
            sqlConnection = new SqlConnection(connectionString);
        }

        private static string GetPath()
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(location);
            var path = System.IO.Path.Combine(directory + "\\Models\\DatabaseForShopProducts.mdf");

            return path;
        }

        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            sqlConnectionStringBuilder.AttachDBFilename = GetPath();
            sqlConnectionStringBuilder.IntegratedSecurity = true;

            return sqlConnectionStringBuilder.ConnectionString;
        }

        public static bool OpenConnection()
        {

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                return true;
            }

            return false;
        }

        public static bool CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
                return true;

            }
            return false;
        }

        public static SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}