using ChainOfResponsibility.Concrete;

namespace ChainOfResponsibility.Abstract;

internal abstract class ExpenseHandlerBase
{
    protected ExpenseHandlerBase Successor;
    public abstract void HandleExpense(Expense expense);

    public void SetSuccessor(ExpenseHandlerBase successor)
    {
        Successor = successor;
    }
}