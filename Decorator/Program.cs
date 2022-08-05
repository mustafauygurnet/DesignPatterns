using System;
using Decorator.Concrete;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personalCar = new VipCar { Brand = "Audi",Model = "A8", HirePrice = 800};

            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            Console.WriteLine("Vip Car {0}",personalCar.HirePrice);
            Console.WriteLine("Special Offer {0}",specialOffer.HirePrice);
        }
    }
}