using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IUsers
    {
        void Update();
        object GetUsers();
        bool IsUserExsist(string login, string password);
        bool IsLoginExsist(string login);


    }
}
