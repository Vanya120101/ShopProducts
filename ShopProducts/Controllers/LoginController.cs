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
    class LoginController : IBaseController
    {
        ILoginForm loginForm;
        IShopModel shopModel;
        public LoginController()
        {

        }

        public void SetModel(IShopModel shopModel)
        {
            this.shopModel = shopModel;
        }

        public void SetView(IBaseForm baseForm)
        {
            loginForm = baseForm as ILoginForm;
        }

        public void ShowForm()
        {
            loginForm.Show();
        }
    }

}

