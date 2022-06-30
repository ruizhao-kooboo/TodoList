using AspNetCoreBasic_1;

class Program
{
    static void Main(string[] args)
    {
        IocShow iocShow = new IocShow();
        iocShow.Show();
        Console.WriteLine("World");
    }
}
