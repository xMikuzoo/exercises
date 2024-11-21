using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Ćwiczenia___wzorki
{
    internal class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
        static void Main(string[] args)
        {
            //Prosotkat(10, 10);
            //Console.WriteLine("\n");

            TrojkatWypelniony1(1);
            TrojkatWypelniony1(2);
            TrojkatWypelniony1(3);
            TrojkatWypelniony1(4);
            TrojkatWypelniony1(5);
            TrojkatWypelniony1(6);
            Console.WriteLine();
            //LiteraX(4);
            //Console.WriteLine();

            {
                //PrintList(5, 10, 2);
                //PrintList(5, 5, 11);
                //PrintList(5, 20, 3);
                //Console.WriteLine();

                //LiteraZOdbicie(8);
                //Console.WriteLine();

                //LiteraZ(8);
                //Console.WriteLine();

                //Klepsydra(8);
                //Klepsydra(7);
                //Console.WriteLine();

                //TrojkatPusty1(8);
                //TrojkatPusty1(7);
                //Console.WriteLine();

                //TrojkatPusty2(8);
                //TrojkatPusty2(7);
                //Console.WriteLine();



                //TrojkatWypelniony2(8);
                //TrojkatWypelniony2(7);
                //Console.WriteLine();

                //RombPustyPelny(7);
                //RombPustyPelny(8);
                //Console.WriteLine();

                //RombPelnyPelny(7);
                //RombPelnyPelny(8);
                //Console.WriteLine();

                //LiteraN(7);
                //LiteraN(8);
                //Console.WriteLine();

                //LiteraNOdbicie(7);
                //LiteraNOdbicie(8);
                //Console.WriteLine();

                //Szachownica(8);
                //Szachownica(3);
                //Console.WriteLine();

                //Kratownica1(8);
                //Kratownica1(7);
                //Kratownica1(6);
                //Kratownica1(5);
                //Console.WriteLine();

                //Kratownica2(8);
                //Kratownica2(7);
                //Kratownica2(6);
                //Kratownica2(5);
                //Console.WriteLine();

                //LiteraK(8);
                //LiteraK(7);
                //LiteraK(5);
                //Console.WriteLine();
            }

            Console.ReadKey();
        }
        public static void PrintList(int a, int b, int divisor)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {a} {b} {divisor}\n");
            var start = Math.Min(a, b);
            var end = Math.Max(a, b);

            if (end - start < 1)
            {
                Console.WriteLine("empty");
                return;
            }

            var list = new List<int>();
            for (int i = a + 1; i < end; i++)
            {
                if (i % divisor == 0)
                    list.Add(i);
            }

            if (list.Count > 10)
            {
                Console.WriteLine($"{list[0]}, {list[1]}, {list[2]}, ..., {list[list.Count - 2]}, {list[list.Count - 1]}");
                return;
            }

            Console.WriteLine(string.Join(", ", list));
        }
        /// <summary>
        /// Drukuje litere x
        /// </summary>
        /// <param name="n">liczba naturalna niemniejsza niż 3</param>
        /// <exception cref="ArgumentException"></exception>
        public static void LiteraX(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            if (n % 2 == 0) 
                n--;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i || j == n - i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void Prosotkat(int n, int m)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");
            for (int i = 0; i < n; i++)
                Star();

            if (m > 1)
            {
                NewLine();

                for (int i = 0; i < m - 2; i++)
                {
                    Star();

                    for (int j = 0; j < n - 2; j++)
                        Space();

                    Star();
                    NewLine();
                }

                for (int i = 0; i < n; i++)
                    Star();
            }

        }
        public static void LiteraZOdbicie(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            if (n % 2 == 1)
                n--;

            Console.WriteLine(new string('*', n));


            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', n));
        }
        public static void LiteraZ(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            if (n % 2 == 1)
                n--;

            Console.WriteLine(new string('*', n));


            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', n));
        }
        public static void Klepsydra(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            Console.WriteLine(new string('*', n));

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - i - 1 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', n));
        }
        public static void TrojkatPusty1(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n % 2 == 0)
                n--;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n / 2 - i || j == n / 2 + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', n));
        }
        public static void TrojkatPusty2(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n % 2 == 0)
                n--;

            Console.WriteLine(new string('*', n));

            for (int i = n / 2; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n / 2 - i + 1 || j == n / 2 + i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        //
        public static void TrojkatWypelniony2(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n % 2 == 0)
                n--;

            Console.WriteLine(new string('*', n));

            for (int i = n / 2; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n / 2 - i + 1 && j <= n / 2 + i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void TrojkatWypelniony1(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            //if (n % 2 == 0)
            //    n--;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n / 2 - i && j <= n / 2 + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', n));

        }
        public static void RombPustyPelny(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n % 2 == 0)
                n--;

            //trojkat pusty1
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n / 2 - i || j == n / 2 + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', n));

            //trojkat wypelniony2
            for (int i = n / 2; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n / 2 - i + 1 && j <= n / 2 + i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void RombPelnyPelny(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n % 2 == 0)
                n--;

            //trojkat pelny1
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n / 2 - i && j <= n / 2 + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', n));

            //trojkat wypelniony2
            for (int i = n / 2; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n / 2 - i + 1 && j <= n / 2 + i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void LiteraN(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void LiteraNOdbicie(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i - 1 == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Szachownica(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((i + j) % 2 == 0 ? "*" : " ");
                }
                Console.WriteLine();
            }
            //for(int i = 0; i < n;i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        for(int j = 1; j <= n; j++)
            //        {
            //            if (j  % 2 == 1)
            //            {
            //                Console.Write("*");
            //            } else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    } else
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (j % 2 == 1)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
        public static void Kratownica1(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");


            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for(int j = 0;j < n;j++)
                    {
                        if(j % 2 == 1)
                        {
                            Console.Write("*");
                        } else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(new string('*', n % 2 == 0 ? n - 1 : n));
                }
            }
        }
        public static void Kratownica2(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(new string('*', n % 2 == 0 ? n - 1 : n));
                }
            }
        }
        public static void LiteraK(int n)
        {
            Console.WriteLine($"\n{MethodBase.GetCurrentMethod().Name} dla wartości {n}\n");

            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n ; j++)
                {
                    if (j == 0 || j == i - n / 2 + 1 || j == n / 2 - i + (n % 2 == 0 ? 0 : 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
