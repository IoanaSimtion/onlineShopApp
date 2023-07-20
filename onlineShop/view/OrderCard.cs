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
        private Label cantitate;
        public OrderCard(Panel parent, string id, string name, float price, string description, int amount, int x, int y)
        {
            this.Parent = parent;
            this.Location = new Point(x, y);
            this.Width = 950;
            this.Height = 250;
            panelHeader(name);
            panelContent(description, price, amount);
        }

        private void panelHeader(string name)
        {
            titlu = new LinkLabel();
            titlu.Text = name;
            titlu.Location = new Point(50, 5);
            titlu.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            titlu.Size = new Size(100, 100);


            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.FromArgb(160, 191, 224);
            pnlHeader.Size = new Size(50, 50);
            pnlHeader.Controls.Add(titlu);
            Controls.Add(pnlHeader);

        }
        private void panelContent(string description, float price, int amount)
        {
            cantitate = new Label();
            cantitate.Text = amount.ToString();
            cantitate.Location = new Point(30, 5);
            cantitate.BorderStyle = BorderStyle.FixedSingle;

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
    }
}
