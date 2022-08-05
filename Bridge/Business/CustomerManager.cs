using Bridge.Abstract;
using Bridge.Concrete;

namespace Bridge.Business;

internal class CustomerManager
{
    private readonly MessageSenderBase _messageSenderBase;
    public CustomerManager(MessageSenderBase messageSenderBase)
    {
        _messageSenderBase = messageSenderBase;
    }
    
    internal void Sender()
    {
        _messageSenderBase.Send();
    }
}