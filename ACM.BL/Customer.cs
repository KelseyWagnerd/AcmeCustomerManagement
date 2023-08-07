using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ACM.BL
{
    public class Customer 
    {
        // the Constructors
        // The "this" keyword ties together the constructors?
        // So now the default CustomerID is 0
        public Customer(): this(0)
        {

        }

        // Whenever a Customer is created, they are given an ID
        // and an empty list of addresses is created
        // Later will tie to Address Repository
        public Customer(int customerID)
        {
            CustomerID = customerID;
            AddressList = new List<Address>();
        }


        // the Accessors
        // Get: It can be updated by getting it from UI.
        // Any processing can also occur in the Get code block
        // Set: It can be set to a new value after validation
        // No getter = Write only. No setter = Read only. 

        public List<Address> AddressList { get; set; }

        public int CustomerID { get; private set; }

        public int CustomerType { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        // the "Backing Field"
        // The actual data is stored privately to protect it
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        EntityState entity = new Entity();

        public string Log()
        {
            return $"{CustomerID}: {FirstName} {LastName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        }

        public override string ToString() => FullName;

        // the Methods
        // Checks that last name and email address fields are valid
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

       
        public static int InstanceCount { get; set; }
    }   
}
    

