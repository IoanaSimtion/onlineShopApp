using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.checkoutPage
{
    internal class CheckoutInfoPanel : Panel
    {
        private TextBox firstName;
        private TextBox lastName;
        private TextBox zip;
        public CheckoutInfoPanel()
        {
            this.Location = new Point(700, 150);
            this.BackColor = Color.FromArgb(240, 251, 255);
            this.Width = 500;
            this.Height = 250;
            setInfoPanel();
        }

        private bool validateInfo()
        {
            string text = "";

            if (firstName.Text.Equals(""))
            {
                text += "Enter your first name \n";
            }
            if (lastName.Text.Equals(""))
            {
                text += "Enter your last name \n";
            }
            if (zip.Text.Equals(""))
            {
                text += "Enter your zip/postal code";
            }

            if (text.Length > 0)
            {
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        void setInfoPanel()
        {
            firstName = new TextBox();
            lastName = new TextBox();
            zip = new TextBox();

            firstName.PlaceholderText = "First Name";
            firstName.Font= new Font("Century Gothic", 12, FontStyle.Regular);
            firstName.Location = new Point(20, 30);
            firstName.Width = 460;

            lastName.PlaceholderText = "Last Name";
            lastName.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            lastName.Location = new Point(20,100);
            lastName.Width = 460;

            zip.PlaceholderText = "Zip/Postal code";
            zip.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            zip.Location = new Point(20, 170);
            zip.Width = 460;

            this.Controls.Add(firstName);
            this.Controls.Add(lastName);
            this.Controls.Add(zip);
        }
    }
}
