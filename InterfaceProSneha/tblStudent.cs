using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace InterfaceProSneha
{
    public class tblStudent
    {
        public List<string> lstPeriodName { get; set; }

        public int SID { get; set; }
        public string Name { get; set; }

        public DateTime CreatedDT { get; set; } = DateTime.Now;
        public DateTime? UpdateDT { get; set; }
    }
}
