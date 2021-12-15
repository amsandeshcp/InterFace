using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePro
{
    public class tblteacher
    {
        public int TID { get; set; }
        public string Name { get; set; }
        public List<string> lstClassName { get; set; }

        public DateTime CreatedDT { get; set; } = DateTime.Now;
        public DateTime? UpdateDT { get; set; }
    }
}
