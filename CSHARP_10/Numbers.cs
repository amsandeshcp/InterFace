using System;

namespace CSHARP_10
{
    class Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precision!");
            int a = 4;
            int b = 7;
            int c = 2;
            int d = 34;
            int f = 50;
            SumOUT(a, b, c, out d);
            SumREF(a, b, c, ref f);
            int e = (d - a - b - c);
            Console.WriteLine($"This gives Sum OUT {d}");

            Console.WriteLine($"This gives Substraction {e}");
            Console.WriteLine($"This gives Sum Ref {d}");
            Console.WriteLine("\n");

            double a1 = 4;
            double b1 = 7;
            double c1 = 2;
            double d1 = (a1 + b1) / c1;
            double e1 = (a1 + b1) % c1;
            Console.WriteLine($"This gives Quotient  {d1}");
            Console.WriteLine($"This gives Remainder {e1}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The maximum value of int is {max}");
            Console.WriteLine($"The minimum value of int is {min}");
        }

        private static void SumOUT(int a, int b, int c, out int d)
        {

            if (a > 10)
            {
                d = 20;
            }
            else
            {

                SubstractionOUT(a, b, out d);
                // d = -20;
            }
            //d = (a + b + c);
        }

        private static void SubstractionOUT(int a, int b, out int d)
        {
            d = a - b;
        }



        private static void SumREF(int a, int b, int c, ref int f)
        {
            if (f > 10)
            {
                f = 20;
            }
            else
            {

                SubstractionREF(a, b, ref f);
                // d = -20;
            }
            //d = (a + b + c);
        }
        private static void SubstractionREF(int a, int b, ref int f)
        {
            f = a - b;
        }
    }
}
