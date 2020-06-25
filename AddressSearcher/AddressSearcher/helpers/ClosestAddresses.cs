using System;
using System.Collections.Generic;
using System.IO;
using AddressSearcher.Models;

namespace AddressSearcher.helpers
{
    public class ClosestAddresses
    {
        public string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data/Data.csv");

        /*
         * Given an Address object, return 10 closest address by Longitude and Lattitude
         * returns List<Address>
         */
        public List<Address> Calculate(Address searchInput)
        {
            var csv = new CSVReader();
            var addresses = csv.ReadCSV(csvPath);
            List<Address> tenClosest = new List<Address>();

            int counter = 0;

            foreach (Address address in addresses)
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
                        if ( Distance(address, searchInput) < Distance(shortlist, searchInput) )
                        {
                            tenClosest[tenClosest.FindIndex(ind => ind.Equals(shortlist))] = address;
                            break;
                        }
                    }
                }
            }
            return tenClosest;
        }

        /*
         * Given two address objects calulates distance between the two using Lattitude and Longitude
         * returns float
         */
        private float Distance(Address address1, Address address2)
        {
            float diffInLattitude = address1.Latitude - address2.Latitude;
            float diffInLongitude = address1.Longitude - address2.Longitude;
            float distance = (float)Math.Sqrt( Math.Pow(diffInLattitude, 2) + Math.Pow(diffInLongitude, 2) );

            return distance;
        }
    }
}