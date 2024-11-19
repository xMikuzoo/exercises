using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Most_frequently_used_words_in_a_text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decomp(5));
            Console.WriteLine(Decomp(10));
            Console.WriteLine(Decomp(17));
            Console.ReadKey();
        }

        public static string Decomp(int n)
        {
            decimal silnia = 1m;
            for (var i = 2; i <= n ;i++)
            {
                silnia *= i; 
            }
            var divisor = 2;

            var count = 0;
            var tempSilnia = silnia;
            while (tempSilnia % divisor == 0)
            {
                Console.WriteLine("Tempsilnia: {0}", tempSilnia);
                tempSilnia /= divisor;
                count++;
            }
            Console.WriteLine("Count: {0}", count);

            return ";";
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

    }
}
