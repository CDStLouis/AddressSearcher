using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressSearcher.Models
{
    public class Address
    {
        [Name("Address")]
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}