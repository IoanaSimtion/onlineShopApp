using onlineShop.product.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.product.service
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();

            this.load();
        }

        public List<Product> Products { get { return products; } }
        public void load()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo parent = Directory.GetParent(currentDirectory);

            StreamReader streamReader = new StreamReader(parent.FullName + @"/data/products.txt");

            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {
                products.Add(new Product(line));

            }
            streamReader.Close();
        }

        public void afisare()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Debug.WriteLine("produsul " + i);
                Debug.WriteLine(products[i]);                
                
            }
        }

        public int cardsNumber()
        {
            return products.Count;
        }

        
    }
}
