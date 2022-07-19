using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete
{
    internal class RedisCache : ICache
    {
        public void Caching()
        {
            Console.WriteLine("RedisCache run!");
        }
    }
}
