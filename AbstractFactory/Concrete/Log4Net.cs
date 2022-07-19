using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class Log4Net : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log4Net run!");
        }
    }
}
