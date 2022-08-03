using Proxy.Abstract;

namespace Proxy.Concrete;

internal class Image : IImage
{
    private readonly string _imagePath;


    public Image(string imagePath)
    {
        _imagePath = imagePath;
    }

    public void ShowImage()
    {
        Console.WriteLine(_imagePath);
    }
}