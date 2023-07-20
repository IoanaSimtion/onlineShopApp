using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.order.models
{
    public class Order : OrderDetails
    {
        private string id;
        private string customerId;

        public Order(string properties)
        {
            string[] propr = properties.Split(",");

            this.id = propr[0];
            this.customerId = propr[1];
            
        }

        public Order(string id, string customerId)
        {
            this.id = id;
            this.customerId = customerId;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
    }
}
