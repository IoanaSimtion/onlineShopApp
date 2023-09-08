using onlineShop.orderDetails.models;
using onlineShop.order.models;
using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.user.models;
using onlineShop.user.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using onlineShop.product.models;
using onlineShop.view.checkoutPage;

namespace onlineShop.view.containers
{
    public class PnlCheckoutContainer2 : PnlContainer
    {
        private int x;
        private int y;
        private User utilizator;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        private ProductService produse;
        private MainPage form;
        private int totalPrice;

        public PnlCheckoutContainer2(Panel panel, MainPage main, User user, OrderService orders, OrderDetailsService orderDetails, ProductService products) : base(panel)
        {
            this.utilizator = user;
            this.orderService = orders;
            this.orderDetailsService = orderDetails;
            this.produse = products;
            this.form = main;
            this.attatchCheckoutCards();
            this.Controls.Add(new CheckoutDataPanel(user, x, y, totalPrice));
        }

        void attatchCheckoutCards()
        {

            x = 30;
            y = 50;

            this.form.cartActions.CartItems.ForEach(item => {


                Product prod = produse.findProductById(item.Id);

                this.Controls.Add(new CheckoutCard(form, this, prod.Id, prod.Name, prod.Price * item.Cantitate, prod.Description, item.Cantitate, x, y, orderService, orderDetailsService, produse));

                y += 300;

                totalPrice += prod.Price * item.Cantitate;

            });
        }
    }
       
}
