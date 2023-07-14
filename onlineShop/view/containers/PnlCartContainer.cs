using onlineShop.view.footers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.containers
{
    internal class PnlCartContainer : PnlContainer
    {
        private CartFooter cartFooter;
        public PnlCartContainer()
        {
            cartFooter = new CartFooter();
            base.Controls.Add(cartFooter);
        }


    }
}
