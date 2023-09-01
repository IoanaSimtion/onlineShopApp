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
    internal class CheckoutPage : Panel
    {
        private User utilizator;
        private CheckoutInfoPanel infoPanel;
        public CheckoutPage(MainPage main, User user, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            this.Dock = DockStyle.Fill;

            this.Name = Constants.CHECKOUT_PANEL;

            this.utilizator = user;

            this.infoPanel = new CheckoutInfoPanel();

            this.loadCheckoutPage(main,orders,orderDetails,products);

        }

        public void loadCheckoutPage(MainPage form, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            this.Controls.Add(new PnlCheckoutContainer(this, form, utilizator, orders, orderDetails, products,infoPanel));
            this.Controls.Add(new CheckoutFooter(this,form, orders, orderDetails, products,infoPanel));
            this.Controls.Add(new CheckoutHeader(this, form));
        }
    }
}
