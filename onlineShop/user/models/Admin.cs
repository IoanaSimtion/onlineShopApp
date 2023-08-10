using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.user.models
{
    internal class Admin : User
    {
        private bool readClients;
        private bool editClients;
        private bool readProducts;
        private bool editProducts;

        public Admin(bool readClients, bool editClients, bool readProducts, bool editProducts, string type, string id, string email, string password, string fullName, string address, string username) : base("admin", id, email, password, fullName, address,username)
        {
            this.readClients = readClients;
            this.editClients = editClients;
            this.readProducts = readProducts;
            this.editProducts = editProducts;
        }

        public Admin(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.readClients = Boolean.Parse(propr[7]);
            this.editClients = Boolean.Parse(propr[8]);
            this.readProducts = Boolean.Parse(propr[9]);
            this.editProducts = Boolean.Parse(propr[10]);
        }

        public bool ReadClients
        {
            get { return readClients; }
            set { readClients = value; }
        }

        public bool EditClients
        {
            get { return editClients; }
            set { editClients = value; }
        }

        public bool ReadProducts
        {
            get { return readProducts; }
            set { readProducts = value; }
        }

        public bool EditProducts
        {
            get { return editProducts; }
            set { editProducts = value; }
        }

        public override string ToString()
        {
            string text = base.ToString();

            if (this.readClients)
            {
                text += "Adminul poate citi clienti" + "\n";
            }
            else
            {
                text += "Adminul nu poate citi clienti" + "\n";
            }
            if (this.editClients)
            {
                text += "Adminul poate edita clienti" + "\n";
            }
            else
            {
                text += "Adminul nu poate edita clienti" + "\n";
            }
            if (this.readProducts)
            {
                text += "Adminul poate citi produse" + "\n";
            }
            else
            {
                text += "Adminul nu poate citi produse" + "\n";
            }
            if (this.editProducts)
            {
                text += "Adminul poate edita produse" + "\n";
            }
            else
            {
                text += "Adminul nu poate edita produse" + "\n";
            }

            return text;
        }


        public override string returnSave()
        {
            string save = base.returnSave();

            save += this.readClients + "," + this.editClients + "," + this.readProducts + "," + this.editProducts;

            return save;
        }
    }
}
