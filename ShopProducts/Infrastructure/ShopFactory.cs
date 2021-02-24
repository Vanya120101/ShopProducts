using ShopProducts.Models;
using ShopProducts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Infrastructure
{
    class ShopFactory : IAbstractShopFactory
    {
        public IOrders CreateOrders()
        {
            return new Orders();
        }

        public IProducts CreateProducts()
        {
            return new Products();
        }

        public IUsers CreateUsers()
        {
            return new Users();
        }
    }
}
