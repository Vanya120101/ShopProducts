using ShopProducts.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.OperationWithDataBase
{
    class ModifyOperationModel : IModifyOperationModel
    {
        public void ModifyUsers(object data)
        {
            DataRow row = data as DataRow;

            string commandString = "UPDATE Customers " +
                                   "SET FirstName = @FirstName," +
                                   "SecondName = @SecondName," +
                                   "Age= @Age";

            SqlCommand modifyCommand = new SqlCommand(commandString, DataContext.GetConnection());
            modifyCommand.Parameters.AddWithValue("FirstName", row["FirstName"]);
            modifyCommand.Parameters.AddWithValue("SecondName", row["SecondName"]);
            modifyCommand.Parameters.AddWithValue("Age", row["Age"]);

            Modify(modifyCommand);

            row.AcceptChanges();
        }

        public void ModifyProducts(object data)
        {
            DataRow row = data as DataRow;

            string commandString = "UPDATE Products " +
                                   "SET Name = @Name," +
                                   "Price = @Price," +
                                   "Quantity= @Quantity";

            SqlCommand modifyCommand = new SqlCommand(commandString, DataContext.GetConnection());
            modifyCommand.Parameters.AddWithValue("Name", row["Name"]);
            modifyCommand.Parameters.AddWithValue("Price", row["Price"]);
            modifyCommand.Parameters.AddWithValue("Quantity", row["Quantity"]);

            Modify(modifyCommand);

            row.AcceptChanges();
        }

        public void ModifyOrders(object data)
        {
        }

        private void Modify(object data)
        {

            SqlCommand command = data as SqlCommand;


            DataContext.OpenConnection();
            command.ExecuteNonQuery();
            DataContext.CloseConnection();
        }
    }
}
