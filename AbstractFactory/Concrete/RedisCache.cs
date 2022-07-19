using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    internal class RedisCache : ICache
    {
        public void Cache()
        {
            Console.WriteLine("Redis run!");
        }
    }
}
