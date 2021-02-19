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
    class DeleteOperationModel : IDeleteOperationModel
    {
        private void Delete(object data)
        {
            SqlCommand command = data as SqlCommand;


            DataContext.OpenConnection();

            command.ExecuteNonQuery();

            DataContext.CloseConnection();
        }
        public void DeleteOrders(object data)
        {
            DataRow row = data as DataRow;

            string commandString = @"DELETE Orders 
                                    WHERE OrderId = @OrderId";

            SqlCommand deleteCommand = new SqlCommand(commandString, DataContext.GetConnection());
            deleteCommand.Parameters.AddWithValue("OrderId", row["OrderId"]);


            Delete(deleteCommand);
            row.AcceptChanges();

        }

        public void DeleteProducts(object data)
        {
            DataRow row = data as DataRow;

            string commandString = @"DELETE Products 
                                    WHERE ProductId = @ProductId";

            SqlCommand deleteCommand = new SqlCommand(commandString, DataContext.GetConnection());
            deleteCommand.Parameters.AddWithValue("ProductId", row["ProductId"]);


            Delete(deleteCommand);
            row.AcceptChanges();
        }

        public void DeleteUsers(object data)
        {
            DataRow row = data as DataRow;

            string commandString = @"DELETE Users 
                                    WHERE UserId = @UserId";

            SqlCommand deleteCommand = new SqlCommand(commandString, DataContext.GetConnection());
            deleteCommand.Parameters.AddWithValue("UserId", row["UserId"]);


            Delete(deleteCommand);
            row.AcceptChanges();
        }
    }
}
