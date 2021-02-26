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
    class LoginController : IBaseController
    {


        ILoginForm loginForm;
        IShopModel shopModel;

        public IBaseForm Form
        {
            get
            {
                return loginForm;
            }
        }

        #region Constructs
        public LoginController(IShopModel shopModel, ILoginForm loginForm)
        {
            this.shopModel = shopModel;
            this.loginForm = loginForm;
            Initialize();

        }

        #endregion 
     


        #region ILoginFormHandler
        private void LoginForm_Register()
        {
            ServiceForms.ShowForm("RegisterForm");
            ServiceForms.CloseForm(loginForm);
        }

        private void LoginForm_EnterAccount()
        {
            MessageBox.Show("Вход выполнить");
        }

        private void LoginForm_CloseForm()
        {
            ServiceForms.CloseForm(loginForm);

        }

        #endregion
        #region Methods

        private void Initialize()
        {
            loginForm.CloseForm += LoginForm_CloseForm;
            loginForm.EnterAccount += LoginForm_EnterAccount;
            loginForm.Register += LoginForm_Register;
        }

        #endregion
    }

}

