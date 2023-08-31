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

        private CartActions cartActions;
        private User utilizator;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        private Order order;
        private ProductService produse;
        private Product produs;

        public PnlCheckoutContainer2(Panel panel, MainPage main, User user, OrderService orders, OrderDetailsService orderDetails, ProductService products) : base(panel)
        {
            
        }


       
    }
}
