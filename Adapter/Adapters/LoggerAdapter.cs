using Adapter.Abstract;
using Adapter.OutSourceAPIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
    internal class LoggerAdapter : ILoggerAdapter
    {
        public void Log()
        {
            var log4net = new Log4Net();
            log4net.LogOfLog4Net();

            //var serilog = new Serilog();
            //serilog.LogOfSerilogMethod();
        }
    }
}
