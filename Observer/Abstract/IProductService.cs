namespace Observer.Abstract;

internal interface IProductService
{
    internal void UpdatePrice();
    internal void Attach(IObserver observer);
    internal void Detach(IObserver observer);
    internal void Notify();
    
}