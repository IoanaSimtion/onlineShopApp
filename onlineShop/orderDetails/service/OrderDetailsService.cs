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
    }
}
