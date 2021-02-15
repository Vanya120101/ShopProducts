using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface IInsertControl : IBaseForm
    {
        string ProductsName { get; set; }
        int ProductsQuantity { get; set; }
        int ProductsPrice { get; set; }
        event Action AddProduct;
        void Update();
    }
}
