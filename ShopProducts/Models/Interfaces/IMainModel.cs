using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IMainModel
    {
        object Users { get; set; }
        object Products { get; set; }
        object Orders { get; set; }

        void Update();
        void Insert();
        void Delete();
        void Select();

    }
}
