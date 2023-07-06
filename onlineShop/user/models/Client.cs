using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.user.models
{
    public class Client : User
    {
        private bool abonament;
        private DateTime ultimaComanda;
        private bool blocked;

        public Client(string properties) : base(properties)
        {
            string[] propr = properties.Split(",");

            this.abonament = Boolean.Parse(propr[6]);
            string dateString = propr[7];
            string format = "dd/MM/yyyy";
            this.ultimaComanda = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            this.blocked = Boolean.Parse(propr[8]);

        }

        public Client(bool abonament, DateTime ultimaComanda, bool blocked, string type, string id, string email, string password, string fullName, string address) : base(type, id, email, password, fullName, address)
        {
            this.abonament = abonament;
            this.ultimaComanda = ultimaComanda;
            this.blocked = blocked;
        }

        public bool Abonament
        {
            get { return abonament; }
            set { abonament = value; }
        }

        public DateTime UltimaComanda
        {
            get { return ultimaComanda; }
            set { ultimaComanda = value; }
        }

        public bool Blocked
        {
            get { return blocked; }
            set { blocked = value; }
        }

        public override string ToString()
        {
            string text = base.ToString();

            if (this.abonament)
            {
                text += "Clientul are abonament" + "\n";
            }
            else
            {
                text += "Clientul nu are abonament" + "\n";
            }

            text += "Ultima comanda a fost data in data " + this.ultimaComanda.ToShortDateString() + "\n";
            if (this.blocked)
            {
                text += "Clientul este blocat" + "\n";
            }
            else
            {
                text += "Clinetul nu este blocat" + "\n";
            }

            return text;
        }

        public override string returnSave()
        {
            string format = "dd/MM/yyyy";

            string save = base.returnSave();

            save += this.abonament + "," + this.ultimaComanda.ToString(format) + "," + this.blocked;

            return save;
        }

    }
}
