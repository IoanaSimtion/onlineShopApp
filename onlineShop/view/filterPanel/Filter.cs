using onlineShop.product.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.filterPanel
{
    public class Filter : Panel
    {
        private ProductService produse;
        private Panel pnl;
        private Label pret;
        private Label marime;
        private Label culoare;
        private CheckedListBox culori;
        private CheckedListBox marimi;
        private TextBox pret1;
        private TextBox pret2;
        private Button save;
        private MainPage form;
        private string pretMin;
        private string pretMax;
        private bool pretMinimSchimbat;
        private bool pretMaximSchimbat;
        private List<string> sizes;

        public Filter(Panel panel, MainPage main)
        {
            this.pnl = panel;
            this.Parent = panel;
            this.form = main;
            this.BackColor = Color.LightBlue;
            this.Size = new Size(400, 500);
            this.Location = new Point(1500,200);

            sizes = new List<string>();

            filtruCuloare();
            filtruPret();
            filtruMarime();
            saveButton();                       

            panel.Controls.Add(this); 

            this.BringToFront();

        }

        private void saveButton()
        {
            save = new Button();

            save.Location = new Point(300, 400);
            save.Size = new Size(50,50);
            save.Text = "Save";

            save.Click += save_Click;

            this.Controls.Add(save);
        }
        private void filtruCuloare()
        {
            culoare = new Label();
            culori = new CheckedListBox();

            culori.Items.Add("Albastru");
            culori.Items.Add("Rosu");
            culori.Items.Add("Galben");
            culori.Items.Add("Verde");
            culori.Items.Add("Portocaliu");
            culori.Items.Add("Roz");
            culori.Items.Add("Violet");
            culori.Items.Add("Alb");
            culori.Items.Add("Negru");

            culori.Height = 100;
            culori.Location = new Point(10, 280);
            this.Controls.Add(culori);

            culoare.Text = "Color";
            culoare.Location = new Point(10, 250);
            culoare.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            this.Controls.Add(culoare);
        }

        private void filtruPret()
        {
            pret = new Label();
            pret1 = new TextBox();
            pret2 = new TextBox();

            pret1.PlaceholderText = "Minimum price";
            pret2.PlaceholderText = "Maximum price";

            pret1.TextChanged += PretMinim_TextChanged;
            pret2.TextChanged += PretMaxim_TextChanged;

            pret1.Location = new Point(10, 40);
            pret1.Width = 160;
            pret2.Location = new Point(200, 40);
            pret2.Width = 160;

            pret.Text = "Price";
            pret.Location = new Point(10, 10);
            pret.Size = new Size(60, 30);
            pret.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            this.Controls.Add(pret);
            this.Controls.Add(pret1);
            this.Controls.Add(pret2);


        }

        private void filtruMarime()
        {
            marime = new Label();
            marimi = new CheckedListBox();

            marime.Text = "Size";
            marime.Location = new Point(10, 90);
            marime.Size = new Size(60, 30);
            marime.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            marimi.Items.Add("XS");
            marimi.Items.Add("S");
            marimi.Items.Add("M");
            marimi.Items.Add("L");
            marimi.Items.Add("XL");
            marimi.Items.Add("XXL");

            marimi.ItemCheck += marimi_ItemCheck;

            marimi.Location = new Point(10, 130);

            this.Controls.Add(marime);

            this.Controls.Add(marimi);

        }

        private void PretMinim_TextChanged(object sender, EventArgs e)
        {
            this.pretMin = pret1.Text;
            this.pretMinimSchimbat = true;
        }
        private void PretMaxim_TextChanged(object sender, EventArgs e)
        {
            this.pretMax = pret2.Text;
            this.pretMaximSchimbat = true;
        }
        private void marimi_ItemCheck(object sender, EventArgs e)
        {
            sizes.Add(marimi.GetItemText(marimi.SelectedItem).ToString());
        }
        private void save_Click(object sender, EventArgs e)
        {
            produse = new ProductService();

            if (pretMinimSchimbat == true && pretMaximSchimbat == true)
            {
                produse.filtrarePret(Int32.Parse(pretMin),Int32.Parse(pretMax));
            }

            for(int i = 0; i < sizes.Count(); i++)
            {
                produse.filtrareMarime(sizes[i]);
            }


            form.removeControl("pnlProducts");

            this.PerformLayout();

            form.setProductsPage(produse);
        }
    }
}
