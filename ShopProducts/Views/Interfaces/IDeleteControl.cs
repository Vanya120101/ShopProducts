using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface IDeleteControl : IBaseForm
    {
        string ProductName { get; set; }

        event Action DeleteProduct;
        void Update();
    }
}
