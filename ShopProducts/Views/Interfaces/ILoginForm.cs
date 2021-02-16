using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Views.Interfaces
{
    interface ILoginForm : IBaseForm
    {
        string UsersLogin { get; set; }
        string UsersPassword { get; set; }

        event Action EnterAccount;
        event Action Register;
    }
}
