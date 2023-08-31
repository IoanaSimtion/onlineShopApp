using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.footers
{
    internal class CartFooter : Panel
    {
        private ProductService productService;
        private Button checkout;
        private Button continueShopping;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        
        MainPage form;
        public CartFooter(Panel panel, MainPage mainPage, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {

            this.form = mainPage;

            this.orderDetailsService = orderDetails;
            this.orderService = orders;
            this.productService = products;

            checkout = new Button();
            continueShopping = new Button();

            checkout.Text = "Checkout";
            checkout.Location = new Point(1550, 40);
            checkout.Size = new Size(300, 60);
            checkout.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            checkout.ForeColor = Color.FromArgb(74, 85, 162);
            checkout.BackColor = Color.White;

            checkout.Click += checkout_Click;

            continueShopping.Text = "Continue shopping";
            continueShopping.Location = new Point(50, 40);
            continueShopping.Size = new Size(300, 60);
            continueShopping.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            continueShopping.ForeColor = Color.FromArgb(74, 85, 162);
            continueShopping.BackColor = Color.White;

            continueShopping.Click += continueShopping_Click;

            this.Dock = DockStyle.Bottom;
            this.BackColor = Color.FromArgb(197, 223, 248);
            this.Height = 150;

            this.Controls.Add(checkout);
            this.Controls.Add(continueShopping);
        }

        private void continueShopping_Click(object sender, EventArgs e)
        {

            productService = new ProductService();

            form.removeControl("pnlCart");

            this.PerformLayout();

            form.setProductsPage();

        }
        
        private void checkout_Click(object sender, EventArgs e)
        {
            form.removeControl("pnlCart");

            this.PerformLayout();

            form.setCheckoutPage1(orderService,orderDetailsService,productService);

        }

    }
}
