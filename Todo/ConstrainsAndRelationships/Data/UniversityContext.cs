using ConstrainsAndRelationships.Models;
using Microsoft.EntityFrameworkCore;

namespace ConstrainsAndRelationships.Data
{
    public class UniversityContext:DbContext
    {
        public UniversityContext()
        {

        }

        public UniversityContext(DbContextOptions<UniversityContext> options):base(options)
        {

        }

        //默认情况下属性名称Students就是表名
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        {
            optionsBulder.UseLazyLoadingProxies();//配置懒加载
            optionsBulder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDb;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //配置软删除过滤器
            modelBuilder.Entity<Student>()
                .HasQueryFilter(s => s.SoftDeleted == false);
            modelBuilder.Entity<Student>().HasData(new List<Student>
            {
                new Student { StudentId=1, EnrollmentDate=DateTime.UtcNow, StudentName="s1"},
                new Student { StudentId=2, EnrollmentDate=DateTime.UtcNow, StudentName="s2" },
                new Student { StudentId=3, EnrollmentDate=DateTime.UtcNow, StudentName="s3" },
            });
            modelBuilder.Entity<Instructor>().HasData(new List<Instructor>
            {
                new Instructor{InstructorId = 1,InstructorName="Sky1",HireDate=DateTime.UtcNow},
                new Instructor{InstructorId = 2,InstructorName="Sky2",HireDate=DateTime.UtcNow.AddDays(1)},
                new Instructor{InstructorId = 3,InstructorName="Sky3",HireDate=DateTime.UtcNow.AddDays(2)},
                new Instructor{InstructorId = 4,InstructorName="Sky4",HireDate=DateTime.UtcNow.AddDays(3)},
            });
            modelBuilder.Entity<Department>().HasData(new List<Department>
            {
                new Department{DepartmentId=1,InstructorId=1,DepartmentName="计算机学院",Budget=100000,StartData=DateTime.UtcNow},
                new Department{DepartmentId=2,InstructorId=1,DepartmentName="数学学院",Budget=500000,StartData=DateTime.UtcNow},
                new Department{DepartmentId=3,InstructorId=1,DepartmentName="外语学院",Budget=800000,StartData=DateTime.UtcNow},
            });
            modelBuilder.Entity<Course>().HasData(new List<Course>
            {
                new Course{CourseId=1,DepartmentId=1,Title="C#基础"},
                new Course{CourseId=2,DepartmentId=1,Title="数据结构"},
                new Course{CourseId=3,DepartmentId=1,Title="计算机组成原理"},
                new Course{CourseId=4,DepartmentId=1,Title="计算机网络"},
            });
            modelBuilder.Entity<Enrollment>().HasData(new List<Enrollment>
            {
                new Enrollment { EnrollmentId = 1, CourseId = 1, StudentId = 1, Grade = Grade.A },
                new Enrollment { EnrollmentId = 2, CourseId = 2, StudentId = 1, Grade = Grade.B },
                new Enrollment { EnrollmentId = 3, CourseId = 3, StudentId = 2, Grade = Grade.A },
                new Enrollment { EnrollmentId = 4, CourseId = 4, StudentId = 2, Grade = Grade.A },
            });
        } 
    
    }
}
