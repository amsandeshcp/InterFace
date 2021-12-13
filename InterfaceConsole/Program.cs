using InterfacePro;
using System;
using System.Collections.Generic;

namespace InterfaceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region OldDetails
            //List<string> classname = new List<string>
            //{
            //    "C1",
            //    "C2",
            //    "C3"
            //};

            ////List<string> classname = new List<string>();
            ////classname.Add("C1");
            ////classname.Add("C2");
            ////classname.Add("C3");

            //List<tblteacher> obj = new List<tblteacher>
            //{
            //    new tblteacher { TID = 1, Name = "Sandesh", lstClassName = classname },
            //    new tblteacher { TID = 2, Name = "Sunil", lstClassName = classname },
            //    new tblteacher { TID = 3, Name = "Suresh", lstClassName = classname },
            //    new tblteacher { TID = 4, Name = "Smart", lstClassName = classname }
            //};

            //foreach (var item in obj)
            //{
            //    Console.WriteLine($"TID:{item.TID}, Name: {item.Name}, Classes Associated: [{string.Join(", ", item.lstClassName)}]");
            //}
            #endregion


            //var ls = RepoTeacher.classname;
            //foreach (var item in ls)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine($"\n");

            //var tlist = RepoTeacher.obj;
            //foreach (var item in tlist)
            //{
            //    Console.WriteLine($"TID:{item.TID}, Name: {item.Name}, Classes Associated: [{string.Join(", ", item.lstClassName)}]");
            //}

            RepoTeacher repoTeacher = new RepoTeacher();

            var BeforeDeleteTeacherCount = repoTeacher.Count();
            var BeforeDelete = repoTeacher.GetAllTeacher();
            foreach (var item in BeforeDelete)
            {
                Console.WriteLine($"TID:{item.TID}, Name: {item.Name}, Classes Associated: [{string.Join(", ", item.lstClassName)}]");
            }
            int deletrecordnumber = 1;
            var beforedeleterecordetails = repoTeacher.GetTeacherDetails(deletrecordnumber);
            Console.WriteLine($"\n");
            Console.WriteLine($"Before Delete record Details : Name: {beforedeleterecordetails.Name}, ID: {beforedeleterecordetails.TID}");
            Console.WriteLine($"\n");
            var result = repoTeacher.DeleteTeacher(deletrecordnumber);
            var AfterDeleteTeacherCount = repoTeacher.Count();

            Console.WriteLine($"\n");
            Console.WriteLine($"Before Delete Count : {BeforeDeleteTeacherCount},After Delete Count: {AfterDeleteTeacherCount}, ");
            Console.WriteLine($"\n");

            var AfterDelete = repoTeacher.GetAllTeacher();
            foreach (var item in AfterDelete)
            {
                Console.WriteLine($"TID:{item.TID}, Name: {item.Name}, Classes Associated: [{string.Join(", ", item.lstClassName)}]");
            }



        }
    }
}
