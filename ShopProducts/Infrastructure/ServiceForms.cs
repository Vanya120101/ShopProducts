using ShopProducts.Controllers.Interfaces;
using ShopProducts.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProducts.Infrastructure
{
    static class ServiceForms
    {
        static List<IBaseForm> forms;

        static ServiceForms()
        {
            forms = new List<IBaseForm>();
        }

        public static void AddForm(IBaseForm form)
        {
            forms.Add(form);
        }
        public static void ShowForm(IBaseForm form)
        {
            form.Show();
        }

        public static void ShowForm(string nameForm)
        {
            foreach (IBaseForm form in forms)
            {
                if (form.FormName == nameForm)
                {
                    ShowForm(form);
                    return;
                }
            }
        }

        public static void CloseForm(IBaseForm form)
        {
            form.Visible = false;
            Exit();
        }

        public static void CloseForm(string nameForm)
        {
            foreach (IBaseForm form in forms)
            {
                if (form.FormName == nameForm)
                {
                    CloseForm(form);
                    return;
                }
            }
        }

        private static void Exit()
        {
            foreach (IBaseForm form in forms)
            {
                if (form.Visible == true)
                {
                    return;
                }
            }

            Application.Exit();
        }
    }
}
