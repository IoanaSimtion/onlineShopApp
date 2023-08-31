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
    internal class CheckoutFooter2 : Panel
    {
        private Button finish;
        private Button back;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        private ProductService productService;
        MainPage form;
        public CheckoutFooter2(Panel panel, MainPage mainPage, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {

            this.form = mainPage;

            this.productService = products;
            this.orderDetailsService = orderDetails;
            this.orderService = orders;

            finish = new Button();
            back = new Button();

            finish.Text = "Next";
            finish.Location = new Point(1550, 40);
            finish.Size = new Size(300, 60);
            finish.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            finish.ForeColor = Color.FromArgb(74, 85, 162);
            finish.BackColor = Color.White;

            finish.Click += finish_Click;

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

            this.Controls.Add(finish);
            this.Controls.Add(back);
        }

        private void back_Click(object sender, EventArgs e)
        {

            form.removeControl("pnlCheckout2");

            this.PerformLayout();

            form.setCheckoutPage1(orderService, orderDetailsService, productService);

        }

        private void finish_Click(object sender, EventArgs e)
        {
            form.removeControl("pnlCheckout");

            this.PerformLayout();


        }
    }
}
