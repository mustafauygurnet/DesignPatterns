using Visitor.Concrete;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager{Name = "John Doe", Salary = 5000};
            Manager manager2 = new Manager{Name = "Jane Doe", Salary = 5200};

            Worker worker1 = new Worker { Name = "John Smith", Salary = 2000 };
            Worker worker2= new Worker { Name = "Jane Smith", Salary = 2200 };
            
            manager1.Subordinates.Add(manager2);
            manager2.Subordinates.Add(worker1);
            manager2.Subordinates.Add(worker2);

            OrganisationalStructure organisationalStructure = new OrganisationalStructure(manager1);

            PayrollVisitor payrollVisitor = new PayrollVisitor();
            PayRiseVisitor payRiseVisitor = new PayRiseVisitor();
            
            organisationalStructure.Accept(payrollVisitor);
            organisationalStructure.Accept(payRiseVisitor);
            
        }
    }
}