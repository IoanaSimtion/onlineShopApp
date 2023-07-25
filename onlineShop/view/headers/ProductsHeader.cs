using onlineShop.utils;
using onlineShop.view.cartPage;
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
        private Label cart;
        MainPage form;
        Panel pnl;
        public ProductsHeader(Panel panel, MainPage mainPage) : base(panel)
        {
            this.form = mainPage;
            this.pnl = panel;

            this.Name = Constants.PRODUCTS_HEADER;
            base.Height = 94 + 53;           

            cartIcon = new PictureBox();
            cart = new Label();

            cartIcon.Image = Image.FromFile("D:\\mycode\\icons\\cart.png");
            cartIcon.Location = new Point(1855, 20);
            cartIcon.SizeMode = PictureBoxSizeMode.Zoom;
            cartIcon.Size = new Size(52, 41);
            cartIcon.BackColor = Color.FromArgb(74, 85, 162);

            cartIcon.Click += cart_Click;

            cart.Text = "Cart";
            cart.Location = new Point(1857, 65);
            cart.Size = new Size(100, 100);
            cart.ForeColor = Color.White;
            cart.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            panel.Controls.Add(new HeaderProduse(this, mainPage));
            base.Controls.Add(cart);
            base.Controls.Add(cartIcon);

        }
        private void cart_Click(object sender, EventArgs e)
        {
            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setCartPage();                        

        }
    }
}
