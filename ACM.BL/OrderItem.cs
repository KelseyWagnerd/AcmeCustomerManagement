using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        // the Constructors
        public OrderItem() { }
        public OrderItem (int orderItemID)
        {
            OrderItemID = orderItemID;
        }
        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

      

        // Retrieve 1 order item

        public OrderItem Retrieve(int orderItemID)
        {
            return new OrderItem();
        }

        // Retrieve list of all order items
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        // Save the current order item
        public bool Save()
        {
            return true;
        }

        // Validate the current product

        public bool Validate()
        {
            var isValid = true;
            if (ProductID <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;
            return isValid;
        }
    }
}
