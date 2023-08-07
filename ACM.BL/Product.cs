using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        // Constructors
        public Product() { }
        public Product(int productID) 
        {
            ProductID = productID;
        }

        // Accessors
        public int ProductID { get; private set; }

        // The ? makes the decimal nullable
        public decimal? CurrentPrice { get; set; }

        public string ProductDescription { get; set; }
        private string _productName;
        public string ProductName { 
            get
            {
                
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            } 
        } 

   

        // Overriding a default method w a new definition
        public override string ToString()
        {
            return ProductName;
        }

        // Methods
      

        // Validate the current product

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;
            if (CurrentPrice == null) isValid = false;
         
            return isValid;
        }

    }
}
