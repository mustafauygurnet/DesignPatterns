namespace Visitor.Abstract;

public abstract class EmployeeBase
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public abstract void Accept(VisitorBase visitor);
}