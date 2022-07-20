using Builder.Builder;
using Builder.Builders;
using Builder.Concrete;
using Builder.Director;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarDirector carDirector = new CarDirector(new VipCarBuilder());
            
            CarDto car = carDirector.GenerateCarBuilder();
            
            Console.WriteLine("Car Type: " + car.CarType);
            Console.WriteLine("Car Brand: " + car.BrandName);
            Console.WriteLine("Car DailyPrice: $" + car.DailyPrice);
            Console.WriteLine("Car Discounted Price: $" + car.Discounted);
            Console.WriteLine("Has Discount been applied?: " + car.IsDiscounted);
        }
    }
}