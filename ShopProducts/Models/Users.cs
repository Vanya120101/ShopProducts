using ShopProducts.Models.Interfaces;
using ShopProducts.Models.OperationWithDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    class Users : IUsers
    {
        private static DataTable UsersTable { get; }

        static Users()
        {
            UsersTable = LoadOperationModel.Users as DataTable;
        }
        public object GetUsers()
        {
            return UsersTable;
        }


        public  bool IsLoginExsist(string login)
        {
            var query = from user in UsersTable.AsEnumerable()
                        where user.Field<string>("UsersLogin") == login
                        select new { };
            if (query.ToList().Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool IsUserExsist(string login, string password)
        {

            var query = from user in UsersTable.AsEnumerable()
                        where user.Field<string>("UsersLogin") == login && user.Field<string>("Password") == password
                        select new
                        {

                        };
            if (query.ToList().Count > 0)
            {
                return true;
            }
            return false;
        }

        public void Update(object data)
        {
            DataTable users = data as DataTable;

            //if (users == null)
            //{
            //    return;
            //}

            foreach (DataRow user in users.Rows)
            {
                if (user.RowState == DataRowState.Deleted)
                {
                    this.DeleteUser(user);
                }
                if (user.RowState == DataRowState.Added)
                {
                    this.InsertUser(user);
                }
                if (user.RowState == DataRowState.Modified)
                {
                    this.ModifyUser(user);
                }
            }

            users.AcceptChanges();
        }


        private void DeleteUser(DataRow user)
        {
            string commandString = @"DELETE Users
                                    WHERE UserId = @UserId";

            SqlCommand deleteCommand = new SqlCommand(commandString, DataContext.GetConnection());
            deleteCommand.Parameters.AddWithValue("UserId", user["UserId"]);

            DataContext.OpenConnection();
            deleteCommand.ExecuteNonQuery();
            DataContext.CloseConnection();
        }

        private void InsertUser(DataRow user)
        {
            string commandString = @"INSERT Users 
                                    VALUES (@UsersLogin, @Password, @FirstName, @SecondName, @Age);
                                    SELECT UserId FROM Users WHERE UserId = @@IDENTITY";

            SqlCommand insertCommand = new SqlCommand(commandString, DataContext.GetConnection());
            insertCommand.Parameters.AddWithValue("UsersLogin", user["UsersLogin"]);
            insertCommand.Parameters.AddWithValue("Password", user["Password"]);
            insertCommand.Parameters.AddWithValue("@FirstName", user["FirstName"]);
            insertCommand.Parameters.AddWithValue("@SecondName", user["SecondName"]);
            insertCommand.Parameters.AddWithValue("@Age", user["Age"]);


            DataContext.OpenConnection();
            int currentId = (int)insertCommand.ExecuteScalar();
            DataContext.CloseConnection();

            user.Table.Columns[0].ReadOnly = false;
            user.SetField<int>(0, currentId);
            user.Table.Columns[0].ReadOnly = true;
        }

        private void ModifyUser(DataRow user)
        {
            string commandString = "UPDATE Customers " +
                                   "SET FirstName = @FirstName," +
                                   "SecondName = @SecondName," +
                                   "Age= @Age";

            SqlCommand modifyCommand = new SqlCommand(commandString, DataContext.GetConnection());
            modifyCommand.Parameters.AddWithValue("FirstName", user["FirstName"]);
            modifyCommand.Parameters.AddWithValue("SecondName", user["SecondName"]);
            modifyCommand.Parameters.AddWithValue("Age", user["Age"]);

            DataContext.OpenConnection();
            modifyCommand.ExecuteNonQuery();
            DataContext.CloseConnection();
        }
    }
}
