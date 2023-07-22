using onlineShop.utils;
using onlineShop.view.containers;
using onlineShop.view.footers;
using onlineShop.view.headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.cartPage
{
    internal class Cart : Panel
    {
        public Cart(MainPage form)
        {
            this.Name = Constants.CART_PANEL;

            this.Dock = DockStyle.Fill;

            this.loadCart(form);
        }

        public void removeControl(String name)
        {

            Control aux = null;


            foreach (Control ctrl in this.Controls)
            {

                if (ctrl.Name.Equals(name))
                {
                    aux = ctrl;
                    PerformLayout();
                }

            }

            if (aux != null)
            {
                this.Controls.Remove(aux);
                PerformLayout();
            }

        }

        public void loadCart(MainPage form)
        {
            this.Controls.Add(new PnlCartContainer(this, form));
            this.Controls.Add(new CartFooter(this, form));
            this.Controls.Add(new CartHeader(this, form));
        }
    }
}
