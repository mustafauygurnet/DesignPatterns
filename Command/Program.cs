using Command.Concrete;
using Command.OutSourceAPIs;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockAPI stockApi = new StockAPI();
            
            BuyStock buyStock = new BuyStock(stockApi);
            SellStock sellStock = new SellStock(stockApi);

            StockController stockController = new StockController();
            
            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(sellStock);
            stockController.TakeOrder(buyStock);
            stockController.TakeOrder(buyStock);
            
            stockController.PlaceOrders();
        }
    }
}