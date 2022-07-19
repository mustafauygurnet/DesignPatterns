using AbstractFactory.Abstract;
using AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class CrossCuttingConcernsFactory1 : ICrossCuttingConcernsFactory
    {
        public ICache Caching()
        {
            return new MemCache();
        }

        public ILogger Logging()
        {
            return new Log4Net();
        }
    }
}
