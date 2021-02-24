using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IOrders
    {
        object GetOrders();
        void Update(object data);
        object GetUsersOrders(int UserId)
    }
}
