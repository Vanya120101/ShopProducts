using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IProducts
    {
        object ProductsTable { get; }
        void ChangeProduct(int userId, string productName, int priceProduct, int quantityProduct, out string errorMessage);
        void AddProduct(int userId, string productName, int productQuantity, int price, out string errorMessage);
        void DeleteProudct(int userId, string productName, out string errorMessage);
        int GetProductId(string productName, out string errorMessage);
        void Update();
        object GetProductsFull();
    }
}
