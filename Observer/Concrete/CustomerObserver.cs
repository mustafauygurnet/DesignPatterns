using Observer.Abstract;

namespace Observer.Concrete;

internal class CustomerObserver : IObserver
{
    void IObserver.Update()
    {
        Console.WriteLine("Message of Customer: Product price changed!");
    }
}