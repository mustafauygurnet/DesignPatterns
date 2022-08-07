using Flyweight.Abstract;
using Flyweight.Concrete;

namespace Flyweight.Business;

internal class ProductManager
{
    private readonly CacheFactory _cacheFactory;

    internal ProductManager(CacheFactory cacheFactory)
    {
        _cacheFactory = cacheFactory;
    }

    internal DataResult GetData(DataResult data)
    {
        var dataResult = _cacheFactory.Cache(data);
        return dataResult;
    }
}