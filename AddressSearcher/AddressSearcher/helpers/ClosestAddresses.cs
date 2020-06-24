using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AddressSearcher.Models;
using Microsoft.Ajax.Utilities;

namespace AddressSearcher.helpers
{
    public class ClosestAddresses
    {
        public List<Address> Calculate(Address searchInput)
        {
            var csv = new CSVReader();
            var addresses = csv.ReadCSV();
            List<Address> tenClosest = new List<Address>();
            int counter = 0;

            foreach (Address address in addresses) //enumeration may not execute error
            {
                if (searchInput.Name == address.Name)
                {
                    continue;
                }
                else if (counter < 10)
                {
                    tenClosest.Add(address);
                    counter++;
                }
                else
                {
                    List<Address> currentTenClosest = tenClosest;
                    foreach (Address shortlist in currentTenClosest)
                    {
                        // if address distance larger than shortlist distance replace
                        if ( Distance(address, searchInput) < Distance(shortlist, searchInput) )
                        {
                            tenClosest[tenClosest.FindIndex(ind => ind.Equals(shortlist))] = address;
                            break;
                        }
                    }
                }
            }
            return tenClosest; // CURRENTLY RETURNS ALL THE ADDRESSES! FIX!!!
        }

        private float Distance(Address address1, Address address2)
        {
            float diffInLattitude = address1.Latitude - address2.Latitude;
            float diffInLongitude = address1.Longitude - address2.Longitude;
            float distance = (float)Math.Sqrt( Math.Pow(diffInLattitude, 2) + Math.Pow(diffInLongitude, 2) );

            return distance;
        }
    }
}