using System;

namespace Csharp_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Work more with the strings ");

            String sentence = "Hello  mike how are you ?";

            Console.WriteLine($" the sentence Does it contain hello in it ? {sentence.Contains("Hello")}");


            Console.WriteLine($"the sentence Does it contain watson in it ? {sentence.Contains(" watson")}");

            Console.WriteLine("Check whether the sentence starts wit or ends with the following words");

            Console.WriteLine($"Does the string sentence starts with Hi ? {sentence.StartsWith("")}");


            Console.WriteLine($"Does the string sentence ends with  ? {sentence.EndsWith("?")}");



            

            String lststudentname = "sandesh ,sam1,sam2, sam3";
            
            
            #region Example 1
            var spliter = lststudentname.Split(",",  StringSplitOptions.RemoveEmptyEntries);
           
            foreach (var item in spliter)
            {
                Console.WriteLine($"[{item.Trim()}]");
            }
            #endregion


            #region Example 2
            var spliter1 = lststudentname.Split(",");
            Console.WriteLine($"[{spliter1[3].Trim()}]");
            #endregion



            //sammmer sammmer = new sammmer();
            //sammmer.splitter(1);

            string senta = "Hey , Hi , Hoe , r , you";
            var spl = senta.Split(",", StringSplitOptions.RemoveEmptyEntries);

            Console.Read();
        }

        public class sammmer
        {
            public string splitter(int p1, string p2 = "sm")
            {
                return p1.ToString();
            }
        }


    }
}
