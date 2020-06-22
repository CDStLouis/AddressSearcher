using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressSearcher.Models
{
    public class Address
    {
        public string AddressName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}