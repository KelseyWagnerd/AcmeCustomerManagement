using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        // Retrieve 1 order

        public Order Retrieve(int orderID)
        {
            Order order = new Order();

            if (orderID == 000)
            {
                order.ShippingAddress = "Yo Mama's House";
            }
            return order;
        }

        // Save the current order
        public bool Save()
        {
            return true;
        }

    }
}
