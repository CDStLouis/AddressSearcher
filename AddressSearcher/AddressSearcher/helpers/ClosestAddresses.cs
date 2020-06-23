using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AddressSearcher.Models;

namespace AddressSearcher.helpers
{
    public class ClosestAddresses
    {
        public List<Address> calculate(string searchInput)
        {
            // code to find list of addresses from CSV
            // dummy code for addresses found
            var address = new Address() { Name = "38 New Address Road" };
            var address2 = new Address() { Name = "39 New Address Road" };
            var address3 = new Address() { Name = "40 New Address Road" };
            List<Address> addresses = new List<Address>();
            addresses.Add(address);
            addresses.Add(address2);
            addresses.Add(address3);
            return addresses;
        }
    }
}