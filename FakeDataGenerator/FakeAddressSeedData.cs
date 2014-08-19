using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataGenerator
{
    class FakeAddressSeedData
    {
        public static string[] StreetSuffixesFull = { "street", "avenue", "drive", "boulevard", "road", "lane", "place", "circle", "terrace", "freeway" };
        public static string[] StreetSuffixesAbbreviated = { "st", "ave", "dr", "blvd", "rd", "ln", "pl", "crl" }; 
        public static string[] StreetDirectionFull = { "East", "North", "West", "South", "North East", "North West", "South East", "South West" };
    }
}
