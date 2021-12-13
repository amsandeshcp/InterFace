using System;
using System.Collections.Generic;
using System.Text;
using static CSHARP_09.SORT;

namespace CSHARP_09
{
    public class StudentClass
    {
        public StudentClass()
        {
            NonStatic = Static + 1;
            Static = 0;
            GetReport(LstmyFirstClasses, out System.Text.StringBuilder Dr);
            staticDisplayReport = this.NonDisplayReport = Dr;
        }

        //static StudentClass()
        //{
        //    Static++;
        //    GetReport(LstmyFirstClasses, out System.Text.StringBuilder Dr);
        //    staticDisplayReport = Dr;
        //}
        #region Properties_Fields
        public int NonStatic { get; set; } = 0;
        public static int Static { get; set; } = 0;
        public static List<MyFirstClass> LstmyFirstClasses { get; set; }

        public System.Text.StringBuilder NonDisplayReport { get; set; }
        public static System.Text.StringBuilder staticDisplayReport { get; set; }
        #endregion

        #region Static_Method
        public static void GetReport(List<MyFirstClass> lstcls, out System.Text.StringBuilder Dr)
        {
            var DisplayReport = new System.Text.StringBuilder();
            DisplayReport.AppendLine("\n[SID]\t\t[Student Name]\t[Gender]\t[Student Address]");
            DisplayReport.AppendLine($"------------------------------------------------------------------------------");

            if (lstcls != null)
            {
                foreach (var item in lstcls)
                {
                    Static++;
                    var SID = (item.StudentNo == 0 ? Static : item.StudentNo);
                    var studentName = (item.StudentNo == 0 ? item.NameofMyStudent + SID : item.NameofMyStudent);
                    var studentAddress = (item.lstadd == null ? "No Address" : string.Join(", ", item.lstadd));


                    DisplayReport.AppendLine($"{SID}\t\t{studentName}\t\t{item.Studentgender}\t\t{studentAddress}");
                }
            }
            DisplayReport.AppendLine($"------------------------------------------------------------------------------");
            LstmyFirstClasses = lstcls;
            Dr = DisplayReport;
        }
        #endregion
    }
}
