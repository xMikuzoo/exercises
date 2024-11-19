using System;
using System.Collections.Generic;
using System.Linq;

namespace Integers_Recreation_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(listSquared(1,10000));
            Console.ReadKey();
        }

        public static string listSquared(long m, long n)
        {
            var a = (int) m; var b = (int)n;
            if (a < 1 || a > b) return "Invalid range";

            List<string> valids = new List<string>();
            for (int i = a; i < b; i++)
            {
                List<int> divisors = new List<int>();
                var squaredDivisorsSum = 0;

                for(int j = 1; j <= i; j++)
                    if (i % j == 0)
                        divisors.Add(j);

                for (int x = 0; x < divisors.Count(); x++)
                    squaredDivisorsSum += (int) Math.Pow(divisors[x],2);

                double sqrtSquaredDivisorsSum = Math.Sqrt(squaredDivisorsSum);
                if (Math.Pow(sqrtSquaredDivisorsSum, 2) == squaredDivisorsSum && sqrtSquaredDivisorsSum == (int)sqrtSquaredDivisorsSum)
                    valids.Add(string.Format("[{0}, {1}]", i, squaredDivisorsSum));
            }
            return "[" + string.Join(", ", valids) + "]";
        }
    }
}
