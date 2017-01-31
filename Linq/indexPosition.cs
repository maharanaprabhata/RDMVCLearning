using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class indexPosition
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenNumberIndexPosition = numbers.Select((num, index) => new { Number = num, Index = index }).Where(x => x.Number % 2 == 0).Select(x => x.Index);
            foreach (var evenNumber in evenNumberIndexPosition)
            {
                Console.WriteLine(evenNumber);
            }
            Console.Read();
        }
    }
}
