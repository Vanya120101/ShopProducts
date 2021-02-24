using ShopProducts.Infrastructure;
using ShopProducts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    class MainModel : IMainModel
    {

        IUsers users;
        IProducts products;
        IOrders orders;

        public MainModel(IAbstractShopFactory abstractShopFactory)
        {
            users = abstractShopFactory.CreateUsers();
            products = abstractShopFactory.CreateProducts();
            orders = abstractShopFactory.CreateOrders();
        }

        public object GetOrders()
        {
            return orders.GetOrders();
        }

        public object GetProducts()
        {
            return products.GetProducts();
        }
        public object GetUsers()
        {
            return users.GetUsers();
        }

        public object GetProductsFull()
        {
            return products.GetProductsFull();
        }


        public object GetUsersOrders(int UserId)
        {
            return orders.GetUsersOrders(UserId);
        }

        public bool IsLoginExsist(string login)
        {
            return users.IsLoginExsist(login);
        }

        public bool IsUserExsist(string login, string password)
        {
            return users.IsUserExsist(login, password);
        }

        public void Update(object data)
        {
            //Можно организовать логику обновления

            users.Update(data);
            products.Update(data);
            orders.Update(data);
        }
    }
}
