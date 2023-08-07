using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {

        public CustomerRepository()
        {
            AddressRepository addressRepository = new AddressRepository();
            CustomerRepository customerRepository = new CustomerRepository();
        }
        public AddressRepository addressRepository { get; set; }
        public CustomerRepository customerRepository { get; set; }
    // Overloading: Methods w same name but different parameters.
    // I.e. Retrieve(int) is different from Retrieve()

    // Retrieve 1 customer
    public Customer Retrieve(int customerID)
    {
        Customer customer = new Customer(customerID);

        // For now we hard code in a customer
        // Later will tie to a database

        if (customerID == 1)
        {
            customer.EmailAddress = "s.squarepants@krustykrab.kom";
            customer.FirstName = "SpongeBob";
            customer.LastName = "SquarePants";
            customer.AddressList = addressRepository.RetrieveByCustomerID(customerID).ToList();
        }
        return customer;
    }


    // Retrieve a list of all customers
    public List<Customer> Retrieve()
    {
        return new List<Customer>();
    }

    // Saves the current customer

    public bool Save()
    {
        return true;
    }
}
}
