using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using onlineShop.user.models;
using onlineShop.utils;
using onlineShop.view.containers;
using onlineShop.view.headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.checkoutPage
{
    internal class CheckoutComplete : Panel
    {
        private User utilizator;
        public CheckoutComplete(MainPage main, User user, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            this.Dock = DockStyle.Fill;

            this.Name = Constants.CHECKOUT_PANEL3;

            this.utilizator = user;

            this.loadCheckoutPage2(main, orders, orderDetails, products);

        }

        public void loadCheckoutPage2(MainPage form, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            this.Controls.Add(new PnlCompleteCheckout(this, form, utilizator, orders, orderDetails, products));
            this.Controls.Add(new CheckoutCompleteHeader(this, form));
        }
    }
}
