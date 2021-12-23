using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProSneha
{
    public interface IStudent
    {
        List<tblStudent> GetAllStudent();

        tblStudent GetStudentDetails(int SID);

        bool DeleteStudent(int SID);
        
        tblStudent  InsertStudentDetails(tblStudent Request);

        tblStudent UpdateStudentDetails(tblStudent Request);


        int Count();
    }
}
