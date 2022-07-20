using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Business
{
    internal class ProductManager
    {
        private readonly CacheFactory _cacheFactory;

        public ProductManager(CacheFactory cacheFactory)
        {
            _cacheFactory = cacheFactory;
        }

        public void ApplyCache()
        {
            _cacheFactory.FactoryMethod().Caching();
        }
    }
}
