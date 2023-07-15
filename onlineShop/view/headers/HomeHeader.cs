using onlineShop.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    internal class HomeHeader : MainHeader
    {
        public HomeHeader(Panel panel) : base(panel)
        {
            base.Label = "Home";
            this.Name = Constants.HOME_HEADER;
        }
    }
}
