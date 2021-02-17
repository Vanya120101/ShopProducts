using ShopProducts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    class InsertOperationModel : IInsertOperationModel
    {
        private int currentId;
        private void Insert(object data)
        {
            SqlCommand command = data as SqlCommand;


            DataContext.OpenConnection();
            currentId =  (int)command.ExecuteScalar();

            DataContext.CloseConnection();

        }

        public void InsertOrders(object data)
        {
            DataRow row = data as DataRow;

            string commandString = @"INSERT Orders 
                                    VALUES (@UserId, @ProductId, @Quantity);
                                    SELECT OrderId FROM Orders WHERE OrderId = @@IDENTITY";

            SqlCommand insertCommand = new SqlCommand(commandString, DataContext.GetConnection());
            insertCommand.Parameters.AddWithValue("UserId", row["UserId"]);
            insertCommand.Parameters.AddWithValue("Name", row["Name"]);
            insertCommand.Parameters.AddWithValue("@Quantity", row["Quantity"]);
            insertCommand.Parameters.AddWithValue("@Price", row["Price"]);

            Insert(insertCommand);

            row.Table.Columns[0].ReadOnly = false;
            row.SetField<int>(0, currentId);
            row.Table.Columns[0].ReadOnly = true;
            row.AcceptChanges();
        }

        public void InsertProducts(object data)
        {
            DataRow row = data as DataRow;

            string commandString = @"INSERT Products 
                                    VALUES (@UserId, @Name, @Quantity, @Price);
                                    SELECT ProductId FROM Products WHERE ProductId = @@IDENTITY";

            SqlCommand insertCommand = new SqlCommand(commandString, DataContext.GetConnection());
            insertCommand.Parameters.AddWithValue("UserId", row["UserId"]);
            insertCommand.Parameters.AddWithValue("Name", row["Name"]);
            insertCommand.Parameters.AddWithValue("@Quantity", row["Quantity"]);
            insertCommand.Parameters.AddWithValue("@Price", row["Price"]);

            Insert(insertCommand);

            row.Table.Columns[0].ReadOnly = false;
            row.SetField<int>(0, currentId);
            row.Table.Columns[0].ReadOnly = true;
            row.AcceptChanges();
        }

        public void InsertUsers(object data)
        {
            DataRow row = data as DataRow;

            string commandString = @"INSERT Users 
                                    VALUES (@UsersLogin, @Password, @FirstName, @SecondName, @Age);
                                    SELECT UserId FROM Users WHERE UserId = @@IDENTITY";

            SqlCommand insertCommand = new SqlCommand(commandString, DataContext.GetConnection());
            insertCommand.Parameters.AddWithValue("UsersLogin", row["UsersLogin"]);
            insertCommand.Parameters.AddWithValue("Password", row["Password"]);
            insertCommand.Parameters.AddWithValue("@FirstName", row["FirstName"]);
            insertCommand.Parameters.AddWithValue("@SecondName", row["SecondName"]);
            insertCommand.Parameters.AddWithValue("@Age", row["Age"]);

            Insert(insertCommand);

            row.Table.Columns[0].ReadOnly = false;
            row.SetField<int>(0, currentId);
            row.Table.Columns[0].ReadOnly = true;
            row.AcceptChanges();



        }
    }
}
