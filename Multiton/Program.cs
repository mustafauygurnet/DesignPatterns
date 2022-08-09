namespace Multiton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car camera1 = Car.GetCar("TESLA");
            Car camera2 = Car.GetCar("TESLA");
            Car camera3 = Car.GetCar("AUDI");
            Car camera4 = Car.GetCar("AUDI");
            Car camera5 = Car.GetCar("MERCEDES");

            Console.WriteLine(camera1.Id);
            Console.WriteLine(camera2.Id);
            Console.WriteLine(camera3.Id);
            Console.WriteLine(camera4.Id);
            Console.WriteLine(camera5.Id);
        }
    }
}