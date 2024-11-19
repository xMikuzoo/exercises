using System;

namespace przetwarzanie_talblic_1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(new int[] { -2, -1, 0, 1, 4 }, new int[] { -3, -2, -1, 1, 2, 3 });
            Print(new int[] { 0, 1, 1, 2, 3, 3, 3 }, new int[] { 0, 1, 2, 3, 3 });

        }

        public static void Print(int[] a, int[] b)
        {
            string result = "";
            int previousFromA = int.MinValue;
            int previousFromB = int.MinValue;

            foreach(int i in a)
            {
                if (!Array.Exists(b, x => x == i) && i != previousFromA && i != previousFromB)
                {
                    result += $"{i} ";
                    previousFromA = i;
                }
            }

            foreach (int i in b)
            {
                if (!Array.Exists(a, x => x == i) && i != previousFromB && i != previousFromA)
                {
                    result += $"{i} ";
                    previousFromB = i;
                }
            }

            if(result.Length == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            string[] resultStringArray = result.Split(new char[] { ' ' },
                                                StringSplitOptions.RemoveEmptyEntries
                                              );
            int[] resultIntArray = Array.ConvertAll(resultStringArray, int.Parse);
            Array.Sort(resultIntArray);
            Console.WriteLine(string.Join(" ", resultIntArray));
        }
    }
}
