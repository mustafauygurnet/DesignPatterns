using NullObject.Abstract;

namespace NullObject.Concrete;

public class StubLogger : ILogger
{
    private static StubLogger _stubLogger;
    private static object _lock = new object();

    private StubLogger() { }

    public static StubLogger Singleton()
    {
        lock (_lock)
        {
            if (_stubLogger == null)
            {
                _stubLogger = new StubLogger();
            }

            return _stubLogger;
        }
    }
    public void Log()
    {
    }
}