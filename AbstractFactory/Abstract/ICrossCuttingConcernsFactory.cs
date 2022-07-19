using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    internal interface ICrossCuttingConcernsFactory
    {
        ILogger Logging();
        ICache Caching();
    }
}
