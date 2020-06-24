using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            return first20matches;
        }
    }
}