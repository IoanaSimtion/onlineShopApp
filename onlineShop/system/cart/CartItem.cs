using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.system.cart
{
    internal class CartItem
    {
        private string id;
        private int cantitate;
     
        public CartItem(string id, int cantitate)
        {
            this.id = id;
            this.cantitate = cantitate;
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Cantitate
        {
            get { return this.cantitate; }
            set { this.cantitate = value; }
        }

    }
}
