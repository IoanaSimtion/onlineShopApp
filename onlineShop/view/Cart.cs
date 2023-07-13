using onlineShop.order.models;
using onlineShop.order.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineShop.view
{
    public partial class Cart : Form
    {
        private Panel pnlContainer;
        private Panel pnlHeader;
        private Panel pnlHeader2;
        private Panel pnlFooter;
        private Label titlu;
        private Label cart;
        private Label emptyCart;
        private OrderService orderService;
        public Cart()
        {
            InitializeComponent();
            orderService = new OrderService();
            setContainer(); 
            setHeader2();
            setHeader();
            setFooter();

            this.WindowState = FormWindowState.Maximized;
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        public void setHeader()
        {
            titlu = new Label();
            titlu.Text = "Online shop";
            titlu.Location = new Point(850, 30);
            titlu.Size = new Size(300, 300);
            titlu.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            titlu.ForeColor = Color.White;

            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.FromArgb(74, 85, 162);
            pnlHeader.Height = 94;

            pnlHeader.Controls.Add(titlu);
            this.Controls.Add(pnlHeader);
        }
        private void setHeader2()
        {            
            cart = new Label();
            cart.Text = "Your Cart";
            cart.Location = new Point(10, 15);
            cart.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            cart.ForeColor = Color.FromArgb(74, 85, 162);

            pnlHeader2 = new Panel();
            pnlHeader2.Dock = DockStyle.Top;
            pnlHeader2.BackColor = Color.FromArgb(197, 223, 248);
            pnlHeader2.Height = 53;

            pnlHeader2.Controls.Add(cart);
            this.Controls.Add(pnlHeader2);

        }
        private void PopulateContainer(Panel container)
        {

            List<Order> orders = orderService.Orders;

            if (orderService == null)
            {
                emptyCart = new Label();
                emptyCart.Text = "Your cart is empty";
                emptyCart.Location = new Point(600, 650);
                emptyCart.Font = new Font("Century Gothic", 20, FontStyle.Bold);
                this.Controls.Add(emptyCart);
            }

            //int x = 0, y = 80, k = 1;

            //for (int i = 0; i < orders.Count(); i++)
            //{

            //    Card card = ProductMappers.productToCardMapper(container, orders[i], x, y);

            //    x += card.Width + 100;

            //    if (k == 3)
            //    {
            //        x = 0;
            //        y += card.Height + 80;

            //        k = 1;
            //    }
            //    else
            //    {
            //        k++;
            //    }
            //}
        }
        public void setFooter()
        {

            Button checkout = new Button();
            Button continueShopping = new Button();

            checkout.Text = "Checkout";
            checkout.Location = new Point(1550, 40);
            checkout.Size = new Size(300, 60);
            checkout.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            checkout.ForeColor = Color.FromArgb(74, 85, 162);
            checkout.BackColor = Color.White;
            

            continueShopping.Text = "Continue shopping";
            continueShopping.Location = new Point(50, 40);
            continueShopping.Size = new Size(300, 60);
            continueShopping.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            continueShopping.ForeColor = Color.FromArgb(74, 85, 162);
            continueShopping.BackColor = Color.White;

            pnlFooter = new Panel();
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.BackColor = Color.FromArgb(197, 223, 248);
            pnlFooter.Height = 150;

            pnlFooter.Controls.Add(checkout);
            pnlFooter.Controls.Add(continueShopping);
            this.Controls.Add(pnlFooter);
        }


        private void setContainer()
        {
            pnlContainer = new Panel();
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.BackColor = Color.White;
            pnlContainer.AutoScroll = true;
            PopulateContainer(pnlContainer);

            this.Controls.Add(pnlContainer);

        }
    }
}
