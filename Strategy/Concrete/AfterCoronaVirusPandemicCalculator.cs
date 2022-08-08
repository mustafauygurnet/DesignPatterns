using Strategy.Abstract;

namespace Strategy.Concrete;

internal class AfterCoronaVirusPandemicCalculator: CreditCalculatorBase
{
    internal override void Calculate()
    {
        Console.WriteLine("Credit calculated using after corona virus pandemic");
    }
}