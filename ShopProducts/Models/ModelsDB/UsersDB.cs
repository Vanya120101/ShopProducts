using ShopProducts.Models.Interfaces;
using ShopProducts.Models.ModelsDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    class UsersDB : IUsers
    {

        private static DataTable usersTable;
        public object UsersTable
        {
            get
            {
                return usersTable;
            }
        }
        public int CurrentUserId { get; set; }

        static UsersDB()
        {
            usersTable = LoadOperationModelDB.Users as DataTable;
        }



    
        public bool EnterAccount(string login, string password, out string errorMessage)
        {
            errorMessage = "";

            var query = from user in usersTable.AsEnumerable()
                        where user.Field<string>("UsersLogin") == login && user.Field<string>("Password") == password
                        select new
                        {
                            Id = (int)user["UserId"]
                        };

            if (query.ToList().Count == 1)
            {
                CurrentUserId = query.ToList()[0].Id;
                return true;
            }
            else if (query.ToList().Count > 1)
            {
                errorMessage = "ОШИБКА: Пользователей с таким логином больше одного";
                return false;
            }
            else
            {
                errorMessage = "Логин или пароль введены неправильно";
                return false;
            }
        }

        public void AddUser(string login, string password, out string errorMessage)
        {
            errorMessage = "";
            if (!LoginExsist(login))
            {
                DataRow newUser = usersTable.NewRow();
                newUser["UsersLogin"] = login;
                newUser["Password"] = password;
                usersTable.Rows.Add(newUser);
                this.Update();
            }
            else
            {
                errorMessage = "Логин занят";
            }


        }

        #region Methods
        private bool LoginExsist(string login)
        {
            var query = from user in usersTable.AsEnumerable()
                        where user.Field<string>("UsersLogin") == login
                        select new { };
            if (query.ToList().Count > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Work with DB
        public void Update()
        {

            //if (users == null)
            //{
            //    return;
            //}

            foreach (DataRow user in usersTable.Rows)
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

            usersTable.AcceptChanges();
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
                                    VALUES (@UsersLogin, @Password);
                                    SELECT UserId FROM Users WHERE UserId = @@IDENTITY";

            SqlCommand insertCommand = new SqlCommand(commandString, DataContext.GetConnection());
            insertCommand.Parameters.AddWithValue("UsersLogin", user["UsersLogin"]);
            insertCommand.Parameters.AddWithValue("Password", user["Password"]);


            DataContext.OpenConnection();
            int currentId = (int)insertCommand.ExecuteScalar();
            DataContext.CloseConnection();

            user.Table.Columns[0].ReadOnly = false;
            user.SetField<int>(0, currentId);
            user.Table.Columns[0].ReadOnly = true;
        }

        private void ModifyUser(DataRow user)
        {
            //string commandString = "UPDATE Customers " +
            //                       "SET FirstName = @FirstName," +
            //                       "SecondName = @SecondName," +
            //                       "Age= @Age";

            //SqlCommand modifyCommand = new SqlCommand(commandString, DataContext.GetConnection());
            //modifyCommand.Parameters.AddWithValue("FirstName", user["FirstName"]);
            //modifyCommand.Parameters.AddWithValue("SecondName", user["SecondName"]);
            //modifyCommand.Parameters.AddWithValue("Age", user["Age"]);

            //DataContext.OpenConnection();
            //modifyCommand.ExecuteNonQuery();
            //DataContext.CloseConnection();
        }

        #endregion
    }
}
