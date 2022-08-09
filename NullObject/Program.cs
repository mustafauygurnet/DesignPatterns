using NullObject.Business;
using NullObject.Concrete;
using NullObject.Extension;

namespace NullObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Method of Null Object
            ProductManager productManager = new ProductManager(StubLogger.Singleton());
            productManager.Save();

            

            string text = "lorem ipsum";
            int number = 123;
            
            //Second Method of Null Object
            Console.WriteLine("Is {1} Null? {0}", text.IsNull(),text);
            Console.WriteLine("Is Not {1} Null? {0}", number.IsNotNull(),number);
            
            Console.WriteLine("Is Product Manager Null? {0}", productManager.IsNull());
            Console.WriteLine("Is Not Product Manager Null? {0}", productManager.IsNotNull());
        }
    }
}