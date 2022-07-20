using Facade.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Business
{
    internal class ProductManager
    {
        private readonly ICrossCuttingConcernsFacade _crossCuttingConcernsFacade;
        internal ProductManager(ICrossCuttingConcernsFacade crossCuttingConcernsFacade)
        {
            _crossCuttingConcernsFacade = crossCuttingConcernsFacade;
        }

        internal void ApplyCrossCuttingConcerns()
        {
            _crossCuttingConcernsFacade.Auth();
            _crossCuttingConcernsFacade.Cache();
            _crossCuttingConcernsFacade.Log();
            _crossCuttingConcernsFacade.Validation();
        }
    }
}
