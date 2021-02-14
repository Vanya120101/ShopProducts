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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
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


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PasswordBox.Text);
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
    }
}
