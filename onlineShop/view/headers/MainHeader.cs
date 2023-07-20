using onlineShop.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.headers
{
    internal class MainHeader : Panel
    {
        
        private Label titlu;
        public MainHeader(Panel panel)
        {
            this.Name = Constants.MAIN_HEADER;

            titlu = new Label();
            titlu.Text = "Online shop";
            titlu.Location = new Point(850, 30);
            titlu.Size = new Size(300, 300);
            titlu.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            titlu.ForeColor = Color.White;

            this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(74, 85, 162);
            this.Height = 94;

            this.Controls.Add(titlu);

            panel.Controls.Add(this);
        }
        public string Label
        {
            get { return titlu.Text; }
            set { titlu.Text = value; }
        }
    }
}
