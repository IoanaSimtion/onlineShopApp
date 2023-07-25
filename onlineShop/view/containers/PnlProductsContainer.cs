using onlineShop.product.models;
using onlineShop.product.service;
using onlineShop.utils;
using onlineShop.view.mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.containers
{
    internal class PnlProductsContainer : PnlContainer
    {
        private ProductService productService;
        public PnlProductsContainer(Panel panel, MainPage form, ProductService produse) : base(panel)
        {
            this.Name = Constants.PRODUCTS_CONTAINER;

            this.productService = produse;
            PopulateContainer(this, form);
            panel.Controls.Add(this);

        }

        private void PopulateContainer(Panel container, MainPage form)
        {

            List<Product> products = productService.Products;
                       

            int x = 0, y = 80, k = 1;

            for (int i = 0; i < products.Count(); i++)
            {

                Card card = ProductMappers.productToCardMapper(container, products[i], x, y, form);

                x += card.Width + 100;

                if (k == 3)
                {
                    x = 0;
                    y += card.Height + 80;

                    k = 1;
                }
                else
                {
                    k++;
                }
            }
        }
    }
}
