﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.secondaryHeaders
{
    internal class Header : Panel
    {
        private Label text;
        public Header(Panel panel)
        {
            text = new Label();
            text.Text = "Text";
            text.Width = 300;
            text.Location = new Point(10, 15);
            text.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            text.ForeColor = Color.FromArgb(128, 0, 64);

            //this.Dock = DockStyle.Top;
            this.Location = new Point(0, 94);
            //this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(232, 200, 208);
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
