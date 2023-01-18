using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollmentAPI.src.entities
{
    public class Student
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public List<Course> course { get; set; }
        public int Enrollment { get; set; }
    }
}