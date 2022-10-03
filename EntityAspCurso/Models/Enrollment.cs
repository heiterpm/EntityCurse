

using System.ComponentModel.DataAnnotations.Schema;

namespace EntityAspCurso.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        virtual public Course Course { get; set; }
        virtual public Student Student { get; set; }
    }
}