using Composite.Concrete;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category foods = new Category { Name = "Foods"};
            Category hamburgers = new Category {Name = "Hamburgers" };
            Category salad = new Category { Name = "Salad" };
            Category vegan = new Category { Name = "Vegan Hamburger" };


            foods.Add(hamburgers,salad);

            hamburgers.Add(vegan);

            Console.WriteLine(foods.Name);
            foreach (Category food in foods)
            {
                Console.WriteLine($" {food.Name}");
                foreach (Category f in food)
                {
                    Console.WriteLine($"   {f.Name}");
                }
            }

        }
    }
}