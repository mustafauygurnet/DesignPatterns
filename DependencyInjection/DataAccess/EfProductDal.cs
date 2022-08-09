namespace DependencyInjection.DataAccess;

public class EfProductDal : IProductDal
{
    public void Save()
    {
        Console.WriteLine("Saved with Entity Framework");
    }
}