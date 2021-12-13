using System;

namespace CSHARP_11
{
    
    class Decimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****DECIMAL DATA TYPE******");

            decimal i = 2.3m;
            decimal e = 2.33m;
            decimal result = i / e;
            Console.WriteLine(result);
            Console.WriteLine("\n");

            Console.WriteLine("***RANGES***");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;

            Console.WriteLine($"The Max value of decimal is {max}");
            Console.WriteLine($"The Min value of decimal is {min}");
            Console.WriteLine("\n");

            long min1 = long.MinValue;
            long max1 = long.MaxValue;

            Console.WriteLine($"The Max value of long is {max1}");
            Console.WriteLine($"The Min value of long is {min1}");
            Console.WriteLine("\n");

            short min2 = short.MinValue;
            short max2 = short.MaxValue;

            Console.WriteLine($"The Max value of short is {max2}");
            Console.WriteLine($"The Min value of short is {min2}");
            Console.WriteLine("\n");

            Console.WriteLine("****FINDING THE AREA****");

            double radius = 25.76;
            double area = Math.PI * radius * radius;

           

            
            


            Console.Read();




        }
    }
}
