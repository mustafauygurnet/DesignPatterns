using ChainOfResponsibility.Abstract;

namespace ChainOfResponsibility.Concrete;

internal class Manager : ExpenseHandlerBase
{
    public override void HandleExpense(Expense expense)
    {
        if (expense.Amount <= 1000)
        {
            Console.WriteLine("Manager handled the expense!");
        }
        else if(Successor!= null)
        {
            Successor.HandleExpense(expense);
        }
    }
}