using Iterator.Abstract;

namespace Iterator.Concrete;

public class PersonalAggregate : IAggregate
{
    readonly List<Personal> _personalList = new List<Personal>();

    public void Add(Personal personal)
    {
        _personalList.Add(personal); 
    }

    public Personal GetItem(int index)
    {
       return _personalList[index];  
    }

    public int Count
    {
        get
        {
           return _personalList.Count;
        } 
    }

    public IIterator CreateIterator()
    {
        return new PersonalIterator(this);
    } 
}