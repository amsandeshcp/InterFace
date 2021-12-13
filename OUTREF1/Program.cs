using System;

namespace OUTREF1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***REF EXAMPLE***");

            int outsidevar = 20;
            SomeMethod(ref outsidevar);
            Console.WriteLine($"The Value Of Outsidevar remains same even though reference is passed {outsidevar}");

            static void SomeMethod(ref int insidevar)
            {
                insidevar = insidevar + 10;
                Console.WriteLine($"The value Of Insidevar Increases by 10 and changes it to 30 by taking reference of Outsidevar{ insidevar}");

            }

            Console.WriteLine("\n");


           
            Console.WriteLine("\n");

           




        }
    }
}
