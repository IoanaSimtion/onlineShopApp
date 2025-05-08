using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.view.cartPage;
using onlineShop.view.containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view
{

    internal class CheckoutCard : Panel
    {
        private Panel pnlHeader;
        private Panel pnlContent;
        private Label titlu;
        private Label descriere;
        private Label pret;
        private Label cantitate;
        private MainPage mainPage;
        private string id;
        private int cantitateProd;
        private OrderDetailsService orderDetailsService;
        private OrderService orderService;
        private ProductService productService;
        public CheckoutCard(MainPage form, Panel parent, string id, string name, float price, string description, int amount, int x, int y, OrderService orders, OrderDetailsService orderDetails, ProductService products)
        {
            this.orderDetailsService = orderDetails;
            this.orderService = orders;
            this.productService = products;
            this.mainPage = form;
            this.Parent = parent;
            this.Location = new Point(x, y);
            this.Width = 930;
            this.Height = 250;
            this.id = id;
            panelHeader(name, amount);
            panelContent(description, price);
        }

        private void panelHeader(string name, int amount)
        {
            titlu = new Label();
            titlu.Text = name;
            titlu.Location = new Point(50, 5);
            titlu.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            titlu.Size = new Size(100, 500);
            titlu.Width = 500;

            cantitate = new Label();
            cantitate.Text = amount.ToString();
            cantitate.Location = new Point(840, 10);
            cantitate.Size = new Size(30, 20);
            cantitate.BackColor = Color.White;


            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.FromArgb(163, 118, 141);
            pnlHeader.Size = new Size(50, 50);
            pnlHeader.Controls.Add(titlu);
            pnlHeader.Controls.Add(cantitate);
            Controls.Add(pnlHeader);

        }
        private void panelContent(string description, float price)
        {


            descriere = new Label();
            descriere.Text = description + "\n";
            descriere.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            descriere.Location = new Point(50, 30);
            descriere.Width = 825;
            descriere.Height = 100;
            descriere.BackColor = Color.White;
            descriere.BorderStyle = BorderStyle.FixedSingle;

           
            pret = new Label();
            pret.Width = 130;
            pret.Text = "Price: $" + price.ToString();
            pret.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            pret.Location = new Point(50, 150);
            pret.BackColor = Color.White;

            pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.FromArgb(255, 250, 253);

            pnlContent.Controls.Add(descriere);
            pnlContent.Controls.Add(pret);
            Controls.Add(pnlContent);
            pnlContent.BringToFront();
        }



    }
}
