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
    public partial class TestView : Form
    {
        public TestView()
        {
            InitializeComponent();
            CartControl cartControl = new CartControl();
            cartControl.Dock = DockStyle.Fill;
            
            this.Controls.Add(cartControl);

           // cartControl.BringToFront();

        }
    }
}
