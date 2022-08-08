using Observer.Abstract;
using Observer.Business;
using Observer.Concrete;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            
            var customerObserver = new CustomerObserver();
            var employeeObserver = new EmployeeObserver();
            
            ((IProductService)productManager).Attach(customerObserver);
            ((IProductService)productManager).Attach(employeeObserver);
            
            ((IProductService)productManager).UpdatePrice();
        }
    }
}