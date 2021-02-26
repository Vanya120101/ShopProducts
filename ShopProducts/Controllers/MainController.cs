using ShopProducts.Controllers.Interfaces;
using ShopProducts.Infrastructure;
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
        List<IBaseController> controllers;
        public MainController(IShopModel shopModel)
        {
            ShopModel = shopModel;
            controllers = new List<IBaseController>();
        }

        public void AddControler(IBaseController controller)
        {
            controllers.Add(controller);
            ServiceForms.AddForm(controller.Form);
        }

        public void Start(IBaseForm form)
        {
            ServiceForms.ShowForm(form);
        }
        public void Start(IBaseController controller)
        {
            this.Start(controller.Form);
        }





    }
}
