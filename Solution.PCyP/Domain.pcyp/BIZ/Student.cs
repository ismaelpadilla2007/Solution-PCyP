using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.pcyp.BIZ
{
    public class Student : EntityBase
    {
        public Student()
        {

        }
        public Country country { get; set; }
        public String Alias { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String City { get; set; }
        public int DateOfBirth { get; set; }
        public String Gender { get; set; }

    }
}
