using onlineShop.product.models;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.utils;
using onlineShop.view.footers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.containers
{
    internal class PnlCartContainer : PnlContainer
    {
        //private CartFooter cartFooter;
        private ProductService productService;

        public MainPage main;
        public PnlCartContainer(Panel panel, MainPage mainPage) : base(panel)
        {
           // cartFooter = new CartFooter(panel, mainPage);
            
           // base.Controls.Add(cartFooter);
            this.Name = Constants.CART_CONTAINER;
            this.main = mainPage;
            attachOrderCards();
        }


        public void attachOrderCards()
        {
            productService = new ProductService();

            int x = 30, y = 50 ;

            this.main.cartActions.CartItems.ForEach(item=>{

                Product prod = productService.findProductById(item.Id);

                base.Controls.Add(new OrderCard(this, prod.Id,prod.Name,prod.Price,prod.Description,item.Cantitate,x,y));

                y += 300;

            });
        }

        
    }
}
