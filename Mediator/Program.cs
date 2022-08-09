using Mediator.Concrete;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Concrete.Mediator mediator = new Concrete.Mediator();
            
            Management management = new Management(mediator);
            mediator.Management = management;

            Customer johnDoe = new Customer(mediator);
            johnDoe.Name = "John Doe";
            
            Customer janeDoe = new Customer(mediator);
            janeDoe.Name = "Jane Doe";

            mediator.Customers = new List<Customer> {johnDoe,janeDoe};
            
            mediator.SendMessage("Message 1");
            mediator.SendComplaint("Complaint 1",janeDoe);


        }
    }
}