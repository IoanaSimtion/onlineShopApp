using onlineShop.order.service;
using onlineShop.orderDetails.service;
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
        private OrderDetailsService orderDetailsService;
        private OrderService orderService;
        private Label empty;
        public MainPage main;
        public PnlCartContainer(Panel panel, MainPage mainPage, OrderService orders, OrderDetailsService orderDetails, ProductService products) : base(panel)
        {
            this.orderDetailsService = orderDetails;
            this.orderService = orders;
            this.productService = products;
            empty = new Label();
            empty.Text = "Your cart is empty";
            empty.Font = new Font("Century Gothic", 26, FontStyle.Regular);
            empty.Location = new Point(770, 300);
            empty.Size = new Size(300, 300);
            empty.Width = 1000;
            empty.ForeColor = Color.FromArgb(128, 0, 64);
            this.Name = Constants.CART_CONTAINER;
            this.main = mainPage;

            this.Controls.Add(empty);

            attachOrderCards();

        }


        public void attachOrderCards()
        {           

            productService = new ProductService();

            int x = 30, y = 50 ;

            this.main.cartActions.CartItems.ForEach(item=>{

                this.Controls.Remove(empty);

                Product prod = productService.findProductById(item.Id);

                base.Controls.Add(new OrderCard(main, this, prod.Id, prod.Name, prod.Price*item.Cantitate, prod.Description, item.Cantitate, x, y,orderService,orderDetailsService,productService));

                y += 300;

            });
        }

        public bool validateCartInfo()
        {
            string text = "";

            if (empty.Text == "Your cart is empty")
            {
                text += "Your cart is empty \n";
            }

            if (text.Length > 0)
            {
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
