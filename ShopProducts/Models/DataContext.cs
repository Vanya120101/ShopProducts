using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProducts.Models
{
    class DataContext
    {
        public DataContext()
        {
        }

        private string CreatePath()
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(location);
            var path = System.IO.Path.Combine(directory + "\\Models\\DatabaseForShopProducts.mdf");

            return path;
        }

        private string GetStringConnection()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

            stringBuilder.AttachDBFilename = CreatePath();
            stringBuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            stringBuilder.IntegratedSecurity = true;

            return stringBuilder.ConnectionString;

        }

        public void OpenConnection()
        {

        }
    }
}
