using Flyweight.Concrete;

namespace Flyweight.Abstract;

internal abstract class CacheFactory
{
    internal static Dictionary<string, object>? _dictionary = new();

    internal abstract DataResult Cache(DataResult dataResult);
}