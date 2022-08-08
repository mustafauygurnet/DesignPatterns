using Strategy.Abstract;

namespace Strategy.Concrete;

internal class BeforeCoronaVirusPandemicCalculator : CreditCalculatorBase
{
    internal override void Calculate()
    {
        Console.WriteLine("Credit calculated using before corona virus pandemic");
    }
}