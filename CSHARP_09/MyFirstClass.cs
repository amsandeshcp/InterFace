using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSHARP_09
{
    public class MyFirstClass
    {
        #region Constructor
        //public MyFurstClass()
        //{

        //}
        #endregion

        #region Properties

        [Required]
        [MinLength(10)]
        public string NameofMyStudent { get; set; }
        public string Studentgender { get; set; }
        public int StudentNo { get; set; }
        public decimal StudentPercentage { get; set; }
        [Required]
        public List<string> lstadd { get; set; }

        public List<Secondndclass> NestedClass1 { get; set; }

        public List<Thirdclass> NestedClass2 { get; set; }
        public string[] stringarray { get; set; }
        #endregion
    }

    public class Secondndclass
    {
        public int Secondndclass_p1 { get; set; }
        public int Secondndclass_p2 { get; set; }
    }
    public class Thirdclass
    {
        public String Thirdclass_p1 { get; set; }
        public string Thirdclass_p2 { get; set; }
    }
}
