using AbstractFactory.Business;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new CrossCuttingConcernsFactory1());
            productManager.SomeOperation();
        }
    }
}