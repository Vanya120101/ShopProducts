using ShopProducts.Controllers.Interfaces;
using ShopProducts.Models.Interfaces;
using ShopProducts.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Controllers
{
    class UpdateController : IBaseController
    {

        IUpdateControl updateControl;
        IShopModel shopModel;

        public IBaseForm Form
        {
            get
            {
                return updateControl;
            }
        }

        #region Constructs
        public UpdateController(IShopModel shopModel, IUpdateControl updateControl)
        {
            this.shopModel = shopModel;
            this.updateControl = updateControl;
            Initialize();

        }
        private void Initialize()
        {
            updateControl.UpdateProduct += UpdateControl_UpdateProduct;
        }

        #endregion
        private void UpdateControl_UpdateProduct()
        {
            shopModel.UpdateProduct(updateControl.ProductsName, updateControl.ProductsPrice, updateControl.ProductsQuantity, out string errorMessage);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                updateControl.ShowError(errorMessage);
            }
            else
            {
                updateControl.Clear();
            }

        }

        public void Update()
        {

        }
    }
}
