using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class countries
    {
        static void Main(string[] args)
        {
            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };
            IEnumerable<string> result = countries.SkipWhile(a=>a.Length>2);
                //(from c in countries select c).TakeWhile(a=>a.Length>2);

            foreach (string country in result)
            {
                Console.WriteLine(country);
            }
            Console.Read();
        }
    }
}
