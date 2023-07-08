using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineShop.view
{
    public partial class Cart : Form
    {
        private Panel pnlContainer;
        private Panel pnlHeader;
        private Panel pnlFooter;
        private Label titlu;
        public Cart()
        {
            InitializeComponent();
            setContainer();
            setHeader();
            setFooter();

            this.WindowState = FormWindowState.Maximized;
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        public void setHeader()
        {
            titlu = new Label();
            titlu.Text = "Cart";
            titlu.Location = new Point(850, 60);
            titlu.Size = new Size(300, 300);
            titlu.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            titlu.ForeColor = Color.White;

            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Height = 150;

            pnlHeader.Controls.Add(titlu);
            this.Controls.Add(pnlHeader);
        }
        public void setFooter()
        {

            Button checkout = new Button();
            Button continueShopping = new Button();

            checkout.Text = "Checkout";
            checkout.Location = new Point(1550, 40);
            checkout.Size = new Size(300, 60);
            checkout.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            checkout.ForeColor = Color.RoyalBlue;
            checkout.BackColor = Color.White;
            

            continueShopping.Text = "Continue shopping";
            continueShopping.Location = new Point(50, 40);
            continueShopping.Size = new Size(300, 60);
            continueShopping.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            continueShopping.ForeColor = Color.RoyalBlue;
            continueShopping.BackColor = Color.White;

            pnlFooter = new Panel();
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.BackColor = Color.LightBlue;
            pnlFooter.Height = 150;

            pnlFooter.Controls.Add(checkout);
            pnlFooter.Controls.Add(continueShopping);
            this.Controls.Add(pnlFooter);
        }

        private void PopulateContainer(Panel container)
        {

        }

        private void setContainer()
        {
            pnlContainer = new Panel();
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.BackColor = Color.White;
            pnlContainer.AutoScroll = true;
            PopulateContainer(pnlContainer);

            this.Controls.Add(pnlContainer);

        }
    }
}
