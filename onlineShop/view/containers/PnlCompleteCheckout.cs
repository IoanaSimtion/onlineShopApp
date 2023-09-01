using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.user.models;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.containers
{
    internal class PnlCompleteCheckout : PnlContainer
    {
        private User utilizator;
        private OrderService orderService;
        private OrderDetailsService orderDetailsService;
        private ProductService produse;
        private MainPage form;
        private Label mesaj;
        private Button home;
        private LinkLabel pdf;

        public PnlCompleteCheckout(Panel panel, MainPage main, User user, OrderService orders, OrderDetailsService orderDetails, ProductService products) : base(panel)
        {
            this.utilizator = user;
            this.orderService = orders;
            this.orderDetailsService = orderDetails;
            this.produse = products;
            this.form = main;
            this.Dock = DockStyle.Fill;

            setPage();
        }

        void setPage()
        {
            mesaj = new Label();
            mesaj.Text = "Thank you for your order!";
            mesaj.Font = new Font("Century Gothic", 22, FontStyle.Bold);
            mesaj.Location = new Point(740, 200);
            mesaj.Size = new Size(700, 100);

            home = new Button();
            home.Location = new Point(850, 300);
            home.Text = "Back Home";
            home.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            home.Size = new Size(200, 50);

            home.Click += home_Click;

            pdf = new LinkLabel();
            pdf.Text = "download PDF";
            pdf.Location = new Point(865, 380);
            pdf.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            pdf.Size = new Size(200, 100);

            pdf.Click += pdf_Click;

            this.Controls.Add(home);
            this.Controls.Add(mesaj);
            this.Controls.Add(pdf);
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Generated PDF";

            // Create a page
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
                   new XRect(0, 0, page.Width, page.Height),
                   XStringFormats.Center);

            // Prompt user to save the PDF
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.Title = "Save the PDF";
                sfd.FileName = "output.pdf"; // Default name

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    document.Save(filename);
                    MessageBox.Show($"PDF saved to {filename}!");
                }
            }
        }
        private void home_Click(object sender, EventArgs e)
        {
            form.removeControl("pnlCheckout3");

            this.PerformLayout();

            form.setProductsPage();
        }
    }
}
