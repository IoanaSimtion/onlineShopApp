using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.containers
{
    public class PnlCheckoutContainer : PnlContainer
    {
        public PnlCheckoutContainer(Panel panel, MainPage main, OrderService orders, OrderDetailsService orderDetails, ProductService products) : base(panel)
        {

        }

    }
}
