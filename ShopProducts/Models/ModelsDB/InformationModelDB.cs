using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.ModelsDB
{
    /// <summary>
    /// Класс костыль для объединения двух и более таблиц.
    /// </summary>
    static class InformationModelDB
    {
        static DataTable users;
        static DataTable orders;
        static DataTable products;
       
        static InformationModelDB()
        {
            users = new UsersDB().UsersTable as DataTable;
            orders = new OrdersDB().OrdersTable as DataTable;
            products = new ProductsDB().ProductsTable as DataTable;
        }

 
        public static object GetProductsFull()
        {

            var query = from product in products.AsEnumerable()
                        join user in users.AsEnumerable()
                        on product["UserId"] equals user["UserId"]
                        select new
                        {
                            ProductsName = product["Name"],
                            ProductsQuantity = product["Quantity"],
                            ProductsPrice = product["Price"],
                            SellersName = user["FirstName"].ToString() + user["SecondName"].ToString()
                        };



            return query.ToList();
        }

        public static object GetUsersOrders(int userId)
        {
            var query = from order in orders.AsEnumerable()
                        join product in products.AsEnumerable()
                        on order["ProductId"] equals product["ProductId"]
                        where (int)order["UserId"] == userId
                        select new
                        {
                            ProductName = product["Name"],
                            OrderQuantity = order["Quantity"],
                            Price = product["Price"]
                        };

            return query.ToList();
        }





    }
}
