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

            user = new User("client, noe902wef, marcus@gmail.com, PArolAmarCUS, Marcus Stoica, Romania Bucuresti Sectorul 2 Str Livezii Nr 11, True, 12 / 05 / 2023, False");

            productService = new ProductService();

            userService = new UserService();

            orderService = new OrderService();
            orderDetailsService=new OrderDetailsService();
            
            this.cartActions = new CartActions();

            this.WindowState = FormWindowState.Maximized;

            setLoginPage(productService, orderService, orderDetailsService);

            //setHomePage();

            //setProductsPage(productService,orderService,orderDetailsService);

            //setCartPage();   

            //setCheckoutPage();
        }

        public void MainPage_Load(object sender, EventArgs e)
        {

        }

        public void setLoginPage(ProductService productService, OrderService orders, OrderDetailsService orderDetails)
        {

            LoginPage loginPage = new LoginPage(this, productService, orders, orderDetails, userService);
        }

        public void setCheckoutPage(OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            CheckoutPage checkout = new CheckoutPage(this,orders,orderDetails,products);

            this.Controls.Add(checkout);
        }

        public void setHomePage()
        {
            Home home = new Home(this);
        }

        public void setProductsPage(ProductService productService, OrderService orders, OrderDetailsService orderDetails)
        {
            ProductsPage productsPage = new ProductsPage(this,productService,orders,orderDetails);
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
