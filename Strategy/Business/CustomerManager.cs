using Strategy.Abstract;

namespace Strategy.Business;

internal class CustomerManager
{
    internal CreditCalculatorBase CreditCalculatorBase { get; set; }

    internal void GetCredit()
    {
        CreditCalculatorBase.Calculate();
    }
}