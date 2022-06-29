// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Scaffold-DbContext "server=PC-20220531UTCR;database=AdventureWorksLT2019;trusted_connection=true;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -Context Context -outputdir Models -contextdir Data -Tables Address,Product -DataAnnotations -Force

//-Context Context ,上下文类名称
// -outputdir Models, 模型输出目录
// -contextdir Data, 上下文目录

// -Tables Address,Product, 指定生成的模型
// -DataAnnotations  ,生成数据注解
// -Force, 强制覆盖
