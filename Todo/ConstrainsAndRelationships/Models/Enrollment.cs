

namespace ConstrainsAndRelationships.Models
{
    public enum Grade
    {
        A,B,C,D
    }
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        //?应该是可以为空的意思
        public Grade? Grade { get; set; }

        
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
