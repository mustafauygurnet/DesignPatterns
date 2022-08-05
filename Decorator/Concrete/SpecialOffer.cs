using Decorator.Abstract;

namespace Decorator.Concrete;

internal class SpecialOffer : CarDecoratorBase
{
    private int DiscountRate { get; set; } = 10;
    private readonly CarBase _carBase;
    public SpecialOffer(CarBase carBase) : base(carBase)
    {
        _carBase = carBase;
    }

    public override string Brand { get; set; }
    public override string Model { get; set; }

    public override decimal HirePrice
    {
        get
        {
            return _carBase.HirePrice - _carBase.HirePrice * DiscountRate / 100;
        }
        set
        {
        }
    }
}