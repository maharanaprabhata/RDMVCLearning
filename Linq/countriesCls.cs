using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class countriesCls
    {
        static void Main(string[] args)
        {
            string[] countries = { "India", "Us", "Canada", "Australia" };
            //string result = string.Empty;
            //for (int i = 0; i < countries.Length; i++)
            //{
            //    result += countries[i] + ",";
            //}
            //int lstIndex = result.LastIndexOf(",");
            //result = result.Remove(lstIndex)+".";
            string result = countries.Aggregate((a, b) => a + "," + b);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
