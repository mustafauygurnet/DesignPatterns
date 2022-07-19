using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Business
{
    internal class ProductManager
    {
        readonly ICache _cache;
        readonly ILogger _log;
        readonly ICrossCuttingConcernsFactory _factory;

        internal ProductManager(ICrossCuttingConcernsFactory factory)
        {
            _factory = factory;
            _cache = _factory.Caching();
            _log = _factory.Logging();
        }

        internal void SomeOperation()
        {
            _log.Log();
            _cache.Cache();
        }
    }
}
