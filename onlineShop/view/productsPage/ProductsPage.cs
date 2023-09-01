using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
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

        public ProductsPage(MainPage form, ProductService productService, OrderService orders, OrderDetailsService orderDetails)
        {
            this.Name = Constants.PRODUCTS_PANEL;
            this.Dock = DockStyle.Fill;           
            this.Controls.Add(new PnlProductsContainer(this, form, productService));
            this.Controls.Add(new ProductsHeader(this, form, productService,orders,orderDetails));
           
            form.Controls.Add(this);
            Products = productService;
        }

        public ProductService Products { get; }
    }
}
