using EnumCalculatorProcess;
using System;

namespace EnumCalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World! {"Add"}. {Calculator.Add}");
            CalculatorOperation("Add", 1);
            Console.WriteLine();
        }

        public static void CalculatorOperation(string Owner, int var1)
        {
            #region If Flow
            //if (Enum.IsDefined(typeof(Calculator), Owner))
            //{
            //    if (Convert.ToString(Calculator.Mul) == Owner)
            //    {
            //        Console.WriteLine("Hello World! Mul :" + Owner);
            //    }
            //    else if (Convert.ToString(Calculator.Add) == Owner)
            //    {
            //        Console.WriteLine("Hello World! Add :" + Owner);
            //    }
            //    else if (Convert.ToString(Calculator.Sub) == Owner)
            //    {
            //        Console.WriteLine("Hello World! Sub :" + Owner);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("In valid Implimentation :" + Owner);
            //}
            #endregion
            var output = "";
            int p1 = 1;
            int p2 = 2;

            if (Convert.ToString(Calculator.Mul) == Owner)
            {
                Console.WriteLine("Hello World! Mul :" + Owner);
                return;
            }

            //string temp = "12345678123456781234567812345678";
            //int convertedtemp = int.Parse(temp);
            try
            {
                switch (Enum.Parse(typeof(Calculator), Owner))
                {
                    case Calculator.Mul:
                        Mulimplementation(Calculator.Mul, ref output);
                        break;
                    case Calculator.Add:
                        Addimplementation(Calculator.Add, p1, p2, ref output);
                        break;
                    case Calculator.Sub:
                        Console.WriteLine("Hello World! Sub :" + Owner);
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message : {ex.Message}");
            }

            Console.WriteLine($"Output variable : { output}");
            Console.WriteLine($"Issue With Calculator : {(Calculator)(2)}-{Calculator.Mul}");
        }

        private static void Addimplementation(Calculator add, int p1, int p2, ref string output)
        {
            int p3 = p1 + p2;
            output = "Calculator ID " + (int)(add);
            Console.WriteLine($"Operation type : {add}Sum of A+B={p3} Add :");
        }

        private static void Mulimplementation(Calculator mul, ref string output)
        {
            output = "Calculator ID: " + (int)(mul);
            Console.WriteLine("Hello World! Mul :" + mul);
        }

        public static int OwnerDetails(String Owner)
        {
            var returnvar = 0;

            return returnvar;
        }

        public static string OwnerDetails(int Owner)
        {
            var returnvar = "";

            return returnvar;
        }

    }
}
