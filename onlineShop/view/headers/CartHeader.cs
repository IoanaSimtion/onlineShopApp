using onlineShop.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    internal class CartHeader : MainHeader
    {
        MainPage form;
        Panel pnl;
        public CartHeader(Panel panel, MainPage mainPage) : base(panel)
        {
            this.Name = Constants.CART_HEADER;
            this.form = mainPage;
            this.pnl = panel;

            this.Name = Constants.PRODUCTS_HEADER;
            base.Height = 94 + 53;

            base.Controls.Add(new HeaderCart(this));
        }
    }
}
