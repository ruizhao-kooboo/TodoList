
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstrainsAndRelationships.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [StringLength(50)]
        public string DepartmentName { get; set; }

        [Column(TypeName = "money")]
        public decimal Budget { get; set; }
        public DateTime StartData { get; set; }
        [Display(Name ="Admin")]
        public int? InstructorId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
