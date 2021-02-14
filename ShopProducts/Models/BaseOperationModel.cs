using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    static class BaseOperationModel
    {
        public static DataTable Users { get; set; }
        static BaseOperationModel()
        {
            LoadUsers();
        }

        private static void LoadUsers()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users", DataContext.GetConnection());

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable users = new DataTable();

            sqlDataAdapter.Fill(users);

            Users = users;
        }



    }
}
