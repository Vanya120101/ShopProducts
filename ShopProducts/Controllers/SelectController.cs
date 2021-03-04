using ShopProducts.Controllers.Interfaces;
using ShopProducts.Models.Interfaces;
using ShopProducts.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Controllers
{
    class SelectController : IBaseController
    {

        ISelectControl selectControl;
        IShopModel shopModel;

        public IBaseForm Form
        {
            get
            {
                return selectControl;
            }
        }

        #region Constructs
        public SelectController(IShopModel shopModel, ISelectControl selectControl)
        {
            this.shopModel = shopModel;
            this.selectControl = selectControl;
            Initialize();

        }
        private void Initialize()
        {
            this.selectControl.Products = shopModel.GetProducts();
            selectControl.UpdateForm();
        }

        public void Update()
        {
            this.selectControl.Products = shopModel.GetProducts();

        }
        #endregion
    }
}
