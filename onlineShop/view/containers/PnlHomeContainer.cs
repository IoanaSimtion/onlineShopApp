using onlineShop.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.containers
{
    internal class PnlHomeContainer : PnlContainer
    {
        public PnlHomeContainer(Panel panel) : base(panel)
        {
            this.Name = Constants.HOME_CONTAINER;
            base.BackColor = Color.LightBlue;
        }
    }
}
