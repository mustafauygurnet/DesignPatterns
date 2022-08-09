using Iterator.Concrete;

namespace Iterator.Abstract;

public interface IIterator
{
    bool HasItem();
    Personal NextItem();
    Personal CurrentItem();
}