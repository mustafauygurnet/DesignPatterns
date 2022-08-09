namespace Memento.MementoPattern;

internal class ProductMemento
{
    public string ProductName { get; set; }
    public string CategoryName { get; set; }
    public string Brand { get; set; }
    public DateTime LastEdited { get; set; }

    public ProductMemento(string productName, string categoryName,string brand, DateTime lastEdited)
    {
        ProductName = productName;
        CategoryName = categoryName;
        Brand = brand;
        LastEdited = lastEdited;
    }
}