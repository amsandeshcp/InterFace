using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePro
{
    public interface ITeacher
    {
        dynamic GetAllTeacher();

        tblteacher GetTeacherDetails(int TID);

        bool DeleteTeacher(int TID);

        int Count();
    }
}
