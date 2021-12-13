using System;
using System.Collections.Generic;

namespace Csharp_06
{
    public class ListConpcet
    {
        public string listmethod(List<string> lstname)
        {
            string sam = string.Empty;
            foreach (var item in lstname)
            {
                //if (sam != string.Empty)
                //{
                //    sam = $"{sam.Trim()},{item.Trim()}";
                //}
                //else
                //{
                //    sam = $"{item.Trim()}";
                //}

                sam = (sam != string.Empty ? $"{sam.Trim()},{item.Trim()}" : $"{item.Trim()}");
            }
            // sam.Split(",",2)[1];
            return sam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fibbonacci = new List<int> { 1, 1 };

            ListConpcet obj = new ListConpcet();
            List<string> send = new List<string>();
            send.Add("sam1");
            send.Add("sam2");
            send.Add("sam3");
            var sam = obj.listmethod(send);

            while (fibbonacci.Count < 20)
            {
                var last = fibbonacci[fibbonacci.Count - 1];
                var Second_Last = fibbonacci[fibbonacci.Count - 2];
                fibbonacci.Add(last + Second_Last);
            }
            foreach (int item in fibbonacci)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("That is List example");
            Console.Read();

        }

        
    }
}
