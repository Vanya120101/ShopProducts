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
    class CartController : IBaseController
    {
        ICartControl cartControl;
        IShopModel shopModel;

        public IBaseForm Form
        {
            get
            {
                return cartControl;
            }
        }

        #region Constructs
        public CartController(IShopModel shopModel, ICartControl cartControl)
        {
            this.shopModel = shopModel;
            this.cartControl = cartControl;
            Initialize();

        }
        private void Initialize()
        {
            this.cartControl.AddIntoCart += CartControl_AddIntoCart;
            this.cartControl.UsersOrders = this.shopModel.GetUsersOrders();
            this.cartControl.UpdateForm();
        }

        private void CartControl_AddIntoCart()
        {
            shopModel.AddOrder(cartControl.ProductsName, cartControl.ProductsQuintity, out string errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
            {
                cartControl.Clear();
            }
            else
            {
                cartControl.ShowError(errorMessage);
            }

        }

        public void Update()
        {
            this.cartControl.UsersOrders = this.shopModel.GetUsersOrders();

        }
        #endregion
    }
}
