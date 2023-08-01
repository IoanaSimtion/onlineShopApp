using onlineShop.order.models;
using onlineShop.product.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.mappers
{
    internal abstract class ProductMappers
    {
        public static Card productToCardMapper(Panel panel ,Product product, int x, int y, MainPage main)
        {
            return new Card(product.Marimi, product.Culori, product.Id, product.Name, product.Price, product.Description, product.Image, product.Stock, x, y, panel, main);
        }
    }
}
