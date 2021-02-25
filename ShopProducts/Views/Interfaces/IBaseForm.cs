using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface IBaseForm
    {
        void ShowError(string errorMessage);
        void UpdateForm();
        void Show();
        event Action CloseForm;


    }
}
