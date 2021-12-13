using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSHARP_09
{
    class SORT
    {
        static void Main(string[] args)
        {
            List<string> obj = new List<string>
            {
                "Wierd",
                "scott",
                "Leni"
            };

            obj.Add("Adik");
            obj.Add("Bhavya");

            foreach (var name in obj)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(" Single instance \n");
            #region List Class
            MyFirstClass obj1 = new MyFirstClass
            {
                NameofMyStudent = "PropertyValueFromobj1",
                StudentNo = 1
            };

            MyFirstClass obj2 = new MyFirstClass
            {
                NameofMyStudent = "PropertyValueFromobj2"
            };
            Console.WriteLine($"{obj1.NameofMyStudent}, {obj1.StudentNo}");
            Console.WriteLine($"{obj2.NameofMyStudent}, {obj2.StudentNo}, {obj2.Studentgender}, {obj2.StudentPercentage}m");
            #endregion
            Console.WriteLine(" String Array \n");
            string[] oba = new String[2];
            oba[0] = "Male";
            oba[1] = "Female";
            foreach (var name in oba)
            {
                Console.WriteLine(name);
            }
            //Console.WriteLine(oba);

            //var f = 0f; // float
            //var d = 0d; // double
            //var m = 0m; // decimal (money)
            //var u = 0u; // unsigned int
            //var l = 0l; // long
            //var ul = 0ul; // unsigned long
            Console.WriteLine(" Int Array \n");
            int[] intobj = new int[2];
            intobj[0] = 5;
            intobj[1] = 2;
            foreach (var name in intobj)
            {
                Console.WriteLine(name);
            }



            StudentClass.LstmyFirstClasses = new List<MyFirstClass>
            {
                new MyFirstClass {StudentNo=1,NameofMyStudent = "s1", Studentgender = oba[0],lstadd=new List<string>{ "Home_Address","Office_Address"},stringarray= oba,NestedClass1 =new List<Secondndclass>{ new Secondndclass { Secondndclass_p1 = 1,Secondndclass_p2=2 } },NestedClass2 =new List<Thirdclass>{ new Thirdclass { Thirdclass_p1 = "Raj",Thirdclass_p2="Kumar" } }},
                new MyFirstClass {StudentNo=2,NameofMyStudent = "s2", Studentgender =  oba[0] },
                new MyFirstClass {StudentNo=3,NameofMyStudent = "s3", Studentgender =  oba[1] },
                new MyFirstClass {StudentNo=4,NameofMyStudent = "s4", Studentgender =  oba[1] },
                new MyFirstClass { NameofMyStudent = "s", Studentgender = "Male" }
            };

            StudentClass.LstmyFirstClasses.Add(new MyFirstClass { NameofMyStudent = "s", Studentgender = "Female" });



            //StudentClass onbjstlst = new StudentClass();
            Console.WriteLine($"{StudentClass.staticDisplayReport}");
            Console.WriteLine($"Current Student record NO : {StudentClass.Static}");


            StudentClass.LstmyFirstClasses.Add(new MyFirstClass { NameofMyStudent = "s", Studentgender = oba[1] });
            StudentClass onbjstlst2 = new StudentClass();
            Console.WriteLine($"{onbjstlst2.NonDisplayReport}");

            Console.Read();

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //names.Remove("Wierd");

            //var index = names.IndexOf("Wierd");
            //Console.WriteLine($"Found Bhavya at{index}");

            //if (index == -1)
            //{
            //    Console.WriteLine($"When an item is not fund ,Index returns {index}");
            //}
            //else
            //{
            //    Console.WriteLine($"the name {names[index]} is at index {index}");
            //}
        }
    }
}
