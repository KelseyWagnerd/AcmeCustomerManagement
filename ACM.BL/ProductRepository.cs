using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        // Retrieve 1 product

        public Product Retrieve(int productID)
        {
            Product product = new Product();

            if (productID == 1)
            {
                product.ProductName = "HydroDynamic Spatula";
                product.ProductDescription = "With port and starboard attachments, and turbo drive.";
                product.CurrentPrice = 2999.99M;
            }
            Object myObject = new object();
            Console.WriteLine($"Here is the object: {myObject.ToString()}");
            Console.WriteLine($"Here is the product: {product.ToString()}");
            return product;
        }

        // Save the current product
        public bool Save(Product product)
        {
            var success = true; 
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored procedure
                    }
                }
                else 
                {
                success = false;
                }
            }
            return success;
        }
    }
}
