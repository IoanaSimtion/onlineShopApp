using onlineShop.product.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    internal class HeaderProduse : Header
    {
        private ComboBox filtru;
        private ProductService produse;
        private MainPage form;
        public HeaderProduse(Panel panel, MainPage mainPage) : base(panel)
        {
            base.ResetText();
            base.Label = "Produse";
            base.Name = "pnlHeaderProduse";
            this.form = mainPage;
            //base.Dock = DockStyle.Bottom;
            setFilter();
        }

        public void setFilter()
        {
            filtru = new ComboBox();
            filtru.Items.Add("Name (A to Z)");
            filtru.Items.Add("Name (Z to A)");
            filtru.Items.Add("Price (low to high)");
            filtru.Items.Add("Price (high to low)");
            filtru.Parent = this;
            filtru.Location = new Point(1725, 10);
            filtru.Width = 175;
            filtru.Text = "Filter";
            filtru.Font = new Font("Century Gothic", 10, FontStyle.Regular);

            filtru.SelectedIndexChanged+=filtru_SelectedIndexChanged;

            this.Controls.Add(filtru);
        }

        private void filtru_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filtru.SelectedIndex)
            {
                case 0: sortareCrescNume(); break;
                case 1: sortareDescrescNume(); break;
                case 2: sortareCrescPret();break;
                default: sortareDescrescPret();break;
            }
        }

        void sortareCrescNume()
        {
            produse = new ProductService();

            produse.sortareCrescatorNume();

            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage(produse);


        }
        void sortareDescrescNume()
        {
            produse = new ProductService();

            produse.sortareDescrescatorNume();

            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage(produse);
        }

        void sortareCrescPret()
        {
            produse = new ProductService();

            produse.sortareCrescatorPret();

            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage(produse);
        }
        
        void sortareDescrescPret()
        {
            produse = new ProductService();

            produse.sortareDescrescatorPret();

            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage(produse);
        }
    }
}
