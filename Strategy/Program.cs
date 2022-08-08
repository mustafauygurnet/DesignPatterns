using System;
using Strategy.Business;
using Strategy.Concrete;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.CreditCalculatorBase = new BeforeCoronaVirusPandemicCalculator();
            customerManager.GetCredit();
        }
    }
}