using onlineShop.system.cart;
using onlineShop.view.cartPage;
using onlineShop.view.containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view
{

    internal class OrderCard : Panel
    {
        private Panel pnlHeader;
        private Panel pnlContent;
        private LinkLabel titlu;
        private Label descriere;
        private Button remove;
        private Label pret;
        private ComboBox cantitate;
        private MainPage mainPage;
        private string id;
        private int cantitateProd;
        public OrderCard(MainPage form, Panel parent, string id, string name, float price, string description, int amount, int x, int y)
        {
            this.mainPage = form;
            this.Parent = parent;
            this.Location = new Point(x, y);
            this.Width = 930;
            this.Height = 250;
            this.id = id;
            panelHeader(name, amount);
            panelContent(description, price);
        }

        private void panelHeader(string name, int amount)
        {
            titlu = new LinkLabel();
            titlu.Text = name;
            titlu.Location = new Point(50, 5);
            titlu.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            titlu.Size = new Size(100, 100);

            cantitate = new ComboBox();
            cantitate.Text = amount.ToString();
            cantitate.Location = new Point(830, 10);
            cantitate.Width = 50;
            cantitate.Items.Add("1");
            cantitate.Items.Add("2");
            cantitate.Items.Add("3");
            cantitate.Items.Add("4");
            cantitate.Items.Add("5");
            cantitate.Items.Add("6");
            cantitate.Items.Add("7");
            cantitate.Items.Add("8");
            cantitate.Items.Add("9");
            cantitate.Items.Add("10");

            cantitate.SelectedIndexChanged += cantitate_SelectedIndexChanged;


            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.FromArgb(160, 191, 224);
            pnlHeader.Size = new Size(50, 50);
            pnlHeader.Controls.Add(titlu);
            pnlHeader.Controls.Add(cantitate);
            Controls.Add(pnlHeader);

        }
        private void panelContent(string description, float price)
        {
            

            descriere = new Label();
            descriere.Text = description + "\n";
            descriere.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            descriere.Location = new Point(50, 30);
            descriere.Width = 825;
            descriere.Height = 100;
            descriere.BackColor = Color.White;
            descriere.BorderStyle = BorderStyle.FixedSingle;

            remove = new Button();
            remove.Text = "Remove";
            remove.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            remove.Location = new Point(730, 150);
            remove.Size = new Size(150, 40);
            remove.ForeColor = Color.Red;
            remove.BackColor = Color.White;

            remove.Click += remove_Click;

            pret = new Label();
            pret.Width = 130;
            pret.Text = "Price: $" + price.ToString();
            pret.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            pret.Location = new Point(50, 150);
            pret.BackColor = Color.White;

            pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.FromArgb(240, 251, 255);

            pnlContent.Controls.Add(descriere);
            pnlContent.Controls.Add(remove);
            pnlContent.Controls.Add(pret);
            Controls.Add(pnlContent);
            pnlContent.BringToFront();
        }

        private void cantitate_SelectedIndexChanged(object sender, EventArgs e)
        {

            cantitateProd = int.Parse(cantitate.SelectedItem.ToString());

            mainPage.cartActions.updateItem(id, cantitateProd);

        }


        private void remove_Click(object sender, EventArgs e)
        {
            this.mainPage.cartActions.deleteItem(id);

            mainPage.removeControl("pnlCart");

            this.PerformLayout();

            mainPage.setCartPage();
        }
    }
}
