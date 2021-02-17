using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IModifyOperationModel
    {
        void ModifyUsers(object data);
        void ModifyProducts(object data);
        void ModifyOrders(object data);

    }
}
