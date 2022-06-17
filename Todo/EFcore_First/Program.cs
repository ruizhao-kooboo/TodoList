/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();*/

//数据库连接字符串
//服务器名称：Data Source = (localdb)\MSSQLLocalDB; server=; addr=;
//数据库名称：database=book;initial catalog=;
//安全信息：trusted_connection=true; Integrated Security=false;
//属性：MultipleActvieResultSets=true;

string connString = @"server=PC - 20220531UTCR;database=efcoreDb;MultipleActvieResultSets=true";

//数据库上下文类（管道）
//数据库迁移（CodeFirst模式）add-migration（生成迁移代码） init-Mig（迁移名称） update-database（执行到数据库）