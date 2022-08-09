using ChainOfResponsibility.Abstract;

namespace ChainOfResponsibility.Concrete;

internal class VicePresident : ExpenseHandlerBase
{
    public override void HandleExpense(Expense expense)
    {
        if (expense.Amount > 1000 && expense.Amount <= 10000)
        {
            Console.WriteLine("VicePresident handled the expense!");
        }
        else if(Successor!= null)
        {
            Successor.HandleExpense(expense);
        }
    }
}