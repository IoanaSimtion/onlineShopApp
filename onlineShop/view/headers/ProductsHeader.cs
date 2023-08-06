using onlineShop.product.service;
using onlineShop.utils;
using onlineShop.view.cartPage;
using onlineShop.view.menuPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    
    internal class ProductsHeader : MainHeader
    {
        private PictureBox cartIcon;
        private PictureBox profileIcon;
        private Label cart;
        private Label profile;
        private Label menu;
        MainPage form;
        Panel pnl;
        private ProductService produse;
        public ProductsHeader(Panel panel, MainPage mainPage, ProductService products) : base(panel)
        {
            this.form = mainPage;
            this.pnl = panel;
            this.produse = products;

            this.Name = Constants.PRODUCTS_HEADER;
            base.Height = 94 + 53;           

            cartIcon = new PictureBox();
            cart = new Label();
            menu = new Label();

            cartIcon.Image = Image.FromFile("D:\\mycode\\icons\\cart.png");
            cartIcon.Location = new Point(1835, 20);
            cartIcon.SizeMode = PictureBoxSizeMode.Zoom;
            cartIcon.Size = new Size(57, 41);
            cartIcon.BackColor = Color.FromArgb(74, 85, 162);

            cartIcon.Click += cart_Click;

            cart.Text = "Cart";
            cart.Location = new Point(1840, 65);
            cart.Size = new Size(100, 100);
            cart.ForeColor = Color.White;
            cart.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            profileIcon = new PictureBox();
            profile = new Label();

            profileIcon.Image = Image.FromFile("D:\\mycode\\icons\\1160865.png");
            profileIcon.Location = new Point(1720, 20);
            profileIcon.SizeMode = PictureBoxSizeMode.Zoom;
            profileIcon.Size = new Size(47, 40);
            profileIcon.BackColor = Color.White;

            profileIcon.Click += profile_Click;

            profile.Text = "My Account";
            profile.Location = new Point(1685, 65);
            profile.Size = new Size(150, 100);
            profile.ForeColor = Color.White;
            profile.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            menu.Text = "Menu";
            menu.Location = new Point(30, 65);
            menu.Size = new Size(100, 100);
            menu.ForeColor = Color.White;
            menu.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            menu.Click += menu_Click;

            panel.Controls.Add(new HeaderProduse(this, panel, mainPage,produse));
            base.Controls.Add(cart);
            base.Controls.Add(profile);
            //base.Controls.Add(menu);
            base.Controls.Add(cartIcon);
            base.Controls.Add(profileIcon);

        }
        private void cart_Click(object sender, EventArgs e)
        {
            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setCartPage();                        

        } 
        
        private void profile_Click(object sender, EventArgs e)
        {
                                

        }

        private void menu_Click(object sender, EventArgs e)
        {
            Menu meniu = new Menu(form,pnl);
        }
    }
}
