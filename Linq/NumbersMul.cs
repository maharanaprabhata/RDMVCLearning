using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class NumbersMul
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 2, 3, 4, 5 };
            int result = Numbers.Aggregate(20,(a,b)=>a*b);
            //foreach (var i in Numbers)
            //{
            //    result *= i;
            //}
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
