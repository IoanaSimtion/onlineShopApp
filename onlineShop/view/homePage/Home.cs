using onlineShop.utils;
using onlineShop.view.containers;
using onlineShop.view.headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.home
{
    internal class Home : Panel
    {
        public Home(Form form)
        {
            this.Name = Constants.HOME_PANEL;

            this.Dock = DockStyle.Fill;
            this.Controls.Add(new HomeHeader(this));
            this.Controls.Add(new PnlHomeContainer(this));
            form.Controls.Add(this);
        }
    }
}
