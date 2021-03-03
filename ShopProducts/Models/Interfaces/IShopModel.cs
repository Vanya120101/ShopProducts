using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IShopModel
    {
        void DeleteProduct(string productName, out string errorMessage);
        void AddProduct(string productName, int productQuantity, int productPrice, out string errorMessage);
        object GetProducts();
        void UpdateProduct(string productName, int productQuantity, int productPrice, out string errorMessage);
        void AddOrder(string productName, int productQuantity, out string errorMessage);
        void EnterAccount(string login, string password, out string errorMessage);
        void RegisterAccount(string login, string password, out string errorMessage);
        void AddOrder(string productName, int productQuantity, out string errorMessage);
    }
}
