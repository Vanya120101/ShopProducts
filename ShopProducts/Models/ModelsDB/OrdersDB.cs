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
        private static DataTable ordersTable;
        public object OrdersTable
        {
            get
            {
                return ordersTable;
            }
        }

        static OrdersDB()
        {
            ordersTable = LoadOperationModelDB.Orders as DataTable;
        }
        
        public void AddOrder(int userId, int productId, int quantityProduct)
        {
            DataRow newOrder = ordersTable.NewRow();
            newOrder["UserId"] = userId;
            newOrder["ProductId"] = productId;
            newOrder["Quantity"] = quantityProduct;

            ordersTable.Rows.Add(newOrder);
            this.Update();
        }

        public void DeleteOrderFromCart(int userId, int productId, out string errorMessage)
        {
            errorMessage = "Заказа с таким имененем не найдено";
            foreach (DataRow order in ordersTable.Rows)
            {
                
                if ((int)order["ProductId"] == productId)
                {
                    if ((int)order["UserId"] == userId)
                    {
                        order.Delete();
                        errorMessage = "";
                        break;
                    }
                }
            }

            this.Update();
        }
  

       

        public object GetUsersOrders(int UserId)
        {
            return InformationModelDB.GetUsersOrders(UserId);
        }







        #region Work with DB
        public void Update()
        {
            foreach (DataRow order in ordersTable.Rows)
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

            ordersTable.AcceptChanges();
        }

        private void DeleteOrder(DataRow user)
        {
            string commandString = @"DELETE Orders 
                                    WHERE OrderId = @OrderId";

            SqlCommand deleteCommand = new SqlCommand(commandString, DataContext.GetConnection());
            deleteCommand.Parameters.AddWithValue("OrderId", user["OrderId", DataRowVersion.Original]);



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
            insertCommand.Parameters.AddWithValue("@ProductId", order["ProductId"]);
            insertCommand.Parameters.AddWithValue("@Quantity", order["Quantity"]);



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
        #endregion
    }
}
