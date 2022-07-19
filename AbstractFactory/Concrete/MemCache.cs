using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class MemCache : ICache
    {
        public void Cache()
        {
            Console.WriteLine("Mem Cache run!");
        }
    }
}
