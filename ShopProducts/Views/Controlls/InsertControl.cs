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

namespace ShopProducts.Views.Controlls
{
    public partial class InsertControl : UserControl, IInsertControl
    {
        #region Constructs
        public InsertControl(string formName)
        {
            InitializeComponent();
            FormName = formName;
        }
        #endregion

        #region IInsertControl
        public string FormName { get; }

        public string ProductsName { get => this.ProductsNameBox.Text; set => this.ProductsNameBox.Text = value; }
        public int ProductsQuantity
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
        public int ProductsPrice
        {
            get
            {
                if (int.TryParse(this.ProductsPriceBox.Text, out int price))
                {
                    return price;
                }
                return -1;
            }
            set
            {
                this.ProductsPriceBox.Text = value.ToString();
            }

        }

        public event Action AddProduct;
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
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.CloseForm?.Invoke();
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.AddProduct?.Invoke();
        }

        public void Close()
        {
        }
        public void Clear()
        {
            this.ProductsName = null;
            this.ProductsPrice = -1;
            this.ProductsPriceBox.Clear();
            this.ProductsQuantity = -1;
            this.ProductsQuantityBox.Clear();

            this.ShowError("");
        }
        #endregion
    }
}
