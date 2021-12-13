using System;
using System.Collections.Generic;

namespace ASSIGNMENT
{
    public class second
    {
        public String Board { get; set; }
        public String COUNTRY { get; set; }
    }
    public class firstAssign
    {


        public String PlayerName { get; set; }
        public int Score { get; set; }

        public List<second> Nested { get; set; }


    }
   public class Program
    {
       
       
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Creating list under list under list ");

            List<firstAssign> profile = new List<firstAssign>()
            {
            new firstAssign { PlayerName = "Siraj", Score = 10 , Nested = new List<second>{new second {
            Board="Bcci",COUNTRY="India"} } }
            };

            foreach (var name in profile)
            {
                Console.WriteLine(name.Nested[0].Board);

            }
            
        }

      

    }
}
