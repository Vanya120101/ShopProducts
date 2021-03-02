using ShopProducts.Controllers.Interfaces;
using ShopProducts.Models.Interfaces;
using ShopProducts.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Controllers.ControlControllers
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
            this.cartControl.CloseForm += CartControl_CloseForm;
        }

        private void CartControl_CloseForm()
        {
            //Реализовать закрытие контрола???
        }

        private void CartControl_AddIntoCart()
        {
            if (string.IsNullOrEmpty(cartControl.ProductsName) && !(cartControl.ProductsQuintity > 0))
            {
                cartControl.ShowError("Формы заполнены некорректно");
            }
            else if(!shopModel.isProductExsist(cartControl.ProductsName))
            {
                cartControl.ShowError("Продукта с таким именем не существует");
            }
            else if(!shopModel.isProductEnough(cartControl.ProductsName, cartControl.ProductsQuintity))
            {
                cartControl.ShowError("Количества продукта недостаточно");
            }
            else
            {
                cartControl.AddIntoCart();
            }
            
        }
        #endregion
    }
}
