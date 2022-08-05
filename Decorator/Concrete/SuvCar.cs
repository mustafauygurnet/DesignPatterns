using Decorator.Abstract;

namespace Decorator.Concrete;

internal class SuvCar : CarBase
{
    public override string Brand { get; set; }
    public override string Model { get; set; }
    public override decimal HirePrice { get; set; }
}