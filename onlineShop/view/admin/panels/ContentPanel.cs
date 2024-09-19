using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.admin.panels
{
    internal class ContentPanel : Panel
    {
        public ContentPanel(Panel parent)
        {
            this.BackColor = Color.LightCyan;
            parent.Controls.Add(this);
            this.Dock = DockStyle.Fill;
        }


    }
}
