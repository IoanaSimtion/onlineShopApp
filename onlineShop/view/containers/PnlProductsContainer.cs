﻿using onlineShop.product.models;
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
        private Label noProducts;
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
                       

            int x = 0, y = 40, k = 1;

            if (products.Count() == 0)
            {
                noProducts = new Label();

                noProducts.Text = "No products";
                noProducts.Font = new Font("Century Gothic", 18, FontStyle.Regular);
                noProducts.Location = new Point(850, 350);
                noProducts.Size = new Size(300, 300);
                this.Controls.Add(noProducts);

            }

            for (int i = 0; i < products.Count(); i++)
            {

                Card card = ProductMappers.productToCardMapper(container, products[i], x, y, form);

                x += card.Width + 50;

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
