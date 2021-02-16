using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface ILoadOperationModel
    {
        object Users { get; }
        object Products { get; }
        object Orders { get; }
    }
}
