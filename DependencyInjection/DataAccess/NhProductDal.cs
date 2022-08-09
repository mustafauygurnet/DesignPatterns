namespace DependencyInjection.DataAccess;

public class NhProductDal : IProductDal
{
    public void Save()
    {
        Console.WriteLine("Saved with NHibernate Framework");
    }
}