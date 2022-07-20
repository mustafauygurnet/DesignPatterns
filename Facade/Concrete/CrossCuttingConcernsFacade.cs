using Facade.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Concrete
{
    internal class CrossCuttingConcernsFacade : ICrossCuttingConcernsFacade
    {
        private readonly IAuth _auth;
        private readonly ICache _cache;
        private readonly ILog _log;
        private readonly IValidation _validation;

        public CrossCuttingConcernsFacade(IAuth auth, ICache cache, ILog log, IValidation validation)
        {
            _auth = auth;
            _cache = cache;
            _log = log;
            _validation = validation;
        }

        public void Auth()
        {
            _auth.Authority();
        }

        public void Cache()
        {
            _cache.Caching();
        }

        public void Log()
        {
            _log.Logging();
        }

        public void Validation()
        {
            _validation.Validate();
        }
    }
}
