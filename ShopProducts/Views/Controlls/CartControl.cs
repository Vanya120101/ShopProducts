using ShopProducts.Models;
using ShopProducts.Models.ModelsDB;
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
        public CartControl(string formName)
        {
            InitializeComponent();
            FormName = formName;
        }
        #endregion

        #region ICartControl
        public string FormName { get; }


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

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ShowError(string errorMessage)
        {
            this.ErrorLabel.Text = errorMessage;
        }

        public void UpdateForm()
        {

            this.UserProductsTable.Columns[0].HeaderCell.Value = "Продукт";
            this.UserProductsTable.Columns[1].HeaderCell.Value = "Количество";
            this.UserProductsTable.Columns[2].HeaderCell.Value = "Цена";


            this.UserProductsTable.Columns[0].Width = 200;
            this.UserProductsTable.Columns[1].Width = 200;
            this.UserProductsTable.Columns[2].Width = 200;

            this.UserProductsTable.AllowUserToResizeRows = false;

        }

        public void Clear()
        {
            this.ProductsName = null;
            this.ProductsNameBox.Clear();
            this.ProductsQuintity = -1;
            this.ProductsQuantityBox.Clear();
            
            this.ShowError("");
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
