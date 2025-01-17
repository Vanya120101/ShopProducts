﻿using ShopProducts.Models;
using ShopProducts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Infrastructure
{
    class ShopDBFactory : IAbstractShopFactory
    {
        public IOrders CreateOrders()
        {
            return new OrdersDB();
        }

        public IProducts CreateProducts()
        {
            return new ProductsDB();
        }

        public IUsers CreateUsers()
        {
            return new UsersDB();
        }
    }
}
