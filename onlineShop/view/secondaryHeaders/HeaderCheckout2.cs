using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.secondaryHeaders
{
    internal class HeaderCheckout2 : Header
    {
        public HeaderCheckout2(Panel panel) : base(panel)
        {
            base.ResetText();
            base.Label = "Checkout: Overview";

            base.Name = "pnlCheckoutHeader2";
        }
    }
}
