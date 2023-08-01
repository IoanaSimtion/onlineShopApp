using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.view.menuPanel
{
    public class Menu : Panel
    {
        public Menu(MainPage main, Panel panel)
        {
            this.Location = new Point(0, 0);

            this.Size = new Size(100, 200);

            this.BackColor=Color.Red;

            this.BringToFront();

            panel.Controls.Add(this);

            MessageBox.Show("aici");

        }

    }
}
