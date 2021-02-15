using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface IUpdateControl : IBaseForm
    {
        int ProductsID { get; set; }
        string ProductsName { get; set; }
        int ProductsQuantity { get; set; }
        int ProductsPrice { get; set; }
        event Action UpdateProduct;
        void Update();
    }
}
