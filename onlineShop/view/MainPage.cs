using onlineShop.product.models;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.view.cartPage;
using onlineShop.view.containers;
using onlineShop.view.headers;
using onlineShop.view.home;
using onlineShop.view.mappers;
using onlineShop.view.productsPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineShop.view
{
    public partial class MainPage : Form
    {        
        
        public CartActions cartActions;


        public MainPage()
        {
            InitializeComponent();
            
            this.cartActions = new CartActions();

            this.WindowState = FormWindowState.Maximized;

            //setHomePage();

            setProductsPage();

            //setCartPage()      
        }

        public void MainPage_Load(object sender, EventArgs e)
        {

        }


        public void setHomePage()
        {
            Home home = new Home(this);
        }

        public void setProductsPage()
        {
            ProductsPage productsPage = new ProductsPage(this);
        }

        public void setCartPage()
        {
            Cart cart = new Cart(this);

        }

    public void removeControl(String name)
        {

            Control aux = null;


            foreach (Control ctrl in this.Controls)
            {

                if (ctrl.Name.Equals(name))
                {
                    aux = ctrl;
                    PerformLayout();
                }

            }

            if (aux != null)
            {
                this.Controls.Remove(aux);
                PerformLayout();
            }

        }
    
    }
}
