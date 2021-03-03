using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProducts.Views.Interfaces
{
    interface ISelectControl : IBaseForm
    {
        object Products { get; set; }
    }
}
