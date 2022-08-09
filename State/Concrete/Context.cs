using State.Abstract;

namespace State.Concrete;

public class Context
{
    private IState _state;

    public void SetState(IState state)
    {
        _state = state;
    }
    
    public IState GetState()
    {
        return _state;
    }
}