using System;   
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Program
    {
        public static Random rand = new Random();

        static void Main()
        {
            {
                //Print("Witaj");
                //Print1("Witaj3", ConsoleColor.Magenta, 2, 4);
                //Print("Witaj2", ConsoleColor.Red);
                //Print("Witaj3", ConsoleColor.Magenta, 2, 4);
                //Print("witaj4", xPosition: 3, yPosition: 4);

                //double z = 5.2;
                //int k = -1;

                //try
                //{
                //    Console.WriteLine(MyPower(z, k));
                //}
                //catch (ArgumentException e)
                //{
                //    Console.WriteLine("Błędne dane: {0}", e.Message);
                //}
                //Console.WriteLine("random: {0}", Los());
                //Console.WriteLine("random1: {0}", Los1());
                //Console.WriteLine("random2: {0}", Los2());
                //Console.WriteLine("max of: {0} {1} is: {2}", 5, 6, Max(5, 6));
                //Console.WriteLine("max of: {0} {1} is: {2}", 5, 6, Max1(5, 6));
                //Console.WriteLine("minof: {0} {1} is: {2}", 5, 6, Min(5, 6));
                //Console.WriteLine("max of array is: {0}", Max(2, 3, 4, 5, 6));}

                //int x = 2;
                //int y = 6;
                //int i = 2;
                //Console.WriteLine("x: {0}, y: {0}", x, y);
                //Swap(ref x, ref y, in i);
                //Console.WriteLine("x: {0}, y: {0}", x, y);
                // int parsed;
                ////aha i to mi przypisze do out zmienna jak sie uda
                //Console.WriteLine(Int32.TryParse("123",out parsed));
                //Console.WriteLine(parsed);
                //string napis = Console.ReadLine();

                //int wynik;
                //bool succes = int.TryParse(napis, out wynik);

                //if (succes)
                //{
                //    Console.WriteLine(wynik);
                //}
                //else
                //{
                //    Console.WriteLine("tryparse sie nie powiodl");
                //}
            }

            Console.ReadKey();
        }
        //ref = odwolanie do pamieci i zmieni dane;
        //in = parametr readonly
        //out = nie pamietam  Zmienna nie musi być zainicjalizowana przed przekazaniem jej do metody, ale musi być zainicjalizowana wewnątrz metody.
        static void Swap(ref int x, ref int y, in int i)
        {
            //i++; nei zadziala bo readonly
            var z = 2 + i;
            Console.WriteLine("inFunc\t x: {0}, y: {0}", x, y);
            
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("inFunc\t x: {0}, y: {0}", x, y);
        }

        static Action<string, ConsoleColor, int, int> Print1 = (m, c, x, y) =>
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = c;

            Console.WriteLine("{0} at ({1},{2})", m, x, y);

            Console.ForegroundColor = oldColor;
        };
        //default values of prawej(od konca);
        //kolejnosc parametrow = nazwaParametru: wartość;
        static void Print(string message, ConsoleColor color = ConsoleColor.Yellow, int xPosition = 1, int yPosition = 1)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            Console.WriteLine("{0} at ({1},{2})", message, xPosition, yPosition);

            Console.ForegroundColor = oldColor;

        }
        static Func<int, int, int> Min = (x, y) => (x < y) ? x : y;
        static int Max(params int[] tab)
        {
            Debug.Assert(tab.Length > 0);
            return tab.Max();
        }
        static int Los()
        {
            return rand.Next();
        }
        static int Los1()
        {
            return rand.Next();
        }
        static int Los2() => rand.Next();
        static int Max(int x, int y)
        {
            if (x < y)
                return y;
            else
                return x;

        }
        static int Max1(int x, int y) => (x < y) ? y : x;
        public static double MyPower(double x, int n)
        {
            if (x <= 0)
            {
                throw new ArgumentException("x musi byc dodatnie");
            }

            if (n < 0) throw new ArgumentException("n musi byc nieujemne");

            if (n == 0) return 1;

            double y = x;
            for (int i = 0; i < n; i++)
            {
                y *= x;
            }
            return y;

        }

    }
}
