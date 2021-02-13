using ShopProducts.Views.Controlls;
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
    public partial class ShopProductsMainForm : Form
    {
        public ShopProductsMainForm()
        {
            InitializeComponent();

            AddMenuItem(new SelectControl(), "Ассортимент");
            AddMenuItem(new InsertControl(), "Добавить");
            AddMenuItem(new UpdateControl(), "Обновить");
            AddMenuItem(new DeleteControl(), "Удалить");
            AddMenuItem(new CartControl(), "Корзина");



        }

        public void AddMenuItem(UserControl userControl, string nameOfPage)
        {
            userControl.Dock = DockStyle.Fill;

            TabPage tabPage = new TabPage(nameOfPage);
            tabPage.Controls.Add(userControl);

            this.TabControl.Controls.Add(tabPage);

        }
    }
}
