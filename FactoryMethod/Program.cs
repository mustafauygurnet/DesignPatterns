using FactoryMethod.Business;
using FactoryMethod.Factory;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new MemCacheFactory());
            productManager.SomeOperation();
        }
    }
}