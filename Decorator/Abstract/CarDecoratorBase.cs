namespace Decorator.Abstract;

internal abstract class CarDecoratorBase : CarBase
{
    private CarBase _carBase;

    protected CarDecoratorBase(CarBase carBase)
    {
        _carBase = carBase;
    }
}