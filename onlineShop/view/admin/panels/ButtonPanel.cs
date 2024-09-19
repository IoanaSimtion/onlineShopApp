using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.admin.panels
{
    internal class ButtonPanel : Panel
    {
        Button dashboard;
        Button showOrders;
        Button showCustomers;
        Button editProducts;
        Button manageCustomers;

        public ButtonPanel(Panel parent)
        {
            setPage();
            this.Dock = DockStyle.Left;
            this.Size = new Size(350, 1000);
            this.BackColor = Color.LightBlue;
            parent.Controls.Add(this);
        }
        void setPage()
        {
            dashboard = new Button();
            showOrders = new Button();
            showCustomers = new Button();
            editProducts = new Button();
            manageCustomers = new Button();

            dashboard.Text = "Dashboard";
            showOrders.Text = "Show orders";
            showCustomers.Text = "Show customers";
            editProducts.Text = "Edit products";
            manageCustomers.Text = "Manage customers";

            dashboard.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            showCustomers.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            showOrders.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            editProducts.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            manageCustomers.Font = new Font("Century Gothic", 14, FontStyle.Regular);

            dashboard.Location = new Point(50, 50);
            showCustomers.Location = new Point(50, 200);
            showOrders.Location = new Point(50, 350);
            editProducts.Location = new Point(50, 500);
            manageCustomers.Location = new Point(50, 650);

            dashboard.Size = new Size(200, 50);
            showCustomers.Size = new Size(200, 50);
            showOrders.Size = new Size(200, 50);
            editProducts.Size = new Size(200, 50);
            manageCustomers.Size = new Size(200, 50);

            this.Controls.Add(dashboard);
            this.Controls.Add(showOrders);
            this.Controls.Add(showCustomers);
            this.Controls.Add(editProducts);
            this.Controls.Add(manageCustomers);



        }
    }
}
