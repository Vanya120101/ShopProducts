using ShopProducts.Models;
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
    public partial class SelectControl : UserControl, ISelectControl
    {
        #region Constructs
        public SelectControl()
        {
            InitializeComponent();
        }
        #endregion
        #region ISelectControl
        public object Products { get => this.ProductsTable.DataSource; set => this.ProductsTable.DataSource = value; }

        public event Action CloseForm;

        public void ShowError(string errorMessage)
        {
        }

        public void UpdateForm()
        {
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.CloseForm?.Invoke();
        }
        #endregion





    }
}
