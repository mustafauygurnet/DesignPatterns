using Facade.Abstract;

namespace Facade.Concrete
{
    internal class Validation : IValidation
    {
        public void Validate()
        {
            Console.WriteLine("Validate Run!");
        }
    }
}