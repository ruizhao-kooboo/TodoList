

using System.ComponentModel.DataAnnotations.Schema;

namespace ConstrainsAndRelationships.Models
{
    public class Student
    {
        public bool SoftDeleted { get; set; }
        //一个表第一个字段含有ID就会默认设置为主键
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        // 若不在数据库映射用 [NotMapped]
        [NotMapped]
        public string Image { get; set; }

        //导航属性
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
