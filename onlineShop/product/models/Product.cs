using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.product.models
{
    public class Product
    {
        private string id;
        private string name;
        private float price;
        private string description;
        private string image;
        private int stock;
        private List<string> marimi;

        public Product()
        {

        }

        public Product(string id, string name, int price, string description, string image, int stock)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.image = image;
            this.stock = stock;
        }

        public Product(string properties)
        {
            marimi = new List<string>();

            string[] propr = properties.Split(",");

            this.id = propr[0];
            this.name = propr[1];
            this.price = float.Parse(propr[2]);
            this.description = propr[3];
            this.image = propr[4];
            this.stock = Int32.Parse(propr[5]);
            for(int i = 6; i < propr.Length; i++)
            {
                this.marimi.Add(propr[i]);
            }
        }

        public List<string> Marimi
        {
            get { return marimi; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public override string ToString()
        {
            string text = "";

            text += "Id-ul produsului este " + id + "\n";
            text += "Numele produsului este " + name + "\n";
            text += "Pretul produsului este " + price + "\n";
            text += "Descrierea produsului este " + description + "\n";
            text += "Stocul produsului este " + stock + "\n";

            return text;
        }

    }
}
