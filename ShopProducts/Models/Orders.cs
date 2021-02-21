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
    class Orders : IOrders
    {
        private static object OrdersTable { get; }

        static Orders()
        {
            OrdersTable = LoadOperationModel.Orders;
        }

        public object GetOrders()
        {
            return OrdersTable;
        }

        public void Update(object data)
        {
            DataTable orders = data as DataTable;

            //if (users == null)
            //{
            //    return;
            //}

            foreach (DataRow order in orders.Rows)
            {
                if (order.RowState == DataRowState.Deleted)
                {
                    this.DeleteOrder(order);
                }
                if (order.RowState == DataRowState.Added)
                {
                    this.InsertOrder(order);
                }
                if (order.RowState == DataRowState.Modified)
                {
                    this.ModifyOrder(order);
                }
            }

            orders.AcceptChanges();
        }


        private void DeleteOrder(DataRow user)
        {
            string commandString = @"DELETE Orders 
                                    WHERE OrderId = @OrderId";

            SqlCommand deleteCommand = new SqlCommand(commandString, DataContext.GetConnection());
            deleteCommand.Parameters.AddWithValue("OrderId", user["OrderId"]);



            DataContext.OpenConnection();
            deleteCommand.ExecuteNonQuery();
            DataContext.CloseConnection();
        }

        private void InsertOrder(DataRow order)
        {
            string commandString = @"INSERT Orders 
                                    VALUES (@UserId, @ProductId, @Quantity);
                                    SELECT OrderId FROM Orders WHERE OrderId = @@IDENTITY";

            SqlCommand insertCommand = new SqlCommand(commandString, DataContext.GetConnection());
            insertCommand.Parameters.AddWithValue("UserId", order["UserId"]);
            insertCommand.Parameters.AddWithValue("Name", order["Name"]);
            insertCommand.Parameters.AddWithValue("@Quantity", order["Quantity"]);
            insertCommand.Parameters.AddWithValue("@Price", order["Price"]);




            DataContext.OpenConnection();
            int currentId = (int)insertCommand.ExecuteScalar();
            DataContext.CloseConnection();

            order.Table.Columns[0].ReadOnly = false;
            order.SetField<int>(0, currentId);
            order.Table.Columns[0].ReadOnly = true;
        }

        private void ModifyOrder(DataRow order)
        {
        }
    }
}
