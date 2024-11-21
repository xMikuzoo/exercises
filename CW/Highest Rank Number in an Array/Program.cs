using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_Rank_Number_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighestRank(12, 10, 8, 12, 7, 6, 4, 10, 12));
            Console.WriteLine(HighestRank(12, 10, 8, 8, 3, 3, 3, 3, 2, 2, 2, 2, 4, 10, 12, 10));
        }

        public static int HighestRank(params int[] arr)
        {
            var highestRank = arr
                .GroupBy(x => x)
                .Select(x => new { Number = x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .OrderByDescending (x => x.Number)
                .FirstOrDefault();
            return highestRank.Number;
        }
    }
}
