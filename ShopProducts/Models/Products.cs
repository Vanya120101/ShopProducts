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
    class Products : IProducts
    {   
        private static object ProductsTable { get; }
        static Products()
        {
            ProductsTable = LoadOperationModel.Products;
        }
        public object GetProducts()
        {
            return ProductsTable;
        }

        public object GetProductsFull()
        {
            return InformationModel.GetProductsFull();
        }
        public void Update(object data)
        {
            DataTable products = data as DataTable;

            //if (users == null)
            //{
            //    return;
            //}

            foreach (DataRow product in products.Rows)
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

            products.AcceptChanges();
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
