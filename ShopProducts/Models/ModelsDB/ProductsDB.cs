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
        private static DataTable productsTable;
        public object ProductsTable
        {
            get { return productsTable; }
        }
        static ProductsDB()
        {
            productsTable = LoadOperationModelDB.Products as DataTable;
        }
        public void ChangeProduct(string productName, int priceProduct, int quantityProduct)
        {
            foreach (DataRow product in productsTable.Rows)
            {
                if ((string)product["Name"] == productName)
                {
                    product["Price"] = priceProduct;
                    product["Quantity"] = quantityProduct;
                }
            }
        }
        
        public void AddProduct(int userId, string productName, int productQuantity, int price)
        {
            DataRow newProduct = productsTable.NewRow();
            newProduct["Userid"] = userId;
            newProduct["Name"] = productName;
            newProduct["Quantity"] = productQuantity;
            newProduct["Price"] = price;

            productsTable.Rows.Add(newProduct);
            this.Update();
        }
        public void DeleteProudct(int productId)
        {
            productsTable.Rows.Find(productId).Delete();
            this.Update();
        }
        public int GetProductId(string productName, out string errorMessage)
        {
            errorMessage = "";
            var query = from product in productsTable.AsEnumerable()
                        where product.Field<string>("Name") == productName
                        select new
                        {
                            ProductId = (int)product["ProductId"]
                        };

            if (query.ToList().Count == 1)
            {
               return query.ToList()[0].ProductId;
            }
            else if (query.ToList().Count > 1)
            {
                errorMessage = "ОШИБКА: Продуктов с таким логином больше одного";
                return -1;
            }
            else
            {
                errorMessage = "Продуктов с таким именем нет";
                return -1;
            }
        }
        public object GetProductsFull()
        {
            return InformationModelDB.GetProductsFull();
        }

        #region Work with DB
        public void Update()
        {
            foreach (DataRow product in productsTable.Rows)
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

            productsTable.AcceptChanges();
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
                                   "Quantity= @Quantity" +
                                   "WHERE ProductId = @ProductId";

            SqlCommand modifyCommand = new SqlCommand(commandString, DataContext.GetConnection());
            modifyCommand.Parameters.AddWithValue("Name", product["Name"]);
            modifyCommand.Parameters.AddWithValue("Price", product["Price"]);
            modifyCommand.Parameters.AddWithValue("Quantity", product["Quantity"]);

            DataContext.OpenConnection();
            modifyCommand.ExecuteNonQuery();
            DataContext.CloseConnection();
        }
        #endregion
    }
}
