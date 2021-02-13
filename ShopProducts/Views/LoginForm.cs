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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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
    }
}
