using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gap_in_Primes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gap(2,100,110));
            Console.ReadKey();

        }

        public static long[] Gap(int g, long m, long n)
        {
            var gap = g;
            var start = m;
            var end = n;


            while (start <= end)
            {
                Console.WriteLine("{0}, {1}",isPrime(start), start);
                var count = 0;
                if(isPrime(start))
                    count++;

                Console.WriteLine(count);
                start++;
            }
            return new long[] {1,2};
        }
        public static bool isPrime(long number)
        {
            List<int> divisors = new List<int>();
            int divisor = 1;
            while (divisor <= number)
            {
                if(number % divisor == 0)
                    divisors.Add(divisor);
                divisor++;
            }
            return divisors.Count() == 2;
        }
    }
}
