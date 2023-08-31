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

            StreamReader streamReader = new StreamReader(parent.FullName + @"/data/orders.txt");

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

        public void addOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Order> Orders { get { return orders; } }

        public Order findOrderById(string id)
        {
            for(int i = 0; i < orders.Count(); i++)
            {
                if (orders[i].Id.Equals(id))
                {
                    return orders[i];
                }
            }
            return null;
        }

        public string nextId()
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 1000000);

            while (findOrderById(randomNumber.ToString()) != null)
            {
                randomNumber = random.Next(1, 1000000);

            }

            return randomNumber.ToString();
        }

        public string saveOrderDetails()
        {
            string text = "";

            for (int i = 0; i < orders.Count(); i++)
            {
                text += orders[i].returnSave();
                text += "\n";
            }

            return text;
        }

        public void save()
        {
            string data = saveOrderDetails();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo parentDirectory = Directory.GetParent(currentDirectory);

            StreamWriter streamWriter = new StreamWriter(parentDirectory.FullName + @"/data/orders.txt");

            streamWriter.Write(data);

            streamWriter.Close();

        }

    }
}
