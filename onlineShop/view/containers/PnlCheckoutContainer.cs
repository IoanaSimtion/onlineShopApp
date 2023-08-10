using onlineShop.order.models;
using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using onlineShop.system.cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.containers
{
    public class PnlCheckoutContainer : PnlContainer
    {

        private CartActions cartActions;

        private OrderService orderService;
        OrderDetailsService orderDetailsService;

        private Order order;

        public PnlCheckoutContainer(Panel panel, MainPage main, OrderService orders, OrderDetailsService orderDetails, ProductService products) : base(panel)
        {
            cartActions = main.cartActions;
            this.orderService = orders;
            this.orderDetailsService = orderDetailsService;



        }

        public void createOrder()
        {

            //this.order = new Order();

        }

    }
}
