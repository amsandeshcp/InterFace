using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePro
{
    public interface ITeacher
    {
        List<tblteacher> GetAllTeacher();

        tblteacher GetTeacherDetails(int TID);

        bool DeleteTeacher(int TID);

        tblteacher InsertTeacherDetails(tblteacher Request);
        tblteacher UpdateTeacherDetails(tblteacher Request);


        int Count();
    }
}
