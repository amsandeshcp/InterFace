using System;

namespace CSHARP_12
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****WORKING WITH LOOPS****");
            Console.WriteLine("\n");

            Console.WriteLine("Working With While Loop");
            Console.WriteLine("\n");
            int a = 1;

            while(a<10)
            {
                Console.WriteLine($"Print the statement while a value reaches upto 10 .Right Now the a value is {a}");
                 a++;
            }
            Console.WriteLine("\n");

            Console.WriteLine("Working With doWhile Loop");
            Console.WriteLine("\n");

            int b = 1;
            do
            {
                Console.WriteLine($"Print the statement while a value reaches upto 10.Right Now the b value is { b }");
                b++;
            } while (b < 10);

            Console.WriteLine("\n");

            Console.WriteLine("Working With for Loop");
            Console.WriteLine("\n");

            for (int i =1; i<=10;i++)
            {
                Console.WriteLine($"Print the statement while i value reaches upto 10.Right Now the i value is { i }");
            
            }
            Console.WriteLine("\n");








            Console.Read();


        }
    }
}
