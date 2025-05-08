using onlineShop.system.cart;
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
        private Label titlu;
        private PictureBox pozaProdus;
        private Label descriere;
        private Button addCart;
        private Label pret;
        private string id;

        private MainPage mainPage;

        public Card(List<string> marimi, List<string> culori, string id, string name, float price, string description, string image, int stock, int x, int y, Panel parent,MainPage mainPage)
        {
            this.Parent = parent;
            this.Location = new Point(x, y);
            this.Width = 600;
            this.Height = 400;
            panelHeader(name);
            panelPhoto(image);
            panelContent(description, price, id, stock);

            this.mainPage = mainPage;
            this.id = id;
           
        }

        private void panelHeader(string name)
        {
            titlu = new Label();
            titlu.Text = name;
            titlu.Location = new Point(30, 7);
            titlu.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            titlu.Size = new Size(400, 400);
            titlu.ForeColor = Color.FromArgb(61, 1, 31);


            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.FromArgb(163, 118, 141);
            pnlHeader.Size = new Size(50, 50);
            pnlHeader.Controls.Add(titlu);
            Controls.Add(pnlHeader);

        }

        private void panelPhoto(string path)
        {
            pozaProdus = new PictureBox();
            pozaProdus.Image = Image.FromFile(path);
            pozaProdus.SizeMode = PictureBoxSizeMode.Zoom;
            pozaProdus.Width = 200;
            pozaProdus.Height = 400;
            pozaProdus.Location = new Point(10, 10); 

            pnlPhoto = new Panel();
            pnlPhoto.Dock = DockStyle.Left;
            pnlPhoto.BackColor = Color.White;
            pnlPhoto.Width = 200;
            pnlPhoto.BorderStyle = BorderStyle.FixedSingle;

            pnlPhoto.Controls.Add(pozaProdus);
            pozaProdus.Anchor = AnchorStyles.None;
            pozaProdus.Left = (pnlPhoto.Width - pozaProdus.Width) / 2;
            pozaProdus.Top = (pnlPhoto.Height - pozaProdus.Height) / 2;

            Controls.Add(pnlPhoto);
        }

        private void panelContent(string description, float price, string id, int stock)
        {
            descriere = new Label();
            descriere.Text = description + "\n\n\n" + "ID: " + id + "\n\n\n" + "Stock: " + stock.ToString() + "\n\n";
            descriere.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            descriere.Location = new Point(30, 30);
            descriere.Width = 360;
            descriere.Height = 200;
            descriere.BackColor = Color.White;
            descriere.BorderStyle = BorderStyle.FixedSingle;

            addCart = new Button();
            addCart.Text = "Add to cart";
            addCart.Font = new Font("Century Gothic", 11, FontStyle.Regular);
            addCart.Location = new Point(240, 280);
            addCart.Size = new Size(150, 40);
            //addCart.Dock = DockStyle.Left;
            addCart.BackColor = Color.White;

            addCart.Click += addCart_Click;

            pret = new Label();
            pret.Width = 110;
            pret.Text = "Price: $" + price.ToString();
            pret.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            pret.Location = new Point(30, 285);
            pret.BackColor = Color.White;

            pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.FromArgb(242, 233, 238); 

            pnlContent.Controls.Add(descriere);
            pnlContent.Controls.Add(addCart);
            pnlContent.Controls.Add(pret);
            Controls.Add(pnlContent);
            pnlContent.BringToFront();
        }

        private void addCart_Click(object sender, EventArgs e)
        {

            this.mainPage.cartActions.addItem(new CartItem(id, 1));

        }
    }
}
