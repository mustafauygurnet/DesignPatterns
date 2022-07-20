using Adapter.Adapters;
using Adapter.Business;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new LoggerAdapter());

            productManager.ApplyLogging();
        }
    }
}