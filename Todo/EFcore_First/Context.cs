using EFcore_First.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcore_First
{
    //可以把上下文类看成一个数据库
    public class Context:DbContext
    {
        //主要是框架再用，有时用户也可能用到
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options)
        {

        }

        public DbSet<Book> Book { get; set; }

        //配置上下文类
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = @"server=PC-20220531UTCR;database=efcoreDb;trusted_connection=true;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connString);
        }

    }
}
