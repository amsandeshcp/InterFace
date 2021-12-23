using InterfaceProSneha;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace InterfaceConsoleSneha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region OldDetails
            //List<string> periodname = new List<string>
            //{
            //    "Kannada",
            //    "English",
            //    "Hindi"
            //};


            //List<tblStudent> obj = new List<tblStudent>
            //{
            //    new tblStudent { SID = 1, Name = "raja", lstPeriodName = periodname },
            //    new tblStudent { SID = 2, Name = "rani", lstPeriodName = periodname },
            //    new tblStudent { SID = 3, Name = "mani", lstPeriodName = periodname },
            //    new tblStudent { SID = 4, Name = "vani", lstPeriodName = periodname }
            //};

            //foreach (var item in obj)
            //{
            //    Console.WriteLine($"SID:{item.SID},Name:{item.Name}, Period Associated: {string.Join(",", item.lstPeriodName)}");
            //}
            #endregion

            
            RepoStudent repoStudent = new RepoStudent();
            var BeforeDeleteStudentCount = repoStudent.Count();
            var BeforeDelete = repoStudent.GetAllStudent();
            foreach (var item in BeforeDelete)
            {
                Console.WriteLine($"SID:{item.SID}, Name: {item.Name}, Period Associated: [{string.Join(", ", item.lstPeriodName)}], Created Datetime :{item.CreatedDT}, Update Datetime :{item.UpdateDT}");
            }

            int deleterecordnumber = 1;
            var beforedeleterecorddetails = repoStudent.GetStudentDetails(deleterecordnumber);
            Console.WriteLine($"\n");
            Console.WriteLine($"Before Delete record Details : Name: {beforedeleterecorddetails.Name}, ID: {beforedeleterecorddetails.SID}");
            Console.WriteLine($"\n");
            var result = repoStudent.DeleteStudent(deleterecordnumber);
            var AfterDeleteStudentCount = repoStudent.Count();

            Console.WriteLine($"\n");
            Console.WriteLine($"Before Delete Count : {BeforeDeleteStudentCount},After Delete Count: {AfterDeleteStudentCount}, ");
            Console.WriteLine($"\n");

            var AfterDelete = repoStudent.GetAllStudent();
            foreach (var item in AfterDelete)
            {
                Console.WriteLine($"SID:{item.SID}, Name: {item.Name}, Period Associated: [{string.Join(", ", item.lstPeriodName)}], Created Datetime :{item.CreatedDT}, Update Datetime :{item.UpdateDT}");
            }

            Console.WriteLine($"\n");
            Console.WriteLine($"Insert new record\n");
            var sam = new tblStudent { Name = "kali", lstPeriodName = RepoStudent.periodname.FindAll(x => x.Contains("English") )};
            Console.WriteLine($"{JsonConvert.SerializeObject(repoStudent.InsertStudentDetails(sam))}");

            Console.WriteLine($"\n");
            Console.WriteLine($"Update new record\n");
            var Upd = new tblStudent { SID = 5, Name = "kali_g", lstPeriodName = RepoStudent.periodname.FindAll(x => x.Contains("English")) };
            Console.WriteLine($"{JsonConvert.SerializeObject(repoStudent.UpdateStudentDetails(Upd))}");


            Console.WriteLine($"\n");
            Console.WriteLine($"All Record Display\n");
            foreach (var item in repoStudent.GetAllStudent())
            {
                Console.WriteLine($"SID:{item.SID}, Name: {item.Name}, Period Associated: [{string.Join(", ", item.lstPeriodName)}], Created Datetime :{item.CreatedDT}, Update Datetime :{item.UpdateDT}");
            }
        }
    }
}
