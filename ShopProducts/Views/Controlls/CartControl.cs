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
        public CartControl()
        {
            InitializeComponent();
           
        }

        private  void AddCartProductButton_Click(object sender, EventArgs e)
        {

            this.UserProductsTable.DataSource = BaseOperationModel.Users;
        }
    }
}
