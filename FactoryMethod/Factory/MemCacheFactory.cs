using FactoryMethod.Abstract;
using FactoryMethod.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    internal class MemCacheFactory : CacheFactory
    {
        internal override ICache FactoryMethod()
        {
            return new MemCache();
        }
    }
}
