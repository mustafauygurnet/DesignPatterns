namespace Mediator.Concrete;

public class Mediator
{
    internal Management Management { get; set; }
    internal List<Customer> Customers { get; set; }

    public void SendMessage(string message)
    {
        foreach (var customer in Customers)
        {
            customer.GetMessage(message);
        }
    }
    
    internal void SendComplaint (string complaint, Customer customer)
    {
        Management.GetComplaint(complaint,customer);
    }
}