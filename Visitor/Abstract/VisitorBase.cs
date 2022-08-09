using Visitor.Concrete;

namespace Visitor.Abstract;

public abstract class VisitorBase
{
    public abstract void Visit(Worker worker);
    public abstract void Visit(Manager manager);
}