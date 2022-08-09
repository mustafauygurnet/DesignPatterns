using TemplateMethod.Abstract;
using TemplateMethod.Concrete;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCalculateAlgorithm creditCalculate;
            

            creditCalculate = new BusinessCreditCalculateAlgorithm();
            Console.WriteLine("Business: {0} $ Credit Available",creditCalculate.GenerateCredit(60000,16));
            

            creditCalculate = new IndividualCreditCalculateAlgorithm();
            Console.WriteLine("Individual: {0} $ Credit Available",creditCalculate.GenerateCredit(4500,2));
            

            creditCalculate = new SmeCreditCalculateAlgorithm();
            Console.WriteLine("Sme: {0} $ Credit Available",creditCalculate.GenerateCredit(10000,9));
        }
    }
}