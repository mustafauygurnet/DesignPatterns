using Memento.Concrete;
using Memento.MementoPattern;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product book = new Product
            {
                ProductName = "Milk",
                CategoryName = "Breakfast",
                Brand = "Milka"
            };
            
            book.ShowProduct();
            
            CareTaker history = new CareTaker
            {
                Memento = book.CreateUndo()
            };

            book.Brand = "Milkman";
            book.ProductName = "Cow Milk";
            book.ShowProduct();
            
            book.RestoreFromUndo(history.Memento);
            
            book.ShowProduct();
        }
    }
}