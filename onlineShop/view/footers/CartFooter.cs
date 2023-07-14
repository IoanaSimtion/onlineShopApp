using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.footers
{
    internal class CartFooter : Panel
    {
        private Button checkout;
        private Button continueShopping;
        public CartFooter()
        {
            checkout = new Button();
            continueShopping = new Button();

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

            this.Dock = DockStyle.Bottom;
            this.BackColor = Color.FromArgb(197, 223, 248);
            this.Height = 150;

            this.Controls.Add(checkout);
            this.Controls.Add(continueShopping);
        }
    
    }
}
