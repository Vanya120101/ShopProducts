using ShopProducts.Models;
using ShopProducts.Models.ModelsDB;
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
        public SelectControl(string formName)
        {
            InitializeComponent();
            FormName = formName;
        }
        #endregion
        #region ISelectControl
        public string FormName { get; }

        public object Products
        {
            get
            {
                return ProductsTable.DataSource;

            }
            set
            {
                this.ProductsTable.DataSource = value;
            }

        }



        public event Action CloseForm;

        public void Close()
        {
        }

        public void ShowError(string errorMessage)
        {

        }

        public void UpdateForm()
        {

            this.ProductsTable.Columns[0].HeaderCell.Value = "Продукт";
            this.ProductsTable.Columns[1].HeaderCell.Value = "Количество";
            this.ProductsTable.Columns[2].HeaderCell.Value = "Цена";
            this.ProductsTable.Columns[3].HeaderCell.Value = "Продавец";

            this.ProductsTable.Columns[0].Width = 200;
            this.ProductsTable.Columns[1].Width = 200;
            this.ProductsTable.Columns[2].Width = 200;
            this.ProductsTable.Columns[3].Width = 200;

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.CloseForm?.Invoke();
        }

        public void Clear()
        {
            this.ShowError("");
        }






        #endregion





    }
}
