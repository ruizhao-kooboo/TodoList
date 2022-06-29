

using System.ComponentModel.DataAnnotations;

namespace ConstrainsAndRelationships.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        [Required]
        [StringLength(50)]
        public string InstructorName { get; set; }

        public DateTime HireDate { get; set; }

        //public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}
