using onlineShop.orderDetails.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.orderDetails.service
{
    public class OrderDetailsService
    {
        private List<OrderDetails> orderDetails;

        public OrderDetailsService()
        {
            orderDetails = new List<OrderDetails>();

        }

        public void afisare()
        {
            for (int i = 0; i < orderDetails.Count; i++)
            {
                Debug.WriteLine(orderDetails[i]);

            }
        }

        public List<OrderDetails> Orders { get { return orderDetails; } }

        public void addItem(OrderDetails order)
        {
            this.orderDetails.Add(order);
        }
        public void removeItem(OrderDetails order)
        {
            this.orderDetails.Remove(order);
        }

        public string saveOrderDetails()
        {
            string text = "";

            for(int i = 0; i < orderDetails.Count(); i++)
            {
                text += orderDetails[i].returnSave();
                text += "\n";
            }

            return text;
        }

        public void save()
        {
            string data = saveOrderDetails();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo parentDirectory = Directory.GetParent(currentDirectory);

            StreamWriter streamWriter = new StreamWriter(parentDirectory.FullName + @"/data/orderDetails.txt");

            streamWriter.Write(data);

            streamWriter.Close();

        }

        public int numarProduse()
        {
            return Orders.Count;
        }
    }
}
