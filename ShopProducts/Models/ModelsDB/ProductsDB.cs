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
    class ProductsDB : IProducts
    {   
        private static DataTable ProductsTable { get; }
        static ProductsDB()
        {
            ProductsTable = LoadOperationModelDB.Products as DataTable;
        }
        public object GetProducts()
        {
            return ProductsTable;
        }

        public object GetProductsFull()
        {
            return InformationModelDB.GetProductsFull();
        }
        public void Update()
        {
            
            //if (users == null)
            //{
            //    return;
            //}

            foreach (DataRow product in ProductsTable.Rows)
            {
                if (product.RowState == DataRowState.Deleted)
                {
                    this.DeleteProduct(product);
                }
                if (product.RowState == DataRowState.Added)
                {
                    this.InsertProduct(product);
                }
                if (product.RowState == DataRowState.Modified)
                {
                    this.ModifyProduct(product);
                }
            }

            ProductsTable.AcceptChanges();
        }


        private void DeleteProduct(DataRow product)
        {


            string commandString = @"DELETE Products 
                                    WHERE ProductId = @ProductId";

            SqlCommand deleteCommand = new SqlCommand(commandString, DataContext.GetConnection());
            deleteCommand.Parameters.AddWithValue("ProductId", product["ProductId"]);


            DataContext.OpenConnection();
            deleteCommand.ExecuteNonQuery();
            DataContext.CloseConnection();
        }

        private void InsertProduct(DataRow product)
        {

            string commandString = @"INSERT Products 
                                    VALUES (@UserId, @Name, @Quantity, @Price);
                                    SELECT ProductId FROM Products WHERE ProductId = @@IDENTITY";

            SqlCommand insertCommand = new SqlCommand(commandString, DataContext.GetConnection());
            insertCommand.Parameters.AddWithValue("UserId", product["UserId"]);
            insertCommand.Parameters.AddWithValue("Name", product["Name"]);
            insertCommand.Parameters.AddWithValue("@Quantity", product["Quantity"]);
            insertCommand.Parameters.AddWithValue("@Price", product["Price"]);


            DataContext.OpenConnection();
            int currentId = (int)insertCommand.ExecuteScalar();
            DataContext.CloseConnection();

            product.Table.Columns[0].ReadOnly = false;
            product.SetField<int>(0, currentId);
            product.Table.Columns[0].ReadOnly = true;
        }

        private void ModifyProduct(DataRow product)
        {

            string commandString = "UPDATE Products " +
                                   "SET Name = @Name," +
                                   "Price = @Price," +
                                   "Quantity= @Quantity";

            SqlCommand modifyCommand = new SqlCommand(commandString, DataContext.GetConnection());
            modifyCommand.Parameters.AddWithValue("Name", product["Name"]);
            modifyCommand.Parameters.AddWithValue("Price", product["Price"]);
            modifyCommand.Parameters.AddWithValue("Quantity", product["Quantity"]);

            DataContext.OpenConnection();
            modifyCommand.ExecuteNonQuery();
            DataContext.CloseConnection();
        }
    }
}
