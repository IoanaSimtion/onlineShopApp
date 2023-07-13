using onlineShop.product.service;
using onlineShop.user.service;
using onlineShop.view;

namespace onlineShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginPage());
            Application.Run(new MainPage());
            Application.Run(new Cart());

            //ProductService produse = new ProductService();

            //produse.afisare();

            //UserService users = new UserService();

            //users.afisare();

            //CRUD->create read update detele
        }
    }
}