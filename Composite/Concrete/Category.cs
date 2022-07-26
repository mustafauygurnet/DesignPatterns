using Composite.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Concrete
{
    internal class Category : CategoryComposite, ICategory
    {
        public string Name { get; set; }
    }
}
