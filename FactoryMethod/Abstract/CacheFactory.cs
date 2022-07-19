using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Abstract
{
    internal abstract class CacheFactory
    {
       internal abstract ICache FactoryMethod();
    }
}
