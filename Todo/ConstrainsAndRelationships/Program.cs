// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//约束（Constraints）和关系（RelationShip）
//配置约束的方式有三种：1.按约定（按默认配置）2.数据注释（通过特性进行约束）3.FluentAPI（通过接口来配置，最强大）


using ConstrainsAndRelationships.Data;
using ConstrainsAndRelationships.Models;
using Microsoft.EntityFrameworkCore;

#region CRUD
using (var db = new UniversityContext())
{
    //添加数据
    /* var stu = new Student
     {
         StudentName = ".NET编程",
         EnrollmentDate = DateTime.UtcNow
     };
     var id = db.Add(stu);//在内存里执行，没有真正添加到数据库*/

    //修改
/*    var student = db.Students.Find(6);
    student.StudentName = "修改测试";
    db.Students.Update(student);*/

    //删除 （默认情况是级联删除）
    var stu2 = db.Students.SingleOrDefault(s => s.StudentId == 1);
    //db.Students.Remove(stu2);
    stu2.SoftDeleted = true; //软删除 为true时查不到
    db.Students.Update(stu2);

    db.SaveChanges();//保存到数据库

}

#endregion

#region 数据加载和查询

#region 获取一个表的所有数据
/*using (var db = new UniversityContext())
{
    //ToArrary/ToDictionary
    var students = db.Students.ToList();
    foreach (var s in students)
    {
        Console.WriteLine($"{s.StudentId},{s.StudentName},{s.EnrollmentDate}");
    }
}*/
#endregion

#region 关闭跟踪查询 提高查询效率
/*using (var db = new UniversityContext())
{
    //AsNoTracking()取消跟踪 提高查询效率
    var students = db.Students.AsNoTracking().ToList();
    foreach (var s in students)
    {
        Console.WriteLine($"{s.StudentId},{s.StudentName},{s.EnrollmentDate}");
    }
}*/
#endregion

//数据加载分四种方式：预加载、显示加载、选择加载、延迟加载，默认不加载关联数据
#region 预加载
//缺点：加载所有数据
/*using (var db = new UniversityContext())
{
    //预加载通过两个方法指定加载的数据 Include/ThenInclude
    var student = db.Students
        .AsNoTracking()
        .Include(s=>s.Enrollments)
            .ThenInclude(c=>c.Course)
            .FirstOrDefault();

        Console.WriteLine($"{student.StudentId},{student.StudentName},{student.EnrollmentDate}" + $",{student.Enrollments.FirstOrDefault().Grade},{student.Enrollments.FirstOrDefault().Course.Title}");
}*/
#endregion

#region 显示加载 对于数据很多的情况可以大大减小加载量
//加载实体需要的关系
/*using (var db = new UniversityContext())
{
    var firstCourse = db.Courses.First();

    //根据查询到的实体查询相关导航属性Collection()方法时针对集合
    db.Entry(firstCourse)
        .Collection(c => c.Enrollments).Load();

    //Reference()方法是针对单个实体
    db.Entry(firstCourse)
        .Reference(c => c.Department).Load();

    Console.WriteLine($"{firstCourse.Title}," + $"{firstCourse.Enrollments.Count()}," + $"{firstCourse.Department.DepartmentName},");
}*/
#endregion

#region 选择性加载
//按需加载
/*using (var db = new UniversityContext())
{
    //使用LINQ里面的select方法
    //这里转换对象可以写ViewModel
    var course = db.Courses.AsTracking()
        .Select(c => new CourseVM
        {
            Title = c.Title,
            DepartmentName = c.Department.DepartmentName
        }).ToList();

    foreach (var c in course)
    {
        Console.WriteLine($"{c.Title}，{c.DepartmentName}");
    }

}*/
#endregion

#region 延迟加载
//配置方式
//1安装Entity Framework Core.Proxies
//2配置数据库上下文
//3导航属性必须是虚属性
/*using (var db = new UniversityContext())
{
    var student = db.Students.FirstOrDefault();
    var enrollment = student.Enrollments.FirstOrDefault();

    Console.WriteLine($"{student.StudentId},{student.StudentName},{student.EnrollmentDate}" + $",{student.Enrollments.Count()}");
}*/

#endregion

class CourseVM
{
    public string Title { get; set; }
    public string DepartmentName { get; set; }
}

#endregion