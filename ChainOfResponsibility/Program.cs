using ChainOfResponsibility.Concrete;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new();
            VicePresident vicePresident = new();
            President president = new();
            
            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Expense expense = new Expense()
            {
                Detail = "Food Expenses",
                Amount = 200
            };
            manager.HandleExpense(expense);
        }
    }
}