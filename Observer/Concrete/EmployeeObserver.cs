using Observer.Abstract;

namespace Observer.Concrete;

internal class EmployeeObserver : IObserver
{
    void IObserver.Update()
    {
        Console.WriteLine("Message of Employee: Product price changed!");
    }
}