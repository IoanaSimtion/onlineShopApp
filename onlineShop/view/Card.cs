using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view
{
    internal class Card : Panel
    {
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlPhoto;
        private LinkLabel titlu;
        private PictureBox pozaProdus;
        private Label descriere;
        private Button addCart;
        private Label pret;

        public Card(string id, string name, float price, string description, string image, int stock, int x, int y, Panel parent)
        {
            this.Parent = parent;
            this.Location = new Point(x, y);
            this.Width = 560;
            this.Height = 400;
            panelHeader(name);
            panelPhoto(image);
            panelContent(description, price, id, stock);
        }

        private void panelHeader(string name)
        {
            titlu = new LinkLabel();
            titlu.Text = name;
            titlu.Location = new Point(30, 5);
            titlu.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            titlu.Size = new Size(100, 100);


            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.LightBlue;
            pnlHeader.Size = new Size(50, 50);
            pnlHeader.Controls.Add(titlu);
            Controls.Add(pnlHeader);

        }

        private void panelPhoto(string path)
        {
            pozaProdus = new PictureBox();
            pozaProdus.Width = 120;
            pozaProdus.Image = Image.FromFile(path);
            pozaProdus.SizeMode = PictureBoxSizeMode.Zoom;
            pozaProdus.Location = new Point(0, 0);
            pozaProdus.Dock = DockStyle.Fill;

            pnlPhoto = new Panel();
            pnlPhoto.Dock = DockStyle.Left;
            pnlPhoto.BackColor = Color.LightCyan;
            pnlPhoto.Width = 120;
            pnlPhoto.Controls.Add(pozaProdus);
            Controls.Add(pnlPhoto);
        }

        private void panelContent(string description, float price, string id, int stock)
        {
            descriere = new Label();
            descriere.Text = description + "\n" + "ID: " + id + "\n" + "Stock: " + stock.ToString() + "\n";
            descriere.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            descriere.Location = new Point(30, 30);
            descriere.Width = 360;
            descriere.Height = 200;
            descriere.BackColor = Color.White;

            addCart = new Button();
            addCart.Text = "Add to cart";
            addCart.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            addCart.Location = new Point(240, 280);
            addCart.Size = new Size(150, 40);
            //addCart.Dock = DockStyle.Left;
            addCart.BackColor = Color.White;

            pret = new Label();
            pret.Text = "Price: " + price.ToString();
            pret.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            pret.Location = new Point(30, 285);
            pret.BackColor = Color.White;

            pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.Lavender;

            pnlContent.Controls.Add(descriere);
            pnlContent.Controls.Add(addCart);
            pnlContent.Controls.Add(pret);
            Controls.Add(pnlContent);
            pnlContent.BringToFront();
        }

    }
}
