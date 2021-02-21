using ShopProducts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProducts.Models.OperationWithDataBase
{
    static class LoadOperationModel
    {
        private static readonly DataSet shopDataSet = new DataSet("Shop");

        public  static object Users
        {
            get { return shopDataSet.Tables["Users"]; }
        }
        public  static object Products
        {
            get { return shopDataSet.Tables["Products"]; }
        }
        public  static object Orders
        {
            get { return shopDataSet.Tables["Orders"]; }
        }
        static LoadOperationModel()
        {
            LoadData();
            AddRelationsToDataSet();

        }

        private static void LoadData()
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

        private static void AddRelationsToDataSet()
        {
            DataRelation UsersProductsRel = new DataRelation("Users_Products", 
                ((DataTable)Users).Columns["UserId"], 
                ((DataTable)Products).Columns["UserId"],
                true);


            DataRelation ProductsOrdersRel = new DataRelation("Products_Orders", 
                ((DataTable)Products).Columns["ProductId"], 
                ((DataTable)Orders).Columns["ProductId"], 
                true);


            DataRelation UsersOrdersRel = new DataRelation("Users_Orders", 
                ((DataTable)Users).Columns["UserId"], 
                ((DataTable)Orders).Columns["UserId"], 
                true);

            shopDataSet.Relations.AddRange(new DataRelation[] { UsersProductsRel, ProductsOrdersRel, UsersOrdersRel });


        }

        public static void Test()
        {
            string sum = "";

            foreach (DataRow user in ((DataTable)Users).Rows)
            {
                sum += user["FirstName"];

                DataRow[] products = user.GetChildRows("Users_Products");

                foreach (var product in products)
                {
                    sum += product["Name"];

                }
            }
            MessageBox.Show(sum);
        }





    }
}
