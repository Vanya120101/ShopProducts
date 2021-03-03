using ShopProducts.Views.Controlls;
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
    public partial class ShopProductsMainForm : Form, IShopProductsMainForm
    {
        #region Constructs
        public ShopProductsMainForm(string formName)
        {
            InitializeComponent();
            FormName = formName;
            AddMenuItem(new SelectControl("SelectForm"), "Ассортимент");
            AddMenuItem(new InsertControl("InsertForm"), "Добавить");
            AddMenuItem(new UpdateControl("UpdateControl"), "Обновить");
            AddMenuItem(new DeleteControl("DeleteControl"), "Удалить");
            AddMenuItem(new CartControl("CartControl"), "Корзина");
        }

        #endregion

        #region IShopProductsMainForm
        public string FormName { get; }
        public event Action CloseForm;
        public event Action RefreshEverything;

        public void AddMenuItem(UserControl userControl, string nameOfPage)
        {
            userControl.Dock = DockStyle.Fill;

            TabPage tabPage = new TabPage(nameOfPage);
            tabPage.Controls.Add(userControl);

            this.TabControl.Controls.Add(tabPage);

        }

        public void ShowError(string errorMessage)
        {
        }

        public void UpdateForm()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Methods
        private void ExitMainMenu_Click(object sender, EventArgs e)
        {
            this.CloseForm?.Invoke();
        }

        private void RefreshMainMenu_Click(object sender, EventArgs e)
        {
            this.RefreshEverything?.Invoke();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (CloseForm != null)
            {
                this.CloseForm();
            }
        }

        public void Clear()
        {

        }
        #endregion

    }
}
