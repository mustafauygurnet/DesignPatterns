using Bridge.Business;
using Bridge.Concrete;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new(new SmsSender());

            customerManager.Sender();
        }
    }
}