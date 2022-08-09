using Iterator.Abstract;
using Iterator.Concrete;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalAggregate aggregate = new PersonalAggregate();
            
            aggregate.Add(new Personal { Id = 1, FirstName = "John", LastName = "Doe" });
            aggregate.Add(new Personal { Id = 2, FirstName = "Jane", LastName = "Doe" });
            aggregate.Add(new Personal { Id = 3, FirstName = "John", LastName = "Smith" });
            aggregate.Add(new Personal { Id = 4, FirstName = "Jane", LastName = "Smith" });
            aggregate.Add(new Personal { Id = 5, FirstName = "John", LastName = "Junior" });
 
            IIterator iterator = aggregate.CreateIterator();
            
            while (iterator.HasItem())
            {
                Console.WriteLine("Id: {0}", iterator.CurrentItem().Id);
                Console.WriteLine("FirstName: {0}", iterator.CurrentItem().FirstName);
                Console.WriteLine("LastName: {0}\n", iterator.CurrentItem().LastName);
                iterator.NextItem();
            }
        }
    }
}