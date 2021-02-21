using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    class InformationModel
    {
        static DataTable users;
        static DataTable orders;
        static DataTable products;
       
        static InformationModel()
        {
            users = new Users().GetUsers() as DataTable;
            orders = new Orders().GetOrders() as DataTable;
            products = new Products().GetProducts() as DataTable;
        }

        public object GetUsersOrders(int UserId)
        {
            DataView usersOrdersView = new DataView();
            usersOrdersView.Table = orders as DataTable;
            usersOrdersView.RowFilter = $"UserId = {UserId}";

            return usersOrdersView;
        }

        public bool IsLoginExsist(string login)
        {
            var query = from user in users.AsEnumerable()
                        where user.Field<string>("UsersLogin") == login
                        select new { };
            if (query.ToList().Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool IsUserExsist(string login, string password)
        {
            var query = from user in users.AsEnumerable()
                        where user.Field<string>("UsersLogin") == login && user.Field<string>("Password") == password
                        select new 
                        { 
                        
                        };
            if (query.ToList().Count > 0)
            {
                return true;
            }
            return false;
        }

        public object GetProductsFull()
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
