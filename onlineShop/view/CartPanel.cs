using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view
{
    public class CartPanel : Panel
    {
        private Panel pnlContainer;
        private Panel pnlHeader2;
        private Panel pnlFooter;
        private Label cart;
        public CartPanel(Panel parent)
        {
            this.Parent=parent;
            this.Location=new Point(0,0);
            setContainer();
            this.BringToFront();
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
        }

        private void PopulateContainer(Panel container) { 

        }

        private void setContainer()
        {
            pnlContainer = new Panel();
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.BackColor = Color.White;
            pnlContainer.AutoScroll = true;

            //PopulateContainer(pnlContainer);

            setHeader2();
            pnlContainer.Controls.Add(pnlHeader2);

            setFooter();
            pnlContainer.Controls.Add(pnlFooter);

            this.Controls.Add(pnlContainer);

        }

    }
}
