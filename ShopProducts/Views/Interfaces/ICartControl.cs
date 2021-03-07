using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface ICartControl : IBaseForm
    {
        string ProductsName { get; set; }
        string ProductsNameForDelete { get; set; }
        int ProductsQuintity { get; set; }
        object UsersOrders { get; set; }

        event Action AddIntoCart;
        event Action DeleteFromCart;


    }
}
