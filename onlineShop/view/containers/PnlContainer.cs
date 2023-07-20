using onlineShop.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.containers
{
    public class PnlContainer : Panel
    {

        public PnlContainer(Panel panel)
        {
            this.Name = Constants.CONTAINER_PANEL;

            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.Location = new Point(0, 94 + 53);

            panel.Controls.Add(this);
        }

    }
}
