using ShopProducts.Models;
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
    public partial class SelectControl : UserControl
    {
        public SelectControl()
        {
            InitializeComponent();

            this.ProductsTable.DataSource = BaseOperationModel.Users;
        }


    }
}
