

using System.ComponentModel.DataAnnotations;

namespace ConstrainsAndRelationships.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }

        [StringLength(50,MinimumLength = 2,ErrorMessage = "最大长度为50！")]
        public string Title { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual Department Department { get; set; }
    }
}
