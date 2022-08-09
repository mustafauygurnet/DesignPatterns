using Mediator.Abstract;

namespace Mediator.Concrete;

internal class Customer : Member
{
    public string Name { get; set; }
    
    public Customer(Mediator mediator) : base(mediator)
    {
    }
    public void GetMessage(string message)
    {
        Console.WriteLine("{1} Get Message: {0}", message, Name);
    }
    
}