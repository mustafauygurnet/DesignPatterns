using Visitor.Abstract;

namespace Visitor.Concrete;

public class PayRiseVisitor : VisitorBase
{
    public override void Visit(Worker worker)
    {
        Console.WriteLine("{0} paid increased to {1} ", worker.Name,worker.Salary *(decimal) 1.1);
    }

    public override void Visit(Manager manager)
    {
        Console.WriteLine("{0} paid increased to {1} ", manager.Name,manager.Salary*(decimal) 1.2);
    }
}