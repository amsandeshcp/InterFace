using System;

namespace OUTREF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of OUT Keyword");

            int outsidevar = 20;
            SomeMethod(outsidevar);
            Console.WriteLine($"The Value Of Outsidevar remains same even though reference is passed {outsidevar}");

            static void SomeMethod(int insidevar)
            {
                insidevar = insidevar + 10;
                Console.WriteLine($"The value Of Insidevar Increases by 10 and changes it to 30 by taking reference of Outsidevar{ insidevar}");

            }


            Console.WriteLine(" ****Another Example of Out****");
            Console.WriteLine("\n");
            int a = 10;
            int b = 20;
            int c = 21;
          

            addition(a, b, out c);
            


            Console.WriteLine($"The sum a + b+ c is {c}");
            int o = a + b + c;

            Console.WriteLine($"The value of Letter variable O is {o}");


            Console.WriteLine("\n");
            static void addition(int a, int b, out int c)
            {
                if (a > 10)
                {
                    c = 10;
                }
                else
                {
                    c = 9;
                }
            }


            Console.Read();



        }

       



    }
}
