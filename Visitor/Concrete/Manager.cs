using Visitor.Abstract;

namespace Visitor.Concrete;

public class Manager : EmployeeBase
{
    public Manager()
    {
        Subordinates = new List<EmployeeBase>();
    }

    public List<EmployeeBase> Subordinates { get; set; } 
    public override void Accept(VisitorBase visitor)
    {
        visitor.Visit(this);
        foreach (var employee in Subordinates)
        {
            employee.Accept(visitor);
        }
    }
}

public class Worker : EmployeeBase
{
    public override void Accept(VisitorBase visitor)
    {
        visitor.Visit(this);
    }
}