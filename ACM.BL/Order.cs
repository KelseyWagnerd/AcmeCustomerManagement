using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
  public class Order
    {
        // the Constructors
        public Order(): this (0) { }
        public Order(int orderID)
        {
            OrderID = orderID;
            OrderItems = new List<OrderItem>();
        }
        public int OrderID { get; private set; }

        public int CustomerID { get; set; }

        // Use DateTimeOffset to compare times across time zones
        public DateTimeOffset? OrderDate { get; set; }

        public string ShippingAddress { get; set; }

        public int ShippingAddressID { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public override string ToString() =>$"{OrderDate.Value.Date} ({OrderID})";


        // Validate the current order

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            if (string.IsNullOrWhiteSpace(ShippingAddress)) isValid = false;
            return isValid;
        }
    }
}
