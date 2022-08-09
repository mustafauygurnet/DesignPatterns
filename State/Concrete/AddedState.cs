using State.Abstract;

namespace State.Concrete;

internal class AddedState : IState
{
    public void Entry(Context context)
    {
        Console.WriteLine("State : Added");
        context.SetState(this);
    }
    public override string ToString()
    {
        return "Added";
    }
}