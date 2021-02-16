using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProducts.Views.Interfaces
{
    interface IShopProductsMainForm : IBaseForm
    {
        void AddMenuItem(UserControl userControl, string nameOfPage);
        event Action RefreshEverything;
    }
}
