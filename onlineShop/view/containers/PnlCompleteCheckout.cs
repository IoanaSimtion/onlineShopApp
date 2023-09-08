using onlineShop.order.service;
using onlineShop.orderDetails.service;
using onlineShop.product.models;
using onlineShop.product.service;
using onlineShop.system.cart;
using onlineShop.user.models;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
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
        private int totalPrice;

        public PnlCompleteCheckout(Panel panel, MainPage main, User user, OrderService orders, OrderDetailsService orderDetails, ProductService products) : base(panel)
        {
            this.utilizator = user;
            this.orderService = orders;
            this.orderDetailsService = orderDetails;
            this.produse = products;
            this.form = main;
            this.Dock = DockStyle.Fill;

            setPage();

            getTotalPrice();
        }

        void getTotalPrice()
        {            

            this.form.cartActions.CartItems.ForEach(item => {


                Product prod = produse.findProductById(item.Id);

                totalPrice += prod.Price * item.Cantitate;


            });
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
        public void GeneratePdfWithTable(string outputPath)
        {
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.Pages.Add();

                PdfGraphics graphics = page.Graphics;

                PdfFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20, PdfFontStyle.Regular);
                PdfFont font2B = new PdfStandardFont(PdfFontFamily.TimesRoman, 14,PdfFontStyle.Bold);
                PdfFont font2R = new PdfStandardFont(PdfFontFamily.TimesRoman, 14,PdfFontStyle.Regular);
                PdfFont font3 = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);

                PdfPen pen = new PdfPen(Color.BlueViolet);

                PdfTextElement titlu = new PdfTextElement("Comanda ta", font, pen);
                titlu.Draw(graphics, new PointF(200, 10));
                

                PdfTextElement pret = new PdfTextElement("Pret total: $" + totalPrice.ToString() + " (taxa inclusa)", font2R);
                pret.Draw(graphics, new PointF(10, 200));

                PdfTextElement nume = new PdfTextElement("Nume: " + utilizator.FullName, font2R);
                nume.Draw(graphics, new PointF(10, 220));

                PdfTextElement adresa = new PdfTextElement("Adresa de livrare: " + utilizator.Address, font2R);
                adresa.Draw(graphics, new PointF(10, 240));

                // Create a PDF table
                PdfGrid pdfGrid = new PdfGrid();
                pdfGrid.Columns.Add(3); // Add 3 columns

                // Add header row
                pdfGrid.Headers.Add(1);
                pdfGrid.Headers[0].Cells[0].Value = "Denumire";
                pdfGrid.Headers[0].Cells[0].Style.Font = font2B;
                pdfGrid.Headers[0].Cells[0].StringFormat.Alignment = PdfTextAlignment.Center;
                pdfGrid.Headers[0].Cells[1].Value = "Pret";
                pdfGrid.Headers[0].Cells[1].Style.Font = font2B;
                pdfGrid.Headers[0].Cells[1].StringFormat.Alignment = PdfTextAlignment.Center;
                pdfGrid.Headers[0].Cells[2].Value = "Cantitate";
                pdfGrid.Headers[0].Cells[2].Style.Font = font2B;
                pdfGrid.Headers[0].Cells[2].StringFormat.Alignment = PdfTextAlignment.Center;

                // Add data rows
                for (int i = 0; i < orderDetailsService.numarProduse(); i++)
                {
                    pdfGrid.Rows.Add();
                    pdfGrid.Rows[i].Cells[0].Value = produse.findProductById(orderDetailsService.Orders[i].ProductId).Name;
                    pdfGrid.Rows[i].Cells[0].Style.Font = font3;
                    pdfGrid.Rows[i].Cells[0].StringFormat.Alignment = PdfTextAlignment.Center;
                    pdfGrid.Rows[i].Cells[1].Value = "$"+orderDetailsService.Orders[i].Price.ToString();
                    pdfGrid.Rows[i].Cells[1].Style.Font = font3;
                    pdfGrid.Rows[i].Cells[1].StringFormat.Alignment = PdfTextAlignment.Center;
                    pdfGrid.Rows[i].Cells[2].Value = orderDetailsService.Orders[i].Quantity.ToString();
                    pdfGrid.Rows[i].Cells[2].Style.Font = font3;
                    pdfGrid.Rows[i].Cells[2].StringFormat.Alignment = PdfTextAlignment.Center;
                }

                // Draw the PDF grid
                pdfGrid.Draw(page, new PointF(10, 50));

                // Save the PDF to the specified output path
                document.Save(outputPath);
            }
        }

        private void savePDF()
        {
            // Set up SaveFileDialog to choose download location
            var saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Save PDF"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Copy generated PDF to the chosen location
                var outputPath = "output.pdf";
                File.Copy(outputPath, saveDialog.FileName, true);
                MessageBox.Show("PDF saved successfully!");
            }
        }
        private void pdf_Click(object sender, EventArgs e)
        {
            var outputPath = "output.pdf"; // Provide the desired output path
            this.GeneratePdfWithTable(outputPath);
            //MessageBox.Show("PDF generated successfully!");

            savePDF();

        }
        private void home_Click(object sender, EventArgs e)
        {
            form.removeControl("pnlCheckout3");

            this.PerformLayout();

            form.setProductsPage();
        }
    }
}
