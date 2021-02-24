using ShopProducts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Infrastructure
{
    interface IAbstractShopFactory
    {
        IOrders CreateOrders();
        IProducts CreateProducts();
        IUsers CreateUsers();

    }
}
