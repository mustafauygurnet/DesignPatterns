using Decorator.Abstract;

namespace Decorator.Concrete;

internal class VipCar : CarBase
{
    public override string Brand { get; set; }
    public override string Model { get; set; }
    public override decimal HirePrice { get; set; }
}