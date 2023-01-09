using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollmentAPI.src.entities
{
    public class Course
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String MyProperty { get; set; }
        public String Difficulty { get; set; }

        public int CreditHours { get; set; }
    }
}