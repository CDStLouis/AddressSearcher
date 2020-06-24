using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Web;
using AddressSearcher.Models;

namespace AddressSearcher.helpers
{
    public class SearchAddress
    {
        public List<Address> Find(string searchInput)
        {
            var csv = new CSVReader();
            var addresses = csv.ReadCSV();
            List<Address> first20matches = new List<Address>();
            Regex regex = new Regex(searchInput);

            int counter = 0;
            foreach (Address address in addresses)
            {
                if (counter == 20)
                {
                    break;
                }
                else if (regex.IsMatch(address.Name))
                {
                    first20matches.Add(address);
                    counter++;
                }
            }
            // for loop going over every object in a list and comparing the address with a regex made from the searchInput string, showing a max of 20

            //List<Address> addresses = test.Take(5).ToList();
            return first20matches;
        }
    }
}