﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IOrders
    {
        object OrdersTable { get; }
        void Update();
        object GetUsersOrders(int UserId);
    }
}
