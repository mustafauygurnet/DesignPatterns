using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class Serilog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Serilog run!");
        }
    }
}
