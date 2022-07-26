﻿using Composite.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Concrete
{
    internal class CategoryComposite : IComposite<ICategory>,IEnumerable<ICategory>
    {
        List<ICategory> _categories = new();
        public void Add(params ICategory[] entities)
        {
            foreach (var entity in entities)
            {
                _categories.Add(entity);
            }
        }

        public IEnumerator<ICategory> GetEnumerator()
        {
            foreach (var category in _categories)
            {
                yield return category;  
            }
        }

        public void Remove(params ICategory[] entities)
        {
            foreach (var entity in entities)
            {
                _categories.Remove(entity);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
