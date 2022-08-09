namespace Command.OutSourceAPIs;

internal class StockAPI
{
    private string _name = "Laptop";
    private int _quantity = 10;

    public void Buy()
    {
        Console.WriteLine("Stock : {0}, {1} bought", _name, _quantity);
    }

    public void Sell()
    {
        Console.WriteLine("Stock : {0}, {1} sold", _name, _quantity);
    }
}