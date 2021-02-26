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
    public partial class DeleteControl : UserControl, IDeleteControl
    {
        #region Construcs
        public DeleteControl(string formName)
        {
            InitializeComponent();
            FormName = formName;
        }
        #endregion

        #region IDeleteControl
        public string FormName { get; }

        public int ID
        {
            get
            {
                if (int.TryParse(this.ProductsIdBox.Text, out int Id))
                {
                    return Id;
                }
                return -1;
            }
            set
            {
                this.ProductsIdBox.Text = value.ToString();
            }
        }

        public event Action DeleteProduct;
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
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            this.DeleteProduct?.Invoke();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.CloseForm?.Invoke();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
