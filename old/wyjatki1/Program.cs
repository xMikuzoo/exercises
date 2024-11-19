using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
            int[] numbers = new int[3];
            int count = 0;
            foreach(var x in data)
            {
                try
                {
                    numbers[count] = int.Parse(x);
                    count++;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("argument exception, exit");
                }
                catch (FormatException)
                {
                    Console.WriteLine("format exception, exit");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("overflow exception, exit");
                }
                catch(Exception)
                {
                    Console.WriteLine("non supported exception, exit");
                }

            }

            if(count == 3)
            {
                int a = numbers[0];
                int b = numbers[1];
                int c = numbers[2];

                try
                {
                    checked
                    {
                        int result = a * b * c;
                        Console.WriteLine(result);
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("overflow exception, exit");
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Oblicza obwód trójkąta dowolnego dla zadanych długości boków, zaokrąglając wynik do podanej liczby cyfr po przecinku
        /// </summary>
        /// <param name="a">długość pierwszego boku, liczba całkowita nieujemna</param>
        /// <param name="b">długość drugiego boku, liczba całkowita nieujemna</param>
        /// <param name="c">długość trzeciego boku, liczba całkowita nieujemna</param>
        /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
        /// <returns>obwód trójkąta obliczony z zadaną dokładnością</returns>
        /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
        ///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
        /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>
        /// <remarks>dopuszczamy trójkąt o pokrywających się bokach lub o wszystkich bokach o długości 0</remarks>
        public static double TrianglePerimeter(int a, int b, int c, int precision = 2)
        {
            if (a < 0 || b < 0 || c < 0 || (precision < 2 || precision > 8))
            {
                throw new ArgumentOutOfRangeException("wrong arguments");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("object not exist");
            }


            return Math.Round((double)(a + b + c), precision);
        }
    }
}
