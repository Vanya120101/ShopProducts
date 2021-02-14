using ShopProducts.Models;
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
    public partial class CartControl : UserControl
    {
        int i = 0;
        public CartControl()
        {
            InitializeComponent();
           
        }

        private  void AddCartProductButton_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                this.UserProductsTable.DataSource = LoadOperationModel.Users;

            }

            if (i == 1)
            {
                this.UserProductsTable.DataSource = LoadOperationModel.Products;

            }

            if (i == 2)
            {
                this.UserProductsTable.DataSource = LoadOperationModel.Orders;

            }

            i++;


        }
    }
}
