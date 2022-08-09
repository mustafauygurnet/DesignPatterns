using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete;

internal class IndividualCreditCalculateAlgorithm : CreditCalculateAlgorithm
{
    protected override int CalculateOverallScore(int salary, int reduction)
    {
        return salary - reduction;
    }

    protected override int CalculateFindexScore(int findexScore)
    {
        return findexScore * 100;
    }

    protected override int CalculateBaseScore(int salary)
    {
        return salary / 3;
    }
}