using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.system.cart
{
    internal class CartActions
    {
        private List<CartItem> cartItems;

        public CartActions()
        {
            cartItems = new List<CartItem>();
            
        }

        public void addItem(CartItem item)
        {
            if (returnItemById(item.Id) == null)
            {
                cartItems.Add(item);
            }
            else
            {
                returnItemById(item.Id).Cantitate++;
            }
        }

        public void deleteItem(CartItem item)
        {
            cartItems.Remove(item);
        }

        public CartItem returnItemById(string id)
        {
            foreach(CartItem item in cartItems)
            {
                if (item.Id.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }

        public void updateItem(string id, int cantitate)
        {
            returnItemById(id).Cantitate = cantitate;
        }

        public void afisare()
        {
            for(int i = 0; i < cartItems.Count(); i++)
            {
                //Debug.WriteLine(cartItems[i]);
            }
        }

        public List<CartItem> CartItems { get { return cartItems; } }
    }
}
