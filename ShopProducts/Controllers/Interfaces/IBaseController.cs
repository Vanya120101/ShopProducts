using ShopProducts.Models.Interfaces;
using ShopProducts.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Controllers.Interfaces
{
    interface IBaseController
    {
        void SetView(IBaseForm baseForm);
        void SetModel(IShopModel shopModel);
        void ShowForm();
    }
}
