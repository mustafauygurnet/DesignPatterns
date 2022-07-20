using Facade.Business;
using Facade.Concrete;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var log = new Log();
            var cache = new Cache();
            var validation = new Validation();
            var auth = new Auth();
            
            ProductManager productManager = new ProductManager(new CrossCuttingConcernsFacade(auth,cache,log,validation));


            productManager.ApplyCrossCuttingConcerns();
            
        }
    }
}