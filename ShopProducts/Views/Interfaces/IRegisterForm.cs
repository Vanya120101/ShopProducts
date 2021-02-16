using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface IRegisterForm : IBaseForm
    {
        string UsersLogin { get; set; }
        string UsersPasswrod { get; set; }
        string UsersRepeatedPassword { get; set; }
        event Action Register;
        event Action EnterAccount;
    }
}
