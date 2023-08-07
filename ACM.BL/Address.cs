using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ACM.BL
{
    public class Address
    {
        // Constructors

        public Address() { }

        public Address(int addressID) {
            AddressID = addressID;
        }

        public int AddressID { get; private set; }


        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }    
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public int AddressType { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Street1)) isValid = false;
            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(State)) isValid = false;
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;
            return isValid;
        }
    }
}
