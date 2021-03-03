using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.Interfaces
{
    interface IUsers
    {
        object UsersTable { get; }
        int CurrentUserId { get; set; }
        bool EnterAccount(string login, string password, out string errorMessage);
        void AddUser(string login, string password, out string errorMessage);

        void Update();



    }
}
