using Domain.pcyp.BIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.pcyp.BLL
{
    public static class InstructorBusiness
    {
        private static List<Instructor> _instructorList = new List<Instructor>();

        public static void add(Instructor instructor)
        {
            _instructorList.Add(instructor);
        }

        public static List<Instructor> getInstructorList()
        {
            return _instructorList;
        }
    }
}
