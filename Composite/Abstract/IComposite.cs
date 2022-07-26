using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Abstract
{
    internal interface IComposite<IEntity> : IEnumerable<IEntity>
    {
        void Add(params IEntity[] entity);
        void Remove(params IEntity[] entity);

    }
}
