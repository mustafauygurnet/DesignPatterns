using DependencyInjection.DataAccess;

namespace DependencyInjection.Business;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Save()
    {
        _productDal.Save();
    }
}