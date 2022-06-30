/// 本节：DI（Dependency Injecation） -IOC（Inversion of Control）--依赖倒置原则（效果）
/// 依赖倒置原则：
/// 1、上层模块不应该依赖于底层模块，它们都应该依赖于抽象。
/// 2、抽象不应该依赖于细节，细节应该依赖于抽象

namespace AspNetCoreBasic_1
{
    public class IocShow
    {
        public void Show()
        {
            //Student student = new Student();
            IPerson person = new Student();
            person.PlayGames();
        }
    }

    /// <summary>
    /// 工厂
    /// </summary>
    class Factory
    {
        public static IPerson CreateInstance()
            { return new Teacher(CreateMessage()); }

        public static IMessage CreateMessage()
        { return new Message(); }
    }

    interface IPerson 
    {
        void PlayGames();
    }

    class Student : IPerson
    {
        public void PlayGames()
        {
            Console.WriteLine("hello");
        }
    }

    class Teacher : IPerson
    {
        private IMessage _message;
        public Teacher(IMessage message)
        {
            _message = message;
        }

        public void PlayGames()
        {
            //Message message = new Message();
            //IMessage message = Factory.CreateMessage();
            _message.SendMessage("teacher","morning");
            Console.WriteLine("i am a teacher");
        }
    }

    public interface IMessage
    {
        void SendMessage(string person, string message);
    }

    public class Message : IMessage
    {
        public void SendMessage(string person, string message)
        {
            Console.WriteLine($"{person}{message}");
        }
    }
}