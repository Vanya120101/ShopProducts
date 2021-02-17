using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IInsertOperationModel
    {
        void InsertUsers(object data);
        void InsertProducts(object data);
        void InsertOrders(object data);

    }
}
