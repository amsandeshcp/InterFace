using System;

namespace CSHARP_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combining branches and loops");
            int sum = 0;
            int i = 1;
            for (i = 2; i <= 10;)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }

                i++;
            }
            Console.WriteLine($"The sum is {sum}");
            Console.Read();
        }
    }
}
