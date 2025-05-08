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

        public Product findProductById(string id)
        {
            foreach(Product product in products)
            {
                if (product.Id.Equals(id))
                {
                    return product;
                }
            }
            return null;
        }

        public void sortareCrescatorNume()
        {
            bool flag = true;

            do
            {
                flag = true;
                for(int i = 0; i < products.Count - 1; i++)
                {
                    if (products[i].Name.CompareTo(products[i+1].Name)>0)
                    {
                        Product aux = new Product();
                        aux = products[i];
                        products[i] = products[i + 1];
                        products[i + 1] = aux;
                        flag = false;
                    }
                }

            } while (flag == false);
        } 
        
        public void sortareDescrescatorNume()
        {
            bool flag = true;

            do
            {
                flag = true;
                for(int i = 0; i < products.Count - 1; i++)
                {
                    if (products[i].Name.CompareTo(products[i+1].Name)<0)
                    {
                        Product aux = new Product();
                        aux = products[i];
                        products[i] = products[i + 1];
                        products[i + 1] = aux;
                        flag = false;
                    }
                }

            } while (flag == false);
        }

        public void sortareCrescatorPret()
        {
            bool flag = false;

            do
            {
                flag = true;
                for (int i = 0; i < products.Count - 1; i++)
                {
                    if (products[i].Price > products[i + 1].Price)
                    {
                        Product aux = new Product();
                        aux = products[i];
                        products[i] = products[i + 1];
                        products[i + 1] = aux;
                        flag = false;
                    }
                }
            } while (flag == false);
        }
        
        public void sortareDescrescatorPret()
        {
            bool flag = false;

            do
            {
                flag = true;
                for (int i = 0; i < products.Count - 1; i++)
                {
                    if (products[i].Price < products[i + 1].Price)
                    {
                        Product aux = new Product();
                        aux = products[i];
                        products[i] = products[i + 1];
                        products[i + 1] = aux;
                        flag = false;
                    }
                }
            } while (flag == false);
        }

        public void filtrarePret(int minim, int maxim)
        {
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i].Price<minim || products[i].Price > maxim)
                {                    
                    products.Remove(products[i]);
                    i--;
                }
            }
        } 
        
        public void filtrareMarime(string marime)
        {
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i].Marimi.Contains(marime)==false)
                {                    
                    products.Remove(products[i]);
                    i--;
                }
            }
        }
        public void filtrareCuloare(string culoare)
        {
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i].Culori.Contains(culoare)==false)
                {                    
                    products.Remove(products[i]);
                    i--;
                }
            }
        }
    }
}
