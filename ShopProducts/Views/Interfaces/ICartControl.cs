using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface ICartControl
    {
        string NameProduct { get; set; }
        string Quintity { get; set; }
        object UsersProducts { get; set; }

        event Action AddIntoCart;
        event Action Update;

    }
}
