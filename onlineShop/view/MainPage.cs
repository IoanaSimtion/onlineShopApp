using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.models;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.user.models;
using onlineShop.user.service;
using onlineShop.view.cartPage;
using onlineShop.view.checkoutPage;
using onlineShop.view.containers;
using onlineShop.view.headers;
using onlineShop.view.home;
using onlineShop.view.loginPage;
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
        public ProductService productService;
        public User user;
        public UserService userService;
        public OrderDetailsService orderDetailsService;
        public OrderService orderService;
        


        public MainPage()
        {
            InitializeComponent();                                

            productService = new ProductService();

            userService = new UserService();

            orderService = new OrderService();
            orderDetailsService=new OrderDetailsService();
            
            this.cartActions = new CartActions();

            this.WindowState = FormWindowState.Maximized;

            setLoginPage();

            //setHomePage();

            //setProductsPage();

            //setCartPage();   

            //setCheckoutPage();
        }

        public void MainPage_Load(object sender, EventArgs e)
        {

        }

        public void setLoginPage()
        {

            LoginPage loginPage = new LoginPage(this,productService, orderService, orderDetailsService, userService);
         
        }

        public void setCheckoutPage1(OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            CheckoutPage checkout = new CheckoutPage(this,user,orders,orderDetails,products);

            this.Controls.Add(checkout);
        }
        public void setCheckoutPage2(OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            CheckoutPage2 checkout2 = new CheckoutPage2(this,user,orders,orderDetails,products);

            this.Controls.Add(checkout2);
        }
         public void setCompletedCheckoutPage(OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            CheckoutComplete checkoutComplete = new CheckoutComplete(this,user,orders,orderDetails,products);

            this.Controls.Add(checkoutComplete);
        }

        //public void setHomePage()
        //{
        //    Home home = new Home(this);
        //}

        public void setProductsPage()
        {
            ProductsPage productsPage = new ProductsPage(this, productService, orderService, orderDetailsService);
        }

        public void setCartPage(OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            Cart cart = new Cart(this,orders,orderDetails,products);

            this.Controls.Add(cart);
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
