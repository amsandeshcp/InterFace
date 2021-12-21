using EnumProcess;
using System;

namespace EnumConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OwnerDetails("Branch", 1);
            Console.WriteLine();
        }

        public static void OwnerDetails(string Owner, int var1)
        {
            #region IFFlow
            if (Enum.IsDefined(typeof(OwnerType), Owner))
            {
                if (Convert.ToString(OwnerType.Branch) == Owner)
                {
                    Console.WriteLine("Hello World! Branch :" + Owner);
                }
                else if (Convert.ToString(OwnerType.Spaces) == Owner)
                {
                    Console.WriteLine("Hello World! Spaces :" + Owner);
                }
                else if (Convert.ToString(OwnerType.Appointment) == Owner)
                {
                    Console.WriteLine("Hello World! Appointment :" + Owner);
                }
                else if (Convert.ToString(OwnerType.Services) == Owner)
                {
                    Console.WriteLine("Hello World! Services :" + Owner);
                }
            }
            else
            {
                Console.WriteLine("In valid Implimenation " + Owner);
            }
            #endregion

            #region SwitchOwnerty


            var output = "";
            switch ((OwnerType)Enum.Parse(typeof(OwnerType), Owner))
            {
                case OwnerType.Branch:
                    Branchimplemenation(OwnerType.Branch, ref output);
                    break;
                case OwnerType.Spaces:
                    Console.WriteLine("Hello World! Spaces :" + Owner);
                    break;
                case OwnerType.Appointment:
                    Console.WriteLine("Hello World! Appointment :" + Owner);
                    break;
                case OwnerType.Services:
                    Console.WriteLine("Hello World! Services :" + Owner);
                    break;
            }

            Console.WriteLine($"OutPut variabkle : {output}");
            Console.WriteLine($"Issue With OwnerType : {(OwnerType)(3)}- {OwnerType.Branch}");

            #endregion


            #region Calc using enum and switch and ref 


            #endregion
        }

        private static void Branchimplemenation(OwnerType Owner, ref string output)
        {
            output = "OwnerType ID: " + (int)(Owner);
            Console.WriteLine("Hello World! Branch :" + Owner);
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
