using Observer.Abstract;

namespace Observer.Business;

internal class ProductManager : IProductService
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    void IProductService.UpdatePrice()
    {
        ((IProductService)this).Notify();
    }
    
     void IProductService.Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

     void IProductService.Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    void IProductService.Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}