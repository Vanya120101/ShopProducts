using ShopProducts.Controllers.Interfaces;
using ShopProducts.Models.Interfaces;
using ShopProducts.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProducts.Controllers
{
    class MainController
    {
        IShopModel ShopModel;
        Dictionary<string, IBaseController> Controllers;
        public MainController(IShopModel shopModel)
        {
            Controllers = new Dictionary<string, IBaseController>();
            ShopModel = shopModel;
        }

        public void SetViewToController(string controllersName, IBaseController baseController, IBaseForm baseForm)
        {
            baseController.SetView(baseForm);
            baseController.SetModel(ShopModel);
            Controllers.Add(controllersName, baseController);
        }



        public void ShowForm(string controllersName)
        {
            Controllers[controllersName].ShowForm();
        }
    }
}
