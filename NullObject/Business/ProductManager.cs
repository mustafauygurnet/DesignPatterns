using NullObject.Abstract;

namespace NullObject.Business;

public class ProductManager
{
    private readonly ILogger _logger;

    public ProductManager(ILogger logger)
    {
        _logger = logger;
    }

    public void Save()
    {
        _logger.Log();
    }
}