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
    public partial class RegisterForm : Form, IRegisterForm
    {
        #region Constructs
        public RegisterForm(string formName)
        {
            InitializeComponent();
            FormName = formName;
        }
        #endregion


        #region IRegisterForm
        public string FormName { get; }
        public string UsersLogin { get => this.LoginBox.Text; set => this.LoginBox.Text = value; }
        public string UsersPasswrod { get => this.PasswordBox.Text; set => this.PasswordBox.Text = value; }
        public string UsersRepeatedPassword { get => this.RepeatPasswordBox.Text; set => this.RepeatPasswordBox.Text = value; }

        public event Action EnterAccount;
        public event Action Register;
        public event Action CloseForm;

        public void ShowError(string errorMessage = "")
        {
            this.ErrorLabel.Text = errorMessage;
        }

        public void UpdateForm()
        {
        }
        #endregion


        #region Methods

     
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.ShowError();
            Register?.Invoke();
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            this.ShowError();

            EnterAccount?.Invoke();
        }
        private void TextBox_EnterLeave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string finalString = "Введите " + textBox.Tag.ToString();

            if (textBox.Text == finalString)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
            else if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = finalString;
                textBox.ForeColor = Color.Silver;
            }


        }



        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            TextBox passwordBox = sender as TextBox;

            if (string.IsNullOrEmpty(passwordBox.Text))
            {
                passwordBox.Text = "Введите пароль";
                passwordBox.UseSystemPasswordChar = false;
                passwordBox.ForeColor = Color.Silver;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            TextBox passwordBox = sender as TextBox;
            if (passwordBox.Text == "Введите пароль")
            {
                passwordBox.Text = "";
                passwordBox.UseSystemPasswordChar = true;
                passwordBox.ForeColor = Color.Black;
            }

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (CloseForm != null)
            {
                this.CloseForm();
            }
        }





        #endregion

    }
}
