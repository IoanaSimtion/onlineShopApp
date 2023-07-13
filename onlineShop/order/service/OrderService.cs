using onlineShop.order.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.order.service
{
    public class OrderService
    {
        private List<Order> orders;

        public OrderService()
        {
            orders = new List<Order>();

            load();
        }

        public void load()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo parent = Directory.GetParent(currentDirectory);

            StreamReader streamReader = new StreamReader(parent.FullName + @"/data/products.txt");

            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {
                orders.Add(new Order(line));

            }
            streamReader.Close();
        }

        public void afisare()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                Debug.WriteLine(orders[i]);

            }
        }

        public List<Order> Orders { get { return orders; } }
    }
}
