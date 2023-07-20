using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    internal class Header : Panel
    {
        private Label text;
        public Header(Panel panel)
        {
            text = new Label();
            text.Text = "Text";
            text.Location = new Point(10, 15);
            text.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            text.ForeColor = Color.FromArgb(74, 85, 162);

            //this.Dock = DockStyle.Top;
            this.Location = new Point(0, 94);
            //this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(197, 223, 248);
            this.Height = 53;
            this.Width = 2000;
            this.Name = "pnlHeader";
            this.BringToFront();

            this.Controls.Add(text);

        }

        public string Label
        {
            get { return text.Text; }
            set { text.Text = value; }
        }
    }
}
