using Facade.Abstract;

namespace Facade.Concrete
{
    internal class Auth : IAuth
    {
        public void Authority()
        {
            Console.WriteLine("Auth run!");
        }
    }
}