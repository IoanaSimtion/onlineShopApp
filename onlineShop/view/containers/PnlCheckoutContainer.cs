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
    public class PnlCheckoutContainer : PnlContainer
    {

        private CartActions cartActions;
        private User utilizator;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        private Order order;
        private ProductService produse;
        private Product produs;

        public PnlCheckoutContainer(Panel panel, MainPage main, User user, OrderService orders, OrderDetailsService orderDetails, ProductService products, CheckoutInfoPanel infoPanel) : base(panel)
        {
            cartActions = main.cartActions;
            this.orderService = orders;
            this.orderDetailsService = orderDetails;
            this.utilizator = user;
            this.produse = products;

            this.orderService = new OrderService();

            this.Controls.Add(infoPanel);

            this.createOrder();
        }


        public void createOrder()
        {
            //etapa1 cream orderul

            this.order = new Order(this.orderService.nextId(),utilizator.Id);
            this.orderService.addOrder(this.order);

            this.orderService.save();

            //etapa2 cream detaliile orderului

            this.cartActions.CartItems.ForEach(ci=>{

                produs = produse.findProductById(ci.Id);

                this.orderDetailsService.addItem(new OrderDetails(produs.Id,order.Id,ci.Cantitate,produs.Price*ci.Cantitate));

            });

            this.orderDetailsService.save();
            
           
        }

    }
}
