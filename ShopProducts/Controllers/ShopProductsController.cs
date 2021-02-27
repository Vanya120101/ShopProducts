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
            Initialize();

        }
        private void Initialize()
        {
            this.shopProductsForm.CloseForm += ShopProductsForm_CloseForm;
            this.shopProductsForm.RefreshEverything += ShopProductsForm_RefreshEverything;
        }
        #endregion

        #region IShopProductsMainFormHandler
        private void ShopProductsForm_RefreshEverything()
        {
            MessageBox.Show("Всё обновлено");
        }

        private void ShopProductsForm_CloseForm()
        {
            ServiceForms.CloseForm(shopProductsForm);
        }
        #endregion

        
    }
}
