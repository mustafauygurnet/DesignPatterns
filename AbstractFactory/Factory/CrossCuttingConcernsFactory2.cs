using AbstractFactory.Abstract;
using AbstractFactory.Concrete;

namespace AbstractFactory.Factory
{
    internal abstract class CrossCuttingConcernsFactory2 : ICrossCuttingConcernsFactory
    {
        public ICache Caching()
        {
            return new RedisCache();
        }

        public ILogger Logging()
        {
            return new Serilog();
        }
    }
}
