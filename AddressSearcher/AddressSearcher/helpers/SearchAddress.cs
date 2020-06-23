using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using AddressSearcher.Models;

namespace AddressSearcher.helpers
{
    public class SearchAddress
    {
        public List<Address> find(string searchInput)
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