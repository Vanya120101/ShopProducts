using ShopProducts.Infrastructure;
using ShopProducts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    class ShopModel : IShopModel
    {
        #region Construct
        IUsers users;
        IProducts products;
        IOrders orders;


        public ShopModel(IAbstractShopFactory abstractShopFactory)
        {
            users = abstractShopFactory.CreateUsers();
            products = abstractShopFactory.CreateProducts();
            orders = abstractShopFactory.CreateOrders();
        }

        #endregion

        #region User
        public void EnterAccount(string login, string password, out string errorMessage)
        {
            users.EnterAccount(login, password, out string error);
            errorMessage = error;
        }

        public void RegisterAccount(string login, string password, out string errorMessage)
        {
            users.AddUser(login, password, out string error);
            errorMessage = error;
        }

        #endregion

        #region Order
        public void AddOrder(string productName, int productQuantity, out string errorMessage)
        {
            int productId = products.GetProductId(productName, out string error);
            errorMessage = error;

            if (!string.IsNullOrEmpty(errorMessage))
            { 
                return;
            }

            int userId = users.CurrentUserId;

            orders.AddOrder(userId, productId, productQuantity);
        }

        public object GetUsersOrders()
        {
            return this.orders.GetUsersOrders(users.CurrentUserId);
        }
        #endregion

        #region Product
        public void DeleteProduct(string productName, out string errorMessage)
        {
            products.DeleteProudct(productName, out string error);
            errorMessage = error;
        }

        public void AddProduct(string productName, int productQuantity, int productPrice, out string errorMessage)
        {
            int userId = users.CurrentUserId;
            products.AddProduct(userId, productName, productQuantity, productPrice, out string error);
            errorMessage = error;
        }

        public object GetProducts()
        {
            return products.GetProductsFull();
        }

        public void UpdateProduct(string productName, int productQuantity, int productPrice, out string errorMessage)
        {
            this.products.ChangeProduct(productName, productQuantity, productPrice, out string error);
            errorMessage = error;
        }


        #endregion




    }
}
