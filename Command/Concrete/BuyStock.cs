
using Command.Abstract;
using Command.OutSourceAPIs;

namespace Command.Concrete;

internal class BuyStock : ICommand
{
    private readonly StockAPI _stock;

    public BuyStock(StockAPI stock)
    {
        _stock = stock;
    }

    public void Execute()
    {
        _stock.Buy();
    }
}