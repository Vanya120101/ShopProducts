using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    static class LoadOperationModel
    {
        private static DataSet shopDataSet;
        public static DataTable Users
        {
            get { return shopDataSet.Tables["Users"]; }
        }
        public static DataTable Products
        {
            get { return shopDataSet.Tables["Products"]; }
        }
        public static DataTable Orders
        {
            get { return shopDataSet.Tables["Orders"]; }
        }
        static LoadOperationModel()
        {
            shopDataSet = new DataSet("Shop");
            LoadData();


        }

        private async static void LoadData()
        {
            string sqlCommandString = "SELECT * FROM Users; SELECT * FROM Products; SELECT * FROM Orders";
            SqlCommand sqlCommand = new SqlCommand(sqlCommandString, DataContext.GetConnection());

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.TableMappings.Add("Table", "Users");
            sqlDataAdapter.TableMappings.Add("Table1", "Products");
            sqlDataAdapter.TableMappings.Add("Table2", "Orders");

            sqlDataAdapter.Fill(shopDataSet);

            //Для асинхронной версии нужен метод для обновления в вью. Не успевает прогрузиться.
            //await Task.Run(() => sqlDataAdapter.Fill(shopDataSet));


        }





    }
}
