using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if(addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.PostalCode = 144122;
                address.Country = "Middle Earth";
                address.AddressType = 1;
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                PostalCode = 144122,
                Country = "Middle Earth",
                AddressType = 1
            };
            addressList.Add(address);

            address = new Address(2)
            {
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                PostalCode = 146123,
                Country = "Middle Earth",
                AddressType = 2
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
