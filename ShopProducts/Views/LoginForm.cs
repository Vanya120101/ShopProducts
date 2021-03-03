using ShopProducts.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProducts.Views
{
    public partial class LoginForm : Form, ILoginForm
    {

        #region Constructors
        public LoginForm(string formName)
        {
            InitializeComponent();
            FormName = formName;
        }
        #endregion


        #region ILoginForm
        public string FormName { get; }

        public string UsersLogin { get => this.LoginBox.Text; set => this.LoginBox.Text = value; }
        public string UsersPassword { get => this.PasswordBox.Text; set => this.PasswordBox.Text = value; }

        public event Action Register;
        public event Action EnterAccount;
        public event Action CloseForm;

        public void ShowError(string errorMessage)
        {
            this.ErrorLabel.Text = errorMessage;
        }
        public void UpdateForm()
        {
        }

        #endregion


        #region Methods
        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text== "Введите логин")
            {
                this.LoginBox.Text = "";
                this.LoginBox.ForeColor = Color.Black;
            }

        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginBox.Text))
            {
                this.LoginBox.Text = "Введите логин";
                this.LoginBox.ForeColor = Color.Silver;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Введите пароль")
            {
                this.PasswordBox.Text = "";
                this.PasswordBox.UseSystemPasswordChar = true;
                this.PasswordBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordBox.Text))
            {
                this.PasswordBox.Text = "Введите пароль";
                this.PasswordBox.UseSystemPasswordChar = false;
                this.PasswordBox.ForeColor = Color.Silver;
            }
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            EnterAccount?.Invoke();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register?.Invoke();
        }
        #endregion

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (CloseForm != null)
            {
                this.CloseForm();
            }
        }

        public void Clear()
        {
            this.UsersLogin = "Введите логин";
            this.UsersPassword = "Введите пароль";
            this.LoginBox.ForeColor = Color.Silver;
            this.PasswordBox.ForeColor = Color.Silver;
            this.PasswordBox.UseSystemPasswordChar = false;
            this.ShowError("");
        }
    }
}
