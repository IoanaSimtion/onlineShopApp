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
    internal class CheckoutFooter : Panel
    {
        private Button next;
        private Button back;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        private ProductService productService;
        MainPage form;
        public CheckoutFooter(Panel panel, MainPage mainPage, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {

            this.form = mainPage;

            this.productService = products;
            this.orderDetailsService = orderDetails;
            this.orderService=orders;

            next = new Button();
            back = new Button();

            next.Text = "Next";
            next.Location = new Point(1550, 40);
            next.Size = new Size(300, 60);
            next.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            next.ForeColor = Color.FromArgb(74, 85, 162);
            next.BackColor = Color.White;

            next.Click += next_Click;

            back.Text = "Back";
            back.Location = new Point(50, 40);
            back.Size = new Size(300, 60);
            back.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            back.ForeColor = Color.FromArgb(74, 85, 162);
            back.BackColor = Color.White;

            back.Click += back_Click; ;

            this.Dock = DockStyle.Bottom;
            this.BackColor = Color.FromArgb(197, 223, 248);
            this.Height = 150;

            this.Controls.Add(next);
            this.Controls.Add(back);
        }

        private void back_Click(object sender, EventArgs e)
        {

            form.removeControl("pnlCheckout");

            this.PerformLayout();

            form.setCartPage(orderService,orderDetailsService,productService);

        }

        private void next_Click(object sender, EventArgs e)
        {
            form.removeControl("pnlCheckout");

            this.PerformLayout();

            //form.setCheckoutPage();

        }
    }
}
