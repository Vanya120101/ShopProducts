﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IProducts
    {
        object GetProducts();
        void Update(object data);
        object GetProductsFull();
    }
}
