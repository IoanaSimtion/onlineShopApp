using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.secondaryHeaders
{
    internal class HeaderCheckoutComplete : Header
    {
        public HeaderCheckoutComplete(Panel panel) : base(panel)
        {
            base.ResetText();
            base.Label = "Checkout: Complete!";

            base.Name = "pnlCheckoutCompleteHeader";
        }
    }
}
