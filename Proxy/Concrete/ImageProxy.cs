using Proxy.Abstract;

namespace Proxy.Concrete;

internal class ImageProxy : IImage
{
    private Image _image;
    private readonly string _imagePath;


    public ImageProxy(string imagePath)
    {
        _imagePath = imagePath;
    }

    public void ShowImage()
    {
        if (_image == null)
        {
            _image = new Image(_imagePath);
        }
        _image.ShowImage();
    }
}