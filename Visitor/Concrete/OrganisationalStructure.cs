using Visitor.Abstract;

namespace Visitor.Concrete;

public class OrganisationalStructure
{
    public EmployeeBase Employee;

    public OrganisationalStructure(EmployeeBase employeeBase)
    {
        Employee = employeeBase;
    }

    public void Accept(VisitorBase visitor)
    {
        Employee.Accept(visitor);
    }
}