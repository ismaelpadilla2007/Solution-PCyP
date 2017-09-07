using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.pcyp.BIZ
{
    public class Instructor : EntityBase
    {
        public Instructor()
        {

        }

        public int Alias { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String MiddleName { get; set; }
        public int HireDate { get; set; }
        public int IsFullTime { get; set; }
        public double Salary { get; set; }
        public int TotalCourses { get; set; }
        public String ExternalId { get; set; }
        public int MyProperty { get; set; }
        public DateTime DeleteOn { get; set; }
        public int DeleteBy { get; set; }
        public int IsDelete { get; set; }
    }
}
