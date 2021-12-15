using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePro
{
    public class RepoTeacher : ITeacher, IStudent
    {
        public static List<string> classname = new List<string>
            {
                "C1",
                "C2",
                "C3"
            };

        private static List<tblteacher> obj = new List<tblteacher>
            {
                new tblteacher { TID = 1, Name = "Sandesh", lstClassName = classname },
                new tblteacher { TID = 2, Name = "Sunil", lstClassName = classname },
                new tblteacher { TID = 3, Name = "Suresh", lstClassName = classname },
                new tblteacher { TID = 4, Name = "Smart", lstClassName = classname }
            };

        public int Count()
        {
            return obj.Count;
        }

        #region Teacher
        public bool DeleteTeacher(int TID)
        {
            obj.RemoveAt(obj.FindIndex(x => x.TID == TID));
            if (obj.Exists(x => x.TID == TID))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<tblteacher> GetAllTeacher()
        {
            return obj;
        }

        public tblteacher GetTeacherDetails(int TID)
        {
            return obj.Find(x => x.TID == TID);
        }

        public tblteacher InsertTeacherDetails(tblteacher Request)
        {
            int T_ID = Count() + 1;
            while (obj.Exists(x => x.TID == T_ID))
            {
                T_ID++;
            }

            obj.Add(new tblteacher { TID = T_ID, Name = Request.Name, lstClassName = Request.lstClassName });

            return GetTeacherDetails(T_ID);
        }

        public tblteacher UpdateTeacherDetails(tblteacher Request)
        {
            foreach (var teach in obj)
            {
                if (teach.TID == Request.TID)
                {
                    teach.Name = Request.Name;
                    teach.lstClassName = Request.lstClassName;
                    teach.UpdateDT = DateTime.Now;
                    break;
                }
            }
            return GetTeacherDetails(Request.TID);
        }

        #endregion

        #region Student 
        public bool DeleteStudent(int SID)
        {
            throw new NotImplementedException();
        }
        public dynamic GetAllStudent()
        {
            throw new NotImplementedException();
        }
        public tblStudent GetStudentDetails(int SID)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
