using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return inputString;
        }
        static void Main(string[] args)
        {
            string strName = "prava";
            strName = strName.ChangeFirstLetterCase();
            Console.WriteLine(strName);
            List<int> lstNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            IEnumerable<int> oddNum = lstNumbers.Where(a => a % 2 != 0);
            foreach (var item in oddNum)
            {
                Console.WriteLine(item);
            }
            int minNum = lstNumbers.Min();
            Console.WriteLine("minNum {0}",minNum);
            int maxNum = lstNumbers.Max();
            int sumAllNum = lstNumbers.Sum();
            double avgOfNum = lstNumbers.Average();
            int countOfNum = lstNumbers.Count();
            int firstNum = lstNumbers.First();

            Console.Read();
        }
    }
}
