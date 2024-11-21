using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace objetosc_stozka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dane = Console.ReadLine().Split(' ');

            int r = int.Parse(dane[0]);
            int l = int.Parse(dane[1]);

            if (r < 0 || l < 0)
            {
                Console.WriteLine("ujemny argument");
                return;
            }

            if (l < r)
            {
                Console.WriteLine("obiekt nie istnieje");
                return;
            }

            //math.pow sie przekreca no niezle
            BigInteger bigL = new BigInteger(l);
            BigInteger bigR = new BigInteger(r);
            var bigLSquare = bigL * bigL;
            var bigRSquare = bigR * bigR;
            BigInteger heightSquare = bigLSquare - bigRSquare;

            decimal h = (decimal)Math.Sqrt((double)heightSquare);
            decimal pp = (decimal)Math.PI * (decimal)Math.Pow(r, 2);
            decimal v = pp * h / 3;

            decimal a = Math.Floor(v);
            decimal b = Math.Ceiling(v);

            Console.WriteLine("{0} {1}", a, b);

            Console.ReadKey();
        }
    }
}           