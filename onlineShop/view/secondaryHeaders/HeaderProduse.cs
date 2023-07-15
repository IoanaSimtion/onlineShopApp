using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    internal class HeaderProduse : Header
    {
        public HeaderProduse(Panel panel) : base(panel)
        {
            base.ResetText();
            base.Label = "Produse";
            base.Name = "pnlHeaderProduse";
        }
    }
}
