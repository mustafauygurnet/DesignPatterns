using DependencyInjection.Business;
using DependencyInjection.DataAccess;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductDal efproductDal = new EfProductDal();
            IProductDal NproductDal = new NhProductDal();
            
            IProductService productManager = new ProductManager(efproductDal);
            
            productManager.Save();
        }
    }
}