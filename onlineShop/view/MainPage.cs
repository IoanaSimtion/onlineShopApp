using onlineShop.product.models;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.view.containers;
using onlineShop.view.headers;
using onlineShop.view.mappers;
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
    public partial class MainPage : Form
    {

        private PnlContainer pnlProductsContainer;
        private PnlCartContainer pnlCartContainer;
        private Panel pnlHeader;
        private Panel pnlContainer;
        private Panel pnlTitleHeader;
        //private Button menu;
        //private ComboBox filtru;
        private Label titlu;
        private ProductService productService;
        private CartPanel pnlCart;
        private HeaderProduse pnlHeaderProduse;
        private HeaderCart pnlHeaderCart;

        public CartActions cartActions;


        public MainPage()
        {
            InitializeComponent();

            this.productService = new ProductService();

            this.pnlProductsContainer=new PnlContainer();
            setContainer();
            
            setHeader();

            this.WindowState = FormWindowState.Maximized;

            this.cartActions = new CartActions();             

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void PopulateContainer(Panel container)
        {

            List<Product> products = productService.Products;

            int x = 0, y = 80, k = 1;

            for (int i = 0; i < products.Count(); i++)
            {

                Card card = ProductMappers.productToCardMapper(container, products[i], x, y,this);

                x += card.Width + 100;

                if (k == 3)
                {
                    x = 0;
                    y += card.Height + 80;

                    k = 1;
                }
                else
                {
                    k++;
                }
            }
        }

        private void setTitleHeader()
        {
            PictureBox cartIcon = new PictureBox();
            Label cart = new Label();

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

            titlu = new Label();
            titlu.Text = "Online shop";
            titlu.Location = new Point(850, 30);
            titlu.Size = new Size(300, 300);
            titlu.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            titlu.ForeColor = Color.White;

            pnlTitleHeader = new Panel();
            pnlTitleHeader.Dock = DockStyle.Top;
            pnlTitleHeader.BackColor = Color.FromArgb(74, 85, 162);
            pnlTitleHeader.Height = 94;

            pnlTitleHeader.Controls.Add(titlu);
            pnlTitleHeader.Controls.Add(cartIcon);
            pnlTitleHeader.Controls.Add(cart);
            this.Controls.Add(pnlTitleHeader);
        }

        private void setHeader()
        {
            this.pnlHeader = new Panel();
            pnlHeader.Height = 94 + 53;
            pnlHeader.Dock = DockStyle.Top;

            setTitleHeader();
            this.pnlHeader.Controls.Add(pnlTitleHeader);
           
            this.pnlHeaderProduse = new HeaderProduse();
            this.pnlHeader.Controls.Add(pnlHeaderProduse);

            this.Controls.Add(pnlHeader);
        }
   
        private void setContainer()
        {
            this.pnlContainer = new Panel();
            this.pnlContainer.Dock = DockStyle.Fill;
            PopulateContainer(pnlProductsContainer);
            this.pnlContainer.Controls.Add(pnlProductsContainer);

            this.Controls.Add(pnlContainer);
        }

        private void cart_Click(object sender, EventArgs e)
        {
            this.pnlHeaderCart = new HeaderCart();
            removeHeaderControl("pnlHeaderProduse");
            this.pnlHeader.Controls.Add(pnlHeaderCart);

            this.pnlCartContainer = new PnlCartContainer();
            removeContainerControl("pnlProductsContainer");
            this.pnlContainer.Controls.Add(pnlCartContainer);

            //MessageBox.Show("da");

        }

        public void removeHeaderControl(String name)
        {

            Control aux = null;

           
            foreach(Control ctrl in this.pnlHeader.Controls){

                if (ctrl.Name.Equals(name)) 
                {
                    aux = ctrl;
                    PerformLayout();
                }

            }

            if (aux != null)
            {

                this.pnlHeader.Controls.Remove(aux);
                PerformLayout();
            }

        }
        
        public void removeContainerControl(String name)
        {

            Control aux = null;

           
            foreach(Control ctrl in this.pnlContainer.Controls){
                if (ctrl.Name.Equals(name)) 
                {
                    aux = ctrl;
                    PerformLayout();
                }

            }

            if (aux != null)
            {

                this.pnlContainer.Controls.Remove(aux);
                PerformLayout();
            }

        }
    }
}
