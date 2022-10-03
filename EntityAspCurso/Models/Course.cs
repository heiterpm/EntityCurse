using System.ComponentModel.DataAnnotations;

namespace EntityAspCurso.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        virtual public ICollection<Enrollment>? Enrollments { get; set; }
    }
}