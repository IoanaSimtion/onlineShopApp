using onlineShop.utils;
using onlineShop.view.containers;
using onlineShop.view.headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.productsPage
{
    internal class ProductsPage : Panel
    {

        public ProductsPage(MainPage form)
        {
            this.Name = Constants.PRODUCTS_PANEL;
            this.Dock = DockStyle.Fill;           
            this.Controls.Add(new PnlProductsContainer(this, form));           
            this.Controls.Add(new ProductsHeader(this, form));
           
            form.Controls.Add(this);
        }
    }
}
