using Facade.Abstract;

namespace Facade.Concrete
{
    internal class Log : ILog
    {
        public void Logging()
        {
            Console.WriteLine("Logging Run!");
        }
    }
}