using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    internal class MemCache : ICache
    {
        public void Caching()
        {
            Console.WriteLine("MemCache run!");
        }
    }
}
