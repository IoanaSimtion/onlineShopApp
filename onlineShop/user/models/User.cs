using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.user.models
{
    public class User
    {
        private string id;
        private string email;
        private string password;
        private string fullName;
        private string address;
        private string type;
        private string username;


        public User(string type, string id, string email, string password, string fullName, string address, string username)
        {
            this.type = type;
            this.id = id;
            this.email = email;
            this.address = address;
            this.password = password;
            this.fullName = fullName;
            this.username = username;
        }

        public User(string properties)
        {
            string[] propr = properties.Split(",");

            this.type = propr[0];
            this.id = propr[1];
            this.email = propr[2];
            this.password = propr[3];
            this.fullName = propr[4];
            this.address = propr[5];
            this.username = propr[6];


        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public override string ToString()
        {
            string text = "";

            text += "Id-ul este " + this.id + "\n";
            text += "Numele este " + this.fullName + "\n";
            text += "Emailul este " + this.email + "\n";
            text += "Parola este " + this.password + "\n";
            text += "Adresa este " + this.address + "\n";

            return text;
        }

        public virtual string returnSave()
        {
            string save = this.type + "," + this.id + "," + this.email + "," + this.password + "," + this.fullName + "," + this.address + ",";

            return save;
        }

    }
}
