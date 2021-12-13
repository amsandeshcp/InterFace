using System;

namespace CHARP_13
{
    class branchloop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***COMBINING BRANCHES AND LOOPS***");
            Console.WriteLine("\n");

            Console.WriteLine("FIND THE SUM OF ALL THE INTEGERS THAT ARE DIVISIBLE BY 3 UPTO 20");
            Console.WriteLine("\n");
            int sum = 0;
            for (int i = 1; i<=20;i++)
            {
               
                if(i%3==0)
                {
                    
                    sum = sum + i;
                    Console.WriteLine("The sum is "+sum);

                }
               
            }
            Console.WriteLine("\n");

            Console.WriteLine($"The Total sum is {sum}");

        Console.ReadLine();


        }
    }
}
