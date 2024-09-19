using onlineShop.view.admin.panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.admin.containers
{
    internal class PnlAdmin : Panel
    {
        ButtonPanel buttons;
        ContentPanel content;
        public PnlAdmin(MainPage form)
        {
            this.Dock = DockStyle.Fill;
            buttons = new ButtonPanel(this);
            content = new ContentPanel(this);
            form.Controls.Add(this);
        }

        
    }
}
