using Bridge.Abstract;

namespace Bridge.Concrete;

internal class MailSender : MessageSenderBase
{
    internal override void Send()
    {
        Console.WriteLine("The message has been sent with email");
    }
}