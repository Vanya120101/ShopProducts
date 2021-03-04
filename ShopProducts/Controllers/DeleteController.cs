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
    class DeleteController : IBaseController
    {

        IDeleteControl deleteControl;
        IShopModel shopModel;

        public IBaseForm Form
        {
            get
            {
                return deleteControl;
            }
        }

        #region Constructs
        public DeleteController(IShopModel shopModel, IDeleteControl deleteControl)
        {
            this.shopModel = shopModel;
            this.deleteControl = deleteControl;
            Initialize();

        }
        private void Initialize()
        {
            deleteControl.DeleteProduct += DeleteControl_DeleteProduct;
        }

        private void DeleteControl_DeleteProduct()
        {
            shopModel.DeleteProduct(deleteControl.ProductName, out string errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
            {
                deleteControl.Clear();
            }
            else
            {
                deleteControl.ShowError(errorMessage);
            }
        }
        #endregion

        public void Update()
        {

        }

    }
}
