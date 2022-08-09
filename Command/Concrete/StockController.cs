using Command.Abstract;

namespace Command.Concrete;

public class StockController
{
    private readonly List<ICommand> _orders = new List<ICommand>();

    public void TakeOrder(ICommand order)
    {
        _orders.Add(order);
    }

    public void PlaceOrders()
    {
        foreach (var order in _orders)
        {
            order.Execute();
        }
        
        _orders.Clear();
    }

}