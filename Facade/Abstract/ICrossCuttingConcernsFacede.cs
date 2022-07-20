using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Abstract
{
    internal interface ICrossCuttingConcernsFacade
    {
        void Log();
        void Cache();
        void Auth();
        void Validation();
    }
}
