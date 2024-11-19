using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factors(7775460));

            Console.ReadKey();
        }

        public static String factors(int lst)
        {
            var number = lst;
            int[] divisors = new int[] { 2, 3, 5, 7, 11, 17, 19, 23 };
            string result = "";
            int count = 0;
            while (!divisors.Contains(lst))
            {
                var count2 = 0;
                while (lst % divisors[count] == 0)
                {
                    lst /= divisors[count];
                    count2++;
                }
                result += count2 > 1 ? $"({divisors[count]}**{count2})" : $"({divisors[count]})";
                count++;
            }
            result += $"({divisors[count]})";
            return result;
        }
    }
}
