using System;

namespace Csharp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Work with the strings");

            String student_Name = "Raju";
            String teacher_Name = "Bangaraju";

            Console.WriteLine($" The student name is {student_Name} and the teacher name is {teacher_Name}" );

            Console.WriteLine($"The student name has {student_Name.Length} Letters AND The teacher name has {teacher_Name.Length} Letters ");
            Console.WriteLine("");
            Console.WriteLine("Lets Do some trimming ");

            string trim = "    Bangaraju    ";
            Console.WriteLine($"[{trim}]");

            Console.WriteLine($"after trimming from start [{trim.TrimStart()}]" );
            Console.WriteLine($"after trimming from end [{trim.TrimEnd()}]");

            trim = trim.Replace("Banga", "ganga");

            Console.WriteLine($"[{ trim}]");
            Console.WriteLine($"[{trim.Trim()}]");


            Console.WriteLine($" Old Name : [{trim}], After trim New name : [{trim.Replace("Banga", "sam")}]");

            Console.WriteLine(
                " Old Name :"
                + trim +
                ", After trim New name : "
                + trim.Replace("Banga", "sam").Trim().ToUpper() +
                " SSSample"
                );

            Console.Read();


        }
    }
}
