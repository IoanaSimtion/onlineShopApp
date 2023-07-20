using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    internal class HeaderCart : Header
    {
        public HeaderCart(Panel panel) : base(panel)
        {
            base.ResetText();
            base.Label = "Your cart";
            base.Name = "pnlHeaderCart";
            
        }
    }
}
