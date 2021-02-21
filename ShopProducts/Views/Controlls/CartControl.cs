using ShopProducts.Models;
using ShopProducts.Models.OperationWithDataBase;
using ShopProducts.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProducts.Views.Controlls
{
    public partial class CartControl : UserControl, ICartControl
    {
        #region Constructs
        public CartControl()
        {
            InitializeComponent();
            this.UserProductsTable.DataSource = new InformationModel().GetProductsFull();
        }
        #endregion

        #region ICartControl

        public string ProductsName { get => this.ProductsNameBox.Text; set => this.ProductsNameBox.Text = value; }
        public int ProductsQuintity
        {
            get
            {
                if (int.TryParse(ProductsQuantityBox.Text, out int count))
                {
                    return count;
                }
                return -1;
            }
            set
            {
                this.ProductsQuantityBox.Text = value.ToString();
            }
        }
        public object UsersOrders { get => this.UserProductsTable.DataSource; set => this.UserProductsTable.DataSource = value; }

        public event Action AddIntoCart;
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
        private void AddProductIntoCartButton_Click(object sender, EventArgs e)
        {
            this.AddIntoCart?.Invoke();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.CloseForm?.Invoke();
        }
        #endregion
    }
}
