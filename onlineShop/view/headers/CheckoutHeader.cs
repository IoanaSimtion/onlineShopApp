using onlineShop.view.secondaryHeaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    internal class CheckoutHeader : MainHeader
    {
        private MainPage form;
        private Panel pnl;
        public CheckoutHeader(Panel panel, MainPage main) : base(panel)
        {
            this.form = main;
            this.pnl = panel;

            base.Height = 94 + 53;

            panel.Controls.Add(new HeaderCheckout(panel));

        }
    }
}
