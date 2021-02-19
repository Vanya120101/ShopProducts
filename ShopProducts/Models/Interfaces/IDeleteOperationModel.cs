using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IDeleteOperationModel
    {
        void DeleteUsers(object data);
        void DeleteProducts(object data);
        void DeleteOrders(object data);
    }
}
