using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProSneha
{
    public class RepoStudent : IStudent
    {
        public static List<string> periodname = new List<string>
        {
                "Kannada",
                "English",
                "Hindi"
        };

        private List<tblStudent> obj = new List<tblStudent>
        {
                new tblStudent { SID = 1, Name = "raja", lstPeriodName = periodname },
                new tblStudent { SID = 2, Name = "rani", lstPeriodName = periodname },
                new tblStudent { SID = 3, Name = "mani", lstPeriodName = periodname },
                new tblStudent { SID = 4, Name = "vani", lstPeriodName = periodname }
        };

        public int Count()
        {
            return obj.Count;
        }

        public bool DeleteStudent(int SID)
        {
            obj.RemoveAt(obj.FindIndex(x => x.SID == SID));
            if (obj.Exists(x => x.SID == SID))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<tblStudent> GetAllStudent()
        {
            return obj;
        }

        public tblStudent GetStudentDetails(int SID)
        {
            return obj.Find(x => x.SID == SID);
        }

        public tblStudent InsertStudentDetails(tblStudent Request)
        {
            int S_ID = Count() + 1;
            while (obj.Exists(x => x.SID == S_ID))
            {
                S_ID++;
            }

            obj.Add(new tblStudent { SID = S_ID, Name = Request.Name, lstPeriodName = Request.lstPeriodName });

            return GetStudentDetails(S_ID);
        }

        public tblStudent UpdateStudentDetails(tblStudent Request)
        {
            foreach (var teach in obj)
            {
                if (teach.SID == Request.SID)
                {
                    teach.Name = Request.Name;
                    teach.lstPeriodName = Request.lstPeriodName;
                    teach.UpdateDT = DateTime.Now;
                    break;
                }
            }
            return GetStudentDetails(Request.SID);
        }
    }
}
