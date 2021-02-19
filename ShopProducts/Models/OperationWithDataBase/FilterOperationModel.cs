using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models.OperationWithDataBase
{
    class FilterOperationModel
    {
        LoadOperationModel LoadOperationModel;
        public FilterOperationModel()
        {
            LoadOperationModel = new LoadOperationModel();
        }

        public object GetUsersOrders(int UserId)
        {
            DataView usersOrders = new DataView();
            usersOrders.Table = LoadOperationModel.Orders as DataTable;
            usersOrders.RowFilter = $"UserId = {UserId}";

            return usersOrders;
        }

        public object GetProducts()
        {
            DataView products = new DataView();
            products.Table = LoadOperationModel.Products as DataTable;
            products.RowFilter = "Quantity > 0";

            return products;
        }
    }
}
