namespace Decorator.Abstract;

public abstract class CarBase
{
    public abstract string Brand { get; set; }
    public abstract string Model { get; set; }
    public abstract decimal HirePrice { get; set; }
}