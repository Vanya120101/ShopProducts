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
    class InsertController : IBaseController
    {
        IInsertControl insertControl;
        IShopModel shopModel;

        public IBaseForm Form
        {
            get
            {
                return insertControl;
            }
        }

        #region Constructs
        public InsertController(IShopModel shopModel, IInsertControl insertControl)
        {
            this.shopModel = shopModel;
            this.insertControl = insertControl;
            Initialize();

        }
        private void Initialize()
        {
            this.insertControl.AddProduct += InsertControl_AddProduct;
        }
        #endregion
        private void InsertControl_AddProduct()
        {
            this.shopModel.AddProduct(insertControl.ProductsName, insertControl.ProductsQuantity, insertControl.ProductsPrice, out string errorMessage);
            this.insertControl.Clear();
            if (!string.IsNullOrEmpty(errorMessage))
            {
                insertControl.ShowError(errorMessage);
            }
        }
        public void Update()
        {

        }
    }
}
