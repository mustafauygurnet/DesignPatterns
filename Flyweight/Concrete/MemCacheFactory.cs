using Flyweight.Abstract;

namespace Flyweight.Concrete;

internal class MemCacheFactory : CacheFactory
{
    internal override DataResult Cache(DataResult dataResult)
    {
        if (!_dictionary.ContainsKey(dataResult.Key))
        {
            _dictionary.Add(dataResult.Key, dataResult.Data);
            Thread.Sleep(5000);
            
            return dataResult;
        }

        var contains = _dictionary[dataResult.Key];
        return new DataResult{Key = dataResult.Key, Data = contains};
    }
}