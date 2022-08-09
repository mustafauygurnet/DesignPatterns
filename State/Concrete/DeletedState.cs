using State.Abstract;

namespace State.Concrete;

internal class DeletedState : IState
{
    public void Entry(Context context)
    {
        Console.WriteLine("State : Deleted");
        context.SetState(this);
    }
    
    public override string ToString()
    {
        return "Deleted";
    }
}