using State.Concrete;

namespace State.Abstract;

public interface IState
{
    void Entry(Context context);
}