using FactoryMethod.Abstract;
using FactoryMethod.Concrete;

namespace FactoryMethod.Factory
{
    internal class RedisCacheFactory : CacheFactory
    {
        internal override ICache FactoryMethod()
        {
            return new RedisCache();
        }
    }
}
