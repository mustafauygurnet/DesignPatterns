using NullObject.Abstract;

namespace NullObject.Concrete;

public class Log4NetLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged with Log4NetLogger");
    }
}