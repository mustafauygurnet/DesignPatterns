using Proxy.Concrete;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Image image = new Image("image.png");
            ImageProxy imageProxy = new ImageProxy("imageProxy.png");

            
            image.ShowImage();
            imageProxy.ShowImage();
        }
    }
}