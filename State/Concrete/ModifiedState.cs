using State.Abstract;

namespace State.Concrete;

internal class ModifiedState : IState
{
    public void Entry(Context context)
    {
        Console.WriteLine("State : Modified");
        context.SetState(this);
    }

    public override string ToString()
    {
        return "Modified";
    }
}