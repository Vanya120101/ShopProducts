﻿using System;
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
            users = new UsersDB().GetUsers() as DataTable;
            orders = new OrdersDB().GetOrders() as DataTable;
            products = new ProductsDB().GetProducts() as DataTable;
        }

 
        public static object GetProductsFull()
        {

            var query = from product in products.AsEnumerable()
                        join user in users.AsEnumerable()
                        on product["UserId"] equals user["UserId"]
                        where product.Field<int>("Quantity") > 0
                        select new
                        {
                            ProductId = product["ProductId"],
                            SellersName = user["FirstName"].ToString() + user["SecondName"].ToString(),
                            ProductsName = product["Name"],
                            ProductsQuantity = product["Quantity"],
                            ProductsPrice = product["Price"]
                        };


            return query.ToList();
        }






    }
}