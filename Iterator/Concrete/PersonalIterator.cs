using Iterator.Abstract;

namespace Iterator.Concrete;

public class PersonalIterator : IIterator
{
    private readonly PersonalAggregate _aggregate;
    private int _currentIndex;

    public PersonalIterator(PersonalAggregate aggregate)
    { 
        _aggregate = aggregate;  
    }

    public Personal CurrentItem()
    {
       return _aggregate.GetItem(_currentIndex); 
    } 
    public bool HasItem()
    {
        if (_currentIndex < _aggregate.Count)
            return true;
        return false;
    }
    public Personal NextItem()
    {
        if (HasItem())
            return _aggregate.GetItem(_currentIndex++);
        return new Personal();
    }
}