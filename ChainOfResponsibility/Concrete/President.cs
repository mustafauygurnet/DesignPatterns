using ChainOfResponsibility.Abstract;

namespace ChainOfResponsibility.Concrete;

internal class President : ExpenseHandlerBase
{
    public override void HandleExpense(Expense expense)
    {
        if (expense.Amount > 10000)
        {
            Console.WriteLine("President handled the expense!");
        }
    }
}