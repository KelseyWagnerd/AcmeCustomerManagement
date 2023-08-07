using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class AddressRepository
    {
        // Retrieve 1 address
        public Address Retrieve(int addressID)
        {
            // Create a new instance of Address class
            // Pass in requested ID
            Address address = new Address(addressID);

            // Retrieves defined address
            // Temporary hard-coding an address

            if (addressID == 1)
            {
                address.AddressType = 1;
                address.Street1 = "Rock Bottom Road";
                address.City = "Bikini Bottom";
                address.State = "Bikini Atoll";
                address.Country = "USA";
                address.PostalCode = "666";
             }
            return address;
        }

        // Use IEnumerable for retrieving multiple objects
        // More flexible than a list 

        public IEnumerable<Address> RetrieveByCustomerID(int customerID) {

            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                Street1 = "Rock Bottom Road",
                City = "Bikini Bottom",
                State = "Bikini Atoll",
                Country = "USA",
                PostalCode = "666"
            };
        addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                Street1 = "Creepy Street",
                City = "Rock Bottom",
                State = "Bikini Atoll",
                Country = "USA",
                PostalCode = "666"
            };
        addressList.Add(address);
            return addressList;
        
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
