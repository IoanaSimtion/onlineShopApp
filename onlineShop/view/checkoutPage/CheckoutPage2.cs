using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using onlineShop.user.models;
using onlineShop.utils;
using onlineShop.view.containers;
using onlineShop.view.footers;
using onlineShop.view.headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.checkoutPage
{
    internal class CheckoutPage2 : Panel
    {
        private User utilizator;
        public CheckoutPage2(MainPage main, User user, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            this.Dock = DockStyle.Fill;

            this.Name = Constants.CHECKOUT_PANEL2;

            this.utilizator = user;

            this.loadCheckoutPage2(main, orders, orderDetails, products);

        }

        public void loadCheckoutPage2(MainPage form, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            this.Controls.Add(new PnlCheckoutContainer2(this, form, utilizator, orders, orderDetails, products));
            this.Controls.Add(new CheckoutFooter2(this, form, orders, orderDetails, products));
            this.Controls.Add(new CheckoutHeader2(this, form));
        }
    }
}
