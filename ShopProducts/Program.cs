using ShopProducts.Controllers;
using ShopProducts.Controllers.Interfaces;
using ShopProducts.Infrastructure;
using ShopProducts.Models;
using ShopProducts.Models.Interfaces;
using ShopProducts.Views;
using ShopProducts.Views.Controlls;
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

            IBaseController registerContoller = new RegisterController(shopModel, new RegisterForm("RegisterForm"));
            IBaseController loginController = new LoginController(shopModel, new LoginForm("LoginForm"));
            IBaseController shopProductsContoller = new ShopProductsController(shopModel, new ShopProductsMainForm("ShopProductsForm"));

            IBaseController selectController = new SelectController(shopModel, new SelectControl("SelectControl"));
            IBaseController insertController = new InsertController(shopModel, new InsertControl("InsertControl"));


            mainController.AddControler(registerContoller);
            mainController.AddControler(loginController);
            mainController.AddControler(shopProductsContoller);

            ((ShopProductsController)shopProductsContoller).AddPage(selectController, "Все товары");
            ((ShopProductsController)shopProductsContoller).AddPage(insertController, "Добавление");


            mainController.Start(loginController);



            Application.Run();











        }
    }
}
