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

//���ݿ������ַ���
//���������ƣ�Data Source = (localdb)\MSSQLLocalDB; server=; addr=;
//���ݿ����ƣ�database=book;initial catalog=;
//��ȫ��Ϣ��trusted_connection=true; Integrated Security=false;
//���ԣ�MultipleActvieResultSets=true;

string connString = @"server=PC - 20220531UTCR;database=efcoreDb;MultipleActvieResultSets=true";

//���ݿ��������ࣨ�ܵ���
//���ݿ�Ǩ�ƣ�CodeFirstģʽ��add-migration������Ǩ�ƴ��룩 init-Mig��Ǩ�����ƣ� update-database��ִ�е����ݿ⣩