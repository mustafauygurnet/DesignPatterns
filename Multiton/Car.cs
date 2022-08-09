namespace Multiton;

public class Car
{
    private static readonly Dictionary<string, Car> Cars = new Dictionary<string, Car>();
    private static readonly object Lock = new object();
    public Guid Id { get; set; }
    private Car()
    {
        Id = Guid.NewGuid();
    }

    public static Car GetCar(string brand)
    {
        lock (Lock)
        {
            if (!Cars.ContainsKey(brand))
            {
                Cars.Add(brand,new Car());
            }
            return Cars[brand];
        }
    }


}