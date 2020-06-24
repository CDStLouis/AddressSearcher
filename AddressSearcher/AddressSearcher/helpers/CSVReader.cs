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
        /*
         * Given a CSV path, reads corresponding CSV and returns List of Address objects
         * returns List<Address>
         */
        public List<Address> ReadCSV(string csvPath)
        {
            var reader = new StreamReader(csvPath);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            List<Address> records = csv.GetRecords<Address>().ToList();
            return records;
        }
    }
}