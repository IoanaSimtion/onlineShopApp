using onlineShop.product.models;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.view.containers;
using onlineShop.view.headers;
using onlineShop.view.home;
using onlineShop.view.mappers;
using onlineShop.view.productsPage;
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
        
        public CartActions cartActions;


        public MainPage()
        {
            InitializeComponent();
            
            this.cartActions = new CartActions();

            this.WindowState = FormWindowState.Maximized;

            //this.pnlProductsContainer=new PnlContainer();
            //setContainer();
            //setHeader();

            //setHomePage();

            setProductsPage();

            

                       

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }


        private void setHomePage()
        {
            Home home = new Home(this);
        }

        private void setProductsPage()
        {
            ProductsPage productsPage = new ProductsPage(this);
        }

        private void setCartPage()
        {

        }


        

        

        //private void setHeader()
        //{
        //    this.pnlHeader = new Panel();
        //    pnlHeader.Height = 94 + 53;
        //    pnlHeader.Dock = DockStyle.Top;

        //    this.pnlHeader.Controls.Add(pnlTitleHeader);
           
        //    this.pnlHeaderProduse = new HeaderProduse();
        //    this.pnlHeader.Controls.Add(pnlHeaderProduse);

        //    this.Controls.Add(pnlHeader);
        //}
   
        //private void setContainer()
        //{
        //    this.pnlContainer = new Panel();
        //    this.pnlContainer.Dock = DockStyle.Fill;
        //    PopulateContainer(pnlProductsContainer);
        //    this.pnlContainer.Controls.Add(pnlProductsContainer);

        //    this.Controls.Add(pnlContainer);
        //}

        //private void cart_Click(object sender, EventArgs e)
        //{
        //    this.pnlHeaderCart = new HeaderCart();
        //    removeHeaderControl("pnlHeaderProduse");
        //    this.pnlHeader.Controls.Add(pnlHeaderCart);

        //    this.pnlCartContainer = new PnlCartContainer();
        //    removeContainerControl("pnlProductsContainer");
        //    this.pnlContainer.Controls.Add(pnlCartContainer);

        //    //MessageBox.Show("da");

        //}

        public void removeHeaderControl(String name)
        {

            //Control aux = null;

           
            //foreach(Control ctrl in this.pnlHeader.Controls){

            //    if (ctrl.Name.Equals(name)) 
            //    {
            //        aux = ctrl;
            //        PerformLayout();
            //    }

            //}

            //if (aux != null)
            //{

            //    this.pnlHeader.Controls.Remove(aux);
            //    PerformLayout();
            //}

        }
        
        public void removeContainerControl(String name)
        {

            //Control aux = null;

           
            //foreach(Control ctrl in this.pnlContainer.Controls){
            //    if (ctrl.Name.Equals(name)) 
            //    {
            //        aux = ctrl;
            //        PerformLayout();
            //    }

            //}

            //if (aux != null)
            //{

            //    this.pnlContainer.Controls.Remove(aux);
            //    PerformLayout();
            //}

        }
    }
}
