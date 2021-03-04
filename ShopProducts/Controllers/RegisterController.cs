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
    class RegisterController : IBaseController
    {
        IRegisterForm registerForm;
        IShopModel shopModel;

        public IBaseForm Form
        {
            get
            {
                return registerForm;
            }
        }
        #region Constructs
        public RegisterController(IShopModel shopModel, IRegisterForm registerForm)
        {
            this.shopModel = shopModel;
            this.registerForm = registerForm;
            Initialize();

        }

        #endregion 

       

       

        #region IRegisterFormHandler


        private void RegisterForm_EnterAccount()
        {
            ServiceForms.ShowForm("LoginForm");
            ServiceForms.CloseForm(registerForm);
         
 
        }

        private void RegisterForm_Register()
        {
            shopModel.RegisterAccount(registerForm.UsersLogin, registerForm.UsersPasswrod, out string errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                registerForm.ShowError(errorMessage);
                return;
            }

            MessageBox.Show("Вы успешны зарегестрированы");

            ServiceForms.ShowForm("LoginForm");
            ServiceForms.CloseForm(registerForm);

        }

        private void RegisterForm_CloseForm()
        {
            ServiceForms.CloseForm(registerForm);
  
        }
        #endregion

        #region Methods

        private void Initialize()
        {
            registerForm.CloseForm += RegisterForm_CloseForm;
            registerForm.Register += RegisterForm_Register;
            registerForm.EnterAccount += RegisterForm_EnterAccount;
        }

        public void Update()
        {

        }
        #endregion






    }
}
