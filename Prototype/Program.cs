namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car original = new Car();

            original.BrandName = "AUDI";
            original.ModelYear = 2022;
            original.CarStyle = new CarStyle("SUV");

            Car shallowCopy = original.ShallowCopy();

            Console.WriteLine("Original Object: " + original.BrandName);
            Console.WriteLine("Original Object: " + original.ModelYear);
            Console.WriteLine("Original Object: " + original.CarStyle.Style);

            Console.WriteLine("");

            Console.WriteLine("ShallowCopy Object: " + shallowCopy.BrandName);
            Console.WriteLine("ShallowCopy Object: " + shallowCopy.ModelYear);
            Console.WriteLine("ShallowCopy Object: " + shallowCopy.CarStyle.Style);

            Console.WriteLine("-----------------------------------------------");

            original.BrandName = "BMW";
            original.ModelYear = 2023;
            original.CarStyle.Style = "SPORT";

            Console.WriteLine("Original Object After Changed: " + original.BrandName);
            Console.WriteLine("Original Object After Changed: " + original.ModelYear);
            Console.WriteLine("Original Object After Changed: " + original.CarStyle.Style);

            Console.WriteLine("");

            Console.WriteLine("ShallowCopy Object After Changed: " + shallowCopy.BrandName);
            Console.WriteLine("ShallowCopy Object After Changed: " + shallowCopy.ModelYear);
            Console.WriteLine("ShallowCopy Object After Changed: " + shallowCopy.CarStyle.Style + " JUST THIS CHANGED");

            Console.WriteLine("-----------------------------------------------");

            Car deepCopy = original.DeepCopy();

            original.BrandName = "Mercedes";
            original.ModelYear = 2012;
            original.CarStyle.Style = "SEDAN";
            
            Console.WriteLine("Original Object After Changed: " + original.BrandName);
            Console.WriteLine("Original Object After Changed: " + original.ModelYear);
            Console.WriteLine("Original Object After Changed: " + original.CarStyle.Style);

            Console.WriteLine("");
            Console.WriteLine("DeepCopy Object After Changed: " + deepCopy.BrandName);
            Console.WriteLine("DeepCopy Object After Changed: " + deepCopy.ModelYear);
            Console.WriteLine("DeepCopy Object After Changed: " + deepCopy.CarStyle.Style);


        }
    }
}