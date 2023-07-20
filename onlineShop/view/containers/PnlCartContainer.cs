using onlineShop.utils;
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
        public PnlCartContainer(Panel panel, MainPage mainPage) : base(panel)
        {
            cartFooter = new CartFooter(panel, mainPage);
            base.Controls.Add(cartFooter);
            this.Name = Constants.CART_CONTAINER;
        }


    }
}
