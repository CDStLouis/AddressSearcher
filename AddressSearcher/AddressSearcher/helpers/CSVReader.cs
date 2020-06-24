using System.Collections.Generic;
using System.Linq;
using CsvHelper;
using AddressSearcher.Models;
using System.IO;
using System.Globalization;

namespace AddressSearcher.helpers
{
    public class CSVReader
    {
        public List<Address> ReadCSV()
        {
            var reader = new StreamReader("//Mac/Home/Documents/Address Searcher Project/AddressSearcher/AddressSearcher/data/Data.csv");
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            List<Address> records = csv.GetRecords<Address>().ToList();
            return records;
        }
    }
}