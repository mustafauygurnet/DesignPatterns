namespace TemplateMethod.Abstract;

internal abstract class CreditCalculateAlgorithm
{
    internal int GenerateCredit(int salary, int findexScore)
    {
        int score = CalculateBaseScore(salary);
        int findex = CalculateFindexScore(findexScore);

        return CalculateOverallScore(score,findex);
    }

    protected abstract int CalculateOverallScore(int salary, int findexScore);

    protected abstract int CalculateFindexScore(int findexScore);

    protected abstract int CalculateBaseScore(int salary);
}