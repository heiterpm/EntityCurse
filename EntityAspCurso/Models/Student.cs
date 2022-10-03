using System;
using System.Collections.Generic;

namespace EntityAspCurso.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        virtual public ICollection<Enrollment>? Enrollments { get; set; }
    }
}