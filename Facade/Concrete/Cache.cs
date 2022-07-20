using Facade.Abstract;

namespace Facade.Concrete
{
    internal class Cache : ICache
    {
        public void Caching()
        {
            Console.WriteLine("Caching Run!");
        }
    }
}