using ShopProducts.Controllers;
using ShopProducts.Infrastructure;
using ShopProducts.Models;
using ShopProducts.Models.Interfaces;
using ShopProducts.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProducts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dataDir;
#if DEBUG
            dataDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
#else
            dataDir = AppDomain.CurrentDomain.BaseDirectory;
#endif
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IShopModel shopModel = new ShopModel(new ShopDBFactory());
            MainController mainController = new MainController(shopModel);
            
            mainController.SetViewToController("RegisterController", new RegisterController(), new RegisterForm());
            mainController.SetViewToController("LoginForm", new LoginController(), new LoginForm());
            mainController.ShowForm("RegisterController");

            Application.Run();
            

         
        }
    }
}
