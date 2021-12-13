using System;

namespace CSHARP_07
{
    class PracticeClass
    {

        int r = 20;
        static void Main(string[] args)
        {
            int a = 10; 
            float b= 20.34f;
            decimal d = 9.090909m;
            int c = Convert.ToInt32(b);
            float e =(float) d;
            decimal r = (decimal)b;

            string a1 = "232.333";
            string b1 = "1029.09090";

            float a3 = float.Parse(a1) + float.Parse(b1);

            Console.WriteLine("the value of a3 is "+a3);
            Console.WriteLine(e);

            int i; 
            for ( i=0;  i<10;i++)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("---------------------------");

            Console.WriteLine(i);
            Console.WriteLine("---------------------------");
            Console.WriteLine("\n");

            int ki = 0;
            while(ki<10)
            {
                Console.WriteLine(ki);
                ki++;
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine(ki);


        }
        

        

    }
}
