using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePro
{
    public interface IStudent
    {
        dynamic GetAllStudent();

        tblStudent GetStudentDetails(int SID);

        bool DeleteStudent(int SID);
        int Count();
    }
}
