using System.Diagnostics;
using Flyweight.Business;
using Flyweight.Concrete;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new MemCacheFactory());
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var start = stopwatch.ElapsedMilliseconds;

            var dataResult1 = new DataResult { Key = "ABC", Data = 123};
            var data1 = productManager.GetData(dataResult1);
            
            var dataResult2 = new DataResult { Key = "ABCD", Data = 12345};
            var data2 = productManager.GetData(dataResult2);
            
            var dataResult3 = new DataResult { Key = "ABC", Data = 123};
            var data3 = productManager.GetData(dataResult3);
            
            stopwatch.Stop();
            var stop = stopwatch.ElapsedMilliseconds;
            

            Console.WriteLine("Data1 {0} - {1}",data1.Key,data1.Data);
            Console.WriteLine("Data2 {0} - {1}",data2.Key,data2.Data);
            Console.WriteLine("Data3 {0} - {1}",data3.Key,data3.Data);
            
            
            Console.WriteLine("Passing Seconds: {0}",(stop-start) / 1000);
            
            
        }
    }
}