using ShopProducts.Controllers.Interfaces;
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
        public RegisterController()
        {

        }
        public void SetView(IBaseForm baseForm)
        {
            registerForm = baseForm as IRegisterForm;
            Initialize();
        }
        public void SetModel(IShopModel shopModel)
        {
            this.shopModel = shopModel;
        }
        private void Initialize()
        {
            registerForm.CloseForm += RegisterForm_CloseForm;
            registerForm.Register += RegisterForm_Register;
            registerForm.EnterAccount += RegisterForm_EnterAccount;
        }

        private void RegisterForm_EnterAccount()
        {
            MessageBox.Show("войти в аккаунт");
        }

        private void RegisterForm_Register()
        {

            if (string.IsNullOrEmpty(registerForm.UsersLogin) || registerForm.UsersLogin == "Введите логин")
            {
                registerForm.ShowError("Логин не может быть пустым");
                return;
            }
            if (string.IsNullOrEmpty(registerForm.UsersPasswrod) || registerForm.UsersPasswrod == "Введите пароль")
            {
                registerForm.ShowError("Пароль не может быть пустым");
                return;
            }
            if (registerForm.UsersPasswrod != registerForm.UsersRepeatedPassword)
            {
                registerForm.ShowError("Пароли не совпадают");
                return;
            }

            bool isLoginExsist = shopModel.IsLoginExsist(registerForm.UsersLogin);

            if (isLoginExsist)
            {
                registerForm.ShowError("Логин занят");
                return;
            }

            shopModel.AddUser(registerForm.UsersLogin, registerForm.UsersPasswrod);






        }

        private void RegisterForm_CloseForm()
        {
            Application.Exit();
        }

        public void ShowForm()
        {
            registerForm.Show();
        }
    }
}
