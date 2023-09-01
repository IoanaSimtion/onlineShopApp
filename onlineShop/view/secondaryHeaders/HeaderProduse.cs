using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using onlineShop.view.filterPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.secondaryHeaders
{
    internal class HeaderProduse : Header
    {
        private Panel pnl;
        private Panel containerPanel;
        private ComboBox sort;
        private ProductService produse;
        private MainPage form;
        private Label filtru;
        private PictureBox filtruIcon;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        public HeaderProduse(Panel panel, Panel container, MainPage mainPage, ProductService products, OrderService orders, OrderDetailsService orderDetails) : base(panel)
        {
            base.ResetText();
            base.Label = "Produse";
            base.Name = "pnlHeaderProduse";
            this.form = mainPage;
            this.pnl = panel;
            this.containerPanel = container;
            this.produse = products;
            this.orderService= orders;
            this.orderDetailsService = orderDetails;
            //base.Dock = DockStyle.Bottom;
            sortProducts();
            filterProducts();
        }

        public void filterProducts()
        {
            filtru = new Label();
            filtru.Text = "filtru";
            filtru.Size = new Size(100, 100);
            filtru.ForeColor = Color.Blue;
            filtru.Location = new Point(1680, 10);
            filtru.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            filtruIcon = new PictureBox();
            filtruIcon.Image = Image.FromFile("D:\\mycode\\icons\\Filter.png");
            filtruIcon.Location = new Point(1680, 10);
            filtruIcon.SizeMode = PictureBoxSizeMode.Zoom;
            filtruIcon.Size = new Size(30, 30);
            filtruIcon.BackColor = Color.FromArgb(74, 85, 162);

            filtruIcon.Click += filtru_Click;

            this.Controls.Add(filtruIcon);
        }
        public void sortProducts()
        {
            sort = new ComboBox();
            sort.Items.Add("Name (A to Z)");
            sort.Items.Add("Name (Z to A)");
            sort.Items.Add("Price (low to high)");
            sort.Items.Add("Price (high to low)");
            sort.Parent = this;
            sort.Location = new Point(1725, 10);
            sort.Width = 175;
            sort.Text = "Sort products";
            sort.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            sort.SelectedIndexChanged+=sort_SelectedIndexChanged;

            this.Controls.Add(sort);
        }

        private void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sort.SelectedIndex)
            {
                case 0: sortareCrescNume(); break;
                case 1: sortareDescrescNume(); break;
                case 2: sortareCrescPret();break;
                default: sortareDescrescPret();break;
            }
        }

        void sortareCrescNume()
        {

            produse.sortareCrescatorNume();

            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage();


        }
        void sortareDescrescNume()
        {

            produse.sortareDescrescatorNume();

            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage();
        }

        void sortareCrescPret()
        {

            produse.sortareCrescatorPret();

            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage();
        }
        
        void sortareDescrescPret()
        {

            produse.sortareDescrescatorPret();

            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage();
        }

        private void filtru_Click(object sender, EventArgs e)
        {
            Filter filtru = new Filter(containerPanel,form,orderService,orderDetailsService);
        }
    }
}
