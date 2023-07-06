using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.order.models
{
    public class OrderDetails
    {
        private string orderId;
        private string productId;
        private int price;
        private int quantity;

        public OrderDetails()
        {

        }

        public OrderDetails(string productId, string orderId, int quantity, int price)
        {
            this.productId = productId;
            this.orderId = orderId;
            this.price = price;
            this.quantity = quantity;
        }

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
