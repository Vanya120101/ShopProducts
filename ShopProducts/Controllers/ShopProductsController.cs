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
    class ShopProductsController : IBaseController
    {
        IShopProductsMainForm shopProductsForm;
        IShopModel shopModel;
        List<IBaseController> controllers;
        public IBaseForm Form
        {
            get
            {
                return shopProductsForm;
            }
        }

        #region Constructs
        public ShopProductsController(IShopModel shopModel, IShopProductsMainForm shopProductsForm)
        {
            this.shopModel = shopModel;
            this.shopProductsForm = shopProductsForm;
            controllers = new List<IBaseController>();
            Initialize();

        }
        private void Initialize()
        {
            this.shopProductsForm.CloseForm += ShopProductsForm_CloseForm;
            this.shopProductsForm.RefreshEverything += Update;
        }
        #endregion

        #region IShopProductsMainFormHandler
        public void Update()
        {
            foreach (IBaseController controller in controllers)
            {
                controller.Update();
            }
        }

        private void ShopProductsForm_CloseForm()
        {
            ServiceForms.CloseForm(shopProductsForm);
        }
        #endregion

        public void AddPage(IBaseController controllerOfPage, string nameOfUserControl)
        {
            shopProductsForm.AddMenuItem((UserControl)controllerOfPage.Form, nameOfUserControl);
            controllers.Add(controllerOfPage);
        }

        
    }
}
