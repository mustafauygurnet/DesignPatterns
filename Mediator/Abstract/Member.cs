namespace Mediator.Abstract;

internal abstract class Member
{
    protected readonly Concrete.Mediator Mediator;

    protected Member(Concrete.Mediator mediator)
    {
        Mediator = mediator;
    }
}

