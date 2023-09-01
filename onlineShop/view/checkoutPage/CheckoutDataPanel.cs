using onlineShop.user.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.checkoutPage
{
    

    internal class CheckoutDataPanel : Panel
    {
        private Label paymentInfo;
        private Label payment;
        private Label shippingInfo;
        private Label shipping;
        private int price;
        private Label total;
        private User utilizator;
        private Label pret;

        public CheckoutDataPanel(User user, int x, int y, int totalPrice)
        {
            this.utilizator = user;
            this.Location = new Point(x, y);
            this.Size = new Size(500, 350);
            this.price = totalPrice + 2;
            //this.BackColor = Color.Red;
            setInfo();
        }

        void setInfo()
        {
            payment = new Label();
            payment.Text = "Payment Information";
            payment.Size = new Size(400, 30);
            payment.Location = new Point(10, 10);
            payment.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            paymentInfo = new Label();
            paymentInfo.Text = "card1241";
            paymentInfo.Size= new Size(400, 30);
            paymentInfo.Location = new Point(10, 40);
            paymentInfo.Font = new Font("Century Gothic", 12, FontStyle.Regular);

            shipping = new Label();
            shipping.Text = "Shipping Adress";
            shipping.Location = new Point(10, 90);
            shipping.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            shipping.Size = new Size(200, 30);

            shippingInfo = new Label();
            shippingInfo.Text = utilizator.Address;
            shippingInfo.Location = new Point(10, 120);
            shippingInfo.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            shippingInfo.Size= new Size(400, 30);

            total = new Label();
            total.Text = "Total price";
            total.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            total.Location = new Point(10, 170);
            total.Size = new Size(200, 30);

            pret = new Label();
            pret.Text = "$" + price.ToString() + "\n($2.00 tax included)";
            pret.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            pret.Size = new Size(400, 100);
            pret.Location = new Point(10, 200);

            this.Controls.Add(shipping);
            this.Controls.Add(shippingInfo);
            this.Controls.Add(payment);
            this.Controls.Add(paymentInfo);
            this.Controls.Add(total);
            this.Controls.Add(pret);

        }
    }
}
