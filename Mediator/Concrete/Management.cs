using Mediator.Abstract;

namespace Mediator.Concrete;

internal class Management : Member
{
    public Management(Mediator mediator) : base(mediator)
    {
    }
    public void GetComplaint(string complaint, Customer customer)
    {
        Console.WriteLine("Management get a complaint from {0} : {1}", customer.Name, complaint);
    }
}