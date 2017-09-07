using Domain.pcyp.BIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.pcyp.BLL
{
    public static class StudentBusiness
    {
        private static List<Student> _studentList = new List<Student>();

        public static void add(Student estudiante)
        {
            _studentList.Add(estudiante);
        }

        public static List<Student> getStudentList()
        {
            return _studentList;
        }
    }
}
