using Command.Abstract;
using Command.OutSourceAPIs;

namespace Command.Concrete;

internal class SellStock : ICommand
{
    private readonly StockAPI _stock;

    public SellStock(StockAPI stock)
    {
        _stock = stock;
    }

    public void Execute()
    {
        _stock.Sell();
    }
}