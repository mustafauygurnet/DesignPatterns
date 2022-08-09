using Memento.MementoPattern;

namespace Memento.Concrete;

internal class Product
{
    private string _productName;
    private string _categoryName;
    private string _brand;

    private DateTime _lastEdited;

    public string ProductName
    {
        get => _productName;
        set
        {
            _productName = value;
            SetLastEdited();
        } 
    }

    public string CategoryName
    {
        get => _categoryName;
        set
        {
            _categoryName = value;
            SetLastEdited();
        } 
    }

    public string Brand
    {
        get => _brand;
        set
        {
          _brand = value;
          SetLastEdited();
        } 
    }

    public ProductMemento CreateUndo()
    {
        return new ProductMemento(_productName,_categoryName,_brand,_lastEdited);
    }
    
    public void RestoreFromUndo(ProductMemento memento)
    {
        _productName = memento.ProductName;
        _categoryName = memento.CategoryName;
        _brand = memento.Brand;
        _lastEdited = memento.LastEdited;
    }

    public void ShowProduct()
    {
        Console.WriteLine("{0}-{1}-{2}-{3} ", _productName,_categoryName,_brand, _lastEdited);
    }

    private void SetLastEdited()
    {
        _lastEdited = DateTime.Now;
    }
}