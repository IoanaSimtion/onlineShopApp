using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.secondaryHeaders
{
    internal class HeaderCheckout : Header
    {
        public HeaderCheckout(Panel panel) : base(panel)
        {
            base.ResetText();
            base.Label = "Checkout: Your Information";
            
            base.Name = "pnlCheckoutHeader";
        }
    }
}
