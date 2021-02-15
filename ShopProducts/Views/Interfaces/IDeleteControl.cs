﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface IDeleteControl : IBaseForm
    {
        int ID { get; set; }

        event Action Delete;
        void Update();
    }
}
