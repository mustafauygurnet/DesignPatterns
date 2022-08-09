using NullObject.Abstract;

namespace NullObject.Concrete;

public class NLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged with NLogger");
    }
}