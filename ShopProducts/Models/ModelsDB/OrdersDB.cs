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
    class OrdersDB : IOrders
    {
        private static DataTable OrdersTable { get; }

        static OrdersDB()
        {
            OrdersTable = LoadOperationModelDB.Orders as DataTable;
        }

        public object GetOrders()
        {
            return OrdersTable;
        }

        public object GetUsersOrders(int UserId)
        {
            DataView usersOrdersView = new DataView();
            usersOrdersView.Table = OrdersTable as DataTable;
            usersOrdersView.RowFilter = $"UserId = {UserId}";

            return usersOrdersView;
        }

        public void Update()
        {

            //if (users == null)
            //{
            //    return;
            //}

            foreach (DataRow order in OrdersTable.Rows)
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

            OrdersTable.AcceptChanges();
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
