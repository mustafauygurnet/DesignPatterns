using Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Business
{
    internal class ProductManager
    {
        private readonly ILoggerAdapter _loggerAdapter;

        public ProductManager(ILoggerAdapter loggerAdapter)
        {
            _loggerAdapter = loggerAdapter;
        }

        public void ApplyLogging()
        {
            _loggerAdapter.Log();
        }
    }
}
